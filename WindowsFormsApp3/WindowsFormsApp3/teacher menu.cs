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
    public partial class Teacher : Form
    {
        private string userid;
        private string salary;
        private string exp;
        private string jdate;
        private string qual;
        private string job;
        private string fname;
        private string lname;
        private string email;
        private string cnic;
        private string address;
        private string gender;
        private string phone;
        private string dob;
        private string nationality;
        public Teacher(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            string query = "SELECT fname,lname,email,gender,cnic,address,dob,phone,nationality FROM Users WHERE id = '" + userid + "'";
            string query1 = "SELECT Teacher.type,qual,salary,experience,date FROM Users join Teacher on Users.id = Teacher.id WHERE Users.id = '" + userid + "'";
            using (SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.fname = reader.GetString(0);
                    this.lname = reader.GetString(1);
                    this.email = reader.GetString(2);
                    this.gender = reader.GetString(3);
                    this.cnic = reader.GetString(4);
                    this.address = reader.GetString(5);
                    this.dob = reader.GetString(6);
                    this.phone = reader.GetString(7);
                    this.nationality = reader.GetString(8);
                }
                reader.Close();

                SqlCommand cmd1 = new SqlCommand(query1, connection);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    this.qual = reader1.GetString(1);
                    this.job = reader1.GetString(0);
                    this.salary = (reader1.GetInt32(2)).ToString();
                    this.exp = (reader1.GetInt32(3)).ToString();
                    this.jdate = reader1.GetString(4);
                }
                reader1.Close();
            }

            userlabel1.Text = "Hello, " + this.fname + " " + this.lname;
            namelbl.Text = this.fname + " " + this.lname;
            rollnolbl.Text = this.userid;
            moblbl.Text = this.phone;
            emaillbl.Text = this.email;
            genderlbl.Text = this.gender;
            cniclbl.Text = this.cnic;
            nationalitylbl.Text = this.nationality;
            emaillbl.Text = this.email;
            doblbl.Text = this.dob;
            sallabel.Text = this.salary;
            explabel.Text = this.exp;
            quallabel.Text = this.qual;
            joindatelabel.Text = this.jdate;
            joblabel.Text = this.job;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes(this.userid);
            this.Hide();
            classes.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
