using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SuperTool.RequestTool
{
    public class RequestCodeGen
    {
        private string settingFile;

        private Dictionary<string, JsonObject> codeDict = new Dictionary<string, JsonObject>();
        private Dictionary<string, string> patternDict = new Dictionary<string, string>();
        private Dictionary<string, string[]> replaceDict = new Dictionary<string, string[]>();
        private Dictionary<string, string> codelineDict = new Dictionary<string, string>();

        public List<string> NameList { get; set; }

        public RequestCodeGen()
        {
            settingFile = @"setting\jsoncode.json";
        }

        public Dictionary<string, JsonObject> GetSettingData()
        {
            string jsonString = File.ReadAllText(settingFile);

            JsonObject? jsonObj = null;
            try
            {
                JsonNode node = JsonNode.Parse(jsonString)!;
                jsonObj = node!.AsObject();
            }
            catch
            {
                MessageBox.Show("json文本格式不对，请检查文件内容");
            }

            var value = jsonObj!["setting"];
            JsonArray jsonArray = value!.AsArray();

            foreach (var item in jsonArray)
            {
                JsonObject childObj = item.AsObject();

                string name = childObj["name"]!.ToString();
                codeDict.Add(name, childObj);
            }

            return codeDict;

        }



        /// <summary>
        /// 显示指定文本
        /// </summary>
        /// <param name="fileArr"></param>
        /// <param name="display">[0]或者[0,1] 0默认显示, 1显示数组节点</param>
        /// <param name="replaceStr"></param>
        /// <returns></returns>
        public string GetCodeText(JsonArray fileArr, int[] display, string replaceStr = "")
        {
            string codeText = "";
            for (int i = 0; i < fileArr.Count; i++)
            {

                JsonObject root = fileArr[i]!.AsObject();

                //根据配置是否显示相关文档文本
                if (root["add"]!.GetValue<int>() == 1 && display.Contains(root["display"]!.GetValue<int>()))
                {
                    //如果配置add=1，则该配置下的文本需要添加
                    int replace = root["replace"]!.GetValue<int>();//是否有替换
                    string oldString = root["replace_str"]!.ToString();
                    string file = root["fname"]!.ToString();//代码文本文档，相对路径
                    string codeStr = GetFileData(file, replace, oldString, replaceStr);//读取文档中代码文本
                    codeText += codeStr;
                }
            }

            return codeText;

        }

        /// <summary>
        /// 获取代码文档中文本
        /// </summary>
        /// <param name="replace"></param>
        /// <param name="oldStr"></param>
        /// <param name="replaceStr"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public string GetFileData(string file, int replace, string oldStr, string replaceStr = "")
        {
            string codeText = "";

            try
            {
                codeText = File.ReadAllText(file);//直接读入代码文档中文本
            }
            catch (Exception)
            {
                MessageBox.Show("代码文档文件：" + file + "不存在，请检查");
                return "";
                //throw;
            }

            if (replace == 1)
            {
                //进行节点文本替换
                codeText = codeText.Replace(oldStr, replaceStr);
            }
            codeText = codeText + "\r\n";
            Console.WriteLine(codeText);

            return codeText;
        }
    }
}
