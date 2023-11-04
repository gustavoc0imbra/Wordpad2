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
            this.rchTxtBxWords = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.opnFlDlgArchive = new System.Windows.Forms.OpenFileDialog();
            this.svFlDlgArchive = new System.Windows.Forms.SaveFileDialog();
            this.cmbBxFonts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBxSize = new System.Windows.Forms.ComboBox();
            this.pctrBxTeste = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // rchTxtBxWords
            // 
            this.rchTxtBxWords.Location = new System.Drawing.Point(1, 41);
            this.rchTxtBxWords.Name = "rchTxtBxWords";
            this.rchTxtBxWords.Size = new System.Drawing.Size(798, 186);
            this.rchTxtBxWords.TabIndex = 0;
            this.rchTxtBxWords.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(114, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // opnFlDlgArchive
            // 
            this.opnFlDlgArchive.Title = "Abrir arquivo";
            // 
            // svFlDlgArchive
            // 
            this.svFlDlgArchive.AddExtension = false;
            this.svFlDlgArchive.Title = "Salvar arquivo";
            // 
            // cmbBxFonts
            // 
            this.cmbBxFonts.FormattingEnabled = true;
            this.cmbBxFonts.Location = new System.Drawing.Point(346, 10);
            this.cmbBxFonts.Name = "cmbBxFonts";
            this.cmbBxFonts.Size = new System.Drawing.Size(121, 23);
            this.cmbBxFonts.TabIndex = 3;
            this.cmbBxFonts.TextChanged += new System.EventHandler(this.cmbBxFonts_TextChanged);
            this.cmbBxFonts.Click += new System.EventHandler(this.cmbBxFonts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fonte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tam.:";
            // 
            // cmbBxSize
            // 
            this.cmbBxSize.DisplayMember = "12";
            this.cmbBxSize.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBxSize.FormattingEnabled = true;
            this.cmbBxSize.Location = new System.Drawing.Point(528, 10);
            this.cmbBxSize.Name = "cmbBxSize";
            this.cmbBxSize.Size = new System.Drawing.Size(31, 24);
            this.cmbBxSize.TabIndex = 6;
            this.cmbBxSize.ValueMember = "12";
            this.cmbBxSize.SelectedIndexChanged += new System.EventHandler(this.cmbBxSize_SelectedIndexChanged);
            // 
            // pctrBxTeste
            // 
            this.pctrBxTeste.Location = new System.Drawing.Point(192, 233);
            this.pctrBxTeste.Name = "pctrBxTeste";
            this.pctrBxTeste.Size = new System.Drawing.Size(429, 205);
            this.pctrBxTeste.TabIndex = 8;
            this.pctrBxTeste.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctrBxTeste);
            this.Controls.Add(this.cmbBxSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxFonts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.rchTxtBxWords);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Wordpad2";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBxWords;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog opnFlDlgArchive;
        private System.Windows.Forms.SaveFileDialog svFlDlgArchive;
        private System.Windows.Forms.ComboBox cmbBxFonts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBxSize;
        private System.Windows.Forms.PictureBox pctrBxTeste;
    }
}
