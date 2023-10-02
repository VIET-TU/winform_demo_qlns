using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_C_
{
    public partial class MainForm : Form
    {
        public readonly USER u;

        public MainForm(USER u)
        {
            InitializeComponent();
            this.u = u;
            label_ten.Text = u.username;
            label_role.Text = u.role;
            label_title.Text = "Dashboard";
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_avatar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_title.Text = "Dashboard";
            dashboard1.Visible = true;
            employee1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label_ten_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_title.Text = "Nhân viên";
            dashboard1.Visible = false;
            employee1.Visible = true;

        }
    }
}
