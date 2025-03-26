namespace WindowsFormsApp3
{
    partial class Studentuser
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
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.nextbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.semesterbox = new System.Windows.Forms.TextBox();
            this.degreebox = new System.Windows.Forms.TextBox();
            this.batchbox = new System.Windows.Forms.TextBox();
            this.sectionbox = new System.Windows.Forms.TextBox();
            this.departmentbox = new System.Windows.Forms.TextBox();
            this.sectionlabel = new System.Windows.Forms.Label();
            this.semesterlabel = new System.Windows.Forms.Label();
            this.degreelabel = new System.Windows.Forms.Label();
            this.batchlabel = new System.Windows.Forms.Label();
            this.departmentlabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox3.Location = new System.Drawing.Point(12, 756);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1509, 54);
            this.richTextBox3.TabIndex = 88;
            this.richTextBox3.Text = "";
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(1363, 668);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(102, 33);
            this.nextbutton.TabIndex = 87;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(65, 668);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(102, 33);
            this.backbutton.TabIndex = 86;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            // 
            // semesterbox
            // 
            this.semesterbox.Location = new System.Drawing.Point(992, 415);
            this.semesterbox.Name = "semesterbox";
            this.semesterbox.Size = new System.Drawing.Size(211, 22);
            this.semesterbox.TabIndex = 83;
            // 
            // degreebox
            // 
            this.degreebox.Location = new System.Drawing.Point(992, 350);
            this.degreebox.Name = "degreebox";
            this.degreebox.Size = new System.Drawing.Size(211, 22);
            this.degreebox.TabIndex = 82;
            // 
            // batchbox
            // 
            this.batchbox.Location = new System.Drawing.Point(378, 419);
            this.batchbox.Name = "batchbox";
            this.batchbox.Size = new System.Drawing.Size(209, 22);
            this.batchbox.TabIndex = 79;
            // 
            // sectionbox
            // 
            this.sectionbox.Location = new System.Drawing.Point(378, 481);
            this.sectionbox.Name = "sectionbox";
            this.sectionbox.Size = new System.Drawing.Size(209, 22);
            this.sectionbox.TabIndex = 78;
            // 
            // departmentbox
            // 
            this.departmentbox.Location = new System.Drawing.Point(378, 352);
            this.departmentbox.Name = "departmentbox";
            this.departmentbox.Size = new System.Drawing.Size(209, 22);
            this.departmentbox.TabIndex = 74;
            // 
            // sectionlabel
            // 
            this.sectionlabel.AutoSize = true;
            this.sectionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionlabel.Location = new System.Drawing.Point(265, 481);
            this.sectionlabel.Name = "sectionlabel";
            this.sectionlabel.Size = new System.Drawing.Size(70, 20);
            this.sectionlabel.TabIndex = 73;
            this.sectionlabel.Text = "Section:";
            this.sectionlabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // semesterlabel
            // 
            this.semesterlabel.AutoSize = true;
            this.semesterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterlabel.Location = new System.Drawing.Point(858, 419);
            this.semesterlabel.Name = "semesterlabel";
            this.semesterlabel.Size = new System.Drawing.Size(86, 20);
            this.semesterlabel.TabIndex = 72;
            this.semesterlabel.Text = "Semester:";
            // 
            // degreelabel
            // 
            this.degreelabel.AutoSize = true;
            this.degreelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreelabel.Location = new System.Drawing.Point(858, 352);
            this.degreelabel.Name = "degreelabel";
            this.degreelabel.Size = new System.Drawing.Size(69, 20);
            this.degreelabel.TabIndex = 67;
            this.degreelabel.Text = "Degree:";
            // 
            // batchlabel
            // 
            this.batchlabel.AutoSize = true;
            this.batchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchlabel.Location = new System.Drawing.Point(265, 419);
            this.batchlabel.Name = "batchlabel";
            this.batchlabel.Size = new System.Drawing.Size(58, 20);
            this.batchlabel.TabIndex = 64;
            this.batchlabel.Text = "Batch:";
            // 
            // departmentlabel
            // 
            this.departmentlabel.AutoSize = true;
            this.departmentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentlabel.Location = new System.Drawing.Point(265, 354);
            this.departmentlabel.Name = "departmentlabel";
            this.departmentlabel.Size = new System.Drawing.Size(102, 20);
            this.departmentlabel.TabIndex = 62;
            this.departmentlabel.Text = "Department:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox2.Location = new System.Drawing.Point(12, 193);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1509, 96);
            this.richTextBox2.TabIndex = 60;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(1509, 164);
            this.richTextBox1.TabIndex = 59;
            this.richTextBox1.Text = "                                                    \n  \n\tAdd Student Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 61;
            this.label1.Text = "Student Information";
            // 
            // Studentuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.semesterbox);
            this.Controls.Add(this.degreebox);
            this.Controls.Add(this.batchbox);
            this.Controls.Add(this.sectionbox);
            this.Controls.Add(this.departmentbox);
            this.Controls.Add(this.sectionlabel);
            this.Controls.Add(this.semesterlabel);
            this.Controls.Add(this.degreelabel);
            this.Controls.Add(this.batchlabel);
            this.Controls.Add(this.departmentlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Studentuser";
            this.Text = "Studentuser";
            this.Load += new System.EventHandler(this.Studentuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox semesterbox;
        private System.Windows.Forms.TextBox degreebox;
        private System.Windows.Forms.TextBox batchbox;
        private System.Windows.Forms.TextBox sectionbox;
        private System.Windows.Forms.TextBox departmentbox;
        private System.Windows.Forms.Label sectionlabel;
        private System.Windows.Forms.Label semesterlabel;
        private System.Windows.Forms.Label degreelabel;
        private System.Windows.Forms.Label batchlabel;
        private System.Windows.Forms.Label departmentlabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}