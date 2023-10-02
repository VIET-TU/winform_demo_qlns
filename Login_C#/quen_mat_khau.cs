using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_C_
{
    public partial class quen_mat_khau : Form
    {
        public quen_mat_khau()
        {
            InitializeComponent();
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == " ")
            {
                txtemail.Text = "Email";
                txtemail.ForeColor = Color.White;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Email")
            {
                txtemail.Text = " ";
                txtemail.ForeColor = Color.White;
            }
        }

        private void lbclose_Click(object sender, EventArgs e)
        {

            // DialogResult dr = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if (dr == DialogResult.Yes) {

            this.Close();
            //}
        }
    }
}
