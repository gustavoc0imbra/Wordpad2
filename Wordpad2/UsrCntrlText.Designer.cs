namespace Wordpad2
{
    partial class UsrCntrlText
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
            grpBxTools = new System.Windows.Forms.GroupBox();
            btnCloseTab = new System.Windows.Forms.Button();
            btnOpnImg = new System.Windows.Forms.Button();
            btnChngFontDlg = new System.Windows.Forms.Button();
            rchTxtBxUsrCntrl = new System.Windows.Forms.RichTextBox();
            fntDlgUsrCntrlText = new System.Windows.Forms.FontDialog();
            opnFlDlgImg = new System.Windows.Forms.OpenFileDialog();
            grpBxTools.SuspendLayout();
            SuspendLayout();
            // 
            // grpBxTools
            // 
            grpBxTools.BackColor = System.Drawing.SystemColors.MenuBar;
            grpBxTools.Controls.Add(btnCloseTab);
            grpBxTools.Controls.Add(btnOpnImg);
            grpBxTools.Controls.Add(btnChngFontDlg);
            grpBxTools.Dock = System.Windows.Forms.DockStyle.Top;
            grpBxTools.Location = new System.Drawing.Point(0, 0);
            grpBxTools.Name = "grpBxTools";
            grpBxTools.Size = new System.Drawing.Size(681, 100);
            grpBxTools.TabIndex = 0;
            grpBxTools.TabStop = false;
            grpBxTools.Text = "Ferramentas";
            // 
            // btnCloseTab
            // 
            btnCloseTab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCloseTab.Location = new System.Drawing.Point(591, 22);
            btnCloseTab.Name = "btnCloseTab";
            btnCloseTab.Size = new System.Drawing.Size(76, 41);
            btnCloseTab.TabIndex = 2;
            btnCloseTab.Text = "Fechar";
            btnCloseTab.UseVisualStyleBackColor = true;
            btnCloseTab.Click += btnCloseTab_Click;
            // 
            // btnOpnImg
            // 
            btnOpnImg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOpnImg.Location = new System.Drawing.Point(494, 22);
            btnOpnImg.Name = "btnOpnImg";
            btnOpnImg.Size = new System.Drawing.Size(91, 41);
            btnOpnImg.TabIndex = 1;
            btnOpnImg.Text = "Imagem";
            btnOpnImg.UseVisualStyleBackColor = true;
            btnOpnImg.Click += btnOpnImg_Click;
            // 
            // btnChngFontDlg
            // 
            btnChngFontDlg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnChngFontDlg.Location = new System.Drawing.Point(15, 22);
            btnChngFontDlg.Name = "btnChngFontDlg";
            btnChngFontDlg.Size = new System.Drawing.Size(170, 41);
            btnChngFontDlg.TabIndex = 0;
            btnChngFontDlg.Text = "Fonte";
            btnChngFontDlg.UseVisualStyleBackColor = true;
            btnChngFontDlg.Click += btnChngFontDlg_Click;
            // 
            // rchTxtBxUsrCntrl
            // 
            rchTxtBxUsrCntrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rchTxtBxUsrCntrl.Location = new System.Drawing.Point(15, 124);
            rchTxtBxUsrCntrl.Name = "rchTxtBxUsrCntrl";
            rchTxtBxUsrCntrl.ShowSelectionMargin = true;
            rchTxtBxUsrCntrl.Size = new System.Drawing.Size(652, 350);
            rchTxtBxUsrCntrl.TabIndex = 1;
            rchTxtBxUsrCntrl.Text = "";
            rchTxtBxUsrCntrl.TextChanged += rchTxtBxUsrCntrl_TextChanged;
            // 
            // fntDlgUsrCntrlText
            // 
            fntDlgUsrCntrlText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fntDlgUsrCntrlText.FontMustExist = true;
            fntDlgUsrCntrlText.ShowColor = true;
            fntDlgUsrCntrlText.ShowHelp = true;
            // 
            // UsrCntrlText
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            Controls.Add(rchTxtBxUsrCntrl);
            Controls.Add(grpBxTools);
            Name = "UsrCntrlText";
            Size = new System.Drawing.Size(681, 477);
            SizeChanged += UsrCntrlText_SizeChanged;
            grpBxTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxTools;
        public System.Windows.Forms.RichTextBox rchTxtBxUsrCntrl;
        private System.Windows.Forms.FontDialog fntDlgUsrCntrlText;
        private System.Windows.Forms.Button btnChngFontDlg;
        private System.Windows.Forms.Button btnOpnImg;
        private System.Windows.Forms.OpenFileDialog opnFlDlgImg;
        private System.Windows.Forms.Button btnCloseTab;
    }
}
