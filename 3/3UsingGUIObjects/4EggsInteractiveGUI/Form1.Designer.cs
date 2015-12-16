namespace _4EggsInteractiveGUI
{
    partial class EggsInteractiveForm
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
            this.chicken1TxtBx = new System.Windows.Forms.TextBox();
            this.chicken2TxtBx = new System.Windows.Forms.TextBox();
            this.chicken3TxtBx = new System.Windows.Forms.TextBox();
            this.chicken4TxtBx = new System.Windows.Forms.TextBox();
            this.chicken5TxtBx = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eggs produced by chicken 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eggs produced by chicken 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eggs produced by chicken 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eggs produced by chicken 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eggs produced by chicken 5:";
            // 
            // chicken1TxtBx
            // 
            this.chicken1TxtBx.Location = new System.Drawing.Point(168, 30);
            this.chicken1TxtBx.Name = "chicken1TxtBx";
            this.chicken1TxtBx.Size = new System.Drawing.Size(100, 20);
            this.chicken1TxtBx.TabIndex = 5;
            // 
            // chicken2TxtBx
            // 
            this.chicken2TxtBx.Location = new System.Drawing.Point(168, 73);
            this.chicken2TxtBx.Name = "chicken2TxtBx";
            this.chicken2TxtBx.Size = new System.Drawing.Size(100, 20);
            this.chicken2TxtBx.TabIndex = 6;
            // 
            // chicken3TxtBx
            // 
            this.chicken3TxtBx.Location = new System.Drawing.Point(168, 118);
            this.chicken3TxtBx.Name = "chicken3TxtBx";
            this.chicken3TxtBx.Size = new System.Drawing.Size(100, 20);
            this.chicken3TxtBx.TabIndex = 7;
            // 
            // chicken4TxtBx
            // 
            this.chicken4TxtBx.Location = new System.Drawing.Point(168, 152);
            this.chicken4TxtBx.Name = "chicken4TxtBx";
            this.chicken4TxtBx.Size = new System.Drawing.Size(100, 20);
            this.chicken4TxtBx.TabIndex = 8;
            // 
            // chicken5TxtBx
            // 
            this.chicken5TxtBx.Location = new System.Drawing.Point(168, 196);
            this.chicken5TxtBx.Name = "chicken5TxtBx";
            this.chicken5TxtBx.Size = new System.Drawing.Size(100, 20);
            this.chicken5TxtBx.TabIndex = 9;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(170, 227);
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
            this.resultLbl.Location = new System.Drawing.Point(13, 266);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 11;
            // 
            // EggsInteractiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.chicken5TxtBx);
            this.Controls.Add(this.chicken4TxtBx);
            this.Controls.Add(this.chicken3TxtBx);
            this.Controls.Add(this.chicken2TxtBx);
            this.Controls.Add(this.chicken1TxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EggsInteractiveForm";
            this.Text = "4 Eggs Interactive GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox chicken1TxtBx;
        private System.Windows.Forms.TextBox chicken2TxtBx;
        private System.Windows.Forms.TextBox chicken3TxtBx;
        private System.Windows.Forms.TextBox chicken4TxtBx;
        private System.Windows.Forms.TextBox chicken5TxtBx;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

