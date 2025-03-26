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
    public partial class Adminfeedback : Form
    {
        private string userid;
        public Adminfeedback(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            SqlConnection connection = new SqlConnection("Data Source=HAANIKHAN\\SQLEXPRESS;Initial Catalog=flex;Integrated Security=True");
            string query = "SELECT name as Name,score as Score, grade as Grade, comments as Comments FROM Feedback";
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

        private void Adminfeedback_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.userid);
            this.Close();
            admin.Show();
        }
    }
}
