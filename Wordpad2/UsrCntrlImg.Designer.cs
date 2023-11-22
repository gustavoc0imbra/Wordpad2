namespace Wordpad2
{
    partial class UsrCntrlImg
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBxImg = new System.Windows.Forms.GroupBox();
            this.btnCloseImg = new System.Windows.Forms.Button();
            this.pctrBxImg = new System.Windows.Forms.PictureBox();
            this.grpBxImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxImg
            // 
            this.grpBxImg.AutoSize = true;
            this.grpBxImg.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpBxImg.Controls.Add(this.btnCloseImg);
            this.grpBxImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxImg.Location = new System.Drawing.Point(0, 0);
            this.grpBxImg.Name = "grpBxImg";
            this.grpBxImg.Size = new System.Drawing.Size(575, 116);
            this.grpBxImg.TabIndex = 0;
            this.grpBxImg.TabStop = false;
            this.grpBxImg.Text = "Ferramentas";
            // 
            // btnCloseImg
            // 
            this.btnCloseImg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseImg.Location = new System.Drawing.Point(6, 22);
            this.btnCloseImg.Name = "btnCloseImg";
            this.btnCloseImg.Size = new System.Drawing.Size(132, 72);
            this.btnCloseImg.TabIndex = 0;
            this.btnCloseImg.Text = "Fechar";
            this.btnCloseImg.UseVisualStyleBackColor = true;
            this.btnCloseImg.Click += new System.EventHandler(this.btnCloseImg_Click);
            // 
            // pctrBxImg
            // 
            this.pctrBxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrBxImg.Location = new System.Drawing.Point(0, 116);
            this.pctrBxImg.Name = "pctrBxImg";
            this.pctrBxImg.Size = new System.Drawing.Size(575, 249);
            this.pctrBxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxImg.TabIndex = 1;
            this.pctrBxImg.TabStop = false;
            this.pctrBxImg.WaitOnLoad = true;
            // 
            // UsrCntrlImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pctrBxImg);
            this.Controls.Add(this.grpBxImg);
            this.Name = "UsrCntrlImg";
            this.Size = new System.Drawing.Size(575, 365);
            this.grpBxImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxImg;
        private System.Windows.Forms.Button btnCloseImg;
        private System.Windows.Forms.PictureBox pctrBxImg;
    }
}
