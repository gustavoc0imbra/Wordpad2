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
            pctrBxImgForm2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctrBxImgForm2).BeginInit();
            SuspendLayout();
            // 
            // pctrBxImgForm2
            // 
            pctrBxImgForm2.Dock = System.Windows.Forms.DockStyle.Fill;
            pctrBxImgForm2.Location = new System.Drawing.Point(0, 0);
            pctrBxImgForm2.Name = "pctrBxImgForm2";
            pctrBxImgForm2.Size = new System.Drawing.Size(800, 450);
            pctrBxImgForm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pctrBxImgForm2.TabIndex = 0;
            pctrBxImgForm2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pctrBxImgForm2);
            Name = "Form2";
            Text = "Imagem";
            ((System.ComponentModel.ISupportInitialize)pctrBxImgForm2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.PictureBox pctrBxImgForm2;
    }
}