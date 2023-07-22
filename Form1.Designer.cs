namespace WordShuffle
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lblWc = new System.Windows.Forms.Label();
            this.lblWg = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lbTitle.Location = new System.Drawing.Point(125, 42);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(342, 55);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Guess The Word";
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.Indigo;
            this.lblWord.Location = new System.Drawing.Point(135, 186);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(318, 60);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "---------";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb1
            // 
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(135, 249);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(318, 29);
            this.tb1.TabIndex = 2;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPreessed);
            // 
            // lblWc
            // 
            this.lblWc.AutoSize = true;
            this.lblWc.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWc.ForeColor = System.Drawing.Color.Indigo;
            this.lblWc.Location = new System.Drawing.Point(217, 300);
            this.lblWc.Name = "lblWc";
            this.lblWc.Size = new System.Drawing.Size(149, 16);
            this.lblWc.TabIndex = 3;
            this.lblWc.Text = "word number:  0 / 0";
            this.lblWc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWg
            // 
            this.lblWg.AutoSize = true;
            this.lblWg.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWg.ForeColor = System.Drawing.Color.Indigo;
            this.lblWg.Location = new System.Drawing.Point(12, 444);
            this.lblWg.Name = "lblWg";
            this.lblWg.Size = new System.Drawing.Size(132, 16);
            this.lblWg.TabIndex = 4;
            this.lblWg.Text = "guessed: 0 time/s";
            this.lblWg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Indigo;
            this.lblInfo.Location = new System.Drawing.Point(118, 106);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(36, 16);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(595, 497);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWg);
            this.Controls.Add(this.lblWc);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Shuffle Game - Issa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lblWc;
        private System.Windows.Forms.Label lblWg;
        private System.Windows.Forms.Label lblInfo;
    }
}

