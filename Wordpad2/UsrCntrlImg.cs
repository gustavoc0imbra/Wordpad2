using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordpad2
{
    public partial class UsrCntrlImg : UserControl
    {
        private string filePath { get; set; }

        public UsrCntrlImg(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            pctrBxImg.ImageLocation = filePath;
        }

        private void btnCloseImg_Click(object sender, EventArgs e)
        {
            pctrBxImg.ImageLocation = null;

            UsrCntrlText selectedTabCntrl = this.Parent as UsrCntrlText;

            selectedTabCntrl.Controls.Remove(this);
        }
    }
}
