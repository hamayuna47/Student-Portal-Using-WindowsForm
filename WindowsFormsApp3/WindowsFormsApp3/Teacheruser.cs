using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Teacheruser : Form
    {
        private string adminid;
        private string teacherid;
        private string type;
        private string qualification;
        private string salary;
        private string exp;
        private string date;
        public Teacheruser(string teacherid, string adminid)
        {
            InitializeComponent();
            this.teacherid = teacherid;
            this.adminid = adminid;
        }

        private void Teacheruser_Load(object sender, EventArgs e)
        {
            
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            this.type = typebox.Text;
            this.qualification = qualificationbox.Text;
            this.salary = salarybox.Text;
            this.exp = expbox.Text;
            this.date = datebox.Text;
            string connection = "Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True";
            string query = "INSERT INTO Teacher(id,type,qual,salary,experience,date) VALUES ('"+this.teacherid + "','" + this.type + "','" + this.qualification + "','" + this.salary + "','"
                + this.exp + "','" + this.date + "')";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }
            MessageBox.Show("Succesfully added Teacher");
            Admin admin = new Admin(this.adminid);
            this.Hide();
            admin.Show();
        }
    }
}
