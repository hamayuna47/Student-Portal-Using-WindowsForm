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
    public partial class TeacherGrade : Form
    {
        private string userid;
        private string courseid;
        private string section;
        private string type;
        private float obtained;
        private float total;
        public TeacherGrade(string userid,string courseid,string section)
        {
            InitializeComponent();
            this.userid = userid;
            this.courseid = courseid;
            this.section = section;



        }

        private void TeacherGrade_Load(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT DISTINCT student_id FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "'";
            




            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            while (reader.Read())
            {



                SqlConnection bharmaija= new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
                string studentid = (reader.GetInt32(0)).ToString();

                string querymarks = "SELECT (sum(obtained)*100) /sum(total) FROM Marks WHERE student_id = '" + studentid + "' AND course_id = '" + this.courseid  + "'";

                bharmaija.Open();
                SqlCommand cmdmarks = new SqlCommand(querymarks, bharmaija);
                SqlDataReader readermarks = cmdmarks.ExecuteReader();
                float percentageScore = 0;
                if (readermarks.Read())
                {
                    percentageScore = readermarks.GetInt32(0);
                }

                



                

                // Determine the grade and grade points based on the percentage score
                string grade;
                float gradePoints;
                if (percentageScore >= 90.0f)
                {
                    grade = "A+";
                    gradePoints = 4.0f;
                }
                else if (percentageScore >= 80.0f)
                {
                    grade = "A";
                    gradePoints = 3.5f;
                }
                else if (percentageScore >= 70.0f)
                {
                    grade = "B";
                    gradePoints = 3.0f;
                }
                else if (percentageScore >= 60.0f)
                {
                    grade = "C";
                    gradePoints = 2.5f;
                }
                else if (percentageScore >= 50.0f)
                {
                    grade = "D";
                    gradePoints = 2.0f;
                }
                else
                {
                    grade = "F";
                    gradePoints = 0.0f;
                }


                string marks = percentageScore.ToString();
                string gp = gradePoints.ToString();


                string query2 = "UPDATE Transcript SET points = '" + gp + "', grade = '" + grade + "' WHERE student_id = '" + studentid + "'AND course_id = '" + this.courseid +"'";
                using (SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(query2, conn);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    conn.Close();

                }
            }
            MessageBox.Show("New " + this.type + " Inserted Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes(this.userid);
            this.Hide();
            classes.Show();
        }
    }
}
