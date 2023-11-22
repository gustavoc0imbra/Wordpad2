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
            this.opnFlDlgArchive = new System.Windows.Forms.OpenFileDialog();
            this.svFlDlgArchive = new System.Windows.Forms.SaveFileDialog();
            this.mnStrpTop = new System.Windows.Forms.MenuStrip();
            this.filelTlStrpMnItmMain = new System.Windows.Forms.ToolStripMenuItem();
            this.newTlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.opnTlStrpMnItmTop = new System.Windows.Forms.ToolStripMenuItem();
            this.svTlStrpMnItmTop = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAstlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.qtTlStrpMnItmTop = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoTlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.slctAllStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atmtcBrkLnStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZoomTlStrpMnItm = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCntrlMain = new System.Windows.Forms.TabControl();
            this.mnStrpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // opnFlDlgArchive
            // 
            this.opnFlDlgArchive.Filter = "Documento de Texto (*.rtf)|*.rtf|Arquivo de Texto (*.txt)|*.txt";
            this.opnFlDlgArchive.Title = "Abrir arquivo";
            // 
            // svFlDlgArchive
            // 
            this.svFlDlgArchive.AddExtension = false;
            this.svFlDlgArchive.Filter = "Documento de Texto (*.rtf)|*.rtf|Arquivo de Texto (*.txt)|*.txt";
            this.svFlDlgArchive.Title = "Salvar arquivo";
            // 
            // mnStrpTop
            // 
            this.mnStrpTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filelTlStrpMnItmMain,
            this.editarToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.mnStrpTop.Location = new System.Drawing.Point(0, 0);
            this.mnStrpTop.Name = "mnStrpTop";
            this.mnStrpTop.Size = new System.Drawing.Size(800, 24);
            this.mnStrpTop.TabIndex = 10;
            this.mnStrpTop.Text = "Menu";
            // 
            // filelTlStrpMnItmMain
            // 
            this.filelTlStrpMnItmMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTlStrpMnItm,
            this.toolStripSeparator4,
            this.opnTlStrpMnItmTop,
            this.svTlStrpMnItmTop,
            this.saveAstlStrpMnItm,
            this.toolStripSeparator1,
            this.qtTlStrpMnItmTop});
            this.filelTlStrpMnItmMain.Name = "filelTlStrpMnItmMain";
            this.filelTlStrpMnItmMain.Size = new System.Drawing.Size(61, 20);
            this.filelTlStrpMnItmMain.Text = "Arquivo";
            // 
            // newTlStrpMnItm
            // 
            this.newTlStrpMnItm.Name = "newTlStrpMnItm";
            this.newTlStrpMnItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTlStrpMnItm.Size = new System.Drawing.Size(213, 22);
            this.newTlStrpMnItm.Text = "Novo";
            this.newTlStrpMnItm.Click += new System.EventHandler(this.newTlStrpMnItm_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
            // 
            // opnTlStrpMnItmTop
            // 
            this.opnTlStrpMnItmTop.Name = "opnTlStrpMnItmTop";
            this.opnTlStrpMnItmTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opnTlStrpMnItmTop.Size = new System.Drawing.Size(213, 22);
            this.opnTlStrpMnItmTop.Text = "Abrir";
            this.opnTlStrpMnItmTop.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // svTlStrpMnItmTop
            // 
            this.svTlStrpMnItmTop.Name = "svTlStrpMnItmTop";
            this.svTlStrpMnItmTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.svTlStrpMnItmTop.Size = new System.Drawing.Size(213, 22);
            this.svTlStrpMnItmTop.Text = "Salvar";
            this.svTlStrpMnItmTop.Click += new System.EventHandler(this.svTlStrpMnItmTop_Click);
            // 
            // saveAstlStrpMnItm
            // 
            this.saveAstlStrpMnItm.Name = "saveAstlStrpMnItm";
            this.saveAstlStrpMnItm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAstlStrpMnItm.Size = new System.Drawing.Size(213, 22);
            this.saveAstlStrpMnItm.Text = "Salvar Como";
            this.saveAstlStrpMnItm.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // qtTlStrpMnItmTop
            // 
            this.qtTlStrpMnItmTop.Name = "qtTlStrpMnItmTop";
            this.qtTlStrpMnItmTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.qtTlStrpMnItmTop.Size = new System.Drawing.Size(213, 22);
            this.qtTlStrpMnItmTop.Text = "Sair";
            this.qtTlStrpMnItmTop.Click += new System.EventHandler(this.qtTlStrpMnItmTop_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoTlStrpMnItm,
            this.toolStripSeparator3,
            this.copyStrpMnItm,
            this.pasteStrpMnItm,
            this.slctAllStrpMnItm});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // undoTlStrpMnItm
            // 
            this.undoTlStrpMnItm.Name = "undoTlStrpMnItm";
            this.undoTlStrpMnItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoTlStrpMnItm.Size = new System.Drawing.Size(200, 22);
            this.undoTlStrpMnItm.Text = "Desfazer";
            this.undoTlStrpMnItm.Click += new System.EventHandler(this.undoTlStrpMnItm_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // copyStrpMnItm
            // 
            this.copyStrpMnItm.Name = "copyStrpMnItm";
            this.copyStrpMnItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyStrpMnItm.Size = new System.Drawing.Size(200, 22);
            this.copyStrpMnItm.Text = "Copiar";
            this.copyStrpMnItm.Click += new System.EventHandler(this.copyStrpMnItm_Click);
            // 
            // pasteStrpMnItm
            // 
            this.pasteStrpMnItm.Name = "pasteStrpMnItm";
            this.pasteStrpMnItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteStrpMnItm.Size = new System.Drawing.Size(200, 22);
            this.pasteStrpMnItm.Text = "Colar";
            this.pasteStrpMnItm.Click += new System.EventHandler(this.pasteStrpMnItm_Click);
            // 
            // slctAllStrpMnItm
            // 
            this.slctAllStrpMnItm.Name = "slctAllStrpMnItm";
            this.slctAllStrpMnItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.slctAllStrpMnItm.Size = new System.Drawing.Size(200, 22);
            this.slctAllStrpMnItm.Text = "Selecionar Tudo";
            this.slctAllStrpMnItm.Click += new System.EventHandler(this.slctAllStrpMnItm_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atmtcBrkLnStrpMnItm});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatToolStripMenuItem.Text = "Formatar";
            // 
            // atmtcBrkLnStrpMnItm
            // 
            this.atmtcBrkLnStrpMnItm.CheckOnClick = true;
            this.atmtcBrkLnStrpMnItm.Name = "atmtcBrkLnStrpMnItm";
            this.atmtcBrkLnStrpMnItm.Size = new System.Drawing.Size(221, 22);
            this.atmtcBrkLnStrpMnItm.Text = "Quebra de linha automática";
            this.atmtcBrkLnStrpMnItm.Click += new System.EventHandler(this.atmtcBrkLnStrpMnItm_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.resetZoomTlStrpMnItm});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Sinal de Adição";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.zoomInToolStripMenuItem.Text = "Aumentar Zoom";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Sinal de Subtração";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.zoomOutToolStripMenuItem.Text = "Diminuir Zoom";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // resetZoomTlStrpMnItm
            // 
            this.resetZoomTlStrpMnItm.Name = "resetZoomTlStrpMnItm";
            this.resetZoomTlStrpMnItm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetZoomTlStrpMnItm.Size = new System.Drawing.Size(292, 22);
            this.resetZoomTlStrpMnItm.Text = "Redefinir Zoom";
            this.resetZoomTlStrpMnItm.Click += new System.EventHandler(this.resetZoomTlStrpMnItm_Click);
            // 
            // tbCntrlMain
            // 
            this.tbCntrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCntrlMain.Location = new System.Drawing.Point(0, 24);
            this.tbCntrlMain.Name = "tbCntrlMain";
            this.tbCntrlMain.SelectedIndex = 0;
            this.tbCntrlMain.Size = new System.Drawing.Size(800, 538);
            this.tbCntrlMain.TabIndex = 12;
            this.tbCntrlMain.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.tbCntrlMain);
            this.Controls.Add(this.mnStrpTop);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnStrpTop;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordpad2";
            this.mnStrpTop.ResumeLayout(false);
            this.mnStrpTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opnFlDlgArchive;
        private System.Windows.Forms.SaveFileDialog svFlDlgArchive;
        private System.Windows.Forms.MenuStrip mnStrpTop;
        private System.Windows.Forms.ToolStripMenuItem filelTlStrpMnItmMain;
        private System.Windows.Forms.ToolStripMenuItem opnTlStrpMnItmTop;
        private System.Windows.Forms.ToolStripMenuItem svTlStrpMnItmTop;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem qtTlStrpMnItmTop;
        private System.Windows.Forms.ToolStripMenuItem saveAstlStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoTlStrpMnItm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem pasteStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem slctAllStrpMnItm;
        private System.Windows.Forms.ToolStripMenuItem atmtcBrkLnStrpMnItm;
        private System.Windows.Forms.TabControl tbCntrlMain;
        private System.Windows.Forms.ToolStripMenuItem newTlStrpMnItm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem resetZoomTlStrpMnItm;
    }
}
