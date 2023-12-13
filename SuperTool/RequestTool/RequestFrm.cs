using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;
using SuperTool.Common;
using System.Web;

namespace SuperTool.RequestTool
{
    public partial class RequestFrm : Form
    {

        private string cacheFile = @"cache\request.ini";
        private readonly IniService iniService;
        private Dictionary<string, Method> methodDict = new Dictionary<string, Method>();
        private CancellationTokenSource? requestCts = null;//访问任务取消线程
        private UpFileHelpFrm upFileHelpFrm;
        public RequestFrm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            iniService = new IniService(cacheFile);//创建缓存ini文件对象
        }

        private void RequestFrm_Load(object sender, EventArgs e)
        {


            cmbMethodInit();
            cmbContentTypeInit();

            Task.Run(() =>
            {
                CacheInit();//加载缓存
            });

        }

        private void cmbContentTypeInit()
        {
            cmbContentType.Items.Clear();
            cmbContentType.Items.Add("application/x-www-form-urlencoded");
            cmbContentType.Items.Add("application/json");
            cmbContentType.Items.Add("multipart/form-data");
            //cmbContentType.SelectedIndex = 0;//这个和加载配置会冲突，放到加载配置CacheInit()里设置
        }
        private void cmbMethodInit()
        {

            cmbMethod.Items.Clear();

            //methodDict.Add("Get", Method.Get);
            //methodDict.Add("Post", Method.Post);

            //直接遍历enum Method即可
            foreach (var method in Enum.GetValues(typeof(Method)))
            {
                Console.WriteLine("{0}", method.ToString());
                methodDict.Add(method.ToString(), (Method)method);
                //methodDict.Add(method.ToString(), Enum.Parse<Method>(method.ToString()));
            }

            foreach (string key in methodDict.Keys)
            {
                cmbMethod.Items.Add(key);
            }

            //这个和加载配置会冲突，放到加载配置CacheInit()里设置
            //if (cmbMethod.SelectedIndex < 0)
            //{
            //    cmbMethod.SelectedIndex = 0;//当这个设置后会触发SelectedIndexChanged事件，造成缓存重置为0对应的item
            //}

        }

        /// <summary>
        /// 加载缓存
        /// </summary>
        private void CacheInit()
        {
            //请求方式
            string method = iniService.ReadIniData("request", "method");
            if (methodDict.ContainsKey(method))
                cmbMethod.SelectedItem = method;
            else
                cmbMethod.SelectedIndex = 0;

            //代理
            string proxyStr = iniService.ReadIniData("request", "proxy");
            if (proxyStr != string.Empty)
                txtProxy.Text = proxyStr;

            //是否禁止重定向
            string banRedirect = iniService.ReadIniData("request", "banredirect");
            if (!string.IsNullOrEmpty(banRedirect))
            {
                if (banRedirect == "1")
                    chkBanRedirect.Checked = true;
                else
                    chkBanRedirect.Checked = false;
            }

            string maxTimeOut = iniService.ReadIniData("request", "maxtimeout");
            if (!string.IsNullOrEmpty(maxTimeOut))
            {
                if (Convert.ToInt32(maxTimeOut) >= 1)
                {
                    txtMaxTimeOut.Text = maxTimeOut;
                }
                else
                {
                    txtMaxTimeOut.Text = "5";
                }
            }

            //请求地址url
            string url = iniService.ReadIniData("request", "url");
            if (!string.IsNullOrEmpty(url))
            {
                txtUrl.Text = HttpUtility.UrlDecode(url, Encoding.UTF8);
            }

            //content-type
            string contentType = iniService.ReadIniData("request", "contenttype");
            if (!string.IsNullOrEmpty(contentType))
            {
                //先确定列表框里有该配置文本
                if (cmbContentType.Items.Contains(contentType))
                    cmbContentType.SelectedItem = contentType;
                else
                    cmbContentType.SelectedIndex = 0;
            }

            //上传的文件路径，同时设置文件类型
            string filePath = iniService.ReadIniData("request", "filepath");
            if (!string.IsNullOrEmpty(filePath))
            {
                txtFilePath.Text = filePath;
                string fileExt = Path.GetExtension(filePath);
                txtMime.Text = FileContentTypeMime.GetMimeType(fileExt);
            }

            //提交内容
            string sendContent = iniService.ReadIniData("request", "sendcontent");
            if (!string.IsNullOrEmpty(sendContent))
            {
                txtSendContent.Text = HttpUtility.UrlDecode(sendContent, Encoding.UTF8);
            }
            //文件字段替换字符串
            string fileReplaceString = iniService.ReadIniData("request", "filereplacestring");
            txtFileReplaceString.Text = fileReplaceString;

            //cookie
            string cookie = iniService.ReadIniData("request", "cookie");
            if (!string.IsNullOrEmpty(cookie))
            {
                txtCookie.Text = HttpUtility.UrlDecode(cookie, Encoding.UTF8);
            }

            //headers
            string headers = iniService.ReadIniData("request", "headers");
            if (!string.IsNullOrEmpty(headers))
            {
                txtRequestHeaders.Text = HttpUtility.UrlDecode(headers, Encoding.UTF8);
            }

        }

