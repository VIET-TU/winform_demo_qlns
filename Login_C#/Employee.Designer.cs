namespace Login_C_
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.button_add_nv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView_employee.Location = new System.Drawing.Point(0, 59);
            this.dataGridView_employee.MultiSelect = false;
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.ReadOnly = true;
            this.dataGridView_employee.RowHeadersWidth = 51;
            this.dataGridView_employee.RowTemplate.Height = 24;
            this.dataGridView_employee.Size = new System.Drawing.Size(1002, 635);
            this.dataGridView_employee.TabIndex = 0;
            this.dataGridView_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_add_nv
            // 
            this.button_add_nv.BackColor = System.Drawing.Color.Transparent;
            this.button_add_nv.FlatAppearance.BorderSize = 0;
            this.button_add_nv.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_nv.ForeColor = System.Drawing.Color.White;
            this.button_add_nv.Image = ((System.Drawing.Image)(resources.GetObject("button_add_nv.Image")));
            this.button_add_nv.Location = new System.Drawing.Point(927, 13);
            this.button_add_nv.Name = "button_add_nv";
            this.button_add_nv.Size = new System.Drawing.Size(55, 40);
            this.button_add_nv.TabIndex = 1;
            this.button_add_nv.UseVisualStyleBackColor = false;
            this.button_add_nv.Click += new System.EventHandler(this.button_add_nv_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_add_nv);
            this.Controls.Add(this.dataGridView_employee);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1005, 697);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_employee;
        private System.Windows.Forms.Button button_add_nv;
    }
}
