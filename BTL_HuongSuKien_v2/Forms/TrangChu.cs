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

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien danhSachNhanVien = new DanhSachNhanVien();
            danhSachNhanVien.MdiParent = this;
            danhSachNhanVien.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachPhongBan danhSachPhongBan = new DanhSachPhongBan();
             danhSachPhongBan.MdiParent = this;
            danhSachPhongBan.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachChucVu danhSachChucVu = new DanhSachChucVu();
             danhSachChucVu.MdiParent = this;
            danhSachChucVu.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachHopDong danhSachHopDong = new DanhSachHopDong();
            danhSachHopDong.MdiParent = this;
            danhSachHopDong.Show();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachLuong danhSachLuong = new DanhSachLuong();
            danhSachLuong.MdiParent = this;
            danhSachLuong.Show();
        }

        private void thờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThoiGian danhSachThoiGian = new DanhSachThoiGian();
            danhSachThoiGian.MdiParent = this;
            danhSachThoiGian.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nhânViênTheoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemNhanVienTheoTen danhSachTheoTen = new TimKiemNhanVienTheoTen();
            danhSachTheoTen.MdiParent = this;
            danhSachTheoTen.Show();
        }

        private void nhânViênTheoPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemNhanVienTheoPhongBan danhSachPhongBan = new TimKiemNhanVienTheoPhongBan();
            danhSachPhongBan.MdiParent = this;
            danhSachPhongBan.Show();
        }

        private void nhânViênTheoChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemNhanVienTheoChucVu danhSachPhongBan = new TimKiemNhanVienTheoChucVu();
            danhSachPhongBan.MdiParent = this;
            danhSachPhongBan.Show();
        }

        private void nhânViênTheoPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
            }
        }
    }
}
