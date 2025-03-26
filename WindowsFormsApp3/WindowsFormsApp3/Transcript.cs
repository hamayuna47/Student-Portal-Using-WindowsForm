using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Transcript : Form
    {
        private string userid;
        private int maxsem;
        public Transcript(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            transcriptview.Hide();
            string query = "SELECT DIStINCT semester FROM Transcript WHERE Transcript.student_id = '" + userid + "'";
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int buttonCount = 0;
                while (reader.Read())
                {
                    int courseName = reader.GetInt32(0);
                    Button courseButton = new Button();
                    courseButton.Name = "btnCourse" + buttonCount.ToString();
                    courseButton.Text = "Semester " + courseName.ToString();
                    courseButton.Width = 80;
                    courseButton.Height = 40;
                    courseButton.Tag = courseName;
                    courseButton.Location = new Point(430 + buttonCount * 80, 151);
                    courseButton.Click += new EventHandler(courseButton_Click);
                    this.Controls.Add(courseButton);
                    buttonCount++;
                }
            }
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            string semester = ((Button)sender).Tag.ToString();
            SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            conn.Open();

            SqlCommand cm;


            string query = "SELECT Transcript.course_id,Course.name,Transcript.grade,Transcript.points FROM Transcript JOIN Student on Transcript.student_id = Student.id JOIN Course on Transcript.course_id = Course.id  WHERE Student.id = '" + userid + "'AND Transcript.semester = '" + semester + "'";

            cm = new SqlCommand(query, conn);

            SqlDataReader rdr = cm.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            conn.Close();
            adapter.Fill(table);
            transcriptview.Show();
            transcriptview.DataSource = table;
            transcriptview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(this.userid);
            this.Hide();
            student.Show();
        }

        private void Transcript_Load(object sender, EventArgs e)
        {

        }
    }
}
