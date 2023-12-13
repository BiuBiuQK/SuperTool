namespace SuperTool.RequestTool
{
    partial class UpFileHelpFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpFileHelpFrm));
            txtTips = new TextBox();
            SuspendLayout();
            // 
            // txtTips
            // 
            txtTips.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTips.BorderStyle = BorderStyle.FixedSingle;
            txtTips.Location = new Point(12, 12);
            txtTips.Multiline = true;
            txtTips.Name = "txtTips";
            txtTips.ReadOnly = true;
            txtTips.ScrollBars = ScrollBars.Vertical;
            txtTips.Size = new Size(491, 437);
            txtTips.TabIndex = 0;
            txtTips.Text = resources.GetString("txtTips.Text");
            // 
            // UpFileHelpFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 461);
            Controls.Add(txtTips);
            Name = "UpFileHelpFrm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "文件上传帮助信息";
            Load += UpFileHelpFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTips;
    }
}