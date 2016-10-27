namespace WindowsFormsApplication1
{
    partial class Assignment2
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
            this.txtthirdMark = new System.Windows.Forms.TextBox();
            this.txtfourthMark = new System.Windows.Forms.TextBox();
            this.txtsecondMark = new System.Windows.Forms.TextBox();
            this.txtfirstMark = new System.Windows.Forms.TextBox();
            this.txtfifthMark = new System.Windows.Forms.TextBox();
            this.lblgr1 = new System.Windows.Forms.Label();
            this.lblgr2 = new System.Windows.Forms.Label();
            this.lblgr3 = new System.Windows.Forms.Label();
            this.lblgr4 = new System.Windows.Forms.Label();
            this.lblgr5 = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtthirdMark
            // 
            this.txtthirdMark.Location = new System.Drawing.Point(313, 255);
            this.txtthirdMark.Name = "txtthirdMark";
            this.txtthirdMark.Size = new System.Drawing.Size(129, 20);
            this.txtthirdMark.TabIndex = 0;
            // 
            // txtfourthMark
            // 
            this.txtfourthMark.Location = new System.Drawing.Point(313, 281);
            this.txtfourthMark.Name = "txtfourthMark";
            this.txtfourthMark.Size = new System.Drawing.Size(129, 20);
            this.txtfourthMark.TabIndex = 1;
            this.txtfourthMark.TextChanged += new System.EventHandler(this.fourthMark_TextChanged);
            // 
            // txtsecondMark
            // 
            this.txtsecondMark.Location = new System.Drawing.Point(313, 229);
            this.txtsecondMark.Name = "txtsecondMark";
            this.txtsecondMark.Size = new System.Drawing.Size(129, 20);
            this.txtsecondMark.TabIndex = 2;
            // 
            // txtfirstMark
            // 
            this.txtfirstMark.Location = new System.Drawing.Point(313, 203);
            this.txtfirstMark.Name = "txtfirstMark";
            this.txtfirstMark.Size = new System.Drawing.Size(129, 20);
            this.txtfirstMark.TabIndex = 3;
            this.txtfirstMark.TextChanged += new System.EventHandler(this.firstMark_TextChanged);
            // 
            // txtfifthMark
            // 
            this.txtfifthMark.Location = new System.Drawing.Point(313, 307);
            this.txtfifthMark.Name = "txtfifthMark";
            this.txtfifthMark.Size = new System.Drawing.Size(129, 20);
            this.txtfifthMark.TabIndex = 4;
            this.txtfifthMark.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblgr1
            // 
            this.lblgr1.AutoSize = true;
            this.lblgr1.Location = new System.Drawing.Point(259, 206);
            this.lblgr1.Name = "lblgr1";
            this.lblgr1.Size = new System.Drawing.Size(48, 13);
            this.lblgr1.TabIndex = 5;
            this.lblgr1.Text = "Grade 1:";
            this.lblgr1.Click += new System.EventHandler(this.lblgr1_Click);
            // 
            // lblgr2
            // 
            this.lblgr2.AutoSize = true;
            this.lblgr2.Location = new System.Drawing.Point(259, 232);
            this.lblgr2.Name = "lblgr2";
            this.lblgr2.Size = new System.Drawing.Size(48, 13);
            this.lblgr2.TabIndex = 6;
            this.lblgr2.Text = "Grade 2:";
            // 
            // lblgr3
            // 
            this.lblgr3.AutoSize = true;
            this.lblgr3.Location = new System.Drawing.Point(259, 258);
            this.lblgr3.Name = "lblgr3";
            this.lblgr3.Size = new System.Drawing.Size(48, 13);
            this.lblgr3.TabIndex = 7;
            this.lblgr3.Text = "Grade 3:";
            // 
            // lblgr4
            // 
            this.lblgr4.AutoSize = true;
            this.lblgr4.Location = new System.Drawing.Point(259, 284);
            this.lblgr4.Name = "lblgr4";
            this.lblgr4.Size = new System.Drawing.Size(48, 13);
            this.lblgr4.TabIndex = 8;
            this.lblgr4.Text = "Grade 4:";
            this.lblgr4.Click += new System.EventHandler(this.lblgr4_Click);
            // 
            // lblgr5
            // 
            this.lblgr5.AutoSize = true;
            this.lblgr5.Location = new System.Drawing.Point(259, 310);
            this.lblgr5.Name = "lblgr5";
            this.lblgr5.Size = new System.Drawing.Size(48, 13);
            this.lblgr5.TabIndex = 9;
            this.lblgr5.Text = "Grade 5:";
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(484, 214);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(269, 101);
            this.btnAverage.TabIndex = 10;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(384, 356);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(235, 145);
            this.lblResult.TabIndex = 11;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 559);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblgr5);
            this.Controls.Add(this.lblgr4);
            this.Controls.Add(this.lblgr3);
            this.Controls.Add(this.lblgr2);
            this.Controls.Add(this.lblgr1);
            this.Controls.Add(this.txtfifthMark);
            this.Controls.Add(this.txtfirstMark);
            this.Controls.Add(this.txtsecondMark);
            this.Controls.Add(this.txtfourthMark);
            this.Controls.Add(this.txtthirdMark);
            this.Name = "Assignment2";
            this.Text = "Assignment 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtthirdMark;
        private System.Windows.Forms.TextBox txtfourthMark;
        private System.Windows.Forms.TextBox txtsecondMark;
        private System.Windows.Forms.TextBox txtfirstMark;
        private System.Windows.Forms.TextBox txtfifthMark;
        private System.Windows.Forms.Label lblgr1;
        private System.Windows.Forms.Label lblgr2;
        private System.Windows.Forms.Label lblgr3;
        private System.Windows.Forms.Label lblgr4;
        private System.Windows.Forms.Label lblgr5;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblResult;
    }
}

