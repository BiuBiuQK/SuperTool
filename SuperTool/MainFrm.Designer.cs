namespace SuperTool
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            lblMainMsg = new Label();
            btnJsonFormLoad = new Button();
            splitContainer1 = new SplitContainer();
            btnRegexFormLoad = new Button();
            btnMainPanel = new Button();
            btnRequestFormLoad = new Button();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.LemonChiffon;
            pnlMain.Controls.Add(lblMainMsg);
            pnlMain.Location = new Point(3, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(944, 614);
            pnlMain.TabIndex = 0;
            // 
            // lblMainMsg
            // 
            lblMainMsg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMainMsg.AutoSize = true;
            lblMainMsg.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMainMsg.ForeColor = Color.FromArgb(192, 0, 192);
            lblMainMsg.Location = new Point(234, 254);
            lblMainMsg.Name = "lblMainMsg";
            lblMainMsg.Size = new Size(445, 62);
            lblMainMsg.TabIndex = 0;
            lblMainMsg.Text = "SuperTool 专业网页访问调试工具\r\njson解析，正则匹配替换，网页访问调试";
            lblMainMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnJsonFormLoad
            // 
            btnJsonFormLoad.BackColor = Color.FromArgb(255, 192, 128);
            btnJsonFormLoad.Location = new Point(7, 79);
            btnJsonFormLoad.Name = "btnJsonFormLoad";
            btnJsonFormLoad.Size = new Size(152, 56);
            btnJsonFormLoad.TabIndex = 1;
            btnJsonFormLoad.Text = "JSON解析工具";
            btnJsonFormLoad.UseVisualStyleBackColor = false;
            btnJsonFormLoad.Click += btnJsonFormLoad_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(192, 192, 255);
            splitContainer1.Panel1.Controls.Add(btnRegexFormLoad);
            splitContainer1.Panel1.Controls.Add(btnMainPanel);
            splitContainer1.Panel1.Controls.Add(btnRequestFormLoad);
            splitContainer1.Panel1.Controls.Add(btnJsonFormLoad);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlMain);
            splitContainer1.Size = new Size(1120, 620);
            splitContainer1.SplitterDistance = 166;
            splitContainer1.TabIndex = 2;
            // 
            // btnRegexFormLoad
            // 
            btnRegexFormLoad.BackColor = Color.FromArgb(255, 192, 128);
            btnRegexFormLoad.Location = new Point(7, 139);
            btnRegexFormLoad.Name = "btnRegexFormLoad";
            btnRegexFormLoad.Size = new Size(152, 56);
            btnRegexFormLoad.TabIndex = 4;
            btnRegexFormLoad.Text = "正则工具";
            btnRegexFormLoad.UseVisualStyleBackColor = false;
            btnRegexFormLoad.Click += btnRegexFormLoad_Click;
            // 
            // btnMainPanel
            // 
            btnMainPanel.BackColor = Color.Khaki;
            btnMainPanel.Location = new Point(7, 19);
            btnMainPanel.Name = "btnMainPanel";
            btnMainPanel.Size = new Size(152, 56);
            btnMainPanel.TabIndex = 3;
            btnMainPanel.Text = "主页面";
            btnMainPanel.UseVisualStyleBackColor = false;
            btnMainPanel.Click += btnMainPanel_Click;
            // 
            // btnRequestFormLoad
            // 
            btnRequestFormLoad.BackColor = Color.FromArgb(255, 192, 128);
            btnRequestFormLoad.Location = new Point(7, 199);
            btnRequestFormLoad.Name = "btnRequestFormLoad";
            btnRequestFormLoad.Size = new Size(152, 56);
            btnRequestFormLoad.TabIndex = 2;
            btnRequestFormLoad.Text = "网页调试工具";
            btnRequestFormLoad.UseVisualStyleBackColor = false;
            btnRequestFormLoad.Click += btnRequestFormLoad_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1144, 641);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(980, 500);
            Name = "MainFrm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "SuperTool";
            FormClosing += MainFrm_FormClosing;
            Load += MainFrm_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Button btnJsonFormLoad;
        private SplitContainer splitContainer1;
        private Button btnRequestFormLoad;
        private Label lblMainMsg;
        private Button btnMainPanel;
        private Button btnRegexFormLoad;
    }
}