using BTL_HuongSuKien_v2.ConnectDatabase;
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
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        //close form
        private void clickQuayLai(object sender, EventArgs e)
        {
            Close();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            load_dgvNhanvien();
            Init_dsChucvu();
            Init_dsPhongban();
        }
        public void load_dgvNhanvien()
        {
            ConnectDatabase.ConnectDatabase dt = new ConnectDatabase.ConnectDatabase();
            string getdata = "select * from DanhSachNhanVien";
            dataGridViewNhanVien.DataSource = dt.getTable(getdata);
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTenNhanVien.Text = dataGridViewNhanVien.CurrentRow.Cells["Họ tên"].Value.ToString();
            // int idPhongBan = cbPhongBan.SelectedIndex + 1;
            comboBoxTenChucVu.Text = dataGridViewNhanVien.CurrentRow.Cells["Tên chức vụ"].Value.ToString();
            comboBoxTenPhongBan.Text = dataGridViewNhanVien.CurrentRow.Cells["Tên phòng ban"].Value.ToString();
            textBoxDiaChi.Text = dataGridViewNhanVien.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            dateTimePickerNgaySinh.Text = Convert.ToDateTime(dataGridViewNhanVien.CurrentRow.Cells["Ngày sinh"].Value).ToShortDateString();
            textBoxSDT.Text = dataGridViewNhanVien.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            string gioiTinh = dataGridViewNhanVien.CurrentRow.Cells["Giới tính"].Value.ToString();
            if (gioiTinh == radioButtonNam.Text)
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
        }

        private void Init_dsPhongban()
        {
            ConnectDatabase.ConnectDatabase db = new ConnectDatabase.ConnectDatabase();
            DataTable tb = db.getTable("select ten_phong_ban from phong_ban");
            comboBoxTenPhongBan.DataSource = tb;
            comboBoxTenPhongBan.DisplayMember = "ten_phong_ban";
            comboBoxTenPhongBan.ValueMember = "ten_phong_ban";

            /*foreach (DataRow i in tb.Rows)
            {
                comboBoxTenPhongBan.Items.Add(i["ten_phong_ban"].ToString());
            }*/
            //comboBoxTenPhongBan.SelectedIndex = 0;
        }
        private void Init_dsChucvu()
        {
            ConnectDatabase.ConnectDatabase db = new ConnectDatabase.ConnectDatabase();
            DataTable tb = db.getTable("select ten_chuc_vu from chuc_vu");
            comboBoxTenChucVu.DataSource = tb;
            comboBoxTenChucVu.DisplayMember = "ten_chuc_vu";
            comboBoxTenChucVu.ValueMember = "ten_chuc_vu";
            /*foreach (DataRow i in tb.Rows)
            {
                comboBoxTenChucVu.Items.Add(i["ten_chuc_vu"].ToString());
            }*/
            //comboBoxTenChucVu.SelectedIndex = 0;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            try
            {
                check = check | checkTextBoxBlank(textBoxTenNhanVien);
                check = check | checkTextBoxBlank(textBoxDiaChi);
                check = check | checkTextBoxBlank(textBoxSDT);

                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                var idPhongBan = connectDatabase.ExcuteScalar("select id from phong_ban where ten_phong_ban = '"+comboBoxTenPhongBan.Text+"'" );
                var idChucVu = connectDatabase.ExcuteScalar("select id from chuc_vu where ten_chuc_vu = '" + comboBoxTenChucVu.Text + "'");

               // MessageBox.Show(idChucVu.ToString() + " " + idPhongBan.ToString());
                string gioiTinh = "";
                bool isChecked = radioButtonNam.Checked;
                if (isChecked)
                    gioiTinh = "Nam";
                else
                    gioiTinh = "Nu";

                if (check == false)
                {
                    //chinhr connectstring
                    string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                    SqlConnection cnt = new SqlConnection(cont);
                    cnt.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnt;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"themNhanVien";

                    cmd.Parameters.AddWithValue("@id_phong_ban", idPhongBan);
                    cmd.Parameters.AddWithValue("@id_chuc_vu", idChucVu);
                    cmd.Parameters.AddWithValue("@hoten", textBoxTenNhanVien.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", dateTimePickerNgaySinh.Text);
                    //data
                    cmd.Parameters.AddWithValue("@diachi", textBoxDiaChi.Text);
                    cmd.Parameters.AddWithValue("@sdt", textBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        load_dgvNhanvien();
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                int ma = int.Parse(dataGridViewNhanVien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
                string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"suaNhanVien";
                cmd.Parameters.AddWithValue("@id", ma);
                cmd.Parameters.AddWithValue("@id_phong_ban", connectDatabase.ExcuteScalar("select id from phong_ban where ten_phong_ban = '" + comboBoxTenPhongBan.Text + "'"));
                cmd.Parameters.AddWithValue("@id_chuc_vu", connectDatabase.ExcuteScalar("select id from chuc_vu where ten_chuc_vu = '" + comboBoxTenChucVu.Text + "'"));
                cmd.Parameters.AddWithValue("@hoten", textBoxTenNhanVien.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePickerNgaySinh.Text);
                cmd.Parameters.AddWithValue("@diachi", textBoxDiaChi.Text);
                cmd.Parameters.AddWithValue("@sdt", textBoxSDT.Text);
                cmd.Parameters.AddWithValue("@gioitinh", (radioButtonNam.Checked?"Nam":"Nu"));
                /*                @id int,
                @id_phong_ban int,
                @id_chuc_vu int,
                @hoten nvarchar(50),
                @ngaysinh date,
                @diachi nvarchar(100),
                @sdt nvarchar(15),
                @gioitinh nvarchar(10)*/
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    load_dgvNhanvien();
                    MessageBox.Show("Sửa thành công");
                }
                else MessageBox.Show("Sửa không thành công");
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }


        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();

                int ma = int.Parse(dataGridViewNhanVien.CurrentRow.Cells["Mã nhân viên"].Value.ToString());
                string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"XoaNhanVien";
                cmd.Parameters.AddWithValue("@id", ma);
                /*                @id int,
                @id_phong_ban int,
                @id_chuc_vu int,
                @hoten nvarchar(50),
                @ngaysinh date,
                @diachi nvarchar(100),
                @sdt nvarchar(15),
                @gioitinh nvarchar(10)*/

                int i = cmd.ExecuteNonQuery();
                if (i > 0 && MessageBox.Show("Ban co muon xoa nhan vien nay khong?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    load_dgvNhanvien();
                    MessageBox.Show("Xóa thành công");
                }
                else MessageBox.Show("Xóa không thành công");
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }
    }
}
