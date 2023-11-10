using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordpad2
{
    class TabPageDefault : TabPage
    {
        public RichTextBox RchTxtBxTbPage;
        public TabPageDefault(string name, string tabName, int tbMainWidth, int tbMainHeight) {
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Name = name;
            this.Text = tabName;
            GroupBox grpBox = new GroupBox();
            grpBox.Name = "grpBxTbPage";
            grpBox.Dock = DockStyle.Top;
            grpBox.Text = "Tools";
            grpBox.BackColor = System.Drawing.SystemColors.Control;
            grpBox.Visible = true;
            this.Controls.Add(grpBox);
            
            this.RchTxtBxTbPage = new RichTextBox();
            this.RchTxtBxTbPage.Name = "rchTxtBxTbPage";
            this.RchTxtBxTbPage.Visible = true;
            this.RchTxtBxTbPage.Width = 595;
            this.RchTxtBxTbPage.Height = 892;
            this.RchTxtBxTbPage.Top = (tbMainHeight - grpBox.Height) / 3;
            this.RchTxtBxTbPage.Left = (tbMainWidth / 2) - this.RchTxtBxTbPage.Width / 2;
            this.RchTxtBxTbPage.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(RchTxtBxTbPage);
        }
    }
}
