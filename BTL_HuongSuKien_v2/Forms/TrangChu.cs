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
            /*danhSachNhanVien.MdiParent = this;*/
            danhSachNhanVien.Show();


        }

        // openDanhSachPhongBan
        private void clickPhongBan(object sender, EventArgs e)
        {
            DanhSachPhongBan  danhSachPhongBan = new DanhSachPhongBan();
           // danhSachPhongBan.MdiParent = this;
            danhSachPhongBan.Show();
        }

        //open DanhSachLuong
        private void clickLuong(object sender, EventArgs e)
        {
            DanhSachLuong danhSachLuong = new DanhSachLuong();
           // danhSachLuong.MdiParent = this;
            danhSachLuong.Show();
        }

        //open DanhSachHopDong
        private void clickHopDong(object sender, EventArgs e)
        {
            DanhSachHopDong danhSachHopDong = new DanhSachHopDong();
          //  danhSachHopDong.MdiParent = this;
            danhSachHopDong.Show();
        }

        private void clickTimKiemNhanVienTheoTen(object sender, EventArgs e)
        {
            TimKiemNhanVienTheoTen timKiemNhanVienTheoTen = new TimKiemNhanVienTheoTen();
           // timKiemNhanVienTheoTen.MdiParent = this;
            timKiemNhanVienTheoTen.Show();
        }

        private void clickTimKiemNhanVienPhongBan(object sender, EventArgs e)
        {
            TimKiemNhanVienTheoPhongBan timKiemNhanVienTheoPhongBan = new TimKiemNhanVienTheoPhongBan();
           // timKiemNhanVienTheoPhongBan.MdiParent = this;
            timKiemNhanVienTheoPhongBan.Show();
        }

        private void clickThongKeTheoTuoi(object sender, EventArgs e)
        {
            ThongKeNhanVienTheoTuoi thongKeNhanVienTheoTuoi = new ThongKeNhanVienTheoTuoi();
          //  thongKeNhanVienTheoTuoi.MdiParent = this;
            thongKeNhanVienTheoTuoi.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachChucVu danhSachChucVu = new DanhSachChucVu();
/*            danhSachChucVu.MdiParent = this;*/
            danhSachChucVu.Show();
        }

        private void thờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThoiGian danhSachThoiGian = new DanhSachThoiGian();
            /*danhSachThoiGian.MdiParent = this;*/
            danhSachThoiGian.Show();
            
        }
    }
}
