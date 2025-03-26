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
using System.Xml;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Classes : Form
    {
        private string userid;
        private string courseid;
        private string coursename;
        private string section;
        private string batch;
        private string date;
        private string typeofquery;

        public class ClassInfo
        {
            

            public string courseName;
            public string section;
            public string batch;
            public string courseid;
        }

        public Classes(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            label1.Text = "";
            string query = "SELECT course_id, Course.name, section,batch FROM Teaches_in join Course on Course.id = Teaches_in.course_id WHERE teacher_id = '" + userid + "'";
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int buttonCount = 0;
                while (reader.Read())
                {
                    ClassInfo info = new ClassInfo();
                    string courseName = reader.GetString(0);
                    string section = reader.GetString(2);
                    string batch = (reader.GetInt32(3)).ToString();
                    
                    info.section = section;
                    info.batch = batch;
                    info.courseid = courseName;
                    info.courseName = reader.GetString(1);
                    Button courseButton = new Button();
                    courseButton.Name = "btnCourse" + buttonCount.ToString();
                    courseButton.Text = batch + " - "+ courseName + " - " + section;
                    courseButton.Width = 130;
                    courseButton.Height = 40;
                    courseButton.Tag = info;
                    courseButton.Location = new Point(430 + buttonCount * 130, 151);
                    courseButton.Click += new EventHandler(courseButton_Click);
                    this.Controls.Add(courseButton);
                    buttonCount++;
                }
                
            }
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ClassInfo info = (ClassInfo)button.Tag;

            this.courseid = info.courseid;
            this.section = info.section;
            this.batch = info.batch;
            this.coursename = info.courseName;

            label1.Text = batch + " - " + courseid + " - " + this.section;

            
        }
        private void Classes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(this.userid);
            this.Hide();
            teacher.Show();
        }

        private void attendancebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT Student.id as RollNo ,Users.fname + ' ' + Users.lname as Name FROM Student join Users on Student.id = Users.id join Studies on Student.id = Studies.student_id WHERE Studies.section= '" + this.section + "' AND Student.semester = Studies.semester AND Studies.course_id = '" + this.courseid+"'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            connection.Close();
            adapter.Fill(table);
            dataGridView1.Show();
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            this.date = datebox.Text;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT Student.id FROM Student join Users on Student.id = Users.id WHERE Section = '" + this.section + "' AND Batch = '" + this.batch + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            while(reader.Read())
            {
                string studentid = (reader.GetInt32(0)).ToString();

                string query2 = "INSERT INTO Attendance (course_id, student_id , status, date) VALUES ('" + this.courseid +"','" 
                + studentid + "', 'P' ,'" + datebox.Text + "')";
                using (SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(query2, conn);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    conn.Close();
                 
                }
            }
            MessageBox.Show("Attendance Inserted Successfully");
            Teacher teacher = new Teacher(this.userid);
            this.Hide();
            teacher.Show();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            string query = "UPDATE Attendance SET status = '" + typebox.Text + "' WHERE student_id = '" + rollnobox.Text + "' AND date = '" + updatedatebox.Text + "'";
            using (SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                conn.Close();

            }

            MessageBox.Show("Attendance Updated Successfully");
        }

        private void evaluationbutton_Click(object sender, EventArgs e)
        {
            Evaluation eval = new Evaluation(this.userid,this.courseid,this.section);
            this.Hide();
            eval.Show();    
        }

        private void gradebutton_Click(object sender, EventArgs e)
        {
            TeacherGrade tg = new TeacherGrade(this.userid, this.courseid, this.section);
            this.Hide();
            tg.Show();
        }
    }
}