        /// <summary>
        /// 一些操作条件的判断警告提示等
        /// -9 ~ 0 根据返回值等级
        /// -9 定义为最高等级，如果返回该值就不再执行后续代码
        /// </summary>
        /// <returns></returns>
        public int DoWarning()
        {
            int flag = 0;
            if (!txtRequestHeaders.Text.Contains("user-agent", StringComparison.OrdinalIgnoreCase))
            {
                //string tips = "提交协议头里无内容，建议加一个User-Agent\n点击【是】不添加继续访问，点击【否】取消访问";
                //if ( MessageBox.Show(tips, "提示",MessageBoxButtons.OKCancel) != DialogResult.Yes ) return;
                lblWarning.Text = "提交协议头里无User-Agent，建议加一个";
                flag = -1;
            }
            else
            {
                lblWarning.Text = "";
            }

            if (cmbContentType.SelectedItem.ToString() == "multipart/form-data" && txtFilePath.Text == "")
            {
                if (MessageBox.Show("还未选择文件，点【确定】继续执行，点【取消】停止操作", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    flag = -9;
                }
            }

            if (FileFieldReplaceStringWarining())
                flag = -9;

            return flag;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (DoWarning() == -9)
                return;

            //重置面板部分控件
            btnSend.Enabled = false;
            txtResponseContent.Text = string.Empty;
            txtResponseHeaders.Text = string.Empty;
            txtResponseCookie.Text = string.Empty;
            lblStatus.Text = string.Empty;
            prgRequest.Value = 0;


            //将面板上的数据给结构体
            requestData reqData;
            reqData.method = methodDict[cmbMethod.SelectedItem.ToString()!];
            reqData.proxy = txtProxy.Text.Trim();
            reqData.url = txtUrl.Text.Trim();
            reqData.content = txtSendContent.Text.Trim();
            reqData.cookie = txtCookie.Text.Trim();
            reqData.headers = txtRequestHeaders.Text.Trim();
            reqData.contentType = cmbContentType.SelectedItem.ToString()!;
            reqData.maxTimeOut = Convert.ToInt32(txtMaxTimeOut.Text.Trim()) * 1000;//ms*1000转为s
            reqData.file = txtFilePath.Text.Trim();
            reqData.mime = txtMime.Text.Trim();
            string fileReplaceString = txtFileReplaceString.Text.Trim();
            reqData.fileFieldReplace = fileReplaceString != string.Empty ? fileReplaceString : "(binary)";
            if (chkBanRedirect.Checked)
            {
                reqData.banRedirect = true;
            }
            else
            {
                reqData.banRedirect = false;
            }

            prgRequest.Maximum = reqData.maxTimeOut / 1000;//进度条最大值

            //访问任务
            requestCts = new CancellationTokenSource();
            CancellationToken token = requestCts.Token;
            Task requestTask = new Task(() => DoRequest(reqData, token));//创建访问任务
            requestTask.Start();

            //进度条显示任务
            Task prgBarTask = new Task(ProgressBarDisplay);
            prgBarTask.Start();
        }

        /// <summary>
        /// 访问操作
        /// </summary>
        /// <param name="reqData"></param>
        /// <param name="cancellationToken"></param>
        public async void DoRequest(requestData reqData, CancellationToken cancellationToken = default)
        {
            RequestOption reqOp = new RequestOption();

            //开启访问

            lblStatus.Text = "正在访问.....";
            try
            {
                responseData rspData = await reqOp.RequestAsync(reqData, cancellationToken);

                txtResponseContent.Text = rspData.responseContent;
                txtResponseHeaders.Text = rspData.responseHeaders;
                txtResponseCookie.Text = rspData.responseCookie;

                lblStatus.Text = "访问完成！";

                prgRequest.Value = prgRequest.Maximum;
                Console.WriteLine(rspData.responseContent);
            }
            catch (TimeoutException)
            {
                lblStatus.Text = "访问超时！";
                lblStatus.ForeColor = Color.Red;
                prgRequest.Value = 0;
                //throw;
            }
            catch (HttpRequestException)
            {
                if (cancellationToken.IsCancellationRequested)
                    lblStatus.Text = "任务已取消，停止访问！";
                else
                    lblStatus.Text = "访问异常，无法访问！";

                lblStatus.ForeColor = Color.Red;
                prgRequest.Value = 0;
                //throw;
            }
            catch (TaskCanceledException)
            {
                //HttpClient有这个异常，不过RestSharp包装后，统一用HttpRequestException替代了，所以这个其实这个在这里无作用
                Console.WriteLine("取消访问");
                lblStatus.Text = "取消访问！";
                lblStatus.ForeColor = Color.Red;
                prgRequest.Value = 0;
            }
            finally
            {
                btnSend.Enabled = true;

                //任务到这里已经全部结束了，释放一下requestCts，并置为null
                if (requestCts != null)
                {
                    requestCts.Dispose();
                    requestCts = null;
                }

                Console.WriteLine("结束啦啦啦！");
            }
        }

        /// <summary>
        /// 进度条显示
        /// </summary>
        public void ProgressBarDisplay()
        {
            //这里最终Value不会等于Maximum，会留有1格，等访问完成后直接会置满格
            for (int i = 0; i < prgRequest.Maximum; i++)
            {
                //其它地方有异常进度条置0，或者已经访问完成，直接跳出
                if ((i > 1 && prgRequest.Value == 0) || prgRequest.Value == prgRequest.Maximum || requestCts == null)
                    break;

                prgRequest.Value = i;
                Thread.Sleep(1000);
            }
        }

        private void RequestFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region 面板信息变动，保存到缓存配置ini文件
        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("request", "method", cmbMethod.SelectedItem.ToString()!);
        }

