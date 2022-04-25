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

namespace BTL_HuongSuKien_v2.Reports
{
    public partial class BaoCaoLuongTheoThoiGian : Form
    {
        public BaoCaoLuongTheoThoiGian()
        {
            InitializeComponent();
        }

        private void labelTenPhongBan_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            try
            {

                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"ThongKeLuong_ThoiGian";
                cmd.Parameters.AddWithValue("@thang", comboBoxThang.Text);
                cmd.Parameters.AddWithValue("@nam", textBoxNam.Text);

                DataTable table = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(table);

                ThongKeLuongTheoThoiGian cry = new ThongKeLuongTheoThoiGian();
                cry.SetDataSource(table);

                FormLoadReport form = new FormLoadReport();
                form.crystalReportViewer1.ReportSource = cry;
                form.ShowDialog();
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void BaoCaoLuongTheoThoiGian_FormClosing(object sender, FormClosingEventArgs e)
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
