namespace WindowsFormsApp3
{
    partial class Teacheruser
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
            this.nextbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.expbox = new System.Windows.Forms.TextBox();
            this.qualificationbox = new System.Windows.Forms.TextBox();
            this.salarybox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.TextBox();
            this.typebox = new System.Windows.Forms.TextBox();
            this.datelabel = new System.Windows.Forms.Label();
            this.explabel = new System.Windows.Forms.Label();
            this.qualificationlabel = new System.Windows.Forms.Label();
            this.salarylabel = new System.Windows.Forms.Label();
            this.typelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(1363, 668);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(102, 33);
            this.nextbutton.TabIndex = 102;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(65, 668);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(102, 33);
            this.backbutton.TabIndex = 101;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            // 
            // expbox
            // 
            this.expbox.Location = new System.Drawing.Point(992, 415);
            this.expbox.Name = "expbox";
            this.expbox.Size = new System.Drawing.Size(211, 22);
            this.expbox.TabIndex = 100;
            // 
            // qualificationbox
            // 
            this.qualificationbox.Location = new System.Drawing.Point(992, 350);
            this.qualificationbox.Name = "qualificationbox";
            this.qualificationbox.Size = new System.Drawing.Size(211, 22);
            this.qualificationbox.TabIndex = 99;
            // 
            // salarybox
            // 
            this.salarybox.Location = new System.Drawing.Point(378, 419);
            this.salarybox.Name = "salarybox";
            this.salarybox.Size = new System.Drawing.Size(209, 22);
            this.salarybox.TabIndex = 98;
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(378, 481);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(209, 22);
            this.datebox.TabIndex = 97;
            // 
            // typebox
            // 
            this.typebox.Location = new System.Drawing.Point(378, 352);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(209, 22);
            this.typebox.TabIndex = 96;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(265, 481);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(108, 20);
            this.datelabel.TabIndex = 95;
            this.datelabel.Text = "Joining Date:";
            // 
            // explabel
            // 
            this.explabel.AutoSize = true;
            this.explabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explabel.Location = new System.Drawing.Point(858, 419);
            this.explabel.Name = "explabel";
            this.explabel.Size = new System.Drawing.Size(97, 20);
            this.explabel.TabIndex = 94;
            this.explabel.Text = "Experience:";
            // 
            // qualificationlabel
            // 
            this.qualificationlabel.AutoSize = true;
            this.qualificationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualificationlabel.Location = new System.Drawing.Point(858, 352);
            this.qualificationlabel.Name = "qualificationlabel";
            this.qualificationlabel.Size = new System.Drawing.Size(107, 20);
            this.qualificationlabel.TabIndex = 93;
            this.qualificationlabel.Text = "Qualification:";
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarylabel.Location = new System.Drawing.Point(265, 419);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(61, 20);
            this.salarylabel.TabIndex = 92;
            this.salarylabel.Text = "Salary:";
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelabel.Location = new System.Drawing.Point(265, 354);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(74, 20);
            this.typelabel.TabIndex = 91;
            this.typelabel.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 90;
            this.label1.Text = "Teacher Information";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox2.Location = new System.Drawing.Point(12, 193);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1509, 96);
            this.richTextBox2.TabIndex = 89;
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
            this.richTextBox1.TabIndex = 88;
            this.richTextBox1.Text = "                                                    \n  \n\tAdd Teacher Menu";
            // 
            // Teacheruser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.expbox);
            this.Controls.Add(this.qualificationbox);
            this.Controls.Add(this.salarybox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.explabel);
            this.Controls.Add(this.qualificationlabel);
            this.Controls.Add(this.salarylabel);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Teacheruser";
            this.Text = "Teacheruser";
            this.Load += new System.EventHandler(this.Teacheruser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox expbox;
        private System.Windows.Forms.TextBox qualificationbox;
        private System.Windows.Forms.TextBox salarybox;
        private System.Windows.Forms.TextBox datebox;
        private System.Windows.Forms.TextBox typebox;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label explabel;
        private System.Windows.Forms.Label qualificationlabel;
        private System.Windows.Forms.Label salarylabel;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}