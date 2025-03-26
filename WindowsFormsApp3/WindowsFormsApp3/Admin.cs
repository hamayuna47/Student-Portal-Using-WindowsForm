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

namespace WindowsFormsApp3
{
    
    public partial class Admin : Form
    {
        private string userid;
        private string fname;
        private string lname;
        private string dob;
        private string cnic;
        private string email;
        private string nationality;
        private string phone;
        private string section;
        private string campus;
        private string batch;
        private int semester;
        private string gender;
        private string address;
        private string degree;
        public Admin(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            string query = "SELECT fname,lname,email,gender,cnic,address,dob,phone,nationality FROM Users WHERE id = '" + userid + "'";
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
                namelbl.Text = this.fname + " "+ this.lname;
                emaillbl.Text = this.email;
                genderlbl.Text = this.gender;
                cniclbl.Text = this.cnic;
                nationalitylbl.Text = this.nationality;
                emaillbl.Text = this.email;
                doblbl.Text = this.dob;
                moblbl.Text = this.phone;
                userlabel1.Text = "Welcome Admin # " + this.userid;
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adduser adduser = new Adduser(userid);
            this.Hide();
            adduser.Show();
        }

        private void deleteuser_Click(object sender, EventArgs e)
        {
            Deleteuser delete = new Deleteuser(userid);
            this.Hide();
            delete.Show();
        }

        private void edituser_Click(object sender, EventArgs e)
        {
            Adminfeedback feedback = new Adminfeedback(this.userid);
            this.Hide();
            feedback.Show();
        }
    }
}
