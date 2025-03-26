namespace WindowsFormsApp3
{
    partial class Evaluation
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
            this.updatebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.quizid2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rollnobox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insertbutton = new System.Windows.Forms.Button();
            this.idbox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.final = new System.Windows.Forms.Button();
            this.quiz = new System.Windows.Forms.Button();
            this.mid = new System.Windows.Forms.Button();
            this.project = new System.Windows.Forms.Button();
            this.assignment = new System.Windows.Forms.Button();
            this.totalmarksbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.obtained = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.newquizbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addquizbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(1258, 419);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 40);
            this.updatebutton.TabIndex = 53;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1044, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Obtained Marks:";
            // 
            // quizid2
            // 
            this.quizid2.Location = new System.Drawing.Point(1206, 343);
            this.quizid2.Name = "quizid2";
            this.quizid2.Size = new System.Drawing.Size(127, 22);
            this.quizid2.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1044, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "ID:";
            // 
            // rollnobox
            // 
            this.rollnobox.Location = new System.Drawing.Point(1206, 316);
            this.rollnobox.Name = "rollnobox";
            this.rollnobox.Size = new System.Drawing.Size(127, 22);
            this.rollnobox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1044, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Roll No:";
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(1172, 655);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(92, 34);
            this.insertbutton.TabIndex = 47;
            this.insertbutton.Text = " Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // idbox1
            // 
            this.idbox1.Location = new System.Drawing.Point(559, 663);
            this.idbox1.Name = "idbox1";
            this.idbox1.Size = new System.Drawing.Size(127, 22);
            this.idbox1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(264, 170);
            this.dataGridView1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 126);
            this.button1.TabIndex = 43;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "                                                    \n  \n\tEvaluation";
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(38, 483);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(168, 60);
            this.final.TabIndex = 59;
            this.final.Text = "Final";
            this.final.UseVisualStyleBackColor = true;
            this.final.Click += new System.EventHandler(this.final_Click);
            // 
            // quiz
            // 
            this.quiz.Location = new System.Drawing.Point(38, 210);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(168, 62);
            this.quiz.TabIndex = 58;
            this.quiz.Text = "Quiz";
            this.quiz.UseVisualStyleBackColor = true;
            this.quiz.Click += new System.EventHandler(this.quiz_Click);
            // 
            // mid
            // 
            this.mid.Location = new System.Drawing.Point(38, 417);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(168, 60);
            this.mid.TabIndex = 57;
            this.mid.Text = "Mid";
            this.mid.UseVisualStyleBackColor = true;
            this.mid.Click += new System.EventHandler(this.mid_Click);
            // 
            // project
            // 
            this.project.Location = new System.Drawing.Point(38, 346);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(168, 65);
            this.project.TabIndex = 56;
            this.project.Text = "Project";
            this.project.UseVisualStyleBackColor = true;
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // assignment
            // 
            this.assignment.Location = new System.Drawing.Point(38, 278);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(168, 62);
            this.assignment.TabIndex = 55;
            this.assignment.Text = "Assignment";
            this.assignment.UseVisualStyleBackColor = true;
            this.assignment.Click += new System.EventHandler(this.assignment_Click);
            // 
            // totalmarksbox
            // 
            this.totalmarksbox.Location = new System.Drawing.Point(912, 663);
            this.totalmarksbox.Name = "totalmarksbox";
            this.totalmarksbox.Size = new System.Drawing.Size(127, 22);
            this.totalmarksbox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Total Marks: ";
            // 
            // obtained
            // 
            this.obtained.Location = new System.Drawing.Point(1206, 371);
            this.obtained.Name = "obtained";
            this.obtained.Size = new System.Drawing.Size(127, 22);
            this.obtained.TabIndex = 62;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox3.Location = new System.Drawing.Point(249, 622);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1272, 22);
            this.richTextBox3.TabIndex = 63;
            this.richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox2.Location = new System.Drawing.Point(249, 540);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1272, 22);
            this.richTextBox2.TabIndex = 64;
            this.richTextBox2.Text = "";
            // 
            // newquizbox
            // 
            this.newquizbox.Location = new System.Drawing.Point(758, 580);
            this.newquizbox.Name = "newquizbox";
            this.newquizbox.Size = new System.Drawing.Size(127, 22);
            this.newquizbox.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Total Marks: ";
            // 
            // addquizbutton
            // 
            this.addquizbutton.Location = new System.Drawing.Point(1172, 574);
            this.addquizbutton.Name = "addquizbutton";
            this.addquizbutton.Size = new System.Drawing.Size(92, 34);
            this.addquizbutton.TabIndex = 67;
            this.addquizbutton.Text = " Insert";
            this.addquizbutton.UseVisualStyleBackColor = true;
            this.addquizbutton.Click += new System.EventHandler(this.addquizbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "New:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 71;
            this.label8.Text = "Update Total:";
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newquizbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addquizbutton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.obtained);
            this.Controls.Add(this.totalmarksbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.final);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.project);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quizid2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rollnobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.idbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quizid2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rollnobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.TextBox idbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.Button quiz;
        private System.Windows.Forms.Button mid;
        private System.Windows.Forms.Button project;
        private System.Windows.Forms.Button assignment;
        private System.Windows.Forms.TextBox totalmarksbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox obtained;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox newquizbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addquizbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}