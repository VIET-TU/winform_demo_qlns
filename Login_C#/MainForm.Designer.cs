namespace Login_C_
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_leftmenu = new System.Windows.Forms.Panel();
            this.button_dang_xuat = new System.Windows.Forms.Button();
            this.button_dmk = new System.Windows.Forms.Button();
            this.button_ho_so = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.label_role = new System.Windows.Forms.Label();
            this.label_ten = new System.Windows.Forms.Label();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_tai_khoan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.employee1 = new Login_C_.Employee();
            this.dashboard1 = new Login_C_.Dashboard();
            this.panel_leftmenu.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_leftmenu
            // 
            this.panel_leftmenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_leftmenu.Controls.Add(this.button_dang_xuat);
            this.panel_leftmenu.Controls.Add(this.button_dmk);
            this.panel_leftmenu.Controls.Add(this.button_ho_so);
            this.panel_leftmenu.Controls.Add(this.button_tai_khoan);
            this.panel_leftmenu.Controls.Add(this.button2);
            this.panel_leftmenu.Controls.Add(this.button_dashboard);
            this.panel_leftmenu.Controls.Add(this.pictureBox1);
            this.panel_leftmenu.Controls.Add(this.label_role);
            this.panel_leftmenu.Controls.Add(this.label_ten);
            this.panel_leftmenu.Controls.Add(this.pictureBox_avatar);
            this.panel_leftmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftmenu.Location = new System.Drawing.Point(0, 0);
            this.panel_leftmenu.Name = "panel_leftmenu";
            this.panel_leftmenu.Size = new System.Drawing.Size(281, 752);
            this.panel_leftmenu.TabIndex = 0;
            // 
            // button_dang_xuat
            // 
            this.button_dang_xuat.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_dang_xuat.FlatAppearance.BorderSize = 0;
            this.button_dang_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dang_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dang_xuat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_dang_xuat.Location = new System.Drawing.Point(11, 519);
            this.button_dang_xuat.Name = "button_dang_xuat";
            this.button_dang_xuat.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_dang_xuat.Size = new System.Drawing.Size(253, 55);
            this.button_dang_xuat.TabIndex = 10;
            this.button_dang_xuat.Text = "Đăng xuất";
            this.button_dang_xuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dang_xuat.UseVisualStyleBackColor = false;
            // 
            // button_dmk
            // 
            this.button_dmk.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_dmk.FlatAppearance.BorderSize = 0;
            this.button_dmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dmk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_dmk.Location = new System.Drawing.Point(11, 458);
            this.button_dmk.Name = "button_dmk";
            this.button_dmk.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_dmk.Size = new System.Drawing.Size(253, 55);
            this.button_dmk.TabIndex = 9;
            this.button_dmk.Text = "Đổi mật khẩu";
            this.button_dmk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dmk.UseVisualStyleBackColor = false;
            // 
            // button_ho_so
            // 
            this.button_ho_so.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_ho_so.FlatAppearance.BorderSize = 0;
            this.button_ho_so.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ho_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ho_so.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ho_so.Location = new System.Drawing.Point(11, 397);
            this.button_ho_so.Name = "button_ho_so";
            this.button_ho_so.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_ho_so.Size = new System.Drawing.Size(253, 55);
            this.button_ho_so.TabIndex = 8;
            this.button_ho_so.Text = "Hồ sơ";
            this.button_ho_so.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ho_so.UseVisualStyleBackColor = false;
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_dashboard.FlatAppearance.BorderSize = 0;
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_dashboard.Location = new System.Drawing.Point(11, 214);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_dashboard.Size = new System.Drawing.Size(253, 55);
            this.button_dashboard.TabIndex = 2;
            this.button_dashboard.Text = "dashboard";
            this.button_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dashboard.UseVisualStyleBackColor = false;
            this.button_dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Location = new System.Drawing.Point(128, 68);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(61, 23);
            this.label_role.TabIndex = 4;
            this.label_role.Text = "admin";
            // 
            // label_ten
            // 
            this.label_ten.AutoSize = true;
            this.label_ten.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ten.Location = new System.Drawing.Point(128, 30);
            this.label_ten.Name = "label_ten";
            this.label_ten.Size = new System.Drawing.Size(105, 27);
            this.label_ten.TabIndex = 3;
            this.label_ten.Text = "username";
            this.label_ten.Click += new System.EventHandler(this.label_ten_Click);
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_nav.Controls.Add(this.pictureBox2);
            this.panel_nav.Controls.Add(this.label_title);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_nav.Location = new System.Drawing.Point(281, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(1002, 57);
            this.panel_nav.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(78, 11);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(51, 27);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Title";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dashboard1);
            this.panel1.Controls.Add(this.employee1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(281, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 695);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_tai_khoan
            // 
            this.button_tai_khoan.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_tai_khoan.FlatAppearance.BorderSize = 0;
            this.button_tai_khoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tai_khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tai_khoan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_tai_khoan.Image = ((System.Drawing.Image)(resources.GetObject("button_tai_khoan.Image")));
            this.button_tai_khoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_tai_khoan.Location = new System.Drawing.Point(11, 336);
            this.button_tai_khoan.Name = "button_tai_khoan";
            this.button_tai_khoan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_tai_khoan.Size = new System.Drawing.Size(253, 55);
            this.button_tai_khoan.TabIndex = 7;
            this.button_tai_khoan.Text = "Tài khoản";
            this.button_tai_khoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_tai_khoan.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(11, 275);
            this.button2.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(253, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Nhân viên";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_avatar.Image")));
            this.pictureBox_avatar.Location = new System.Drawing.Point(12, 28);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(92, 78);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_avatar.TabIndex = 2;
            this.pictureBox_avatar.TabStop = false;
            this.pictureBox_avatar.Click += new System.EventHandler(this.pictureBox_avatar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // employee1
            // 
            this.employee1.Location = new System.Drawing.Point(0, -3);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(1002, 695);
            this.employee1.TabIndex = 0;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(-3, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1002, 695);
            this.dashboard1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1283, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_leftmenu);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel_leftmenu.ResumeLayout(false);
            this.panel_leftmenu.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.panel_nav.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_leftmenu;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.Label label_ten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_tai_khoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_dang_xuat;
        private System.Windows.Forms.Button button_dmk;
        private System.Windows.Forms.Button button_ho_so;
        private System.Windows.Forms.Panel panel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private Employee employee1;
        private Dashboard dashboard1;
    }
}