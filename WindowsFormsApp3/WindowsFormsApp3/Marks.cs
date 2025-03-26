using System;
using System.Collections;
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

namespace WindowsFormsApp3
{
    public partial class Marks : Form
    {
        private string userid;
        private string courseid;
        private string coursename;
        public Marks(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            string query = "SELECT DISTINCT course_id FROM Attendance WHERE student_id = '" + userid + "'";
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int buttonCount = 0;
                while (reader.Read())
                {
                    string courseName = reader.GetString(0);
                    Button courseButton = new Button();
                    courseButton.Name = "btnCourse" + buttonCount.ToString();
                    courseButton.Text = courseName;
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
            courseid = ((Button)sender).Tag.ToString();
            string query1 = "SELECT name FROM Course WHERE id = '" + courseid + "'";
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                dataGridView1.Hide();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                connection.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    coursename = reader1.GetString(0);
                }
                namelabel.Text = courseid + "-" + coursename;
                connection.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(this.userid);
            this.Hide();
            student.Show();
        }

        private void Marks_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                string query1 = "SELECT name FROM Course WHERE id = '" + courseid + "'";
                string query = "SELECT obtained as Obtained, total as Total FROM Marks WHERE student_id = '" + this.userid + "' AND course_id = '" +courseid  +"' AND Marks.type = 'QUIZ'" ;
                this.coursename = "";
                dataGridView1.Hide();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                connection.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    coursename = reader1.GetString(0);
                }
                namelabel.Text = courseid + "-" + coursename;
                connection.Close();
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
        }

        private void assignment_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                string query1 = "SELECT name FROM Course WHERE id = '" + courseid + "'";
                string query = "SELECT obtained as Obtained, total as Total FROM Marks WHERE student_id = '" + this.userid + "' AND course_id = '" + courseid + "' AND Marks.type = 'ASSIGNMENT'";
                this.coursename = "";
                dataGridView1.Hide();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                connection.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    coursename = reader1.GetString(0);
                }
                namelabel.Text = courseid + "-" + coursename;
                connection.Close();
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
        }

        private void project_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                string query1 = "SELECT name FROM Course WHERE id = '" + courseid + "'";
                string query = "SELECT obtained as Obtained, total as Total FROM Marks WHERE student_id = '" + this.userid + "' AND course_id = '" + courseid + "' AND Marks.type = 'PROJECT'";
                this.coursename = "";
                dataGridView1.Hide();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                connection.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    coursename = reader1.GetString(0);
                }
                namelabel.Text = courseid + "-" + coursename;
                connection.Close();
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
        }

        private void mid_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                string query1 = "SELECT name FROM Course WHERE id = '" + courseid + "'";
                string query = "SELECT obtained as Obtained, total as Total FROM Marks WHERE student_id = '" + this.userid + "' AND course_id = '" + courseid + "' AND Marks.type = 'MID'";
                this.coursename = "";
                dataGridView1.Hide();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                connection.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    coursename = reader1.GetString(0);
                }
                namelabel.Text = courseid + "-" + coursename;
                connection.Close();
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
        }

        private void final_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                string query1 = "SELECT name FROM Course WHERE id = '" + courseid + "'";
                string query = "SELECT obtained as Obtained, total as Total FROM Marks WHERE student_id = '" + this.userid + "' AND course_id = '" + courseid + "' AND Marks.type = 'FINAL'";
                this.coursename = "";
                dataGridView1.Hide();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                connection.Open();
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    coursename = reader1.GetString(0);
                }
                namelabel.Text = courseid + "-" + coursename;
                connection.Close();
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
        }
    }
}
