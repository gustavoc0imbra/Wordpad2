using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Wordpad2
{
    class TabPageDefault : TabPage
    {
        private Panel pnlUsrCntrl;
        public UsrCntrlText usrCntrlTxt;

        public TabPageDefault(string name, string fileName, string fileContent, bool isNew) {
            this.pnlUsrCntrl = new Panel();
            this.usrCntrlTxt = new UsrCntrlText(fileName);

            this.pnlUsrCntrl.Name = "pnlUsrCntrlText";
            this.pnlUsrCntrl.AutoSize = true;
            this.usrCntrlTxt.Dock = DockStyle.Fill;
            this.usrCntrlTxt.isNew = isNew;
            this.usrCntrlTxt.isChanged = false;
            this.pnlUsrCntrl.Dock = DockStyle.Fill;
            this.pnlUsrCntrl.Controls.Add(this.usrCntrlTxt);
            this.Controls.Add(pnlUsrCntrl);

            this.Name = name;
            this.Text = fileName;
            this.Visible = true;
        }
    }
}
