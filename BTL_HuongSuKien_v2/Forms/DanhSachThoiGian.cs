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
    public partial class DanhSachThoiGian : Form
    {
        public DanhSachThoiGian()
        {
            InitializeComponent();
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
        public bool checkThang(TextBox textBox)
        {
            int thang = Convert.ToInt32(textBoxThang.Text);
            if (thang>12 || thang<=0)
            {
               
                errorProvider1.SetError(textBox, "Tháng không hợp lệ !");
                return true;
            }
            else
            {
                errorProvider1.Clear();
                return false;
            }

        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            try
            {
                check = check | checkTextBoxBlank(textBoxNam);
                check = check | checkTextBoxBlank(textBoxThang)| checkThang(textBoxThang);

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
                    cmd.CommandText = @"ThemThoiGian";

                    cmd.Parameters.AddWithValue("@thang", textBoxThang.Text);
                    cmd.Parameters.AddWithValue("@nam", textBoxNam.Text);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thời gian thành công");
                        load_dataGridViewThoiGian();
                    }
                    else
                        MessageBox.Show("Thêm thời gian không thành công");
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
        public void load_dataGridViewThoiGian()
        {
            ConnectDatabase.ConnectDatabase dt = new ConnectDatabase.ConnectDatabase();
            string getdata = "select * from DanhSachThoiGian";
            dataGridViewThoiGian.DataSource = dt.getTable(getdata);
        }
        private void DanhSachThoiGian_Load(object sender, EventArgs e)
        {
            load_dataGridViewThoiGian();
        }

        private void DanhSachThoiGian_FormClosing(object sender, FormClosingEventArgs e)
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
