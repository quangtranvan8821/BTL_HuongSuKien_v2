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
            textBoxMaThoiGian.Text = dataGridViewLuong.CurrentRow.Cells["Mã thời gian"].Value.ToString();
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

        private void buttonThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            try
            {
                check = check | checkTextBoxBlank(textBoxMaHopDong);
                check = check | checkTextBoxBlank(textBoxSoNgayCong);
                check = check | checkTextBoxBlank(textBoxMaThoiGian);
                

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
                    cmd.Parameters.AddWithValue("@id_thoi_gian",textBoxMaThoiGian.Text);
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
                    cmd.Parameters.AddWithValue("@id_thoi_gian",textBoxMaThoiGian.Text);
                    cmd.Parameters.AddWithValue("@ngay_cong", textBoxSoNgayCong.Text);

                    /*    @id int,
            @id_hop_dong int,
            @id_thoi_gian int,
            @ngay_cong int*/
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

        
    }
}
