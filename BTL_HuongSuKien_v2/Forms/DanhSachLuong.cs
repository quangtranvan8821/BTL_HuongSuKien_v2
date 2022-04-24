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
    public partial class DanhSachLuong : Form
    {
        public DanhSachLuong()
        {
            InitializeComponent();
        }

        //close form
        private void clickQuayLai(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHopDong.Text = dataGridViewLuong.CurrentRow.Cells["Mã Hợp đồng"].Value.ToString();
            textBoxSoNgayCong.Text = dataGridViewLuong.CurrentRow.Cells["Số ngày công"].Value.ToString();
            textBoxThang.Text = dataGridViewLuong.CurrentRow.Cells["Tháng"].Value.ToString();
            textBoxNam.Text = dataGridViewLuong.CurrentRow.Cells["Năm"].Value.ToString();

            int don_gia_ngay_cong = Convert.ToInt32(dataGridViewLuong.CurrentRow.Cells["Lương ngày"].Value.ToString());
            int so_ngay_cong = Convert.ToInt32(textBoxSoNgayCong.Text);
            int phu_cap = Convert.ToInt32(dataGridViewLuong.CurrentRow.Cells["Phụ cấp"].Value.ToString());
            //tinh luong
            textBoxLuong.Text = ( ( 2 * (so_ngay_cong - 22) * don_gia_ngay_cong ) + ( 22 * don_gia_ngay_cong ) + phu_cap ).ToString();
            //Lương ngày*22 + 2*Lương ngày*(ngày công-22) + phụ cấp
        }

        private void DanhSachLuong_Load(object sender, EventArgs e)
        {
            load_dataGridViewLuong();
        }
        public void load_dataGridViewLuong()
        {
            ConnectDatabase.ConnectDatabase dt = new ConnectDatabase.ConnectDatabase();
            string getdata = "select * from DanhSachLuong";
            dataGridViewLuong.DataSource = dt.getTable(getdata);
        }

        public int getIdThoiGian(int thang, int nam)
        {
            int id_thoi_gian = 0;
            string sql = "select id from thoi_gian where thang = " + thang + " and nam = " + nam;

            string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
            SqlConnection cnt = new SqlConnection(cont);
            cnt.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnt;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();
            int id_thoi_gian_index = reader.GetOrdinal("id"); // lấy chỉ số index của cột trong sql
            if(reader.Read())
            {
                id_thoi_gian = reader.GetInt32(id_thoi_gian_index); // lấy data theo type của index ( để ý hàm getInt là lấy kiểu int32 nếu string thì dùng getString)
                return id_thoi_gian;
            }

            return id_thoi_gian;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int id_thoi_gian = getIdThoiGian(Convert.ToInt32(textBoxThang.Text), Convert.ToInt32(textBoxNam.Text));

            bool check = false;
            try
            {
                check = check | checkTextBoxBlank(textBoxMaHopDong);
                check = check | checkTextBoxBlank(textBoxSoNgayCong);

                if(id_thoi_gian == 0)
                {
                    MessageBox.Show("Thời gian không khớp");
                    return;
                }
                

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
                    cmd.CommandText = @"ThemLuong";

                    cmd.Parameters.AddWithValue("@id_hop_dong", textBoxMaHopDong.Text);
                    cmd.Parameters.AddWithValue("@id_thoi_gian", id_thoi_gian);
                    cmd.Parameters.AddWithValue("@ngay_cong", textBoxSoNgayCong.Text);


                    /*  @id_hop_dong int,
                        @id_thoi_gian int,
                        @ngay_cong int*/


                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm lương thành công");
                        load_dataGridViewLuong();
                    }
                    else
                        MessageBox.Show("Thêm lương không thành công");
                    cnt.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công! nhập thiếu nội dung hoặc nhập dữ liệu bị trùng!");
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
            int id_thoi_gian = getIdThoiGian(Convert.ToInt32(textBoxThang.Text), Convert.ToInt32(textBoxNam.Text));

            if (id_thoi_gian == 0)
            {
                MessageBox.Show("Thời gian không khớp");
                return;
            }

            try
            {
                bool check = false;
                if (check == false) {
                    ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                    int ma = int.Parse(dataGridViewLuong.CurrentRow.Cells["Mã lương"].Value.ToString());
                    string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                    SqlConnection cnt = new SqlConnection(cont);
                    cnt.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnt;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SuaLuong";
                    cmd.Parameters.AddWithValue("@id", ma);
                    cmd.Parameters.AddWithValue("@id_hop_dong", textBoxMaHopDong.Text);
                    cmd.Parameters.AddWithValue("@id_thoi_gian", id_thoi_gian);
                    cmd.Parameters.AddWithValue("@ngay_cong", textBoxSoNgayCong.Text);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        load_dataGridViewLuong();
                        MessageBox.Show("Sửa lương thành công");
                    }
                    else MessageBox.Show("Sửa lương không thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công! nhập thiếu nội dung hoặc nhập dữ liệu bị trùng!");
                }
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void DanhSachLuong_FormClosing(object sender, FormClosingEventArgs e)
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
