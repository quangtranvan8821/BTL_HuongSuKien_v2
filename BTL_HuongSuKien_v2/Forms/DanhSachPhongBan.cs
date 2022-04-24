using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HuongSuKien_v2.Forms
{
    public partial class DanhSachPhongBan : Form
    {
        public DanhSachPhongBan()
        {
            InitializeComponent();
        }

        //close form
        private void clickQuayLai(object sender, EventArgs e)
        {
            Close();
        }

        private void DanhSachPhongBan_Load(object sender, EventArgs e)
        {
            load_dataGridViewPhongBan();
            Init_dsPhongban();
        }
        public void load_dataGridViewPhongBan()
        {
            ConnectDatabase.ConnectDatabase dt = new ConnectDatabase.ConnectDatabase();
            string getdata = "select * from DanhSachPhongBan";
            dataGridViewPhongBan.DataSource = dt.getTable(getdata);
        }
        private void Init_dsPhongban()
        {
            ConnectDatabase.ConnectDatabase db = new ConnectDatabase.ConnectDatabase();
            DataTable tb = db.getTable("select ten_phong_ban from phong_ban");
            comboBoxTenPhongBan.DataSource = tb;
            comboBoxTenPhongBan.DisplayMember = "ten_phong_ban";
            comboBoxTenPhongBan.ValueMember = "ten_phong_ban";
        }

        private void DanhSachPhongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
