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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }


        //open NhanVien form
        private void clickNhanVien(object sender, EventArgs e)
        {
            DanhSachNhanVien danhSachNhanVien = new DanhSachNhanVien();
            danhSachNhanVien.Show();
        }

        private void clickPhongBan(object sender, EventArgs e)
        {
            DanhSachPhongBan danhSachPhongBan = new DanhSachPhongBan();
            danhSachPhongBan.Show();
        }
    }
}
