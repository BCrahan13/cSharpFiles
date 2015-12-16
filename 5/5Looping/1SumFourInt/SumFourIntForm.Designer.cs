namespace _1SumFourInt
{
    partial class SumFourIntForm
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
            this.resultLbl = new System.Windows.Forms.Label();
            this.int1TxtBx = new System.Windows.Forms.TextBox();
            this.int2TxtBx = new System.Windows.Forms.TextBox();
            this.int3TxtBx = new System.Windows.Forms.TextBox();
            this.int4TxtBx = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Int 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Int 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Int 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Int 4:";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(12, 168);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 17);
            this.resultLbl.TabIndex = 4;
            // 
            // int1TxtBx
            // 
            this.int1TxtBx.Location = new System.Drawing.Point(72, 13);
            this.int1TxtBx.Name = "int1TxtBx";
            this.int1TxtBx.Size = new System.Drawing.Size(100, 20);
            this.int1TxtBx.TabIndex = 5;
            // 
            // int2TxtBx
            // 
            this.int2TxtBx.Location = new System.Drawing.Point(72, 44);
            this.int2TxtBx.Name = "int2TxtBx";
            this.int2TxtBx.Size = new System.Drawing.Size(100, 20);
            this.int2TxtBx.TabIndex = 6;
            // 
            // int3TxtBx
            // 
            this.int3TxtBx.Location = new System.Drawing.Point(72, 78);
            this.int3TxtBx.Name = "int3TxtBx";
            this.int3TxtBx.Size = new System.Drawing.Size(100, 20);
            this.int3TxtBx.TabIndex = 7;
            // 
            // int4TxtBx
            // 
            this.int4TxtBx.Location = new System.Drawing.Point(72, 108);
            this.int4TxtBx.Name = "int4TxtBx";
            this.int4TxtBx.Size = new System.Drawing.Size(100, 20);
            this.int4TxtBx.TabIndex = 8;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(72, 135);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(100, 25);
            this.calcBtn.TabIndex = 9;
            this.calcBtn.Text = "CALCULATE";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // SumFourIntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.int4TxtBx);
            this.Controls.Add(this.int3TxtBx);
            this.Controls.Add(this.int2TxtBx);
            this.Controls.Add(this.int1TxtBx);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SumFourIntForm";
            this.Text = "5.1 Sum Four Int";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox int1TxtBx;
        private System.Windows.Forms.TextBox int2TxtBx;
        private System.Windows.Forms.TextBox int3TxtBx;
        private System.Windows.Forms.TextBox int4TxtBx;
        private System.Windows.Forms.Button calcBtn;
    }
}

