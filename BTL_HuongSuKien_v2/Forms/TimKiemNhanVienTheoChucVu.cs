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
    public partial class TimKiemNhanVienTheoChucVu : Form
    {
        public TimKiemNhanVienTheoChucVu()
        {
            InitializeComponent();
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
                cmd.CommandText = @"TimKiemNhanVien_CV";
                cmd.Parameters.AddWithValue("@ten_chuc_vu", comboBoxTenChucVu.Text);
                DataTable table = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(table);
                dataGridViewNhanVienTheoChucVu.DataSource = table;
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TimKiemNhanVienTheoChucVu_Load(object sender, EventArgs e)
        {
            Init_dsChucvu();
        }

        private void TimKiemNhanVienTheoChucVu_FormClosing(object sender, FormClosingEventArgs e)
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
