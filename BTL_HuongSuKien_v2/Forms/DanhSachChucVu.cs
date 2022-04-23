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
    public partial class DanhSachChucVu : Form
    {
        public DanhSachChucVu()
        {
            InitializeComponent();
        }

        private void buttonSua_Click(object sender, EventArgs e)
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
                cmd.CommandText = @"SuaChucVu";
                cmd.Parameters.AddWithValue("@ten_chuc_vu",comboBoxTenChucVu.Text);
                cmd.Parameters.AddWithValue("@phucap", textBoxTienPhuCap.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    load_dataGridViewChucVu();
                    MessageBox.Show("Sửa tiền phụ cấp thành công");
                }
                else MessageBox.Show("Sửa tiền phụ cấp không thành công");
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void DanhSachChucVu_Load(object sender, EventArgs e)
        {
            Init_dsChucvu();
            load_dataGridViewChucVu();

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
        public void load_dataGridViewChucVu()
        {
            ConnectDatabase.ConnectDatabase dt = new ConnectDatabase.ConnectDatabase();
            string getdata = "select * from DanhSachChucVu";
            dataGridViewChucVu.DataSource = dt.getTable(getdata);
        }

        private void dataGridViewChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            comboBoxTenChucVu.Text = dataGridViewChucVu.CurrentRow.Cells["Tên chức vụ"].Value.ToString();
            textBoxTienPhuCap.Text = dataGridViewChucVu.CurrentRow.Cells["Phụ cấp"].Value.ToString();
        }

        private void DanhSachChucVu_FormClosing(object sender, FormClosingEventArgs e)
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
