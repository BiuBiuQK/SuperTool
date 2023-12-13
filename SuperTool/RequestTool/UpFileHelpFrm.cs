using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTool.RequestTool
{
    public partial class UpFileHelpFrm : Form
    {
        public UpFileHelpFrm()
        {
            InitializeComponent();
        }

        private void UpFileHelpFrm_Load(object sender, EventArgs e)
        {
            txtTips.Select(0, 0);
        }
    }
}
