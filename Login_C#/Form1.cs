
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
    public partial class dang_nhap : Form
    {
 
        public dang_nhap()
        {
            InitializeComponent();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == " ")
            {
                txtusername.Text = "User name";
                txtusername.ForeColor = Color.White;
            }
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "User name")
            {
                txtusername.Text = " ";
                txtusername.ForeColor = Color.White;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password"|| txtpassword.Text=="*")
            {
                txtpassword.Text = " ";
                txtpassword.ForeColor = Color.White;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == " ")
            {
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.White;
            }
        }

        private void pictureye_off_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                pictureye_off.BringToFront();
                txtpassword.PasswordChar = '\0';
                pictureye_off.Hide();
                pictureye.Show();
            }
        }

        private void pictureye_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                pictureye.BringToFront();
                txtpassword.PasswordChar = '*';
                pictureye.Hide();
                pictureye_off.Show();
            }
        }

        private void lbclose_Click(object sender, EventArgs e)
        {
            // DialogResult dr = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if (dr == DialogResult.Yes) {

            this.Close();
            //}
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            dang_ki dang_Ki = new dang_ki();
            dang_Ki.ShowDialog();
        }

        private void lbquen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quen_mat_khau quen_Mat_Khau = new quen_mat_khau();
            quen_Mat_Khau.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (txtusername.Text.Trim().Length == 0 || txtusername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
            USER eixtUser = Connection.db.USERS.First(u => u.username == txtusername.Text.Trim());
                if (eixtUser != null)
                {
                    if (eixtUser.password == txtpassword.Text)
                    {
                        MainForm mainForm = new MainForm(eixtUser);
                        mainForm.Show();
                        this.Hide();
                        return;

                    }
                }

                MessageBox.Show("User hoặc password không đúng", "Login failse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

             } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error message",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void dang_nhap_Load(object sender, EventArgs e)
        {

        }
    }
}
