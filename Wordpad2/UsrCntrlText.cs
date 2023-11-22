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
        public bool isNew = false;
        public string fileName = "";
        public int imagesOpened = 0;

        public UsrCntrlText(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
        }

        private void rchTxtBxUsrCntrl_TextChanged(object sender, EventArgs e)
        {
            this.isChanged = true;
            if (!hasAlrdyChngdTabText)
            {
                TabControl tabCntrl = this.ParentForm.Controls["tbCntrlMain"] as TabControl;
                TabPage tabPage = tabCntrl.SelectedTab;
                tabPage.Text = $"{tabPage.Text} *";
                hasAlrdyChngdTabText = true;
            }
        }

        private void btnChngFontDlg_Click(object sender, EventArgs e)
        {
            if (fntDlgUsrCntrlText.ShowDialog() == DialogResult.OK)
            {
                if(rchTxtBxUsrCntrl.SelectedRtf != "")
                {
                    rchTxtBxUsrCntrl.SelectionFont = fntDlgUsrCntrlText.Font;
                    rchTxtBxUsrCntrl.SelectionColor = fntDlgUsrCntrlText.Color;
                }
                else
                {
                    rchTxtBxUsrCntrl.Font = new Font(fntDlgUsrCntrlText.Font.FontFamily, fntDlgUsrCntrlText.Font.Size, fntDlgUsrCntrlText.Font.Style);
                }
            }
        }

        private void btnOpnImg_Click(object sender, EventArgs e)
        {
            if (opnFlDlgImg.ShowDialog() == DialogResult.OK)
            {
                UsrCntrlImg newImg = new UsrCntrlImg(opnFlDlgImg.FileName);
                this.Controls.Add(newImg);
                newImg.Visible = true;
                newImg.Show();
                newImg.BringToFront();
                this.imagesOpened++;
            }
        }

        private void UsrCntrlText_SizeChanged(object sender, EventArgs e)
        {
            rchTxtBxUsrCntrl.Left = (this.Width / 2) - (rchTxtBxUsrCntrl.Width / 2);
            rchTxtBxUsrCntrl.Height = this.Height - ((70 / 100) * this.Height);
            btnCloseTab.Left = this.Width - btnOpnImg.Width;
            btnOpnImg.Left = (this.Width - btnOpnImg.Width) - 100;
        }

        private void closeTab()
        {
            TabControl tabCntrl = this.ParentForm.Controls["tbCntrlMain"] as TabControl;
            TabPage tabPage = tabCntrl.SelectedTab;
            tabCntrl.TabPages.Remove(tabPage);
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            if (!isChanged)
            {
                this.closeTab();
            }
            else
            {
                DialogResult result = MessageBox.Show("Arquivo alterado!\nDeseja Salvar?", "Wordpad 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Form1 parentForm = this.ParentForm as Form1;

                    if (isNew)
                    {
                        parentForm.saveAs();
                    }
                    else
                    {
                        parentForm.svTlStrpMnItmTop_Click(sender, e);
                    }
                }
                else
                {
                    this.closeTab();
                }
            }

        }
    }
}
