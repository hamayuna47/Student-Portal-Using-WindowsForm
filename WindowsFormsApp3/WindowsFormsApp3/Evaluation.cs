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
    public partial class Evaluation : Form
    {
        private string userid;
        private string courseid;
        private string section;
        private string type;
        public Evaluation(string userid, string courseid, string section)
        {
            InitializeComponent();
            this.userid = userid;
            this.courseid = courseid;
            this.section = section;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes(this.userid);
            this.Hide();
            classes.Show();
        }

        private void quiz_Click(object sender, EventArgs e)
        {
            this.type = quiz.Text;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT id,student_id,section,obtained,total FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "' AND Marks.Type = 'QUIZ'";
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

        private void assignment_Click(object sender, EventArgs e)
        {
            this.type = assignment.Text;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT id,student_id,section,obtained,total FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "' AND Marks.Type = 'ASSIGNMENT'";
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

        private void project_Click(object sender, EventArgs e)
        {
            this.type = project.Text;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT id,student_id,section,obtained,total FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "' AND Marks.Type = 'PROJECT'";
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

        private void mid_Click(object sender, EventArgs e)
        {
            this.type = mid.Text;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT id,student_id,section,obtained,total FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "' AND Marks.Type = 'MID'";
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

        private void final_Click(object sender, EventArgs e)
        {
            this.type = final.Text;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT id,student_id,section,obtained,total FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "' AND Marks.Type = 'FINAL'";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT id,student_id,section,obtained,total FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "' AND Marks.Type = '" +this.type +  "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            while (reader.Read())
            {
                string studentid = (reader.GetInt32(0)).ToString();

                string query2 = "UPDATE Marks SET total = '" +totalmarksbox.Text +"' WHERE id = '" + idbox1.Text + "' AND type = '" + this.type + "'";
                using (SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(query2, conn);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    conn.Close();

                }
            }
            MessageBox.Show("Marks Inserted Successfully");
            Teacher teacher = new Teacher(this.userid);
            this.Hide();
            teacher.Show();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Marks SET obtained = '" + obtained.Text + "'WHERE id = '" +quizid2.Text + "' AND type = '" + this.type + "' AND student_id = '"+rollnobox.Text +"'";
            using (SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                conn.Close();

            }

            MessageBox.Show("Marks Updated Successfully");
        }

        private void addquizbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT DISTINCT student_id FROM Marks WHERE Section = '" + this.section + "' AND Marks.course_id = '" + this.courseid + "' AND Marks.Type = '" + this.type + "'";
            string maxquery = "select max(Marks.id) from Marks where Marks.type = '" + this.type + "'";
            SqlCommand maxcmd = new SqlCommand(maxquery, connection);
            connection.Open();
            SqlDataReader maxreader = maxcmd.ExecuteReader();
            SqlDataAdapter maxadapter = new SqlDataAdapter(maxcmd);
            int max = 0;
            if(maxreader.Read())
            {
                max = maxreader.GetInt32(0);
                max++;
            }    
            string maxstring = max.ToString();
            connection.Close();
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            while (reader.Read())
            {
                string studentid = (reader.GetInt32(0)).ToString();
                
                string query2 = "INSERT INTO Marks (student_id,section,course_id,obtained,total,type,id) VALUES ('"+studentid +"','" + this.section + "','" + this.courseid + "',0,'" +newquizbox.Text +"','"+this.type+ "','" + maxstring + "')";
                using (SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(query2, conn);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    conn.Close();

                }
            }   
            MessageBox.Show("New "+ this.type + " Inserted Successfully");
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }
    }
}
