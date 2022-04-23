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
    public partial class BaoCaoNhanVienTheoPhongBan : Form
    {
        public BaoCaoNhanVienTheoPhongBan()
        {
            InitializeComponent();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaoCaoNhanVienTheoPhongBan_Load(object sender, EventArgs e)
        {
            Init_dsPhongban();
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

        private void BaoCaoNhanVienTheoPhongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
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
                    cmd.CommandText = @"TimKiemNhanVien_PB";
                    cmd.Parameters.AddWithValue("@ten_phong_ban", comboBoxTenPhongBan.Text);
                    DataTable table = new DataTable();
                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                    sqlData.Fill(table);
                    ThongKeNhanVienTheoPhongBan cry = new ThongKeNhanVienTheoPhongBan();
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
