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
            grpBxImg = new System.Windows.Forms.GroupBox();
            btnCloseImg = new System.Windows.Forms.Button();
            pctrBxImg = new System.Windows.Forms.PictureBox();
            grpBxImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrBxImg).BeginInit();
            SuspendLayout();
            // 
            // grpBxImg
            // 
            grpBxImg.AutoSize = true;
            grpBxImg.BackColor = System.Drawing.SystemColors.MenuBar;
            grpBxImg.Controls.Add(btnCloseImg);
            grpBxImg.Dock = System.Windows.Forms.DockStyle.Top;
            grpBxImg.Location = new System.Drawing.Point(0, 0);
            grpBxImg.Name = "grpBxImg";
            grpBxImg.Size = new System.Drawing.Size(713, 116);
            grpBxImg.TabIndex = 0;
            grpBxImg.TabStop = false;
            grpBxImg.Text = "Ferramentas";
            // 
            // btnCloseImg
            // 
            btnCloseImg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCloseImg.Location = new System.Drawing.Point(6, 22);
            btnCloseImg.Name = "btnCloseImg";
            btnCloseImg.Size = new System.Drawing.Size(132, 72);
            btnCloseImg.TabIndex = 0;
            btnCloseImg.Text = "Fechar";
            btnCloseImg.UseVisualStyleBackColor = true;
            btnCloseImg.Click += btnCloseImg_Click;
            // 
            // pctrBxImg
            // 
            pctrBxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            pctrBxImg.Location = new System.Drawing.Point(0, 116);
            pctrBxImg.Name = "pctrBxImg";
            pctrBxImg.Size = new System.Drawing.Size(713, 344);
            pctrBxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pctrBxImg.TabIndex = 1;
            pctrBxImg.TabStop = false;
            pctrBxImg.WaitOnLoad = true;
            // 
            // UsrCntrlImg
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(pctrBxImg);
            Controls.Add(grpBxImg);
            Name = "UsrCntrlImg";
            Size = new System.Drawing.Size(713, 460);
            grpBxImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctrBxImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxImg;
        private System.Windows.Forms.Button btnCloseImg;
        private System.Windows.Forms.PictureBox pctrBxImg;
    }
}
