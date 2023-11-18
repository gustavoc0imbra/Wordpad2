using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
 
namespace Wordpad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbCntrlMain.Parent = this;
            this.addTab("Document 1", "", true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openArch();
        }

        private void addTab(string fileName, string fileContent, bool isNew)
        {
            int counter = tbCntrlMain.TabPages.Count;
            string newTbPageName = (counter++).ToString();
            TabPageDefault newTbPage = new TabPageDefault($"tbPage{newTbPageName}", fileName, fileContent, isNew);
            tbCntrlMain.TabPages.Add(newTbPage);
            tbCntrlMain.SelectTab(newTbPage);

            if(counter >= 0)
            {
                tbCntrlMain.Visible = true;
            }

            UsrCntrlText newTab = this.getTabComponents();

            newTab.rchTxtBxUsrCntrl.Rtf = fileContent;
        }

        public UsrCntrlText getTabComponents()
        {
            TabPage selectedTab = tbCntrlMain.SelectedTab;

            Panel pnlText = selectedTab.Controls["pnlUsrCntrlText"] as Panel;

            UsrCntrlText usrCntrlText = pnlText.Controls["usrCntrlText"] as UsrCntrlText;

            return usrCntrlText;
        }

        private void openArch()
        {
            if (opnFlDlgArchive.ShowDialog() == DialogResult.OK)
            {
                if (this.checkFileAlreadyOpened(opnFlDlgArchive.FileName))
                {
                    try
                    {

                        var fileStream = new StreamReader(opnFlDlgArchive.FileName);

                        int index = opnFlDlgArchive.FileName.IndexOf(".");

                        string ext = opnFlDlgArchive.FileName.Substring(index, 4).Replace('.', ' ').Trim();

                        switch (ext)
                        {
                            case "jpg":
                            case "png":
                                //Form2 newImg = new Form2();
                                //newImg.MdiParent = this;
                                //newImg.Show();
                                //newImg.BringToFront();
                                //pctrBxTeste.ImageLocation = opnFlDlgArchive.FileName;
                                //newImg.pctrBxImgForm2.ImageLocation = opnFlDlgArchive.FileName;
                                break;
                            case "docx":
                            case "doc":
                            case "txt":
                            case "rtf":
                                this.addTab(opnFlDlgArchive.FileName, fileStream.ReadToEnd(), true);
                                break;
                            default:
                                MessageBox.Show($"Extensão não suportada!!!\nExtensão selecionada: .{ext}", "Wordpad 2 alerta:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    catch (Exception exc) //se dar algum erro para e cai aqui
                    {
                        MessageBox.Show($"Ocorreu um erro ao abrir o arquivo!!! Erro {exc.Message}", "Wordpad 2 erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo já aberto!", "Wordpad 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void saveArch(String archive)
        {
            if (archive != "")
            {
                try
                {
                    StreamWriter buffer = new StreamWriter(archive);

                    UsrCntrlText selectedTabCmpnt = this.getTabComponents();

                    buffer.Write(selectedTabCmpnt.rchTxtBxUsrCntrl.Rtf);

                    buffer.Close();

                    TabPage selectedTab = tbCntrlMain.SelectedTab;

                    selectedTab.Text = archive;
                    selectedTabCmpnt.hasAlrdyChngdTabText = false;
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar o arquivo!\nTente Novamente!{exc}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nome de arquivo errado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void saveAs()
        {
            if (svFlDlgArchive.ShowDialog() == DialogResult.OK)
            {
                this.saveArch(svFlDlgArchive.FileName);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveAs();
        }

        public void svTlStrpMnItmTop_Click(object sender, EventArgs e)
        {
            UsrCntrlText selectedTab = this.getTabComponents();

            if (selectedTab.isNew)
            {
                this.saveAs();
            }
            else
            {
                TabPage tabPage = tbCntrlMain.SelectedTab;
                this.saveArch(tabPage.Text);
            }

        }

        private void checkClose()
        {
            int cntrEditedNotSaved = 0;

            foreach (TabPage tab in this.tbCntrlMain.TabPages)
            {
                Panel panel = tab.Controls["pnlUsrCntrlText"] as Panel;

                UsrCntrlText windowComponents = panel.Controls["usrCntrlText"] as UsrCntrlText;

                if (windowComponents.isChanged)
                {
                    cntrEditedNotSaved++;
                }
            }

            if (cntrEditedNotSaved > 0)
            {
                DialogResult closeWindow = MessageBox.Show("Há arquivos abertos que não foram salvos!\nDeseja salvar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (closeWindow == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    //cancelar evento de fechar   
                }

            }
        }

        private bool checkFileAlreadyOpened(string fileName)
        {
            int counterFounded = 0;

            foreach (TabPage tab in this.tbCntrlMain.TabPages)
            {
                Panel panel = tab.Controls["pnlUsrCntrlText"] as Panel;

                UsrCntrlText windowComponents = panel.Controls["usrCntrlText"] as UsrCntrlText;

                if (windowComponents.fileName == fileName)
                {
                    counterFounded++;
                }
            }

            if (counterFounded > 0)
            {
                return false;
            }

            return true;
        }


        private void qtTlStrpMnItmTop_Click(object sender, EventArgs e)
        {
            this.checkClose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.checkClose();
        }

        private void undoTlStrpMnItm_Click(object sender, EventArgs e)
        {
            UsrCntrlText selectedTab = this.getTabComponents();

            if (selectedTab.rchTxtBxUsrCntrl.Rtf != "")
            {
                selectedTab.rchTxtBxUsrCntrl.Undo();
            }
        }

        private void copyStrpMnItm_Click(object sender, EventArgs e)
        {
            UsrCntrlText selectedTab = this.getTabComponents();

            if (selectedTab.rchTxtBxUsrCntrl.SelectedRtf != "")
            {
                Clipboard.SetDataObject(selectedTab.rchTxtBxUsrCntrl.SelectedRtf);
            }

        }

        private void pasteStrpMnItm_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                UsrCntrlText selectedTab = this.getTabComponents();

                selectedTab.rchTxtBxUsrCntrl.Text = selectedTab.rchTxtBxUsrCntrl.Text + (string)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void slctAllStrpMnItm_Click(object sender, EventArgs e)
        {
            UsrCntrlText selectedTab = this.getTabComponents();

            selectedTab.rchTxtBxUsrCntrl.SelectAll();
        }

        private void atmtcBrkLnStrpMnItm_Click(object sender, EventArgs e)
        {
            UsrCntrlText selectedTab = this.getTabComponents();

            if (atmtcBrkLnStrpMnItm.CheckState == CheckState.Checked)
            {
                atmtcBrkLnStrpMnItm.CheckState = CheckState.Unchecked;
                selectedTab.rchTxtBxUsrCntrl.WordWrap = false;
            }
            else
            {
                atmtcBrkLnStrpMnItm.CheckState = CheckState.Checked;
                selectedTab.rchTxtBxUsrCntrl.WordWrap = true;
            }
        }
    }
}
