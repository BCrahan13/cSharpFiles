namespace _6PayrollGUI
{
    partial class PayrollForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.ssnTxtBx = new System.Windows.Forms.TextBox();
            this.payRateTxtBx = new System.Windows.Forms.TextBox();
            this.hoursWorkedTxtBx = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SSN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly Pay Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours Worked:";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(144, 24);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBx.TabIndex = 4;
            // 
            // ssnTxtBx
            // 
            this.ssnTxtBx.Location = new System.Drawing.Point(144, 57);
            this.ssnTxtBx.Name = "ssnTxtBx";
            this.ssnTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ssnTxtBx.TabIndex = 5;
            // 
            // payRateTxtBx
            // 
            this.payRateTxtBx.Location = new System.Drawing.Point(144, 90);
            this.payRateTxtBx.Name = "payRateTxtBx";
            this.payRateTxtBx.Size = new System.Drawing.Size(100, 20);
            this.payRateTxtBx.TabIndex = 6;
            // 
            // hoursWorkedTxtBx
            // 
            this.hoursWorkedTxtBx.Location = new System.Drawing.Point(144, 126);
            this.hoursWorkedTxtBx.Name = "hoursWorkedTxtBx";
            this.hoursWorkedTxtBx.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedTxtBx.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(144, 164);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Submit";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(13, 199);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 9;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.hoursWorkedTxtBx);
            this.Controls.Add(this.payRateTxtBx);
            this.Controls.Add(this.ssnTxtBx);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PayrollForm";
            this.Text = "6 Payroll GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox ssnTxtBx;
        private System.Windows.Forms.TextBox payRateTxtBx;
        private System.Windows.Forms.TextBox hoursWorkedTxtBx;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

