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
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = opnFlDlgArchive.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    var fileStream = new StreamReader(opnFlDlgArchive.FileName);

                    int index = opnFlDlgArchive.FileName.IndexOf(".");

                    string ext = opnFlDlgArchive.FileName.Substring(index,4).Replace('.', ' ').Trim();

                    switch(ext)
                    {
                        case "jpg":
                        case "png":
                            Form2 newImg = new Form2();
                            newImg.MdiParent = this;
                            newImg.Show();
                            //pctrBxTeste.ImageLocation = opnFlDlgArchive.FileName;
                            newImg.pctrBxImgForm2.ImageLocation = opnFlDlgArchive.FileName;
                            break;
                        case "docx":
                        case "doc":
                        case "txt":
                            rchTxtBxWords.Text = fileStream.ReadToEnd();
                            break;
                        default:
                            MessageBox.Show($"Extensão não suportada!!!\nExtensão selecionada: .{ext}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                }catch(Exception exc)
                {
                    MessageBox.Show($"Ocorreu um erro ao abrir o arquivo!!! Erro {exc.Message}", "Erro ao abrir arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = svFlDlgArchive.ShowDialog();
        }

        private void cmbBxFonts_Click(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            string fontsList = "";

            FontFamily fontFamily = new FontFamily("Arial");

            FontFamily[] fontFamilies;

            fontFamilies = installedFontCollection.Families;

            foreach (var font in fontFamilies)
            {
                cmbBxFonts.Items.Add(font.Name);
            }

            //this.test.Items.Add(cmbBxFonts.Items);
        }

        private void cmbBxFonts_TextChanged(object sender, EventArgs e)
        {
           // var fontsList = cmbBxFonts.Text;

            //MessageBox.Show($"{this.test.Items.Contains(fontsList)}");

        }

        private void cmbBxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
