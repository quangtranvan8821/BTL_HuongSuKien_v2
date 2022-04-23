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
    public partial class BaoCaoNhanVienHetHopDong : Form
    {
        public BaoCaoNhanVienHetHopDong()
        {
            InitializeComponent();
        }

        private void BaoCaoNhanVienHetHopDong_Load(object sender, EventArgs e)
        {
            try
            {

                ConnectDatabase.ConnectDatabase connectDatabase = new ConnectDatabase.ConnectDatabase();
                string cont = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
                SqlConnection cnt = new SqlConnection(cont);
                cnt.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnt;
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = @"select * from DanhSachNV_HetHopDong";
               //cmd.Parameters.AddWithValue("@ten_phong_ban", comboBoxTenPhongBan.Text);
                DataTable table = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(table);
                ThongKeNhanVienHetHopDong cry = new ThongKeNhanVienHetHopDong();
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
    }
}
