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
            this.addTab("Document 1", "");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openArch();
        }

        private void addTab(string fileName, string fileContent)
        {
            int counter = tbCntrlMain.TabPages.Count;
            string newTbPageName = (counter++).ToString();
            TabPageDefault newTbPage = new TabPageDefault($"tbPage{newTbPageName}", fileName, tbCntrlMain.Width, tbCntrlMain.Height);
            tbCntrlMain.TabPages.Add(newTbPage);
            tbCntrlMain.SelectTab(newTbPage);
            newTbPage.RchTxtBxTbPage.Text = fileContent;
        }

        private void openArch()
        {
            if (opnFlDlgArchive.ShowDialog() == DialogResult.OK)
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
                            Form2 newImg = new Form2();
                            newImg.MdiParent = this;
                            newImg.Show();
                            newImg.BringToFront();
                            //pctrBxTeste.ImageLocation = opnFlDlgArchive.FileName;
                            newImg.pctrBxImgForm2.ImageLocation = opnFlDlgArchive.FileName;
                            break;
                        case "docx":
                        case "doc":
                        case "txt":
                        case "rtf":
                            this.addTab(opnFlDlgArchive.FileName, fileStream.ReadToEnd());
                            break;
                        default:
                            MessageBox.Show($"Extensão não suportada!!!\nExtensão selecionada: .{ext}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (Exception exc) //se dar algum erro para e cai aqui
                {
                    MessageBox.Show($"Ocorreu um erro ao abrir o arquivo!!! Erro {exc.Message}", "Erro ao abrir arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveArch(String archive)
        {
            if (archive != "")
            {
                StreamWriter buffer = new StreamWriter(archive);

                //buffer.Write(rchTxtBxTab.Rtf);
                buffer.Close();
                //tbPg1.Text = archive;
            }
            else
            {
                MessageBox.Show("Nome de arquivo errado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAs()
        {
            if (svFlDlgArchive.ShowDialog() == DialogResult.OK)
            {
                this.saveArch(svFlDlgArchive.FileName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveAs();
        }

        private void svTlStrpMnItmTop_Click(object sender, EventArgs e)
        {
            //this.saveArch(rchTxtBxTab.Rtf);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (TabPage tbPage in tbCntrlMain.TabPages)
            {
                foreach (var item in tbPage.Controls)
                {
                    if (item == typeof(RichTextBox))
                    {
                        RichTextBox temp = (RichTextBox)item;
                        temp.Left = (tbPage.Width / 2) - temp.Width / 2;
                        temp.Top = (tbPage.Height / 2);
                    }
                }

            }
        }
    }
}
