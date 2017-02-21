namespace Minesweeper
{
    partial class SlawekKowal
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
            this.txtBomb = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBomb
            // 
            this.txtBomb.Location = new System.Drawing.Point(91, 3);
            this.txtBomb.Name = "txtBomb";
            this.txtBomb.Size = new System.Drawing.Size(36, 20);
            this.txtBomb.TabIndex = 10;
            this.txtBomb.Text = "10";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(176, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(47, 20);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Pokaż";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(133, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(37, 19);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(47, 3);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(38, 20);
            this.txt2.TabIndex = 7;
            this.txt2.Text = "10";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(2, 3);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(39, 20);
            this.txt1.TabIndex = 6;
            this.txt1.Text = "10";
            // 
            // SlawekKowal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 430);
            this.Controls.Add(this.txtBomb);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "SlawekKowal";
            this.Text = "SlawekKowal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBomb;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
    }
}