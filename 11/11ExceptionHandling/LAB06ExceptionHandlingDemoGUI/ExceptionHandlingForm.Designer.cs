namespace LAB06ExceptionHandlingDemoGUI
{
    partial class ExceptionHandlingForm
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
            this.userInputTxtBx = new System.Windows.Forms.TextBox();
            this.calcResultBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer:";
            // 
            // userInputTxtBx
            // 
            this.userInputTxtBx.Location = new System.Drawing.Point(130, 22);
            this.userInputTxtBx.Name = "userInputTxtBx";
            this.userInputTxtBx.Size = new System.Drawing.Size(100, 20);
            this.userInputTxtBx.TabIndex = 1;
            this.userInputTxtBx.TextChanged += new System.EventHandler(this.userInputTxtBx_TextChanged);
            // 
            // calcResultBtn
            // 
            this.calcResultBtn.Location = new System.Drawing.Point(130, 72);
            this.calcResultBtn.Name = "calcResultBtn";
            this.calcResultBtn.Size = new System.Drawing.Size(75, 23);
            this.calcResultBtn.TabIndex = 2;
            this.calcResultBtn.Text = "SUBMIT";
            this.calcResultBtn.UseVisualStyleBackColor = true;
            this.calcResultBtn.Click += new System.EventHandler(this.calcResultBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(13, 113);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 3;
            // 
            // ExceptionHandlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calcResultBtn);
            this.Controls.Add(this.userInputTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "ExceptionHandlingForm";
            this.Text = "LAB06 Exception Handling Demo GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInputTxtBx;
        private System.Windows.Forms.Button calcResultBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

