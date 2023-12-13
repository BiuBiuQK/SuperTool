namespace SuperTool.RegexTool
{
    partial class RegexFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexFrm));
            txtPattern = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnRules = new Button();
            btnMatch = new Button();
            btnReplace = new Button();
            tabResult = new TabControl();
            tabPageMatchResult = new TabPage();
            lvwMatchResult = new ListView();
            tabPageReplaceResult = new TabPage();
            txtReplaceResult = new TextBox();
            tabPageGenerateCode = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnGenerateCode = new Button();
            cmbSelectCode = new ComboBox();
            txtCode = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtContent = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            txtReplace = new TextBox();
            panel1 = new Panel();
            btnReplaceHelp = new Button();
            chkReplaceSpace = new CheckBox();
            chkReplacePrecise = new CheckBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblTips = new Label();
            lblWarning = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabResult.SuspendLayout();
            tabPageMatchResult.SuspendLayout();
            tabPageReplaceResult.SuspendLayout();
            tabPageGenerateCode.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // txtPattern
            // 
            txtPattern.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPattern.Location = new Point(4, 4);
            txtPattern.Multiline = true;
            txtPattern.Name = "txtPattern";
            txtPattern.PlaceholderText = "正则字符串";
            txtPattern.Size = new Size(505, 51);
            txtPattern.TabIndex = 0;
            txtPattern.TextChanged += txtPattern_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(880, 537);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tabResult, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 4);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(874, 531);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnRules, 3, 0);
            tableLayoutPanel3.Controls.Add(btnMatch, 0, 0);
            tableLayoutPanel3.Controls.Add(btnReplace, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(868, 36);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // btnRules
            // 
            btnRules.Anchor = AnchorStyles.Right;
            btnRules.Location = new Point(789, 4);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(75, 28);
            btnRules.TabIndex = 5;
            btnRules.Text = "常用规则";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // btnMatch
            // 
            btnMatch.Anchor = AnchorStyles.Left;
            btnMatch.Location = new Point(4, 4);
            btnMatch.Name = "btnMatch";
            btnMatch.Size = new Size(75, 28);
            btnMatch.TabIndex = 6;
            btnMatch.Text = "匹配";
            btnMatch.UseVisualStyleBackColor = true;
            btnMatch.Click += btnMatch_Click;
            // 
            // btnReplace
            // 
            btnReplace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReplace.Location = new Point(86, 4);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(75, 28);
            btnReplace.TabIndex = 7;
            btnReplace.Text = "替换";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // tabResult
            // 
            tabResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabResult.Controls.Add(tabPageMatchResult);
            tabResult.Controls.Add(tabPageReplaceResult);
            tabResult.Controls.Add(tabPageGenerateCode);
            tabResult.Location = new Point(3, 269);
            tabResult.Name = "tabResult";
            tabResult.SelectedIndex = 0;
            tabResult.Size = new Size(868, 218);
            tabResult.TabIndex = 8;
            // 
            // tabPageMatchResult
            // 
            tabPageMatchResult.Controls.Add(lvwMatchResult);
            tabPageMatchResult.Location = new Point(4, 26);
            tabPageMatchResult.Name = "tabPageMatchResult";
            tabPageMatchResult.Padding = new Padding(3);
            tabPageMatchResult.Size = new Size(860, 188);
            tabPageMatchResult.TabIndex = 0;
            tabPageMatchResult.Text = "匹配结果";
            tabPageMatchResult.UseVisualStyleBackColor = true;
            // 
            // lvwMatchResult
            // 
            lvwMatchResult.Activation = ItemActivation.OneClick;
            lvwMatchResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwMatchResult.FullRowSelect = true;
            lvwMatchResult.GridLines = true;
            lvwMatchResult.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvwMatchResult.LabelEdit = true;
            lvwMatchResult.Location = new Point(6, 6);
            lvwMatchResult.Name = "lvwMatchResult";
            lvwMatchResult.Size = new Size(848, 176);
            lvwMatchResult.TabIndex = 6;
            lvwMatchResult.UseCompatibleStateImageBehavior = false;
            lvwMatchResult.View = View.Details;
            // 
            // tabPageReplaceResult
            // 
            tabPageReplaceResult.Controls.Add(txtReplaceResult);
            tabPageReplaceResult.Location = new Point(4, 26);
            tabPageReplaceResult.Name = "tabPageReplaceResult";
            tabPageReplaceResult.Padding = new Padding(3);
            tabPageReplaceResult.Size = new Size(860, 188);
            tabPageReplaceResult.TabIndex = 1;
            tabPageReplaceResult.Text = "替换结果";
            tabPageReplaceResult.UseVisualStyleBackColor = true;
            // 
            // txtReplaceResult
            // 
            txtReplaceResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtReplaceResult.Location = new Point(6, 6);
            txtReplaceResult.MaxLength = 0;
            txtReplaceResult.Multiline = true;
            txtReplaceResult.Name = "txtReplaceResult";
            txtReplaceResult.ReadOnly = true;
            txtReplaceResult.ScrollBars = ScrollBars.Vertical;
            txtReplaceResult.Size = new Size(848, 176);
            txtReplaceResult.TabIndex = 0;
            // 
            // tabPageGenerateCode
            // 
            tabPageGenerateCode.Controls.Add(tableLayoutPanel7);
            tabPageGenerateCode.Location = new Point(4, 26);
            tabPageGenerateCode.Name = "tabPageGenerateCode";
            tabPageGenerateCode.Padding = new Padding(3);
            tabPageGenerateCode.Size = new Size(860, 188);
            tabPageGenerateCode.TabIndex = 2;
            tabPageGenerateCode.Text = "生成代码";
            tabPageGenerateCode.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel7.Controls.Add(txtCode, 0, 0);
            tableLayoutPanel7.Location = new Point(6, 6);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(848, 176);
            tableLayoutPanel7.TabIndex = 8;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.Controls.Add(btnGenerateCode, 0, 1);
            tableLayoutPanel8.Controls.Add(cmbSelectCode, 0, 2);
            tableLayoutPanel8.Location = new Point(763, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle());
            tableLayoutPanel8.RowStyles.Add(new RowStyle());
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(82, 170);
            tableLayoutPanel8.TabIndex = 0;
            tableLayoutPanel8.Visible = false;
            // 
            // btnGenerateCode
            // 
            btnGenerateCode.Location = new Point(3, 3);
            btnGenerateCode.Name = "btnGenerateCode";
            btnGenerateCode.Size = new Size(75, 30);
            btnGenerateCode.TabIndex = 1;
            btnGenerateCode.Text = "生成代码";
            btnGenerateCode.UseVisualStyleBackColor = true;
            // 
            // cmbSelectCode
            // 
            cmbSelectCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSelectCode.FormattingEnabled = true;
            cmbSelectCode.Location = new Point(3, 39);
            cmbSelectCode.Name = "cmbSelectCode";
            cmbSelectCode.Size = new Size(75, 25);
            cmbSelectCode.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(3, 3);
            txtCode.MaxLength = 0;
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(754, 170);
            txtCode.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 45);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(868, 218);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(txtPattern, 0, 0);
            tableLayoutPanel5.Controls.Add(txtContent, 0, 1);
            tableLayoutPanel5.Location = new Point(4, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(513, 210);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // txtContent
            // 
            txtContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContent.Location = new Point(4, 62);
            txtContent.MaxLength = 0;
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.PlaceholderText = "源文本内容";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(505, 144);
            txtContent.TabIndex = 9;
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(txtReplace, 0, 0);
            tableLayoutPanel9.Controls.Add(panel1, 0, 1);
            tableLayoutPanel9.Location = new Point(524, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.Size = new Size(340, 210);
            tableLayoutPanel9.TabIndex = 8;
            // 
            // txtReplace
            // 
            txtReplace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtReplace.Location = new Point(3, 3);
            txtReplace.Multiline = true;
            txtReplace.Name = "txtReplace";
            txtReplace.PlaceholderText = "正则替换";
            txtReplace.ScrollBars = ScrollBars.Vertical;
            txtReplace.Size = new Size(334, 163);
            txtReplace.TabIndex = 1;
            txtReplace.TextChanged += txtReplace_TextChanged;
            txtReplace.MouseEnter += txtReplace_MouseEnter;
            txtReplace.MouseLeave += txtReplace_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReplaceHelp);
            panel1.Controls.Add(chkReplaceSpace);
            panel1.Controls.Add(chkReplacePrecise);
            panel1.Location = new Point(3, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 35);
            panel1.TabIndex = 2;
            // 
            // btnReplaceHelp
            // 
            btnReplaceHelp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReplaceHelp.Image = (Image)resources.GetObject("btnReplaceHelp.Image");
            btnReplaceHelp.Location = new Point(173, 4);
            btnReplaceHelp.Name = "btnReplaceHelp";
            btnReplaceHelp.Size = new Size(26, 26);
            btnReplaceHelp.TabIndex = 2;
            btnReplaceHelp.UseVisualStyleBackColor = true;
            btnReplaceHelp.Click += btnReplaceHelp_Click;
            btnReplaceHelp.MouseEnter += btnReplaceHelp_MouseEnter;
            btnReplaceHelp.MouseLeave += btnReplaceHelp_MouseLeave;
            // 
            // chkReplaceSpace
            // 
            chkReplaceSpace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkReplaceSpace.AutoSize = true;
            chkReplaceSpace.Location = new Point(84, 8);
            chkReplaceSpace.Name = "chkReplaceSpace";
            chkReplaceSpace.Size = new Size(75, 21);
            chkReplaceSpace.TabIndex = 1;
            chkReplaceSpace.Text = "替换空白";
            chkReplaceSpace.UseVisualStyleBackColor = true;
            chkReplaceSpace.CheckedChanged += chkReplaceSpace_CheckedChanged;
            chkReplaceSpace.MouseEnter += chkReplaceSpace_MouseEnter;
            chkReplaceSpace.MouseLeave += chkReplaceSpace_MouseLeave;
            // 
            // chkReplacePrecise
            // 
            chkReplacePrecise.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkReplacePrecise.AutoSize = true;
            chkReplacePrecise.Location = new Point(3, 8);
            chkReplacePrecise.Name = "chkReplacePrecise";
            chkReplacePrecise.Size = new Size(75, 21);
            chkReplacePrecise.TabIndex = 0;
            chkReplacePrecise.Text = "精准替换";
            chkReplacePrecise.UseVisualStyleBackColor = true;
            chkReplacePrecise.CheckedChanged += chkReplacePrecise_CheckedChanged;
            chkReplacePrecise.MouseEnter += chkReplacePrecise_MouseEnter;
            chkReplacePrecise.MouseLeave += chkReplacePrecise_MouseLeave;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Controls.Add(lblTips, 1, 0);
            tableLayoutPanel6.Controls.Add(lblWarning, 0, 0);
            tableLayoutPanel6.Location = new Point(3, 493);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(868, 35);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // lblTips
            // 
            lblTips.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTips.AutoSize = true;
            lblTips.ForeColor = Color.Red;
            lblTips.Location = new Point(350, 9);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(515, 17);
            lblTips.TabIndex = 0;
            lblTips.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWarning
            // 
            lblWarning.Anchor = AnchorStyles.Left;
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(3, 9);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(44, 17);
            lblWarning.TabIndex = 1;
            lblWarning.Text = "         ";
            lblWarning.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegexFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "RegexFrm";
            Text = "正则工具";
            Load += RegexFrm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabResult.ResumeLayout(false);
            tabPageMatchResult.ResumeLayout(false);
            tabPageReplaceResult.ResumeLayout(false);
            tabPageReplaceResult.PerformLayout();
            tabPageGenerateCode.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPattern;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRules;
        private ListView lvwMatchResult;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TabControl tabResult;
        private TabPage tabPageMatchResult;
        private TabPage tabPageReplaceResult;
        private Button btnMatch;
        private TextBox txtContent;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtReplace;
        private TextBox txtReplaceResult;
        private Button btnReplace;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblTips;
        private Label lblWarning;
        private TabPage tabPageGenerateCode;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private ComboBox cmbSelectCode;
        private Button btnGenerateCode;
        private TextBox txtCode;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel1;
        private CheckBox chkReplaceSpace;
        private CheckBox chkReplacePrecise;
        private Button btnReplaceHelp;
    }
}