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
    public partial class dang_ki : Form
    {
        public dang_ki()
        {
            InitializeComponent();
        }



        private void btnregisterchange_Click(object sender, EventArgs e)
        {
            // DialogResult dr = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if (dr == DialogResult.Yes) {

            this.Close();
            //}
        }

        private void txtnamechange_Enter(object sender, EventArgs e)
        {
            if (txtnamechange.Text == "User name")
            {
                txtnamechange.Text = " ";
                txtnamechange.ForeColor = Color.White;
            }
        }

        private void txtnamechange_Leave(object sender, EventArgs e)
        {
            if (txtnamechange.Text == " ")
            {
                txtnamechange.Text = "User name";
                txtnamechange.ForeColor = Color.White;
            }
        }

        private void txtpasschange_Leave(object sender, EventArgs e)
        {
            if (txtpasschange.Text == " ")
            {
                txtpasschange.Text = "Password";
                txtpasschange.ForeColor = Color.White;
            }
        }

        private void txtpasschange_Enter(object sender, EventArgs e)
        {
            if (txtpasschange.Text == "Password")
            {
                txtpasschange.Text = " ";
                txtpasschange.ForeColor = Color.White;
            }
        }

        private void txtconfirm_Leave(object sender, EventArgs e)
        {
            if (txtconfirm.Text == " ")
            {
                txtconfirm.Text = "Password";
                txtconfirm.ForeColor = Color.White;
            }
        }

        private void txtconfirm_Enter(object sender, EventArgs e)
        {
            if (txtconfirm.Text == "Confirm Password")
            {
                txtconfirm.Text = " ";
                txtconfirm.ForeColor = Color.White;
            }
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
    }
}

     