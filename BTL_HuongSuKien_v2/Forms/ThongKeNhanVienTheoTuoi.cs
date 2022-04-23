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
    public partial class ThongKeNhanVienTheoTuoi : Form
    {
        public ThongKeNhanVienTheoTuoi()
        {
            InitializeComponent();
        }

        //close form
        private void clickQuayLai(object sender, EventArgs e)
        {
            Close();
        }

        private void ThongKeNhanVienTheoTuoi_FormClosing(object sender, FormClosingEventArgs e)
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
        public bool checkTextBoxValua(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                return true;
            }
            else
            {
                errorProvider1.SetError(textBox, "Ô nhập liệu trống!");
                return false;
            }
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                check = check |checkTextBoxValua(textBoxTu)|checkTextBoxValua(textBoxDen);
                if(check){
                    ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                    string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                    SqlConnection cnt = new SqlConnection(cont);
                    cnt.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnt;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"TimNV_Tuoi";
                    cmd.Parameters.AddWithValue("@from", textBoxTu.Text);
                    cmd.Parameters.AddWithValue("@to", textBoxDen.Text);
                    DataTable table = new DataTable();
                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                    sqlData.Fill(table);
                    dataGridViewNhanVienTheoTuoi.DataSource = table;
                }
           
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }
    }
}
