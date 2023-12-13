using SuperTool.JsonTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTool.JsonTool
{
    public partial class JsonFrm : Form
    {

        private string cacheFile = @"cache\jsonbox.txt";//json文本框保存的缓存文件

        private JsonCodeGen jsonSetting;
        private Dictionary<string, List<string>> codeDict;
        private Dictionary<string, JsonArray> codeDictA = new Dictionary<string, JsonArray>();

        public JsonFrm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            jsonSetting = new JsonCodeGen();
        }

        /// <summary>
        /// From_Load窗口创建时进行的一些预处理操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            //json配置文件里读取到语言列表
            //List<string> codeNameList = jsonSetting.GetCodeNameList();
            codeDictA = jsonSetting.GetSettingData();
            foreach (var item in codeDictA)
            {
                cmbSelectCode.Items.Add(item.Key);
            }
            cmbSelectCode.SelectedIndex = 0;

            tvwJsonTree.ImageList = imlJsonTreeIcon;//节点树图标 0值 1组 2像

            //JSON文本框读取缓存
            if (File.Exists(cacheFile))
            {
                Task.Run(() => {
                    txtJsonString.Text = File.ReadAllText(cacheFile);
                });
                
            }

        }

        /// <summary>
        /// 点击解析按钮，进行json文本解析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJsonParse_Click(object sender, EventArgs e)
        {
            //System.Console.Clear();//清除控制台窗口中的内容

            tvwJsonTree.Nodes.Clear();
            TreeNode treeNode = tvwJsonTree.Nodes.Add("root [Object]");//创建树根节点
            treeNode.ImageIndex = 2;//imageIndex=2对象图标
            treeNode.SelectedImageIndex = 2;
            JsonParesToTreeView(txtJsonString.Text, treeNode);

            if (tvwJsonTree.Nodes != null) tvwJsonTree.Nodes[0].Expand();//展开第1级
            //tvwJsonTree.Nodes[0].ExpandAll();全部展开

        }

        /// <summary>
        /// 窗口关闭FromClosing进行的一些处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// 解析json字符串，并加载到TreeView树节点
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="treeNo"></param>
        /// <param name="jsonNo"></param>
        /// <param name="name"></param>
        public void JsonParesToTreeView(string jsonString, TreeNode? treeNo = null, JsonNode? jsonNo = null, string name = "")
        {
            string jsonStr = "";
            if (jsonString != null && jsonString != string.Empty)
            {
                jsonStr = jsonString.Trim();
                if (jsonStr[0] == '{')//如果字符串开头是 { 则为对象
                {
                    //解析json对象，并遍历节点，JsonNode无法遍历操作需转JsonObject
                    JsonNode jsonNode;
                    JsonObject? jsonObject = null;
                    try
                    {
                        jsonNode = JsonNode.Parse(jsonStr)!;
                        jsonObject = jsonNode.AsObject();

                        txtJsonContent.Text = "";
                    }
                    catch (Exception)
                    {
                        txtJsonContent.Text = "字符串文本不是json格式，无法解析";
                        treeNo.Text = string.Empty;
                        //throw;
                    }

                    if (jsonObject == null) { return; }

                    foreach (var item in jsonObject)
                    {
                        if (item.Value != null && item.Value.ToString() != string.Empty)
                        {
                            if (item.Value.ToString()[0] == '{')
                            {
                                //该数组节点是对象，即该节点也是一个json字符串，进行递归解析该子json

                                //节点先添加到树， TreeNode的Name保存JsonNode的各节点属性累加字符串，Tag保存的是该Json节点的内容

                                string treeText = item.Key + ": [Object]";
                                string treeName = name + "[\"" + item.Key + "\"]";//C#格式
                                //string treeName = name + "node=" + item.Key+",";//自定义字符串，后面可以根据该字符串自定义生成
                                //TreeNode childTree = AddChildNode(treeNo, treeText, treeName, item.Value);
                                TreeNode childTree = AddChildNode(treeNo, treeText, treeName, 2, item.Value);//imageIndex=2对象图标

                                //递归，需要把新的树节点作为父节点， 本节点item.Value作为父节点传进去
                                JsonParesToTreeView(item.Value.ToString(), childTree, item.Value, treeName);
                            }

                            else if (item.Value.ToString()[0] == '[' && item.Value is JsonArray)
                            {
                                //该数值节点还是一个数组，进行递归解析子数组

                                //节点先添加到树
                                string treeText = item.Key + ": [Array]";
                                string treeName = name + "[\"" + item.Key + "\"]";//C#格式
                                //string treeName = name + "node=" + item.Key + ",";//自定义字符串，后面可以根据该字符串自定义生成
                                //TreeNode childTree = AddChildNode(treeNo, treeText, treeName, item.Value);
                                TreeNode childTree = AddChildNode(treeNo, treeText, treeName, 1, item.Value);//imageIndex=1数组图标

                                JsonParesToTreeView(item.Value.ToString(), childTree, item.Value, treeName);
                            }
                            else
                            {
                                //正常字段值，进行输出，节点添加到树
                                string treeText = item.Key + ":" + item.Value;
                                string treeName = name + "[\"" + item.Key + "\"]";//C#格式
                                //string treeName = name + "node=" + item.Key + ",";//自定义字符串，后面可以根据该字符串自定义生成
                                //AddChildNode(treeNo, treeText, treeName, item.Value);
                                AddChildNode(treeNo, treeText, treeName, 0, item.Value);//imageIndex=0值图标
                            }

                        }
                        else
                        {
                            //value值为空
                            string treeText = item.Key + ":";
                            string treeName = name + "[\"" + item.Key + "\"]";//C#格式
                            //string treeName = name + "node=" + item.Key + ",";//自定义字符串，后面可以根据该字符串自定义生成
                            //AddChildNode(treeNo, treeText, treeName, item.Value);
                            AddChildNode(treeNo, treeText, treeName, 0, item.Value);//imageIndex=0值图标
                        }

                    }
                }
                else if (jsonStr[0] == '[' && jsonNo != null)//如果字符串开头是 [ 则为数组
                {
                    var jsonArray = jsonNo.AsArray();
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        var childNode = jsonArray[i];
                        if (childNode != null && childNode.ToString() != string.Empty)
                        {
                            //该数组节点是对象，即该节点也是一个json字符串，进行递归解析该子json
                            if (childNode.ToString()[0] == '{')
                            {
                                string treeText = "[" + i.ToString() + "]" + ": [Object]";
                                string treeName = name + "[" + i.ToString() + "]";//C#格式
                                //string treeName = name + "arr=" + i.ToString() + ",";//自定义字符串，后面可以根据该字符串自定义生成
                                //TreeNode childTree = AddChildNode(treeNo, treeText, treeName, childNode.ToString());
                                TreeNode childTree = AddChildNode(treeNo, treeText, treeName, 2, childNode.ToString());

                                JsonParesToTreeView(childNode.ToString(), childTree, childNode, treeName);
                            }

                            else if (childNode.ToString()[0] == '[' && childNode is JsonArray)
                            {
                                //该数值节点还是一个数组，进行递归解析子数组

                                string treeText = "[" + i.ToString() + "]" + ": [Array]";
                                string treeName = name + "[" + i.ToString() + "]";//C#格式
                                //string treeName = name + "arr=" + i.ToString() + ",";//自定义字符串，后面可以根据该字符串自定义生成
                                //TreeNode childTree = AddChildNode(treeNo, treeText, treeName, childNode);
                                TreeNode childTree = AddChildNode(treeNo, treeText, treeName, 1, childNode);

                                JsonParesToTreeView(childNode.ToString(), childTree, childNode, treeName);
                            }
                            else
                            {
                                //正常字段值，进行输出

                                string treeText = "[" + i.ToString() + "]" + ":" + childNode.ToString();
                                string treeName = name + "[" + i.ToString() + "]";//C#格式
                                //string treeName = name + "arr=" + i.ToString() + ",";//自定义字符串，后面可以根据该字符串自定义生成
                                //AddChildNode(treeNo, treeText, treeName, childNode);
                                AddChildNode(treeNo, treeText, treeName, 0, childNode);
                            }

                        }
                        //数值节点对应的值为空
                        else
                        {
                            //value值为空
                            string treeText = "[" + i.ToString() + "]" + ":";
                            string treeName = name + "[" + i.ToString() + "]";//C#格式
                            //string treeName = name + "arr=" + i.ToString() + ",";//自定义字符串，后面可以根据该字符串自定义生成
                            //AddChildNode(treeNo, treeText, treeName, childNode);
                            AddChildNode(treeNo, treeText, treeName, 0, childNode);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// TreeView树新增子节点
        /// </summary>
        /// <param name="node">父节点</param>
        /// <param name="text"></param>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns>返回新增的子节点</returns>
        private TreeNode AddChildNode(TreeNode? node, string text, string name, object? tag)
        {
            TreeNode childTree = new TreeNode(text);
            childTree.Name = name;
            childTree.Tag = tag;

            node.Nodes.Add(childTree);

            return childTree;
        }

        /// <summary>
        /// TreeView树新增子节点 带图标
        /// </summary>
        /// <param name="node">父节点</param>
        /// <param name="text"></param>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns>返回新增的子节点</returns>
        private TreeNode AddChildNode(TreeNode? node, string text, string name, int imgIndex, object? tag)
        {
            TreeNode childTree = new TreeNode(text);
            childTree.Name = name;
            childTree.Tag = tag;
            childTree.ImageIndex = imgIndex;
            childTree.SelectedImageIndex = imgIndex;//节点选择图标保持和原图标一致
            node.Nodes.Add(childTree);

            return childTree;
        }


        /// <summary>
        /// 点选树节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwJsonTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //节点属性累加显示到textBox
            string str = "";
            if (e.Node != null && e.Node.Name != null)
            {
                string name = e.Node.Name.ToString();
                if (name != string.Empty && name[name.Length - 1] == '.')
                {
                    str = name.Substring(0, name.Length - 1);
                }
                else
                {
                    str = name;
                }
            }
            txtJsonNode.Text = str;

            //节点内容显示到textBox
            if (e.Node != null && e.Node.Tag != null)
            {
                txtJsonContent.Text = e.Node.Tag.ToString();
            }
            else
            {
                txtJsonContent.Text = "";
            }


        }


        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (txtJsonNode.Text == "")
            {
                txtCode.Text = "请在右侧选择节点";
                return;
            }

            string code = "";
            string name = cmbSelectCode.SelectedItem.ToString()!;
            string content = txtJsonContent.Text.Trim();
            if (content != "" && content[0] == '[')
            {
                //显示数组节点的代码，可以自己在json配置文件里配置display=1
                code = jsonSetting.GetCodeText(codeDictA[name], new int[] { 0, 1 }, txtJsonNode.Text);
            }
            else
            {
                code = jsonSetting.GetCodeText(codeDictA[name], new int[] { 0 }, txtJsonNode.Text);
            }


            txtCode.Text = code;

        }

        /// <summary>
        /// json文本框内容改变后，保存到缓存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtJsonString_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(cacheFile, txtJsonString.Text);
        }
    }
}
