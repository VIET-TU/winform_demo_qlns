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
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
                  dataGridView_employee.DataSource = Connection.db.HSNVs.ToList(
                        
                      );


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void button_add_nv_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }
    }
}
