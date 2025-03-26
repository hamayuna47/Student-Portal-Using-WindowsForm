using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Registration : Form
    {
        private string userid;
        public Registration(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(this.userid);
            this.Hide();
            student.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
