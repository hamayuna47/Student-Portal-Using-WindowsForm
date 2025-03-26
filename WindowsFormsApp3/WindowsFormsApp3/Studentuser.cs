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
    public partial class Studentuser : Form
    {
        private string adminid;
        private string studentid;
        private string department;
        private string batch;
        private string section;
        private string degree;
        private string semester;
        public Studentuser(string studentid, string adminid)
        {
            InitializeComponent();
            this.studentid = studentid;
            this.adminid = adminid;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Studentuser_Load(object sender, EventArgs e)
        {

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            this.department = departmentbox.Text;
            this.batch = batchbox.Text;
            this.section = sectionbox.Text;
            this.degree = degreebox.Text;
            this.semester = semesterbox.Text;
            string connection = "Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True";
            string query = "INSERT INTO Student(id,department,degree,batch,section,semester) VALUES ('" + this.studentid + "','" + this.department + "','" + this.degree + "','" + this.batch + "','"
                + this.section + "','" + this.semester + "')";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }
            MessageBox.Show("Succesfully added Student");

            Admin admin = new Admin(this.adminid);
            this.Hide();
            admin.Show();
        }
    }
}
