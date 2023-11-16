namespace Wordpad2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            opnFlDlgArchive = new System.Windows.Forms.OpenFileDialog();
            svFlDlgArchive = new System.Windows.Forms.SaveFileDialog();
            mnStrpTop = new System.Windows.Forms.MenuStrip();
            flTlStrpMnItmMain = new System.Windows.Forms.ToolStripMenuItem();
            opnTlStrpMnItmTop = new System.Windows.Forms.ToolStripMenuItem();
            svTlStrpMnItmTop = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            printTlStrpMnItmTop = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            qtTlStrpMnItmTop = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoTlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            copyStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            pasteStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            slctAllStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            atmtcBrkLnStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tbCntrlMain = new System.Windows.Forms.TabControl();
            clrDlgFont = new System.Windows.Forms.ColorDialog();
            mnStrpTop.SuspendLayout();
            SuspendLayout();
            // 
            // opnFlDlgArchive
            // 
            opnFlDlgArchive.Title = "Abrir arquivo";
            // 
            // svFlDlgArchive
            // 
            svFlDlgArchive.AddExtension = false;
            svFlDlgArchive.Filter = "Documento de Texto (*.rtf)|Arquivo de Texto(*.txt)";
            svFlDlgArchive.Title = "Salvar arquivo";
            // 
            // mnStrpTop
            // 
            mnStrpTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { flTlStrpMnItmMain, editarToolStripMenuItem, formatToolStripMenuItem, zoomToolStripMenuItem });
            mnStrpTop.Location = new System.Drawing.Point(0, 0);
            mnStrpTop.Name = "mnStrpTop";
            mnStrpTop.Size = new System.Drawing.Size(800, 24);
            mnStrpTop.TabIndex = 10;
            mnStrpTop.Text = "Menu";
            // 
            // flTlStrpMnItmMain
            // 
            flTlStrpMnItmMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { opnTlStrpMnItmTop, svTlStrpMnItmTop, toolStripMenuItem1, toolStripSeparator1, printTlStrpMnItmTop, toolStripSeparator2, qtTlStrpMnItmTop });
            flTlStrpMnItmMain.Name = "flTlStrpMnItmMain";
            flTlStrpMnItmMain.Size = new System.Drawing.Size(37, 20);
            flTlStrpMnItmMain.Text = "File";
            // 
            // opnTlStrpMnItmTop
            // 
            opnTlStrpMnItmTop.Name = "opnTlStrpMnItmTop";
            opnTlStrpMnItmTop.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            opnTlStrpMnItmTop.Size = new System.Drawing.Size(186, 22);
            opnTlStrpMnItmTop.Text = "Open";
            opnTlStrpMnItmTop.Click += openToolStripMenuItem_Click;
            // 
            // svTlStrpMnItmTop
            // 
            svTlStrpMnItmTop.Name = "svTlStrpMnItmTop";
            svTlStrpMnItmTop.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            svTlStrpMnItmTop.Size = new System.Drawing.Size(186, 22);
            svTlStrpMnItmTop.Text = "Save";
            svTlStrpMnItmTop.Click += svTlStrpMnItmTop_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            toolStripMenuItem1.Text = "Save As";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // printTlStrpMnItmTop
            // 
            printTlStrpMnItmTop.Name = "printTlStrpMnItmTop";
            printTlStrpMnItmTop.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.P;
            printTlStrpMnItmTop.Size = new System.Drawing.Size(186, 22);
            printTlStrpMnItmTop.Text = "Print";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // qtTlStrpMnItmTop
            // 
            qtTlStrpMnItmTop.Name = "qtTlStrpMnItmTop";
            qtTlStrpMnItmTop.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
            qtTlStrpMnItmTop.Size = new System.Drawing.Size(186, 22);
            qtTlStrpMnItmTop.Text = "Quit";
            qtTlStrpMnItmTop.Click += qtTlStrpMnItmTop_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoTlStrpMnItm, redoToolStripMenuItem, toolStripSeparator3, copyStrpMnItm, pasteStrpMnItm, slctAllStrpMnItm });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editarToolStripMenuItem.Text = "Edit";
            // 
            // undoTlStrpMnItm
            // 
            undoTlStrpMnItm.Name = "undoTlStrpMnItm";
            undoTlStrpMnItm.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            undoTlStrpMnItm.Size = new System.Drawing.Size(200, 22);
            undoTlStrpMnItm.Text = "Desfazer";
            undoTlStrpMnItm.Click += undoTlStrpMnItm_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // copyStrpMnItm
            // 
            copyStrpMnItm.Name = "copyStrpMnItm";
            copyStrpMnItm.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyStrpMnItm.Size = new System.Drawing.Size(200, 22);
            copyStrpMnItm.Text = "Copiar";
            copyStrpMnItm.Click += copyStrpMnItm_Click;
            // 
            // pasteStrpMnItm
            // 
            pasteStrpMnItm.Name = "pasteStrpMnItm";
            pasteStrpMnItm.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteStrpMnItm.Size = new System.Drawing.Size(200, 22);
            pasteStrpMnItm.Text = "Colar";
            pasteStrpMnItm.Click += pasteStrpMnItm_Click;
            // 
            // slctAllStrpMnItm
            // 
            slctAllStrpMnItm.Name = "slctAllStrpMnItm";
            slctAllStrpMnItm.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            slctAllStrpMnItm.Size = new System.Drawing.Size(200, 22);
            slctAllStrpMnItm.Text = "Selecionar Tudo";
            slctAllStrpMnItm.Click += slctAllStrpMnItm_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { atmtcBrkLnStrpMnItm });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // atmtcBrkLnStrpMnItm
            // 
            atmtcBrkLnStrpMnItm.CheckOnClick = true;
            atmtcBrkLnStrpMnItm.Name = "atmtcBrkLnStrpMnItm";
            atmtcBrkLnStrpMnItm.Size = new System.Drawing.Size(221, 22);
            atmtcBrkLnStrpMnItm.Text = "Quebra de linha automática";
            atmtcBrkLnStrpMnItm.Click += atmtcBrkLnStrpMnItm_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Addition Key";
            zoomInToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus;
            zoomInToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Minus Key";
            zoomOutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus;
            zoomOutToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // tbCntrlMain
            // 
            tbCntrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tbCntrlMain.Location = new System.Drawing.Point(0, 24);
            tbCntrlMain.Name = "tbCntrlMain";
            tbCntrlMain.SelectedIndex = 0;
            tbCntrlMain.Size = new System.Drawing.Size(800, 538);
            tbCntrlMain.TabIndex = 12;
            tbCntrlMain.Visible = false;
            // 
            // Form1
            // 
            AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(tbCntrlMain);
            Controls.Add(mnStrpTop);
            IsMdiContainer = true;
            KeyPreview = true;
            MainMenuStrip = mnStrpTop;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Wordpad2";
            FormClosing += Form1_FormClosing;
            mnStrpTop.ResumeLayout(false);
            mnStrpTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opnFlDlgArchive;
        private System.Windows.Forms.SaveFileDialog svFlDlgArchive;
        private System.Windows.Forms.MenuStrip mnStrpTop;
        private System.Windows.Forms.ToolStripMenuItem flTlStrpMnItmMain;
        private System.Windows.Forms.ToolStripMenuItem opnTlStrpMnItmTop;
        private System.Windows.Forms.ToolStripMenuItem svTlStrpMnItmTop;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printTlStrpMnItmTop;
        private System.Windows.Forms.ToolStripMenuItem qtTlStrpMnItmTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem undoTlStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog clrDlgFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem pasteStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem slctAllStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem atmtcBrkLnStrpMnItm;
        private System.Windows.Forms.TabControl tbCntrlMain;
    }
}