        private void txtProxy_TextChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("request", "proxy", txtProxy.Text);
        }

        private void chkBanRedirect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBanRedirect.Checked)
            {
                iniService.WriteIniData("request", "banredirect", "1");
            }
            else
            {
                iniService.WriteIniData("request", "banredirect", "0");
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            //保险起见，也URL编码一下再保存
            iniService.WriteIniData("request", "url", HttpUtility.UrlEncode(txtUrl.Text, Encoding.UTF8));
        }

        //如果选择文件上传方式，显示选择文件按钮和框
        private void cmbContentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContentType.SelectedItem.ToString() == "multipart/form-data")
                SetUpFileControlsVisible(true);
            else
                SetUpFileControlsVisible(false);

            iniService.WriteIniData("request", "contenttype", cmbContentType.SelectedItem.ToString()!);

        }

        /// <summary>
        /// 设置文件上传模式下的相关控件是否可见
        /// </summary>
        /// <param name="display"></param>
        public void SetUpFileControlsVisible(bool display)
        {
            btnSelectFile.Visible = display;
            txtFilePath.Visible = display;
            lblMime.Visible = display;
            txtMime.Visible = display;
            btnFileHelp.Visible = display;
            txtFileReplaceString.Visible = display;

            txtFilePath.Text = "";
            txtMime.Text = "";
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("request", "filepath", txtFilePath.Text);
        }

        private void txtSendContent_TextChanged(object sender, EventArgs e)
        {
            //URL编码后保存，否则会有问题，比如换行什么的
            iniService.WriteIniData("request", "sendcontent", HttpUtility.UrlEncode(txtSendContent.Text, Encoding.UTF8));
        }

        private void txtCookie_TextChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("request", "cookie", HttpUtility.UrlEncode(txtCookie.Text, Encoding.UTF8));
        }

        private void txtRequestHeaders_TextChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("request", "headers", HttpUtility.UrlEncode(txtRequestHeaders.Text, Encoding.UTF8));
        }

        private void txtMaxTimeOut_TextChanged(object sender, EventArgs e)
        {
            //避免输入非数字，先转数字一下
            iniService.WriteIniData("request", "maxtimeout", Convert.ToInt32(txtMaxTimeOut.Text).ToString());
        }
        private void txtFileReplaceString_TextChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("request", "filereplacestring", txtFileReplaceString.Text.Trim());
        }

        #endregion



        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txtFilePath.Text = folderBrowserDialog.SelectedPath;
            //}

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
                string fileExt = Path.GetExtension(openFileDialog.FileName);
                txtMime.Text = FileContentTypeMime.GetMimeType(fileExt);
                //另：.NET6好像已经没法用这个了System.Web.MimeMapping.GetMimeMapping(fileName);
            }
        }



        #region 提示设置
        private void cmbContentType_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "如果【提交协议头】包含了content-type，则本选择设置无效";
        }
        private void txtRequestHeaders_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }

        private void txtSendContent_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "提交内容，参考浏览器里Form Data数据；支持json格式";
        }

        private void txtSendContent_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }

        private void txtCookie_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "提交cookie，如果提交协议头里设置了cookie，本项可不填写；支持json格式";
        }

        private void txtCookie_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }

        private void txtRequestHeaders_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "提交协议头，如果包含了content-type，则【提交方式】选择设置无效；支持json格式";
        }
        private void cmbContentType_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }

        private void btnFileHelp_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "查看文件上传相关帮助信息";
        }

        private void btnFileHelp_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }

        #endregion



        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (!requestCts.IsCancellationRequested)
            if (requestCts != null)
            {
                Console.WriteLine("任务Cancel");
                requestCts.Cancel();//任务结束
                requestCts.Dispose();//调用 Dispose 不会向关联的 Token使用者传达取消请求。 可以通过调用方法（如 Cancel 或 CancelAfter）来传达取消请求
                requestCts = null;
            }
        }

        private void btnFileHelp_Click(object sender, EventArgs e)
        {
            UpFileHelpFrm upFileHelpFrm = new UpFileHelpFrm();
            upFileHelpFrm.Show();
        }

        /// <summary>
        /// 文件上传模式下，是否满足条件
        /// </summary>
        /// <returns>true不继续执行， false忽略警告继续执行</returns>
        private bool FileFieldReplaceStringWarining()
        {
            if (cmbContentType.SelectedItem.ToString() == "multipart/form-data")
            {
                string warning = "";

                string fileReplaceStr = txtFileReplaceString.Text.Trim();

                if (fileReplaceStr != string.Empty)
                {
                    warning = "【文件字段对应替换字符串】设置了值，但是提交内容中未找到该值";

                }
                else
                {
                    fileReplaceStr = "(binary)";

                    warning = fileReplaceStr + "为文件提交字段默认替换字符串，但是提交内容中未找到该值";
                }
                if (!txtSendContent.Text.Contains(fileReplaceStr))
                {
                    lblWarning.Text = warning;
                    if (MessageBox.Show(warning + "，继续访问？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        return false;
                    else
                        return true;
                }
            }

            return false;
        }
    }
}
