﻿namespace _2ProjectedRaisesGUI
{
    partial class ProjectedRaisesForm
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
            this.empSalaryTxtBx = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter employee\'s salary:";
            // 
            // empSalaryTxtBx
            // 
            this.empSalaryTxtBx.Location = new System.Drawing.Point(175, 35);
            this.empSalaryTxtBx.Name = "empSalaryTxtBx";
            this.empSalaryTxtBx.Size = new System.Drawing.Size(100, 20);
            this.empSalaryTxtBx.TabIndex = 1;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(35, 128);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(35, 13);
            this.resultLbl.TabIndex = 2;
            this.resultLbl.Text = "label2";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(107, 91);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 3;
            this.calcBtn.Text = "Submit";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // ProjectedRaisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.empSalaryTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "ProjectedRaisesForm";
            this.Text = "2 Projected Raises Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empSalaryTxtBx;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button calcBtn;
    }
}

