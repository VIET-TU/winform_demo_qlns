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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            List<GIOI_TINH> gts = Connection.db.GIOI_TINH.ToList();

            gts.ForEach(g =>
            {
                comboBox_gt.Items.Add(g.ma_gioi_tinh + " (" + g.ten_gioi_tinh + ")");
            });

            List<CHUC_VU> cvs = Connection.db.CHUC_VU.ToList();

            cvs.ForEach(g =>
            {
                comboBox_cv.Items.Add(g.ma_chuc_vu + " (" + g.ten_chuc_vu + ")");
            });

            List<DAN_TOC> dts = Connection.db.DAN_TOC.ToList();

            dts.ForEach(g =>
            {
                comboBox_dt.Items.Add(g.ma_dan_toc + " (" + g.ten_dan_toc + ")");
            });


            List<TON_GIAO> tgs = Connection.db.TON_GIAO.ToList();

            tgs.ForEach(g =>
            {
                comboBox_tg.Items.Add(g.ma_ton_giao + " (" + g.ten_ton_giao + ")");
            });


            List<NOI_SINH> nss = Connection.db.NOI_SINH.ToList();

            nss.ForEach(g =>
            {
                comboBox_ns.Items.Add(g.ma_noi_sinh + " (" + g.ten_noi_sinh + ")");
            });

            List<PHONG_BAN> pbs = Connection.db.PHONG_BAN.ToList();

            pbs.ForEach(g =>
            {
                comboBox_pb.Items.Add(g.ma_phong_ban + " (" + g.ten_phong_ban + ")");
            });

            List<HOC_VAN> hvs = Connection.db.HOC_VAN.ToList();

            hvs.ForEach(g =>
            {
                comboBox_hv.Items.Add(g.ma_hoc_van + " (" + g.ten_hoc_van + ")");
            });

            List<CHUYEN_MON> cms = Connection.db.CHUYEN_MON.ToList();

            cms.ForEach(g =>
            {
                comboBox_cm.Items.Add(g.ma_chuyen_mon + " (" + g.ma_chuyen_mon + ")");
            });



        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_hsnv_Enter(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {

        }
    }
}
