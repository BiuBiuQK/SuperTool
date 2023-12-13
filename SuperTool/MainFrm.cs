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
using SuperTool.JsonTool;
using SuperTool.RegexTool;
using SuperTool.RequestTool;

namespace SuperTool
{
    public partial class MainFrm : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();//关联一个控制台窗口
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();//释放关联的控制台窗口

        [DllImport("kernel32.dll")]
        public static extern bool CloseConsole();

        private JsonFrm? jsonFrm;
        private RequestFrm? requestFrm;
        private RegexFrm? regexFrm;
        public MainFrm()
        {
            InitializeComponent();

            AllocConsole(); //关联一个控制台窗口用于显示信息
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Panel中显示窗口
        /// </summary>
        /// <param name="form"></param>
        public void ShowForm(Form form)
        {
            pnlMain.Controls.Clear();
            form.TopLevel = false;//非顶级窗口才能加到Panle中
            form.FormBorderStyle = FormBorderStyle.None;//无边框模式
            form.Dock = DockStyle.Fill;//填充到父容器
            form.Parent = pnlMain;
            //pnlMain.Controls.Add(form);

            this.Text = "SuperTool - " + form.Text;

            form.Show();

        }

        private void btnJsonFormLoad_Click(object sender, EventArgs e)
        {
            if (jsonFrm == null)
                jsonFrm = new JsonFrm();
            ShowForm(jsonFrm);
        }
        private void btnRequestFormLoad_Click(object sender, EventArgs e)
        {

            if (requestFrm == null)
                requestFrm = new RequestFrm();
            ShowForm(requestFrm);
        }
        private void btnRegexFormLoad_Click(object sender, EventArgs e)
        {
            if (regexFrm == null)
                regexFrm = new RegexFrm();
            //regexFrm.Show();
            ShowForm(regexFrm);
        }

        /// <summary>
        /// 释放new出来的窗口对象
        /// </summary>
        private void DisposeForms()
        {
            if (requestFrm != null)
            {
                requestFrm.Dispose();
                requestFrm = null;
            }

            if (jsonFrm != null)
            {
                jsonFrm.Dispose();
                jsonFrm = null;
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeForms();

            FreeConsole();//释放关联的控制台，不然会报错
        }

        private void btnMainPanel_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(lblMainMsg);
        }


    }
}
