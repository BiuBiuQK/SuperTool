using SuperTool.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SuperTool.RegexTool
{
    public partial class RegexFrm : Form
    {
        private string cacheFile = @"cache\regex.ini";
        private string contentCacheFile = @"cache\regexcontent.txt";
        private IniService iniService;
        //private Dictionary<int, string> replaceDict = new Dictionary<int, string>();
        public RegexFrm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            iniService = new IniService(cacheFile);
        }

        private void RegexFrm_Load(object sender, EventArgs e)
        {


            //加载缓存
            Task.Run(() =>
            {
                cacheInit();
            });

        }
        /// <summary>
        /// 加载缓存
        /// </summary>
        private void cacheInit()
        {
            //正则字符串
            string pattern = iniService.ReadIniData("regex", "pattern");
            if (!string.IsNullOrEmpty(pattern))
            {
                txtPattern.Text = pattern;
            }

            //源文本内容
            if (File.Exists(contentCacheFile))
            {
                string content = File.ReadAllText(contentCacheFile, Encoding.UTF8);
                if (!string.IsNullOrEmpty(content))
                {
                    txtContent.Text = content;
                }
            }

            //替换内容
            string replace = iniService.ReadIniData("regex", "replace");
            if (!string.IsNullOrEmpty(replace))
            {
                txtReplace.Text = HttpUtility.UrlDecode(replace, Encoding.UTF8);
            }

            //精确替换
            string replacePrecis = iniService.ReadIniData("regex", "replaceprecise");
            if (!string.IsNullOrEmpty(replacePrecis))
            {
                if (replacePrecis == "1")
                    chkReplacePrecise.Checked = true;
                else
                    chkReplacePrecise.Checked = false;
            }

            //替换空白
            string replaceSpace = iniService.ReadIniData("regex", "replacespace");
            if (!string.IsNullOrEmpty(replaceSpace))
            {
                if (replaceSpace == "1")
                    chkReplaceSpace.Checked = true;
                else
                    chkReplaceSpace.Checked = false;
            }

        }


        private void btnMatch_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            //lvwMatchResult.Columns.Add("标题1", 120, HorizontalAlignment.Center);
            Console.Clear();
            DoRegexMatch(txtContent.Text, txtPattern.Text.Trim(), lvwMatchResult);
            tabResult.SelectedTab = tabPageMatchResult;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtReplaceResult.Clear();
            string replaceStr = DoRegexReplace(txtContent.Text, txtPattern.Text, chkReplacePrecise.Checked, chkReplaceSpace.Checked);
            txtReplaceResult.Text = replaceStr;
            tabResult.SelectedTab = tabPageReplaceResult;//替换结果tabControl选项卡选中
            txtReplaceResult.Select(0, 0);
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            //用新窗口显示


        }

        /// <summary>
        /// 正则匹配，并显示到列表框里
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="listView"></param>
        public void DoRegexMatch(string input, string pattern, ListView listView)
        {
            try
            {
                var matches = Regex.Matches(input, pattern);
                DisplayRegexMatchs(pattern, matches, listView);
            }
            catch (Exception ex)
            {
                lblWarning.Text = ex.Message;
            }


        }

        /// <summary>
        /// 替换textBox里内容存到字典，textBox内容1行1组
        /// 示例（注：使用工具匹配功能，查看匹配结果分组标题可以看到对应分组name）：
        /// $1=good 替换正则匹配到的分组name=1里的内容为gooood
        /// $word=gooood 替换正则匹配到的分组name=word里的内容为gooood
        /// 保存到字典里格式为： Key=分组name的字符串 , Value=替换的内容
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public Dictionary<string, string> ReplaceDict(string content)
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>();
            //var lines =  content.Split(new string[] { "\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            var lines = content.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                int index = line.IndexOf("=");//第一个=的位置
                if (index >= 2)//$1= 至少是3个字符串，就是index至少不小于2
                {
                    string name = line.Substring(1, index - 1);//取$到第一个=之间的字符串
                    string replaceString = line.Substring(index + 1);//取第一个=之后的字符串
                    replaceDict.Add(name, replaceString);
                }
            }


            return replaceDict;
        }

        /// <summary>
        /// 正则匹配到的内容进行替换
        /// </summary>
        /// <param name="input">输入的文本内容</param>
        /// <param name="pattern">正则字符串</param>
        /// <param name="precise">
        /// true：进行精确替换，替换匹配到的各分组内容，不管是否是空字符""或者空白字符等，就是1个萝卜1个坑的替换
        /// false：碰到空字符""的分组无法进行替换
        /// </param>
        /// <param name="space">是否替换空白字符串： 空格、换行、tab等不可见字符串</param>
        /// <returns>替换后的字符串</returns>
        public string DoRegexReplace(string input, string pattern, bool precise = false, bool space = false)
        {
            string newInput = new string(input);
            Console.WriteLine(newInput);
            Dictionary<string, string> replaceDict = ReplaceDict(txtReplace.Text.Trim());
            var matches = Regex.Matches(input, pattern);
            var matchArray = matches.ToArray();
            if (matches != null)
            {

                for (int i = 0; i < matchArray.Length; i++)
                {
                    string perValue = matchArray[i].Groups[0].Value;
                    string newValue = perValue;
                    for (int j = 0; j < matchArray[i].Groups.Count; j++)
                    {
                        Console.WriteLine($"[{i}]--[{j}]--{matchArray[i].Groups[j].Value}---name:{matchArray[i].Groups[j].Name}---");

                        string? replaceStr = null;
                        if (replaceDict.ContainsKey(matchArray[i].Groups[j].Name))
                        {
                            replaceStr = replaceDict[matchArray[i].Groups[j].Name];

                        }
                        else if (replaceDict.ContainsKey(j.ToString()))
                        {
                            replaceStr = replaceDict[j.ToString()];
                        }
                        Console.WriteLine($"replaceStr:{replaceStr}");

                        if (replaceStr != null
                           && (precise || (!precise && !string.IsNullOrEmpty(matchArray[i].Groups[j].Value)))
                            )
                        {

                            if (precise)
                            {
                                //进行精确替换，替换匹配到的各分组内容，不管是否是空字符""或者空白字符等，就是1个萝卜1个坑的替换
                                string? reStr = ReplaceSingleMatchString(newValue, pattern, matchArray[i].Groups[j].Name, replaceStr);
                                if (reStr != null)
                                {
                                    newValue = reStr;
                                }
                            }
                            else
                            {
                                //模糊替换，就是按匹配到的值进行替换 如果碰到空字符""没法进行空内容替换

                                //可以替换空白字符 或者 不能替换空白字符则对应的那个分组值如果是非空白字符
                                //空白字符包含 空格、换行、tab等非可见字符
                                if (space == true || (space == false && !Regex.Match(matchArray[i].Groups[j].Value, "\\s+").Success))
                                {
                                    newValue = newValue.Replace(matchArray[i].Groups[j].Value, replaceDict[matchArray[i].Groups[j].Name]);
                                }

                            }

                            Console.WriteLine($"--newValue:---{newValue}===");

                            if (j == 0) break; //$0就是匹配整串的了，如果整串都替换了，子分组就不存在，没必要循环替换了

                        }
                    }
                    if (newValue != perValue)
                    {
                        newInput = newInput.Replace(perValue, newValue);
                    }

                }

                DisplayRegexMatchs(pattern, matches, lvwMatchResult);//替换完成后，同时显示匹配结果列表
            }


            return newInput;
        }

        /// <summary>
        /// 匹配到的正则分组进行精准定位替换
        /// </summary>
        /// <param name="value">分组对应的整串，非分组子串</param>
        /// <param name="pattern">正则</param>
        /// <param name="name">正则匹配到的分组name</param>
        /// <param name="replace">替换内容</param>
        /// <returns></returns>
        public string? ReplaceSingleMatchString(string value, string pattern, string name, string replace)
        {
            string? str = null;
            var matches = Regex.Matches(value, pattern);
            if (matches != null)
            {
                var matchArray = matches.ToArray();
                for (int i = 0; i < matchArray.Length; i++)
                {
                    for (int j = 0; j < matchArray[i].Groups.Count; j++)
                    {
                        if (matchArray[i].Groups[j].Name == name)
                        {
                            int replaceIndex = matchArray[i].Groups[j].Index - matchArray[i].Groups[0].Index;
                            int replaceLength = matchArray[i].Groups[j].Value.Length;

                            string prev = matchArray[i].Groups[0].Value.Substring(0, replaceIndex);
                            string next = matchArray[i].Groups[0].Value.Substring(replaceIndex + replaceLength);

                            str = prev + replace + next;
                        }

                    }
                }
            }

            return str;

        }



        /// <summary>
        /// 正则匹配内容显示到列表框里
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="matches"></param>
        /// <param name="listView"></param>
        public void DisplayRegexMatchs(string pattern, MatchCollection matches, ListView listView)
        {
            listView.Clear();

            if (matches != null)
            {

                //var matArray = matches.ToArray();//数组/list都可以
                var matList = matches.Cast<Match>().ToList();

                listView.BeginUpdate();//数据填充完再显示，避免界面闪烁
                for (int i = 0; i < matList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();

                    for (int j = 0; j < matList[i].Groups.Count; j++)
                    {
                        //添加列头标题 ColumnHeader 同时确定了列数
                        if (i == 0)
                        {
                            if (j == 0)
                            {

                                listView.Columns.Add("序号");//第0列作为序号列显示，非匹配列

                                //listView.Columns.Add($"${j} 匹配的完整串");//第1列 $0 正则匹配到的整串
                            }

                            //分组0 是匹配到完整的字符串整串，其它子分组 从下标1开始
                            string headerTitle = " 分组:" + matList[i].Groups[j].Name;

                            listView.Columns.Add(headerTitle);//从第1列开始显示匹配文本
                        }

                        //每个列里添加项
                        //listViewItem.SubItems[0].Text = i.ToString();//第0列
                        listViewItem.Text = i.ToString();//第0列，序号列，第i行
                        listViewItem.SubItems.Add(matList[i].Groups[j].Value);//第j+1列， 第i行

                        Console.WriteLine($"[{i}]---[{j}]--->{matList[i].Groups[j]}");
                    }
                    listView.Items.Add(listViewItem);
                }

                ListViewReSizeWidth(listView);//根据内容自动调整列宽度

                listView.EndUpdate();
            }
        }

        /// <summary>
        /// 列表框自动调整列宽度
        /// </summary>
        private void ListViewReSizeWidth(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
            {
                //column.Width = -1;//根据项内容自动调整宽度
                column.Width = -2;//根据项内容和标题自动调整宽度
                Console.WriteLine("width:{0}", column.Width);

                //再用column.Width获取实际列宽度，为了显示不要太长，这里做一下限制
                if (column.Width > 200)
                {
                    column.Width = 200;
                }

            }
        }

        /// <summary>
        /// 获取正则字符串的分组name，保存到字典里Key第几个分组，Value对应分组name
        /// 分组name直接可以用Groups[i].Name获取，不需要这个
        /// </summary>
        /// <param name="pattern">正则字符串</param>
        /// <returns></returns>


        private void txtPattern_TextChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("regex", "pattern", txtPattern.Text);
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            //这个文本比较判断，内容复杂，全部内容直接保存到一个txt文档里
            File.WriteAllText(contentCacheFile, txtContent.Text, Encoding.UTF8);
        }

        private void txtReplace_TextChanged(object sender, EventArgs e)
        {
            iniService.WriteIniData("regex", "replace", HttpUtility.UrlEncode(txtReplace.Text, Encoding.UTF8));

        }

        private void txtReplace_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "示例：$1=good  解释：$分组name=替换内容；1行1组替换内容，按行填写\r\n" +
                "可以先用本工具的【匹配】可查看对应分组name";
        }
        private void txtReplace_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }
        private void chkReplacePrecise_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "替换匹配到的各分组内容，无视空字符\"\"或空白字符，就是1个萝卜1个坑的替换";
        }

        private void chkReplacePrecise_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }
        private void chkReplaceSpace_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "空白字符包含 空格、换行、tab等非可见字符，但不包括空字符串\"\"";
        }

        private void chkReplaceSpace_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }


        private void btnReplaceHelp_MouseEnter(object sender, EventArgs e)
        {
            lblTips.Text = "查看替换帮助";
        }

        private void btnReplaceHelp_MouseLeave(object sender, EventArgs e)
        {
            lblTips.Text = "";
        }
        private void chkReplaceSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReplaceSpace.Checked)
            {
                iniService.WriteIniData("regex", "replacespace", "1");
            }
            else
            {
                iniService.WriteIniData("regex", "replacespace", "0");
            }

        }


        private void chkReplacePrecise_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReplacePrecise.Checked)
            {
                chkReplaceSpace.Enabled = false;
                iniService.WriteIniData("regex", "replaceprecise", "1");
            }
            else
            {
                chkReplaceSpace.Enabled = true;
                iniService.WriteIniData("regex", "replaceprecise", "0");
            }
        }
        private void btnReplaceHelp_Click(object sender, EventArgs e)
        {

        }




    }
}
