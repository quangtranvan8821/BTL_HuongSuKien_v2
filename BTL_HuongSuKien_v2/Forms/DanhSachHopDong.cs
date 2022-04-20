using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HuongSuKien_v2.Forms
{
    public partial class DanhSachHopDong : Form
    {
        public DanhSachHopDong()
        {
            InitializeComponent();
        }

        //close form
        private void clickQuayLai(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                int ma = int.Parse(dataGridViewHopDong.CurrentRow.Cells["Mã hợp đồng"].Value.ToString());
                string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"XoaHopDong";
                cmd.Parameters.AddWithValue("@id", ma);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    load_dataGridViewHopDong();
                    MessageBox.Show("Xóa hợp đồng thành công");
                }
                else MessageBox.Show("Xóa hợp đồng không thành công");
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                int ma = int.Parse(dataGridViewHopDong.CurrentRow.Cells["Mã hợp đồng"].Value.ToString());
                string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"SuaHopDong";
                cmd.Parameters.AddWithValue("@id", ma);
                cmd.Parameters.AddWithValue("@loai_hop_dong", textBoxLoaiHopDong.Text);
                cmd.Parameters.AddWithValue("@id_nhan_vien", connectDatabase.ExcuteScalar("select id from nhan_vien where ten_nhan_vien='"+textBoxTenNhanVien.Text+"'"));
                cmd.Parameters.AddWithValue("@Ngay_bat_dau", dateTimePickerNgayBatDau.Text);
                cmd.Parameters.AddWithValue("@ngay_ket_thuc",dateTimePickerNgayKetThuc.Text);
                cmd.Parameters.AddWithValue("@don_gia_ngay_cong", textBoxDonGiaNgayCong.Text);

                /*
                                @id int,
                                @loai_hop_dong NVARCHAR(50),
                    @id_nhan_vien int,
                    @ngay_bat_dau date,
                    @ngay_ket_thuc date,
                    @don_gia_ngay_cong int*/
                int i = cmd.ExecuteNonQuery();
                if (i > 0 && checkNgayBatDauvsNgayKetThuc(Convert.ToDateTime(dateTimePickerNgayBatDau.Text),Convert.ToDateTime(dateTimePickerNgayKetThuc.Text )))
                {
                    load_dataGridViewHopDong();
                    MessageBox.Show("Sửa hợp đồng thành công");
                }
                else MessageBox.Show("Sửa hợp đồng không thành công");
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            try
            {
                check = check | checkTextBoxBlank(textBoxTenNhanVien);
                check = check | checkTextBoxBlank(textBoxLoaiHopDong);
                check = check | checkTextBoxBlank(textBoxDonGiaNgayCong);
                check = check | !checkNgayBatDauvsNgayKetThuc(Convert.ToDateTime(dateTimePickerNgayBatDau.Text),Convert.ToDateTime(dateTimePickerNgayKetThuc.Text));

                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                if (check == false)
                {
                    //chinhr connectstring
                    string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                    SqlConnection cnt = new SqlConnection(cont);
                    cnt.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnt;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"ThemHopDong";

                    cmd.Parameters.AddWithValue("@loai_hop_dong", textBoxLoaiHopDong.Text);
                    cmd.Parameters.AddWithValue("@id_nhan_vien", connectDatabase.ExcuteScalar("select id from nhan_vien where ten_nhan_vien='"+textBoxTenNhanVien.Text+"'"));
                    cmd.Parameters.AddWithValue("@ngay_bat_dau", dateTimePickerNgayBatDau.Text);
                    cmd.Parameters.AddWithValue("@ngay_ket_thuc", dateTimePickerNgayKetThuc.Text);
                    cmd.Parameters.AddWithValue("@don_gia_ngay_cong", textBoxDonGiaNgayCong.Text);

                    /* @loai_hop_dong NVARCHAR(50),
     @id_nhan_vien int,
     @ngay_bat_dau date,
     @ngay_ket_thuc date,
     @don_gia_ngay_cong int*/
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm hợp đồng thành công");
                        load_dataGridViewHopDong();
                    }
                    else
                        MessageBox.Show("Thêm hợp đồng không thành công");
                    cnt.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, nhập thiếu nội dung hoặc nhập dữ liệu bị trùng!");
                }
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }
        public bool checkNgayBatDauvsNgayKetThuc(DateTime NgayBatDau , DateTime NgayKetThuc)
        {
            if (NgayBatDau>=NgayKetThuc)
            {
                errorProvider1.SetError(dateTimePickerNgayBatDau, "Ngày bắt đầu nhỏ hơn ngày kết thúc!");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        public bool checkTextBoxBlank(TextBox txtbox)
        {
            if (txtbox.Text == "")
            {
                errorProvider1.SetError(txtbox, "Chưa nhập dữ liệu!");
                return true;
            }
            else
            {
                errorProvider1.Clear();
                return false;
            }
        }

        private void DanhSachHopDong_Load(object sender, EventArgs e)
        {
            load_dataGridViewHopDong();
        }
        public void load_dataGridViewHopDong()
        {
            ConnectDatabase.ConnectDatabase dt = new ConnectDatabase.ConnectDatabase();
            string getdata = "select * from DanhSachHopDong ";
            dataGridViewHopDong.DataSource = dt.getTable(getdata);
        }

        private void dataGridViewHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTenNhanVien.Text = dataGridViewHopDong.CurrentRow.Cells["Họ tên"].Value.ToString();
            textBoxLoaiHopDong.Text = dataGridViewHopDong.CurrentRow.Cells["Loại hợp đồng"].Value.ToString();
            textBoxDonGiaNgayCong.Text = dataGridViewHopDong.CurrentRow.Cells["Lương ngày"].Value.ToString();
            dateTimePickerNgayBatDau.Text = dataGridViewHopDong.CurrentRow.Cells["Ngày bắt đầu"].Value.ToString();
            dateTimePickerNgayKetThuc.Text = dataGridViewHopDong.CurrentRow.Cells["Ngày kết thúc"].Value.ToString();

        }
    }
}
