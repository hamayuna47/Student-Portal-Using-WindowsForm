using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  
    public partial class Feedback : Form
    {
        private string userid;
        private int score;
        private string grade;
        private string teachername;
        public Feedback(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            
           


        }

        private void departmentbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Feedback_Load(object sender, EventArgs e)
        {



        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            int score = 0;
            int max = 100;
            for (int i = 1; i <= 5; i++)
            {
                if (q1box.Text == i.ToString())
                {
                    score += i;
                }
                if (q2box.Text == i.ToString()) { score += i; }
                if (q3box.Text == i.ToString()) { score += i; }
                if (q4box.Text == i.ToString()) { score += i; }
                if (q5box.Text == i.ToString()) { score += i; }
                if (q6box.Text == i.ToString()) { score += i; }
                if (q7box.Text == i.ToString()) { score += i; }
                if (q8box.Text == i.ToString()) { score += i; }
                if (q9box.Text == i.ToString()) { score += i; }
                if (q10box.Text == i.ToString()) { score += i; }
                if (q11box.Text == i.ToString()) { score += i; }
                if (q12box.Text == i.ToString()) { score += i; }
                if (q13box.Text == i.ToString()) { score += i; }
                if (q14box.Text == i.ToString()) { score += i; }
                if (q15box.Text == i.ToString()) { score += i; }
                if (q16box.Text == i.ToString()) { score += i; }
                if (q17box.Text == i.ToString()) { score += i; }
                if (q18box.Text == i.ToString()) { score += i; }
                if (q19box.Text == i.ToString()) { score += i; }
                if (q20box.Text == i.ToString()) { score += i; }

            }

            this.score = score;
            if (this.score >= 90)
            {
                this.grade = "Excellent";
            }
            else if (this.score >= 80 && this.score < 90)
            {
                this.grade = "Very Good";
            }
            else if (this.score >= 70 && this.score < 80)
            {
                this.grade = "Good";
            }
            else if (this.score >= 60 && this.score < 70)
            {
                this.grade = "Average";
            }
            else if (this.score >= 50 && this.score < 60)
            {
                this.grade = "Okay";
            }
            else
                this.grade = "Poor";
            this.teachername = teachernamebox.Text;
            Comment comm = new Comment(this.userid,this.score,this.teachername,this.grade);
            this.Hide();
            comm.Show();
        }
    }
}
