using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace SuperTool.RequestTool
{
    /// <summary>
    /// 和面板数据对应
    /// </summary>
    public struct requestData
    {
        public Method method;
        public string proxy;
        public bool banRedirect;
        public string url;
        public string content;
        public string cookie;
        public string headers;
        public string contentType;
        public int maxTimeOut;
        public string file;
        public string mime;
        public string fileFieldReplace;

    }

    public struct responseData
    {
        public string? responseContent;
        public string? responseCookie;
        public string? responseHeaders;
    }

    /// <summary>
    /// 使用RestSharp实现功能，RestSharp实际就是HttpClient的包装
    /// 官方参考文档：https://github.com/restsharp/RestSharp
    /// </summary>
    public class RequestOption
    {
        public RequestOption()
        {
            
        }

        public async Task<responseData> RequestAsync(requestData reqData, CancellationToken cancellationToken=default)
        {
            //参考示例，大部分设置是在RestClientOptions里设置的
            //var client = new RestClient(new RestClientOptions()
            //{
            //    AutomaticDecompression = DecompressionMethods.All,
            //    FollowRedirects = true,
            //    MaxRedirects = 10,
            //    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.0.0 Safari/537.36",
            //    BaseUrl = new Uri("https://steamcommunity.com/market/eligibilitycheck/?goto=%2Fmy%2Ftradeoffers%2Fprivacy"),
            //    AllowMultipleDefaultParametersWithSameName = true,
            //    Proxy = proxy,
            //    RemoteCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
            //});

            responseData rspData;
            rspData.responseContent = "";
            rspData.responseHeaders = "";
            rspData.responseCookie = "";

            if (reqData.url != null && reqData.url != string.Empty)
            {
                //var client = new RestClient(reqData.url);
                var clientOptions = new RestClientOptions();
                clientOptions.BaseUrl = new Uri(reqData.url);//访问网址
                clientOptions.FollowRedirects = !reqData.banRedirect;//重定向
                clientOptions.MaxTimeout = reqData.maxTimeOut <= 0 ? 1000 : reqData.maxTimeOut;//最大超时时间,1000ms=1s
                clientOptions.ThrowOnAnyError = true;//要设为true，否则不会获取到异常，包括超时异常

                //设置代理
                if (reqData.proxy != null && reqData.proxy != string.Empty)
                    clientOptions.Proxy = new WebProxy(reqData.proxy);

                var client = new RestClient(clientOptions);

                var request = new RestRequest();
                request.Method = reqData.method;
                //request.Timeout = MaxTimeOut;

                //提交协议头转字典
                Dictionary<string, string[]> headerDict = HeaderToDictionary(reqData);

                //添加cookie，在添加头部之前处理，里面有去掉重复cookie操作
                AddCookie(reqData.cookie, headerDict);

                //添加头部
                await Console.Out.WriteLineAsync("------header------e");
                foreach (var header in headerDict)
                {
                    request.AddHeader(header.Value[0], header.Value[1]);
                    await Console.Out.WriteLineAsync($"{header.Value[0]}:{header.Value[1]}");
                }
                await Console.Out.WriteLineAsync("------header------s");
                //获取body到字典，支持读取json格式字符串
                Dictionary<string, string> bodyDict = new Dictionary<string, string>();
                
                //json提交
                if(headerDict["content-type"][1].ToString() == "application/json")
                {
                    request.AddJsonBody(reqData.content);
                }
                else
                {
                    bodyDict = BodyToDictionary(reqData.content);
                }

                //文件上传，在添加body之前操作
                if (headerDict.ContainsKey("content-type") && 
                    headerDict["content-type"].Length >1 && 
                    headerDict["content-type"][1].ToString() == "multipart/form-data" && 
                    bodyDict.ContainsValue(reqData.fileFieldReplace) && 
                    reqData.file != ""
                    )
                {
                    string keyName = bodyDict.FirstOrDefault(x => x.Value.Equals(reqData.fileFieldReplace)).Key;//根据Value获取Key
                    //request.AddFile(keyName, reqData.file, reqData.mime);

                    request.AddParameter("file", File.ReadAllBytes(reqData.file), ParameterType.RequestBody);

                    //无需再body里再添加该parameter了
                    bodyDict.Remove(keyName);//注意这个必须在body添加parameter之前
                }


                //添加body parameter
                if(bodyDict!=null && bodyDict.Count>0)
                {
                    await Console.Out.WriteLineAsync("------body------s");
                    foreach (var body in bodyDict)
                    {
                        request.AddParameter(body.Key, body.Value);
                        await Console.Out.WriteLineAsync($"{body.Key}:{body.Value}");
                    }
                    await Console.Out.WriteLineAsync("------body------e");
                }
                
                //进行访问操作
                RestResponse response;
                try
                {
                    response = await client.ExecuteAsync(request, cancellationToken);
                    
                    //获取 返回响应正文/返回协议头/返回Cookie 全部保存为字符串格式
                    rspData.responseContent = response.Content;
                    rspData.responseHeaders = ResponseHeadersToString(response.Headers);
                    rspData.responseCookie = ResponseCookieToString(response.Cookies);
                    Console.WriteLine("ContentLength:" + response.ContentLength);
                }
                catch (TimeoutException)
                {
                    throw;//访问超时 向上层抛出异常
                }
                catch (TaskCanceledException)
                {
                    throw;//取消访问，RestSharp包装未设置该异常，统一为HttpRequestException
                }
                catch (HttpRequestException)
                {
                    throw;
                }
            }

            return rspData;
        }

        /// <summary>
        /// 响应返回协议头 response.Headers 转字符串
        /// </summary>
        /// <param name="headers"></param>
        /// <returns></returns>
        public string ResponseHeadersToString(IReadOnlyCollection<HeaderParameter>? headers)
        {
            string headerString = "";

            if (headers == null || headers.Count == 0) return "";

            foreach (var header in headers)
            {
                headerString += header.Name + ":" + header.Value + "\r\n";
            }

            return headerString;
        }

        /// <summary>
        /// 响应返回 response.Cookies 转字符串
        /// </summary>
        /// <param name="cookies"></param>
        /// <returns></returns>
        public string ResponseCookieToString(CookieCollection? cookies)
        {
            string cookieString = "";

            if (cookies == null || cookies.Count == 0) return "";

            foreach (var cookie in cookies)
            {
                cookieString += cookie.ToString();
            }

            return cookieString;
        }

        public Dictionary<string, string[]> HeaderToDictionary( requestData reqData)
        {
            Dictionary<string, string[]> headerDict = new Dictionary<string, string[]>();
            if (!string.IsNullOrEmpty(reqData.headers))
            {
                //json格式字符串
                if (reqData.headers[0] == '{')
                {
                    Dictionary<string, string>? headerDictOriginal = JsonSerializer.Deserialize<Dictionary<string, string>>(reqData.headers);
                    if (headerDictOriginal != null)
                    {
                        foreach (var item in headerDictOriginal)
                        {
                            headerDict.Add(item.Key.ToLower(), new string[] { item.Key, item.Value });
                        }
                    }

                }
                else
                {
                    headerDict = HeaderStringSplit(reqData.headers);
                }
            }

            //头部额外处理

            //application/x-www-form-urlencoded 表单提交
            //application/json  提交数据为json格式
            //multipart/form-data   上传文件用
            //在没有content-type的时候，加一个默认的，否则post不了
            if (!headerDict.ContainsKey("content-type"))
            {
                //string[] contentType = new string[] { "content-type", reqData.contentType };//小写的竟然没用
                string[] contentType = new string[] { "Content-Type", reqData.contentType };
                headerDict.Add("content-type", contentType);

            }
            //User-Agent 如果没有，就加一个默认的
            //if (!headerDict.ContainsKey("user-agent"))
            //    headerDict.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36");

            return headerDict;
        }

        /// <summary>
        /// Requestheaders字符串处理，整个字符串分割成可以个request.AddHeader("","")的字典格式
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>
        public Dictionary<string, string[]> HeaderStringSplit(string headers)
        {
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>();
            string newHeader = Regex.Replace(headers, "\\s*:\\s+", ":");//有时浏览器中复制的头文本出现 [Key :换行 Value] 格式不对，先把格式替换好[Key:Value]
            dict = StringToKeyDictionary(newHeader, new string[] { "\r\n", "\n" }, new string[] { ":" });

            return dict;
        }

        /// <summary>
        /// 提交内容字符串转字典，支持json格式转字典
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public Dictionary<string, string> BodyToDictionary(string content)
        {
            Dictionary<string,string> dict = new Dictionary<string,string>();
            if (!string.IsNullOrEmpty(content))
            {
                if (content[0] == '{')
                {
                    //如果提交内容是json格式， json字符串转字典
                    Dictionary<string, string>? bodyJsonDict = JsonSerializer.Deserialize<Dictionary<string, string>>(content);
                    if (bodyJsonDict != null)
                        dict = bodyJsonDict;
                }
                else
                {
                    dict = BodyStringSplit(content);
                }

            }

            return dict;

        }

        /// <summary>
        /// 处理提交内容字符串，统一保存为字典Key:Value格式，便于request.AddParameter()函数处理
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public Dictionary<string, string> BodyStringSplit(string content)
        {
            Dictionary<string, string> bodyDict = new Dictionary<string, string>();


            string newContent = content.Trim();
            if(newContent.Length == 0)return bodyDict;

            if (content.IndexOf(":") != -1) {
                //Key1:Value1
                //Key2:Value2
                //这种格式的，一般是在view parsed里复制到的数据
                bodyDict = StringToKeyValue(newContent, new string[] { "\r\n", "\n" }, new string[] { ":", " ", "\t"});
            }
            else
            {
                //Key1=Value1&Key2=Value2&...这种格式，一般是在view source里复制的数据
                bodyDict = StringToKeyValue(newContent, new string[] { "&"}, new string[] { "=" });
            }

            return bodyDict;
        }

        public Dictionary<string, string> StringToKeyValue(string value, string[] pattern1, string[] pattern2, bool keyToLower=false)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] lines = value.Trim().Split(pattern1, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] keyValues = lines[i].Trim().Split(pattern2, StringSplitOptions.RemoveEmptyEntries);
                if (keyValues.Length == 1 || keyValues.Length == 2)
                {
                    string key = keyToLower ? keyValues[0].ToLower():keyValues[0];
                    string val = keyValues.Length == 2 ? keyValues[1] : "";
                    dict.Add(key.Trim(), val.Trim());
                }
            }

            return dict;
        }

        /// <summary>
        /// 将协议头字符串转为 Key:Value格式，便于request.AddHeader()函数使用
        /// 为了便于统一查找以及同时保留原头协议字符串大小写，这里用keyLow->[Key,Value]保存
        /// 这样统一用小写key即可找到原Key:Value了
        /// 如果不用原大小写的话，可能会出现一些未知问题
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pattern1"></param>
        /// <param name="pattern2"></param>
        /// <param name="keyToLower"></param>
        /// <returns></returns>
        public Dictionary<string, string[]> StringToKeyDictionary(string value, string[] pattern1, string[] pattern2, bool keyToLower = false)
        {
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>();
            string[] lines = value.Split(pattern1, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] keyValues = lines[i].Split(pattern2, StringSplitOptions.RemoveEmptyEntries);
                if (keyValues.Length == 1 || keyValues.Length == 2)
                {
                    string keyLow = keyValues[0].ToLower();
                    string val = keyValues.Length == 2 ? keyValues[1] : "";
                    dict.Add(keyLow, new string[]{ keyValues[0],val });
                }
            }

            return dict;
        }

        public void AddCookie(string cookie, Dictionary<string, string[]> headerDict)
        {
            if (!string.IsNullOrEmpty(cookie))
            {
                string cookieString = string.Empty;
                //如果是json格式，转为字符串
                if (cookie[0] == '{')
                {
                    Dictionary<string,string>? cookieDict    = JsonSerializer.Deserialize<Dictionary<string,string>>(cookie);
                    if (cookieDict != null)
                    {
                        foreach(var  item in cookieDict)
                        {
                            cookieString += item.Key + "=" + item.Value + ";";
                        }
                    }
                }
                else
                {
                    cookieString = cookie;
                }


                string[] cookies = new string[] { "Cookie", cookieString };

                //如果要用cookie文本框里的，headers里如果包含了就去掉，不用重复cookie
                if (headerDict.ContainsKey("cookie"))
                {
                    cookies[0] = headerDict["cookie"][0];//取提交协议头里的原cookie字段name
                    headerDict.Remove("cookie");
                }

                headerDict.Add("cookie", cookies);
            }
        }
    }
}
