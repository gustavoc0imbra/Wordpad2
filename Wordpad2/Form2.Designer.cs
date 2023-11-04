namespace Wordpad2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctrBxImgForm2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxImgForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBxImgForm2
            // 
            this.pctrBxImgForm2.Location = new System.Drawing.Point(12, 12);
            this.pctrBxImgForm2.Name = "pctrBxImgForm2";
            this.pctrBxImgForm2.Size = new System.Drawing.Size(776, 426);
            this.pctrBxImgForm2.TabIndex = 0;
            this.pctrBxImgForm2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctrBxImgForm2);
            this.Name = "Form2";
            this.Text = "Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxImgForm2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pctrBxImgForm2;
    }
}