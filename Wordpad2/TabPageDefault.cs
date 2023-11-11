using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordpad2
{
    class TabPageDefault : TabPage
    {
        public RichTextBox RchTxtBxTbPage;
        public GroupBox GrpBx;
        public ComboBox CmbBxFont;
        public MenuStrip MenuStrip;

        public TabPageDefault(string name, string tabName, int tbMainWidth, int tbMainHeight) {
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Name = name;
            this.Text = tabName;

            this.GrpBx = new GroupBox();
            this.CmbBxFont = new ComboBox();
            this.RchTxtBxTbPage = new RichTextBox();
            this.MenuStrip = new MenuStrip();

            this.MenuStrip.Items.Add("Close");

            this.CmbBxFont.Name = "cmbBxFont";
            this.CmbBxFont.Width = 50;
            this.CmbBxFont.Left = 10;
            this.CmbBxFont.Top = 30;
            this.CmbBxFont.Width = 120;
            this.GrpBx.Controls.Add(this.CmbBxFont);

            GrpBx.Name = "grpBxTbPage";
            GrpBx.Dock = DockStyle.Top;
            GrpBx.Text = "Tools";
            GrpBx.BackColor = System.Drawing.SystemColors.Control;
            GrpBx.Visible = true;
            this.Controls.Add(GrpBx);
            
            
            this.RchTxtBxTbPage.Name = "rchTxtBxTbPage";
            this.RchTxtBxTbPage.Visible = true;
            this.RchTxtBxTbPage.Width = 595;
            this.RchTxtBxTbPage.Height = 892;
            this.RchTxtBxTbPage.Top = (tbMainHeight - this.GrpBx.Height) / 3;
            this.RchTxtBxTbPage.Left = (tbMainWidth / 2) - this.RchTxtBxTbPage.Width / 2;
            this.RchTxtBxTbPage.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(RchTxtBxTbPage);
        }

        public void CmbBxFont_MouseClick(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            FontFamily[] fontFamilies;

            fontFamilies = installedFontCollection.Families;

            foreach (var font in fontFamilies)
            {
                this.CmbBxFont.Items.Add(font.Name);
            }
        }
    }
}
