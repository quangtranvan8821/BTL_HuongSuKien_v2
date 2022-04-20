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
                check = check | checkTextBoxBlank(textBoxNam);
                check = check | checkTextBoxBlank(textBoxThang);
                int idthoigian = getidThoiGian(Convert.ToInt32(textBoxThang.Text), Convert.ToInt32(textBoxNam.Text));
                check = check | (idthoigian <1 ? true : false);


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
                    cmd.Parameters.AddWithValue("@id_thoi_gian",idthoigian);
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
        public int getidThoiGian(int thang, int nam)
        {
            try
            {
                /*string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand("TimID_ThoiGian",cnt);
               // cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //  cmd.CommandText = @"TimID_ThoiGian";
                MessageBox.Show(thang.ToString() + nam.ToString());
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);*/
                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                DataTable dataTable = new DataTable();
                string s = "select id form thoi_gian where thang ="+thang+" and nam ="+nam;
                connectDatabase.getTable(s);
                int i = 0;
                foreach (DataRow j in dataTable.Rows)
                {
                    i++;
                }
/*                int i = cmd.ExecuteNonQuery();*/
                if (i > 0)
                {
                    int id = Convert.ToInt32(connectDatabase.ExcuteScalar(s));
                    return id;
                }
                else
                {
                    errorProvider1.SetError(textBoxThang, "tháng năm không tồn tại trong database!");
                    MessageBox.Show(i.ToString());
                    return 0;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return 0;

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
                int idthoigian = getidThoiGian(Convert.ToInt32(textBoxThang.Text), Convert.ToInt32(textBoxNam.Text));
                bool check = (idthoigian < 1 ? false: true);
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
                    cmd.Parameters.AddWithValue("@id_thoi_gian",idthoigian);
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
