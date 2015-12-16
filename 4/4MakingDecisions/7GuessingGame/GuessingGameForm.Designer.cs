namespace _7GuessingGame
{
    partial class GuessingGameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTxtBx = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.randomNumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess a number between 1 and 10:";
            // 
            // inputTxtBx
            // 
            this.inputTxtBx.Location = new System.Drawing.Point(196, 28);
            this.inputTxtBx.Name = "inputTxtBx";
            this.inputTxtBx.Size = new System.Drawing.Size(100, 20);
            this.inputTxtBx.TabIndex = 1;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(63, 68);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Submit";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(13, 132);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 3;
            // 
            // randomNumLbl
            // 
            this.randomNumLbl.AutoSize = true;
            this.randomNumLbl.Location = new System.Drawing.Point(71, 125);
            this.randomNumLbl.Name = "randomNumLbl";
            this.randomNumLbl.Size = new System.Drawing.Size(0, 13);
            this.randomNumLbl.TabIndex = 4;
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 262);
            this.Controls.Add(this.randomNumLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.inputTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "GuessingGameForm";
            this.Text = "4:7 Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTxtBx;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label randomNumLbl;
    }
}

