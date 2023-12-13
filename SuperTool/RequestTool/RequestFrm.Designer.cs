namespace SuperTool.RequestTool
{
    partial class RequestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestFrm));
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            cmbMethod = new ComboBox();
            label2 = new Label();
            txtProxy = new TextBox();
            label6 = new Label();
            txtMaxTimeOut = new TextBox();
            btnSend = new Button();
            btnCancel = new Button();
            chkBanRedirect = new CheckBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtUrl = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtCookie = new TextBox();
            txtRequestHeaders = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            txtSendContent = new TextBox();
            txtFileReplaceString = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabResponse = new TabControl();
            tabPage1 = new TabPage();
            txtResponseContent = new TextBox();
            tabPage2 = new TabPage();
            txtResponseHeaders = new TextBox();
            tabPage3 = new TabPage();
            txtResponseCookie = new TextBox();
            tabPage4 = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnGerenateCode = new Button();
            cmbSelectCode = new ComboBox();
            txtCode = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            lblStatus = new Label();
            lblTips = new Label();
            lblWarning = new Label();
            prgRequest = new ProgressBar();
            tableLayoutPanel8 = new TableLayoutPanel();
            label5 = new Label();
            cmbContentType = new ComboBox();
            btnSelectFile = new Button();
            txtFilePath = new TextBox();
            lblMime = new Label();
            btnFileHelp = new Button();
            txtMime = new TextBox();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabResponse.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.ColumnCount = 9;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(cmbMethod, 1, 0);
            tableLayoutPanel6.Controls.Add(label2, 2, 0);
            tableLayoutPanel6.Controls.Add(txtProxy, 3, 0);
            tableLayoutPanel6.Controls.Add(label6, 5, 0);
            tableLayoutPanel6.Controls.Add(txtMaxTimeOut, 6, 0);
            tableLayoutPanel6.Controls.Add(btnSend, 8, 0);
            tableLayoutPanel6.Controls.Add(btnCancel, 7, 0);
            tableLayoutPanel6.Controls.Add(chkBanRedirect, 4, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(898, 34);
            tableLayoutPanel6.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(4, 8);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 7;
            label3.Text = "请求类型：";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbMethod
            // 
            cmbMethod.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Location = new Point(79, 4);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(74, 25);
            cmbMethod.TabIndex = 0;
            cmbMethod.SelectedIndexChanged += cmbMethod_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(160, 8);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 6;
            label2.Text = "代理：";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProxy
            // 
            txtProxy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProxy.Location = new Point(211, 5);
            txtProxy.Name = "txtProxy";
            txtProxy.Size = new Size(154, 23);
            txtProxy.TabIndex = 1;
            txtProxy.TextChanged += txtProxy_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(466, 8);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 8;
            label6.Text = "访问超时/秒：";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMaxTimeOut
            // 
            txtMaxTimeOut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaxTimeOut.Location = new Point(558, 5);
            txtMaxTimeOut.Name = "txtMaxTimeOut";
            txtMaxTimeOut.Size = new Size(54, 23);
            txtMaxTimeOut.TabIndex = 9;
            txtMaxTimeOut.Text = "180";
            txtMaxTimeOut.TextAlign = HorizontalAlignment.Center;
            txtMaxTimeOut.TextChanged += txtMaxTimeOut_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Left;
            btnSend.ForeColor = Color.Navy;
            btnSend.Location = new Point(668, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(74, 25);
            btnSend.TabIndex = 2;
            btnSend.Text = "发送请求>";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left;
            btnCancel.Location = new Point(619, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(42, 25);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkBanRedirect
            // 
            chkBanRedirect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkBanRedirect.AutoSize = true;
            chkBanRedirect.Location = new Point(372, 6);
            chkBanRedirect.Name = "chkBanRedirect";
            chkBanRedirect.Size = new Size(87, 21);
            chkBanRedirect.TabIndex = 3;
            chkBanRedirect.Text = "禁止重定向";
            chkBanRedirect.UseVisualStyleBackColor = true;
            chkBanRedirect.CheckedChanged += chkBanRedirect_CheckedChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(txtUrl, 1, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Location = new Point(3, 43);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(898, 54);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(79, 4);
            txtUrl.Multiline = true;
            txtUrl.Name = "txtUrl";
            txtUrl.PlaceholderText = "请输入url访问地址";
            txtUrl.ScrollBars = ScrollBars.Vertical;
            txtUrl.Size = new Size(815, 46);
            txtUrl.TabIndex = 4;
            txtUrl.TextChanged += txtUrl_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 18);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 5;
            label1.Text = "请求地址：";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtCookie, 0, 0);
            tableLayoutPanel1.Controls.Add(txtRequestHeaders, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 259);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(898, 106);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // txtCookie
            // 
            txtCookie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCookie.Location = new Point(3, 3);
            txtCookie.Multiline = true;
            txtCookie.Name = "txtCookie";
            txtCookie.PlaceholderText = "提交cookie";
            txtCookie.ScrollBars = ScrollBars.Vertical;
            txtCookie.Size = new Size(443, 100);
            txtCookie.TabIndex = 9;
            txtCookie.TextChanged += txtCookie_TextChanged;
            txtCookie.MouseEnter += txtCookie_MouseEnter;
            txtCookie.MouseLeave += txtCookie_MouseLeave;
            // 
            // txtRequestHeaders
            // 
            txtRequestHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRequestHeaders.Location = new Point(452, 3);
            txtRequestHeaders.Multiline = true;
            txtRequestHeaders.Name = "txtRequestHeaders";
            txtRequestHeaders.PlaceholderText = "提交协议头";
            txtRequestHeaders.ScrollBars = ScrollBars.Vertical;
            txtRequestHeaders.Size = new Size(443, 100);
            txtRequestHeaders.TabIndex = 10;
            txtRequestHeaders.TextChanged += txtRequestHeaders_TextChanged;
            txtRequestHeaders.MouseEnter += txtRequestHeaders_MouseEnter;
            txtRequestHeaders.MouseLeave += txtRequestHeaders_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 143);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(898, 110);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(txtSendContent, 0, 0);
            tableLayoutPanel11.Controls.Add(txtFileReplaceString, 0, 1);
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle());
            tableLayoutPanel11.Size = new Size(898, 110);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // txtSendContent
            // 
            txtSendContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSendContent.Location = new Point(3, 3);
            txtSendContent.MaxLength = 0;
            txtSendContent.Multiline = true;
            txtSendContent.Name = "txtSendContent";
            txtSendContent.PlaceholderText = "提交内容";
            txtSendContent.ScrollBars = ScrollBars.Vertical;
            txtSendContent.Size = new Size(892, 75);
            txtSendContent.TabIndex = 8;
            txtSendContent.TextChanged += txtSendContent_TextChanged;
            txtSendContent.MouseEnter += txtSendContent_MouseEnter;
            txtSendContent.MouseLeave += txtSendContent_MouseLeave;
            // 
            // txtFileReplaceString
            // 
            txtFileReplaceString.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFileReplaceString.Location = new Point(3, 84);
            txtFileReplaceString.Name = "txtFileReplaceString";
            txtFileReplaceString.PlaceholderText = "提交内容中，文件字段对应替换字符串，默认是：(binary)，该字符串会被替换成要上传的文件";
            txtFileReplaceString.Size = new Size(892, 23);
            txtFileReplaceString.TabIndex = 0;
            txtFileReplaceString.TextChanged += txtFileReplaceString_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tabResponse, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 371);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(898, 136);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tabResponse
            // 
            tabResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabResponse.Controls.Add(tabPage1);
            tabResponse.Controls.Add(tabPage2);
            tabResponse.Controls.Add(tabPage3);
            tabResponse.Controls.Add(tabPage4);
            tabResponse.Location = new Point(3, 3);
            tabResponse.Name = "tabResponse";
            tabResponse.SelectedIndex = 0;
            tabResponse.Size = new Size(892, 130);
            tabResponse.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtResponseContent);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(884, 100);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "响应内容";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResponseContent
            // 
            txtResponseContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResponseContent.Location = new Point(6, 6);
            txtResponseContent.MaxLength = 0;
            txtResponseContent.Multiline = true;
            txtResponseContent.Name = "txtResponseContent";
            txtResponseContent.ScrollBars = ScrollBars.Vertical;
            txtResponseContent.Size = new Size(872, 84);
            txtResponseContent.TabIndex = 12;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtResponseHeaders);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(884, 100);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "返回协议头";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResponseHeaders
            // 
            txtResponseHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResponseHeaders.Location = new Point(6, 6);
            txtResponseHeaders.Multiline = true;
            txtResponseHeaders.Name = "txtResponseHeaders";
            txtResponseHeaders.ScrollBars = ScrollBars.Vertical;
            txtResponseHeaders.Size = new Size(872, 82);
            txtResponseHeaders.TabIndex = 13;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtResponseCookie);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(884, 100);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "返回Cookie";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResponseCookie
            // 
            txtResponseCookie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResponseCookie.Location = new Point(6, 6);
            txtResponseCookie.Multiline = true;
            txtResponseCookie.Name = "txtResponseCookie";
            txtResponseCookie.ScrollBars = ScrollBars.Vertical;
            txtResponseCookie.Size = new Size(872, 82);
            txtResponseCookie.TabIndex = 14;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel9);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(884, 100);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "生成代码";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel9.Controls.Add(txtCode, 0, 0);
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(878, 92);
            tableLayoutPanel9.TabIndex = 12;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel10.Controls.Add(btnGerenateCode, 0, 0);
            tableLayoutPanel10.Controls.Add(cmbSelectCode, 0, 1);
            tableLayoutPanel10.Location = new Point(773, 0);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(105, 79);
            tableLayoutPanel10.TabIndex = 2;
            tableLayoutPanel10.Visible = false;
            // 
            // btnGerenateCode
            // 
            btnGerenateCode.Location = new Point(3, 3);
            btnGerenateCode.Name = "btnGerenateCode";
            btnGerenateCode.Size = new Size(75, 23);
            btnGerenateCode.TabIndex = 0;
            btnGerenateCode.Text = "生成代码";
            btnGerenateCode.UseVisualStyleBackColor = true;
            // 
            // cmbSelectCode
            // 
            cmbSelectCode.Anchor = AnchorStyles.Left;
            cmbSelectCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSelectCode.FormattingEnabled = true;
            cmbSelectCode.Location = new Point(3, 32);
            cmbSelectCode.Name = "cmbSelectCode";
            cmbSelectCode.Size = new Size(75, 25);
            cmbSelectCode.TabIndex = 1;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.Location = new Point(3, 3);
            txtCode.MaxLength = 0;
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(767, 86);
            txtCode.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 6);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 5);
            tableLayoutPanel4.Controls.Add(prgRequest, 0, 7);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 4);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 8;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(904, 561);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel7.Controls.Add(label4, 0, 0);
            tableLayoutPanel7.Controls.Add(lblStatus, 1, 0);
            tableLayoutPanel7.Controls.Add(lblTips, 3, 0);
            tableLayoutPanel7.Controls.Add(lblWarning, 2, 0);
            tableLayoutPanel7.Location = new Point(3, 513);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(898, 34);
            tableLayoutPanel7.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 0;
            label4.Text = "访问状态：";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(77, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(208, 17);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTips
            // 
            lblTips.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTips.AutoSize = true;
            lblTips.ForeColor = Color.Red;
            lblTips.Location = new Point(521, 8);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(374, 17);
            lblTips.TabIndex = 2;
            lblTips.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWarning
            // 
            lblWarning.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.FromArgb(128, 64, 64);
            lblWarning.Location = new Point(291, 8);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(224, 17);
            lblWarning.TabIndex = 3;
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prgRequest
            // 
            prgRequest.Dock = DockStyle.Bottom;
            prgRequest.Location = new Point(3, 556);
            prgRequest.Name = "prgRequest";
            prgRequest.Size = new Size(898, 2);
            prgRequest.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel8.ColumnCount = 7;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Controls.Add(cmbContentType, 1, 0);
            tableLayoutPanel8.Controls.Add(btnSelectFile, 2, 0);
            tableLayoutPanel8.Controls.Add(txtFilePath, 3, 0);
            tableLayoutPanel8.Controls.Add(lblMime, 4, 0);
            tableLayoutPanel8.Controls.Add(btnFileHelp, 6, 0);
            tableLayoutPanel8.Controls.Add(txtMime, 5, 0);
            tableLayoutPanel8.Location = new Point(3, 103);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(898, 34);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(4, 8);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 0;
            label5.Text = "提交方式：";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbContentType
            // 
            cmbContentType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbContentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContentType.FormattingEnabled = true;
            cmbContentType.Location = new Point(79, 4);
            cmbContentType.Name = "cmbContentType";
            cmbContentType.Size = new Size(254, 25);
            cmbContentType.TabIndex = 1;
            cmbContentType.SelectedIndexChanged += cmbContentType_SelectedIndexChanged;
            cmbContentType.MouseEnter += cmbContentType_MouseEnter;
            cmbContentType.MouseLeave += cmbContentType_MouseLeave;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectFile.Location = new Point(340, 4);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(74, 25);
            btnSelectFile.TabIndex = 3;
            btnSelectFile.Text = "选择文件";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Visible = false;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFilePath.Location = new Point(421, 5);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(269, 23);
            txtFilePath.TabIndex = 4;
            txtFilePath.Visible = false;
            txtFilePath.TextChanged += txtFilePath_TextChanged;
            // 
            // lblMime
            // 
            lblMime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMime.AutoSize = true;
            lblMime.Location = new Point(697, 8);
            lblMime.Name = "lblMime";
            lblMime.Size = new Size(44, 17);
            lblMime.TabIndex = 5;
            lblMime.Text = "类型：";
            lblMime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnFileHelp
            // 
            btnFileHelp.Image = (Image)resources.GetObject("btnFileHelp.Image");
            btnFileHelp.Location = new Point(867, 4);
            btnFileHelp.Name = "btnFileHelp";
            btnFileHelp.Size = new Size(26, 26);
            btnFileHelp.TabIndex = 6;
            btnFileHelp.UseVisualStyleBackColor = true;
            btnFileHelp.Click += btnFileHelp_Click;
            btnFileHelp.MouseEnter += btnFileHelp_MouseEnter;
            btnFileHelp.MouseLeave += btnFileHelp_MouseLeave;
            // 
            // txtMime
            // 
            txtMime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMime.Location = new Point(748, 5);
            txtMime.Name = "txtMime";
            txtMime.Size = new Size(112, 23);
            txtMime.TabIndex = 7;
            // 
            // RequestFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 561);
            Controls.Add(tableLayoutPanel4);
            Name = "RequestFrm";
            Text = "网页调试工具";
            FormClosing += RequestFrm_FormClosing;
            Load += RequestFrm_Load;
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tabResponse.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private Button btnSend;
        private ComboBox cmbMethod;
        private CheckBox chkBanRedirect;
        private Label label2;
        private TextBox txtProxy;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtUrl;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtCookie;
        private TextBox txtRequestHeaders;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtSendContent;
        private TableLayoutPanel tableLayoutPanel2;
        private TabControl tabResponse;
        private TabPage tabPage1;
        private TextBox txtResponseContent;
        private TabPage tabPage2;
        private TextBox txtResponseHeaders;
        private TabPage tabPage3;
        private TextBox txtResponseCookie;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label4;
        private Label lblStatus;
        private ProgressBar prgRequest;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label5;
        private ComboBox cmbContentType;
        private Button btnSelectFile;
        private TextBox txtFilePath;
        private Label lblTips;
        private Label label6;
        private TextBox txtMaxTimeOut;
        private Button btnCancel;
        private Label lblWarning;
        private Label lblMime;
        private Button btnFileHelp;
        private TextBox txtMime;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnGerenateCode;
        private ComboBox cmbSelectCode;
        private TextBox txtCode;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox txtFileReplaceString;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel10;
    }
}