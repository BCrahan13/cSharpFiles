namespace HOT3_2
{
    partial class HOT3_2Form
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
            this.calcTotalBtn = new System.Windows.Forms.Button();
            this.calcAvgBtn = new System.Windows.Forms.Button();
            this.calcHighestBtn = new System.Windows.Forms.Button();
            this.calcLowestBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.avgLbl = new System.Windows.Forms.Label();
            this.highestLbl = new System.Windows.Forms.Label();
            this.lowestLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcTotalBtn
            // 
            this.calcTotalBtn.Location = new System.Drawing.Point(13, 23);
            this.calcTotalBtn.Name = "calcTotalBtn";
            this.calcTotalBtn.Size = new System.Drawing.Size(96, 23);
            this.calcTotalBtn.TabIndex = 0;
            this.calcTotalBtn.Text = "calcTotalBtn";
            this.calcTotalBtn.UseVisualStyleBackColor = true;
            this.calcTotalBtn.Click += new System.EventHandler(this.calcTotalBtn_Click);
            // 
            // calcAvgBtn
            // 
            this.calcAvgBtn.Location = new System.Drawing.Point(13, 68);
            this.calcAvgBtn.Name = "calcAvgBtn";
            this.calcAvgBtn.Size = new System.Drawing.Size(96, 23);
            this.calcAvgBtn.TabIndex = 1;
            this.calcAvgBtn.Text = "calcAvgBtn";
            this.calcAvgBtn.UseVisualStyleBackColor = true;
            this.calcAvgBtn.Click += new System.EventHandler(this.calcAvgBtn_Click);
            // 
            // calcHighestBtn
            // 
            this.calcHighestBtn.Location = new System.Drawing.Point(13, 114);
            this.calcHighestBtn.Name = "calcHighestBtn";
            this.calcHighestBtn.Size = new System.Drawing.Size(96, 23);
            this.calcHighestBtn.TabIndex = 2;
            this.calcHighestBtn.Text = "calcHighestBtn";
            this.calcHighestBtn.UseVisualStyleBackColor = true;
            this.calcHighestBtn.Click += new System.EventHandler(this.calcHighestBtn_Click);
            // 
            // calcLowestBtn
            // 
            this.calcLowestBtn.Location = new System.Drawing.Point(12, 154);
            this.calcLowestBtn.Name = "calcLowestBtn";
            this.calcLowestBtn.Size = new System.Drawing.Size(97, 23);
            this.calcLowestBtn.TabIndex = 3;
            this.calcLowestBtn.Text = "calcLowestBtn";
            this.calcLowestBtn.UseVisualStyleBackColor = true;
            this.calcLowestBtn.Click += new System.EventHandler(this.calcLowestBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(133, 32);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(0, 13);
            this.totalLbl.TabIndex = 4;
            // 
            // avgLbl
            // 
            this.avgLbl.AutoSize = true;
            this.avgLbl.Location = new System.Drawing.Point(136, 77);
            this.avgLbl.Name = "avgLbl";
            this.avgLbl.Size = new System.Drawing.Size(0, 13);
            this.avgLbl.TabIndex = 5;
            // 
            // highestLbl
            // 
            this.highestLbl.AutoSize = true;
            this.highestLbl.Location = new System.Drawing.Point(115, 119);
            this.highestLbl.Name = "highestLbl";
            this.highestLbl.Size = new System.Drawing.Size(0, 13);
            this.highestLbl.TabIndex = 6;
            // 
            // lowestLbl
            // 
            this.lowestLbl.AutoSize = true;
            this.lowestLbl.Location = new System.Drawing.Point(115, 164);
            this.lowestLbl.Name = "lowestLbl";
            this.lowestLbl.Size = new System.Drawing.Size(0, 13);
            this.lowestLbl.TabIndex = 7;
            // 
            // HOT3_2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lowestLbl);
            this.Controls.Add(this.highestLbl);
            this.Controls.Add(this.avgLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.calcLowestBtn);
            this.Controls.Add(this.calcHighestBtn);
            this.Controls.Add(this.calcAvgBtn);
            this.Controls.Add(this.calcTotalBtn);
            this.Name = "HOT3_2Form";
            this.Text = "HOT3_2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcTotalBtn;
        private System.Windows.Forms.Button calcAvgBtn;
        private System.Windows.Forms.Button calcHighestBtn;
        private System.Windows.Forms.Button calcLowestBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label avgLbl;
        private System.Windows.Forms.Label highestLbl;
        private System.Windows.Forms.Label lowestLbl;
    }
}

