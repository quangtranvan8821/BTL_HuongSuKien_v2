using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
