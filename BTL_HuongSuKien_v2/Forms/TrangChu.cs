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

        // openDanhSachPhongBan
        private void clickPhongBan(object sender, EventArgs e)
        {
            DanhSachPhongBan danhSachPhongBan = new DanhSachPhongBan();
            danhSachPhongBan.Show();
        }

        //open DanhSachLuong
        private void clickLuong(object sender, EventArgs e)
        {
            DanhSachLuong danhSachLuong = new DanhSachLuong();
            danhSachLuong.Show();
        }

        //open DanhSachHopDong
        private void clickHopDong(object sender, EventArgs e)
        {
            DanhSachHopDong danhSachHopDong = new DanhSachHopDong();
            danhSachHopDong.Show();
        }

        private void clickTimKiemNhanVienTheoTen(object sender, EventArgs e)
        {
            TimKiemNhanVienTheoTen timKiemNhanVienTheoTen = new TimKiemNhanVienTheoTen();
            timKiemNhanVienTheoTen.Show();
        }

        private void clickTimKiemNhanVienPhongBan(object sender, EventArgs e)
        {
            TimKiemNhanVienTheoPhongBan timKiemNhanVienTheoPhongBan = new TimKiemNhanVienTheoPhongBan();
            timKiemNhanVienTheoPhongBan.Show();
        }

        private void clickThongKeTheoTuoi(object sender, EventArgs e)
        {
            ThongKeNhanVienTheoTuoi thongKeNhanVienTheoTuoi = new ThongKeNhanVienTheoTuoi();
            thongKeNhanVienTheoTuoi.Show();
        }
    }
}
