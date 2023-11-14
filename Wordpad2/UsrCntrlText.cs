using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordpad2
{
    public partial class UsrCntrlText : UserControl
    {
        public bool isChanged = false;
        public bool hasAlrdyChngdTabText = false;

        public UsrCntrlText()
        {
            InitializeComponent();
        }

        private void rchTxtBxUsrCntrl_TextChanged(object sender, EventArgs e)
        {
            this.isChanged = !this.isChanged;
            if (!hasAlrdyChngdTabText)
            {
                TabControl tabCntrl = this.ParentForm.Controls["tbCntrlMain"] as TabControl;
                TabPage tabPage = tabCntrl.SelectedTab;
                tabPage.Text = $"{tabPage.Text} ~ Changed";
                hasAlrdyChngdTabText = true;
            }
        }

        private void btnChngFontDlg_Click(object sender, EventArgs e)
        {
            if (fntDlgUsrCntrlText.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxUsrCntrl.SelectionFont = fntDlgUsrCntrlText.Font;
            }
        }

        private void btnOpnImg_Click(object sender, EventArgs e)
        {
            if (opnFlDlgImg.ShowDialog() == DialogResult.OK)
            {
                Form2 newForm = new Form2();
                newForm.Parent = this;
                newForm.pctrBxImgForm2.ImageLocation = opnFlDlgImg.FileName;
                newForm.Show();
                newForm.BringToFront();
            }
        }

        private void UsrCntrlText_SizeChanged(object sender, EventArgs e)
        {
            rchTxtBxUsrCntrl.Left = (this.Width / 2) - (rchTxtBxUsrCntrl.Width / 2);
            rchTxtBxUsrCntrl.Height = this.Height - ((70 / 100) * this.Height);
            //rchTxtBxUsrCntrl.Top = (this.Height / 2) - (rchTxtBxUsrCntrl.Height / 2);
        }
    }
}
