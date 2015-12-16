namespace _5TestsInteractiveGUI
{
    partial class TestsInteractiveForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.test1TxtBx = new System.Windows.Forms.TextBox();
            this.test2TxtBx = new System.Windows.Forms.TextBox();
            this.test3TxtBx = new System.Windows.Forms.TextBox();
            this.test4TxtBx = new System.Windows.Forms.TextBox();
            this.test5TxtBx = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test 1 score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test 2 score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test 3 score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test 4 score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Test 5 score:";
            // 
            // test1TxtBx
            // 
            this.test1TxtBx.Location = new System.Drawing.Point(119, 13);
            this.test1TxtBx.Name = "test1TxtBx";
            this.test1TxtBx.Size = new System.Drawing.Size(100, 20);
            this.test1TxtBx.TabIndex = 5;
            // 
            // test2TxtBx
            // 
            this.test2TxtBx.Location = new System.Drawing.Point(119, 40);
            this.test2TxtBx.Name = "test2TxtBx";
            this.test2TxtBx.Size = new System.Drawing.Size(100, 20);
            this.test2TxtBx.TabIndex = 6;
            // 
            // test3TxtBx
            // 
            this.test3TxtBx.Location = new System.Drawing.Point(119, 70);
            this.test3TxtBx.Name = "test3TxtBx";
            this.test3TxtBx.Size = new System.Drawing.Size(100, 20);
            this.test3TxtBx.TabIndex = 7;
            // 
            // test4TxtBx
            // 
            this.test4TxtBx.Location = new System.Drawing.Point(119, 103);
            this.test4TxtBx.Name = "test4TxtBx";
            this.test4TxtBx.Size = new System.Drawing.Size(100, 20);
            this.test4TxtBx.TabIndex = 8;
            // 
            // test5TxtBx
            // 
            this.test5TxtBx.Location = new System.Drawing.Point(119, 133);
            this.test5TxtBx.Name = "test5TxtBx";
            this.test5TxtBx.Size = new System.Drawing.Size(100, 20);
            this.test5TxtBx.TabIndex = 9;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(119, 171);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 10;
            this.calcBtn.Text = "Submit";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(22, 209);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 11;
            // 
            // TestsInteractiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.test5TxtBx);
            this.Controls.Add(this.test4TxtBx);
            this.Controls.Add(this.test3TxtBx);
            this.Controls.Add(this.test2TxtBx);
            this.Controls.Add(this.test1TxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestsInteractiveForm";
            this.Text = "5 Tests Interactive GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox test1TxtBx;
        private System.Windows.Forms.TextBox test2TxtBx;
        private System.Windows.Forms.TextBox test3TxtBx;
        private System.Windows.Forms.TextBox test4TxtBx;
        private System.Windows.Forms.TextBox test5TxtBx;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

