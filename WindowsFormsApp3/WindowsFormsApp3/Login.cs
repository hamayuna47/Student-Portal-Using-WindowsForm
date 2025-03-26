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
    public partial class Login : Form
    {
        string type;
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            conn.Open();
            SqlCommand cm;
            string un = textBox1.Text;
            string pass = textBox2.Text;
            string query = "SELECT * FROM Users WHERE id = '" + un + "' AND password = '" + pass + "'";
            string query1 = "SELECT type FROM Users WHERE id = '" + un + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader readtype = cmd1.ExecuteReader();
            if(readtype.Read())
            {
                this.type = readtype.GetString(0);
            }
            conn.Close();
            conn.Open();
            cm = new SqlCommand(query, conn);

            SqlDataReader res = cm.ExecuteReader();

            if (!res.HasRows)
            {
                MessageBox.Show("No such username found");
            }
            else
            {
                if (this.type == "Student")
                {
                    MessageBox.Show("Welcome Student");
                    Student home = new Student(un);
                    this.Hide();
                    home.Show();
                }
                else if (this.type == "Faculty")
                {
                    MessageBox.Show("Welcome Faculty");
                    Teacher teacher = new Teacher(un);
                    this.Hide();
                    teacher.Show();
                }
                else
                {
                    MessageBox.Show("Welcome Admin");
                    Admin home = new Admin(un);
                    this.Hide();
                    home.Show();
                }
            }
            Console.WriteLine("After method call, value of res : {0}", res);
            cm.Dispose();
            conn.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
