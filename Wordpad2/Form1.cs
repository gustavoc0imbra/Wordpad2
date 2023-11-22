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

        /* 
            NOMES: Gustavo Silva Coimbra R.A: 04722-013
                   Leonardo Fernando Zanardi R.A: 04722-022
                   Vinicius Inhesta Dos Santos R.A: 04722-071
         
         */

        public int zoom;
        public Form1()
        {
            InitializeComponent();
            tbCntrlMain.Parent = this;
            this.addTab("Document 1", "", "txt", true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openArch();
        }

        private void addTab(string fileName, string fileContent, string ext, bool isNew)
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

            if(ext == "rtf")
            {
                newTab.rchTxtBxUsrCntrl.Rtf = fileContent;
            }
            else
            {
                newTab.rchTxtBxUsrCntrl.Text = fileContent;
            }

            newTab.isChanged = false;
            newTab.hasAlrdyChngdTabText = false;
            newTbPage.Text = fileName;


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
                        string fileContent = fileStream.ReadToEnd();
                        fileStream.Close();

                        int index = opnFlDlgArchive.FileName.IndexOf(".");

                        string ext = opnFlDlgArchive.FileName.Substring(index, 4).Replace('.', ' ').Trim();

                        switch (ext)
                        {
                            case "png":
                            case "jpg":
                            case "jpeg":
                                MessageBox.Show("Para abrir uma imagem favor abrir ou criar um novo documento!", "Wordpad 2 informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                            case "docx":
                            case "doc":
                            case "txt":
                            case "rtf":
                                this.addTab(opnFlDlgArchive.FileName, fileContent, ext, false);
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

        public void saveArch(String archive)
        {
            MessageBox.Show(archive, "Teste");
            if (archive != "")
            {
                try
                {
                    StreamWriter buffer = new StreamWriter(archive);

                    UsrCntrlText selectedTabCmpnt = this.getTabComponents();

                    int index = archive.IndexOf('.');

                    if(archive.Substring(index).Replace(".","") == "rtf")
                    {
                        buffer.Write(selectedTabCmpnt.rchTxtBxUsrCntrl.Rtf);
                    }
                    else
                    {
                        buffer.Write(selectedTabCmpnt.rchTxtBxUsrCntrl.Text);
                    }

                    buffer.Close();

                    TabPage selectedTab = tbCntrlMain.SelectedTab;

                    selectedTab.Text = archive;
                    selectedTabCmpnt.hasAlrdyChngdTabText = false;
                    selectedTabCmpnt.isChanged = false;
                    selectedTabCmpnt.isNew = false;
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
                this.saveArch(svFlDlgArchive.FileName.Replace(")", ""));
                UsrCntrlText selectedTab = this.getTabComponents();
                selectedTab.fileName = svFlDlgArchive.FileName.Replace(")", "");
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
                this.saveArch(tabPage.Text.Replace(" *", ""));
            }

        }

        private void checkClose()
        {
            int cntrEditedNotSaved = 0;

            foreach (TabPage tab in this.tbCntrlMain.TabPages)
            {
                Panel panel = tab.Controls["pnlUsrCntrlText"] as Panel;

                UsrCntrlText windowComponents = panel.Controls["usrCntrlText"] as UsrCntrlText;

                if (windowComponents.isChanged == true)
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

            if (selectedTab.rchTxtBxUsrCntrl.SelectedText != "")
            {
                Clipboard.SetDataObject(selectedTab.rchTxtBxUsrCntrl.SelectedText);
            }

        }

        private void pasteStrpMnItm_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                UsrCntrlText selectedTab = this.getTabComponents();

                selectedTab.rchTxtBxUsrCntrl.Rtf = selectedTab.rchTxtBxUsrCntrl.Rtf + (string)Clipboard.GetData(DataFormats.Text);
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

        private void newTlStrpMnItm_Click(object sender, EventArgs e)
        {
            int amountTab = 0;
            amountTab = tbCntrlMain.TabCount;

            amountTab++;

            this.addTab($"Document {amountTab}", "", "txt", true);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsrCntrlText selectedTab = this.getTabComponents();

            this.zoom++;

            selectedTab.rchTxtBxUsrCntrl.Font = new Font(selectedTab.rchTxtBxUsrCntrl.Font.FontFamily, selectedTab.rchTxtBxUsrCntrl.Font.Size + 1, selectedTab.rchTxtBxUsrCntrl.Font.Style);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsrCntrlText selectedTab = this.getTabComponents();

            this.zoom--;

            selectedTab.rchTxtBxUsrCntrl.Font = new Font(selectedTab.rchTxtBxUsrCntrl.Font.FontFamily, selectedTab.rchTxtBxUsrCntrl.Font.Size - 1, selectedTab.rchTxtBxUsrCntrl.Font.Style);
        }

        private void resetZoomTlStrpMnItm_Click(object sender, EventArgs e)
        {
            this.zoom = 100;

            UsrCntrlText selectedTab = this.getTabComponents();

            selectedTab.rchTxtBxUsrCntrl.Font = new Font(selectedTab.rchTxtBxUsrCntrl.Font.FontFamily, 12, selectedTab.rchTxtBxUsrCntrl.Font.Style);
        }
    }
}
