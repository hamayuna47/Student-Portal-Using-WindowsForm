using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Comment : Form
    {
        private string userid;
        private string grade;
        private string score;
        private string teachername;
        private string comment;
        public Comment(string userid,int score,string teachername,string grade)
        {
            InitializeComponent();
            this.userid = userid;
            this.score = score.ToString();
            this.teachername = teachername;
            this.grade = grade;



        }

        private void Comment_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.comment = richTextBox2.Text;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");

            string query = "INSERT INTO Feedback(name,score,grade,comments) VALUES ('" + this.teachername + "','" + this.score + "','" + this.grade + "','" + this.comment + "')";


            connection.Open();
            SqlCommand cmd1 = new SqlCommand(query, connection);
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            connection.Close();


            MessageBox.Show("Feedback added successfully");


            Student stu = new Student(userid);
            this.Hide();
            stu.Show();
        }
    }
}
