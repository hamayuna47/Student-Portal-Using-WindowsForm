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
    public partial class Deleteuser : Form
    {
        private string userid;
        private string type;
        public Deleteuser(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            
            string query1 = "UPDATE Users SET password = '9999' WHERE id = '" + useridbox.Text + "'";

            connection.Open();
            SqlCommand cmd1 = new SqlCommand(query1,connection);
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            connection.Close() ;
           

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.userid);
            this.Hide();
            admin.Show();
        }

        private void Deleteuser_Load(object sender, EventArgs e)
        {

        }
    }
}
