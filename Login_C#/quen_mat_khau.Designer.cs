namespace Login_C_
{
    partial class quen_mat_khau
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
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btnlaylaimatkhau = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbclose = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.btnlaylaimatkhau);
            this.pnLogin.Controls.Add(this.txtemail);
            this.pnLogin.Controls.Add(this.pictureBox7);
            this.pnLogin.Controls.Add(this.label10);
            this.pnLogin.Controls.Add(this.label6);
            this.pnLogin.Controls.Add(this.label8);
            this.pnLogin.Controls.Add(this.lbclose);
            this.pnLogin.Controls.Add(this.pictureBox6);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnLogin.Location = new System.Drawing.Point(530, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(270, 450);
            this.pnLogin.TabIndex = 3;
            // 
            // btnlaylaimatkhau
            // 
            this.btnlaylaimatkhau.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlaylaimatkhau.FlatAppearance.BorderSize = 2;
            this.btnlaylaimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlaylaimatkhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaylaimatkhau.ForeColor = System.Drawing.Color.White;
            this.btnlaylaimatkhau.Location = new System.Drawing.Point(14, 322);
            this.btnlaylaimatkhau.Name = "btnlaylaimatkhau";
            this.btnlaylaimatkhau.Size = new System.Drawing.Size(241, 46);
            this.btnlaylaimatkhau.TabIndex = 6;
            this.btnlaylaimatkhau.Text = "Lấy lại mật khẩu";
            this.btnlaylaimatkhau.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(60, 209);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(176, 20);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "Email";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Login_C_.Properties.Resources.gmail_icon;
            this.pictureBox7.Location = new System.Drawing.Point(14, 209);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(57, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 1);
            this.label10.TabIndex = 2;
            this.label10.Text = "label2";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(180, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 3);
            this.label6.TabIndex = 2;
            this.label6.Text = "label2";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 3);
            this.label8.TabIndex = 2;
            this.label8.Text = "label2";
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclose.ForeColor = System.Drawing.Color.DimGray;
            this.lbclose.Location = new System.Drawing.Point(240, 5);
            this.lbclose.Name = "lbclose";
            this.lbclose.Size = new System.Drawing.Size(23, 22);
            this.lbclose.TabIndex = 1;
            this.lbclose.Text = "X";
            this.lbclose.Click += new System.EventHandler(this.lbclose_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Login_C_.Properties.Resources.istockphoto_1300845620_612x612;
            this.pictureBox6.Location = new System.Drawing.Point(114, 77);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu: ";
            // 
            // quen_mat_khau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_C_.Properties.Resources.istockphoto_1136823774_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quen_mat_khau";
            this.Text = "quen_mat_khau";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Button btnlaylaimatkhau;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbclose;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
    }
}