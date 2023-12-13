namespace SuperTool.JsonTool;

partial class JsonFrm
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonFrm));
        imlJsonTreeIcon = new ImageList(components);
        txtCode = new TextBox();
        txtJsonContent = new TextBox();
        txtJsonNode = new TextBox();
        btnJsonParse = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel4 = new TableLayoutPanel();
        btnGenerateCode = new Button();
        cmbSelectCode = new ComboBox();
        tvwJsonTree = new TreeView();
        txtJsonString = new TextBox();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        SuspendLayout();
        // 
        // imlJsonTreeIcon
        // 
        imlJsonTreeIcon.ColorDepth = ColorDepth.Depth8Bit;
        imlJsonTreeIcon.ImageStream = (ImageListStreamer)resources.GetObject("imlJsonTreeIcon.ImageStream");
        imlJsonTreeIcon.TransparentColor = Color.Transparent;
        imlJsonTreeIcon.Images.SetKeyName(0, "v.png");
        imlJsonTreeIcon.Images.SetKeyName(1, "a.png");
        imlJsonTreeIcon.Images.SetKeyName(2, "o.png");
        // 
        // txtCode
        // 
        txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtCode.Location = new Point(409, 388);
        txtCode.MaxLength = 0;
        txtCode.Multiline = true;
        txtCode.Name = "txtCode";
        txtCode.ScrollBars = ScrollBars.Both;
        txtCode.Size = new Size(492, 170);
        txtCode.TabIndex = 9;
        // 
        // txtJsonContent
        // 
        txtJsonContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtJsonContent.Location = new Point(3, 388);
        txtJsonContent.MaxLength = 0;
        txtJsonContent.Multiline = true;
        txtJsonContent.Name = "txtJsonContent";
        txtJsonContent.ScrollBars = ScrollBars.Both;
        txtJsonContent.Size = new Size(400, 170);
        txtJsonContent.TabIndex = 8;
        // 
        // txtJsonNode
        // 
        txtJsonNode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtJsonNode.Location = new Point(3, 4);
        txtJsonNode.Name = "txtJsonNode";
        txtJsonNode.Size = new Size(321, 23);
        txtJsonNode.TabIndex = 7;
        // 
        // btnJsonParse
        // 
        btnJsonParse.Anchor = AnchorStyles.Left;
        btnJsonParse.Location = new Point(3, 354);
        btnJsonParse.Name = "btnJsonParse";
        btnJsonParse.Size = new Size(86, 28);
        btnJsonParse.TabIndex = 14;
        btnJsonParse.Text = "解析";
        btnJsonParse.UseVisualStyleBackColor = true;
        btnJsonParse.Click += btnJsonParse_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
        tableLayoutPanel1.Controls.Add(btnJsonParse, 0, 1);
        tableLayoutPanel1.Controls.Add(tvwJsonTree, 1, 0);
        tableLayoutPanel1.Controls.Add(txtJsonContent, 0, 2);
        tableLayoutPanel1.Controls.Add(txtJsonString, 0, 0);
        tableLayoutPanel1.Controls.Add(txtCode, 1, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel1.Size = new Size(904, 561);
        tableLayoutPanel1.TabIndex = 16;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel4.ColumnCount = 3;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
        tableLayoutPanel4.Controls.Add(btnGenerateCode, 2, 0);
        tableLayoutPanel4.Controls.Add(txtJsonNode, 0, 0);
        tableLayoutPanel4.Controls.Add(cmbSelectCode, 1, 0);
        tableLayoutPanel4.Location = new Point(407, 352);
        tableLayoutPanel4.Margin = new Padding(1);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle());
        tableLayoutPanel4.Size = new Size(496, 32);
        tableLayoutPanel4.TabIndex = 17;
        // 
        // btnGenerateCode
        // 
        btnGenerateCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnGenerateCode.Location = new Point(414, 3);
        btnGenerateCode.Name = "btnGenerateCode";
        btnGenerateCode.Size = new Size(79, 25);
        btnGenerateCode.TabIndex = 10;
        btnGenerateCode.Text = "生成代码";
        btnGenerateCode.UseVisualStyleBackColor = true;
        btnGenerateCode.Click += btnGenerateCode_Click;
        // 
        // cmbSelectCode
        // 
        cmbSelectCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbSelectCode.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSelectCode.FormattingEnabled = true;
        cmbSelectCode.Location = new Point(330, 3);
        cmbSelectCode.Name = "cmbSelectCode";
        cmbSelectCode.Size = new Size(78, 25);
        cmbSelectCode.TabIndex = 11;
        // 
        // tvwJsonTree
        // 
        tvwJsonTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tvwJsonTree.Location = new Point(409, 3);
        tvwJsonTree.Name = "tvwJsonTree";
        tvwJsonTree.Size = new Size(492, 345);
        tvwJsonTree.TabIndex = 15;
        tvwJsonTree.AfterSelect += tvwJsonTree_AfterSelect;
        // 
        // txtJsonString
        // 
        txtJsonString.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtJsonString.BackColor = Color.Beige;
        txtJsonString.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        txtJsonString.Location = new Point(3, 3);
        txtJsonString.MaxLength = 0;
        txtJsonString.Multiline = true;
        txtJsonString.Name = "txtJsonString";
        txtJsonString.PlaceholderText = "将json字符串文本放到这里，然后点【解析】按钮";
        txtJsonString.ScrollBars = ScrollBars.Both;
        txtJsonString.Size = new Size(400, 345);
        txtJsonString.TabIndex = 18;
        txtJsonString.TextChanged += txtJsonString_TextChanged;
        // 
        // JsonFrm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(904, 561);
        ControlBox = false;
        Controls.Add(tableLayoutPanel1);
        Name = "JsonFrm";
        Text = "Json解析工具";
        FormClosing += MainFrm_FormClosing;
        Load += MainFrm_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private ImageList imlJsonTreeIcon;
    private TextBox txtCode;
    private TextBox txtJsonContent;
    private TextBox txtJsonNode;
    private Button btnJsonParse;
    private TableLayoutPanel tableLayoutPanel1;
    private TreeView tvwJsonTree;
    private TextBox txtJsonString;
    private Button btnGenerateCode;
    private ComboBox cmbSelectCode;
    private TableLayoutPanel tableLayoutPanel4;
}