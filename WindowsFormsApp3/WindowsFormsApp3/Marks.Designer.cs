namespace WindowsFormsApp3
{
    partial class Marks
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.assignment = new System.Windows.Forms.Button();
            this.project = new System.Windows.Forms.Button();
            this.mid = new System.Windows.Forms.Button();
            this.quiz = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(17, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(1498, 164);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "   \n   \n    Marks";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.richTextBox2.Location = new System.Drawing.Point(240, 182);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(262, 71);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Marks:";
            // 
            // assignment
            // 
            this.assignment.Location = new System.Drawing.Point(240, 377);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(168, 62);
            this.assignment.TabIndex = 10;
            this.assignment.Text = "Assignment";
            this.assignment.UseVisualStyleBackColor = true;
            this.assignment.Click += new System.EventHandler(this.assignment_Click);
            // 
            // project
            // 
            this.project.Location = new System.Drawing.Point(240, 445);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(168, 65);
            this.project.TabIndex = 11;
            this.project.Text = "Project";
            this.project.UseVisualStyleBackColor = true;
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // mid
            // 
            this.mid.Location = new System.Drawing.Point(240, 516);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(168, 60);
            this.mid.TabIndex = 12;
            this.mid.Text = "Mid";
            this.mid.UseVisualStyleBackColor = true;
            this.mid.Click += new System.EventHandler(this.mid_Click);
            // 
            // quiz
            // 
            this.quiz.Location = new System.Drawing.Point(240, 309);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(168, 62);
            this.quiz.TabIndex = 13;
            this.quiz.Text = "Quiz";
            this.quiz.UseVisualStyleBackColor = true;
            this.quiz.Click += new System.EventHandler(this.button5_Click);
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(240, 582);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(168, 60);
            this.final.TabIndex = 14;
            this.final.Text = "Final";
            this.final.UseVisualStyleBackColor = true;
            this.final.Click += new System.EventHandler(this.final_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1080, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(264, 170);
            this.dataGridView1.TabIndex = 15;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(237, 269);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(43, 20);
            this.namelabel.TabIndex = 16;
            this.namelabel.Text = "zxcv";
            // 
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 844);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.final);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.project);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Marks";
            this.Text = "Marks";
            this.Load += new System.EventHandler(this.Marks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button assignment;
        private System.Windows.Forms.Button project;
        private System.Windows.Forms.Button mid;
        private System.Windows.Forms.Button quiz;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label namelabel;
    }
}