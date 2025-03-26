using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Student : Form
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
       
        public Student(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            string query = "SELECT fname,lname,email,gender,cnic,address,dob,phone,nationality FROM Users WHERE id = '" + userid + "'";
            string query1 = "SELECT section,degree,batch,semester FROM Users join Student on Users.id = Student.id WHERE Users.id = '" + userid + "'";
            using (SqlConnection connection =  new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True"))
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
                    this.degree = reader1.GetString(1);
                    this.section = reader1.GetString(0);
                    this.batch = reader1.GetString(2);
                    this.semester = reader1.GetInt32(3);
                }
                reader1.Close();
            }

            userlabel1.Text = "Hello, " + this.fname +" "+ this.lname;
            namelbl.Text = this.fname + " "+ this.lname;
            rollnolbl.Text = this.userid;
            moblbl.Text = this.phone;
            emaillbl.Text = this.email;
            genderlbl.Text = this.gender;
            cniclbl.Text = this.cnic;
            nationalitylbl.Text = this.nationality;
            emaillbl.Text = this.email;
            doblbl.Text = this.dob;
            degreelabel.Text = this.degree;
            seclabel.Text = this.section;
            batchlabel.Text = this.batch;
            campuslabel.Text = "Islamabad";
            semlabel.Text = this.semester.ToString();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance(this.userid);
            this.Hide();
            attendance.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Marks marks = new Marks(this.userid);
            this.Hide();
            marks.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transcript trans = new Transcript(this.userid);
            this.Hide();
            trans.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feedback cr = new Feedback(this.userid);
            this.Hide();
            cr.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeluserid_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
