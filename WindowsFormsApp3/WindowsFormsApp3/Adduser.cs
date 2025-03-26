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
    public partial class Adduser : Form
    {
        private string id;
        private string userid;
        private string password;
        private string fname;
        private string lname;
        private string nationality;
        private string gender;
        private string cnic;
        private string phoneno;
        private string dob;
        private string address;
        private string email;
        private string type;

        public Adduser(string id)
        {
            InitializeComponent();
            this.id = id;
            

        }

        private void Adduser_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.id);
            this.Hide();
            admin.Show();

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            this.userid = useridbox.Text;
            this.password = passbox.Text;
            this.fname = fnamebox.Text;
            this.lname = lnamebox.Text;
            this.nationality = nationalitybox.Text;
            this.gender = genderbox.Text;
            this.cnic = cnicbox.Text;
            this.phoneno = phonebox.Text;
            this.dob = dobbox.Text;
            this.address = addressbox.Text;
            this.email = emailbox.Text;
            this.type = typebox.Text;
            string connection = "Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True";
            string query = "INSERT INTO Users(id,password,nationality,email,gender,cnic,address,dob,phone,fname,lname,type) VALUES ('"+this.userid +"','" + this.password+ "','" + this.nationality + "','" 
                +this.email+ "','"+this.gender+"','"+this.cnic+"','"+this.address+"','"+this.dob+"','"+this.phoneno + "','" +this.fname + "','" +this.lname +"','" +this.type + "')" ;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd= new SqlCommand(query,conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }
            if (this.type == "Admin")
            {
                MessageBox.Show("Succesfully added admin");
                Admin admin = new Admin(this.id);
                this.Hide();
                admin.Show();
               
            }
            else if(this.type == "Student")
            {
                Studentuser addstd = new Studentuser(this.userid,this.id);
                this.Hide();
                addstd.Show();
            }
            else
            {
                Teacheruser addteacher = new Teacheruser(this.userid,this.id);
                this.Hide();
                addteacher.Show();
            }
        }
    }
}
