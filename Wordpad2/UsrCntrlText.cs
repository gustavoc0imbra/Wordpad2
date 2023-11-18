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
                rchTxtBxUsrCntrl.SelectionFont = fntDlgUsrCntrlText.Font;
                rchTxtBxUsrCntrl.SelectionColor = fntDlgUsrCntrlText.Color;
            }
        }

        private void btnOpnImg_Click(object sender, EventArgs e)
        {
            if (opnFlDlgImg.ShowDialog() == DialogResult.OK)
            {
                UsrCntrlImg newImg = new UsrCntrlImg(opnFlDlgImg.FileName);
                //newImg.Parent = this;
                newImg.Visible = true;
                this.Controls.Add(newImg);
                newImg.Show();
                newImg.BringToFront();

                /*Form2 newForm = new Form2();
                newForm.Parent = this;
                newForm.pctrBxImgForm2.ImageLocation = opnFlDlgImg.FileName;
                newForm.Show();
                newForm.BringToFront();*/
            }
        }

        private void UsrCntrlText_SizeChanged(object sender, EventArgs e)
        {
            rchTxtBxUsrCntrl.Left = (this.Width / 2) - (rchTxtBxUsrCntrl.Width / 2);
            rchTxtBxUsrCntrl.Height = this.Height - ((70 / 100) * this.Height);
            //rchTxtBxUsrCntrl.Top = (this.Height / 2) - (rchTxtBxUsrCntrl.Height / 2);
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
                        //salvar só
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
