
namespace BTL_HuongSuKien_v2.Forms
{
    partial class DanhSachHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.comboBoxTenPhongBan = new System.Windows.Forms.ComboBox();
            this.comboBoxTenChucVu = new System.Windows.Forms.ComboBox();
            this.labelTenChucVu = new System.Windows.Forms.Label();
            this.labelTenPhongBan = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.labelMaNhanVien = new System.Windows.Forms.Label();
            this.labelNgayKetThuc = new System.Windows.Forms.Label();
            this.labelNgayBatDau = new System.Windows.Forms.Label();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxDonGiaNgayCong = new System.Windows.Forms.TextBox();
            this.labelDonGiaNgayCong = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(29, 35);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(58, 31);
            this.buttonQuayLai.TabIndex = 79;
            this.buttonQuayLai.Text = "<";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.clickQuayLai);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(867, 493);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(89, 31);
            this.buttonXoa.TabIndex = 78;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(720, 493);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(89, 31);
            this.buttonSua.TabIndex = 77;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonIn
            // 
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIn.Location = new System.Drawing.Point(111, 35);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(89, 31);
            this.buttonIn.TabIndex = 76;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(569, 494);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(89, 31);
            this.buttonThem.TabIndex = 75;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // comboBoxTenPhongBan
            // 
            this.comboBoxTenPhongBan.FormattingEnabled = true;
            this.comboBoxTenPhongBan.Items.AddRange(new object[] {
            "Phòng kinh doanh",
            "Phòng nhân sự",
            "Phòng kế toán",
            "Phòng marketing",
            "Phòng kỹ thuật"});
            this.comboBoxTenPhongBan.Location = new System.Drawing.Point(160, 503);
            this.comboBoxTenPhongBan.Name = "comboBoxTenPhongBan";
            this.comboBoxTenPhongBan.Size = new System.Drawing.Size(303, 21);
            this.comboBoxTenPhongBan.TabIndex = 71;
            // 
            // comboBoxTenChucVu
            // 
            this.comboBoxTenChucVu.FormattingEnabled = true;
            this.comboBoxTenChucVu.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Phó phòng",
            "Nhân viên",
            "Thực tập"});
            this.comboBoxTenChucVu.Location = new System.Drawing.Point(160, 463);
            this.comboBoxTenChucVu.Name = "comboBoxTenChucVu";
            this.comboBoxTenChucVu.Size = new System.Drawing.Size(303, 21);
            this.comboBoxTenChucVu.TabIndex = 70;
            // 
            // labelTenChucVu
            // 
            this.labelTenChucVu.AutoSize = true;
            this.labelTenChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChucVu.Location = new System.Drawing.Point(30, 461);
            this.labelTenChucVu.Name = "labelTenChucVu";
            this.labelTenChucVu.Size = new System.Drawing.Size(98, 20);
            this.labelTenChucVu.TabIndex = 69;
            this.labelTenChucVu.Text = "Tên chức vụ:";
            // 
            // labelTenPhongBan
            // 
            this.labelTenPhongBan.AutoSize = true;
            this.labelTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhongBan.Location = new System.Drawing.Point(30, 505);
            this.labelTenPhongBan.Name = "labelTenPhongBan";
            this.labelTenPhongBan.Size = new System.Drawing.Size(120, 20);
            this.labelTenPhongBan.TabIndex = 68;
            this.labelTenPhongBan.Text = "Tên phòng ban:";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiaChi.Location = new System.Drawing.Point(160, 422);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(303, 22);
            this.textBoxDiaChi.TabIndex = 66;
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(716, 346);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(192, 22);
            this.textBoxMaNhanVien.TabIndex = 65;
            // 
            // labelMaNhanVien
            // 
            this.labelMaNhanVien.AutoSize = true;
            this.labelMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNhanVien.Location = new System.Drawing.Point(565, 346);
            this.labelMaNhanVien.Name = "labelMaNhanVien";
            this.labelMaNhanVien.Size = new System.Drawing.Size(107, 20);
            this.labelMaNhanVien.TabIndex = 64;
            this.labelMaNhanVien.Text = "Mã nhân viên:";
            // 
            // labelNgayKetThuc
            // 
            this.labelNgayKetThuc.AutoSize = true;
            this.labelNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayKetThuc.Location = new System.Drawing.Point(31, 423);
            this.labelNgayKetThuc.Name = "labelNgayKetThuc";
            this.labelNgayKetThuc.Size = new System.Drawing.Size(110, 20);
            this.labelNgayKetThuc.TabIndex = 63;
            this.labelNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // labelNgayBatDau
            // 
            this.labelNgayBatDau.AutoSize = true;
            this.labelNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayBatDau.Location = new System.Drawing.Point(31, 385);
            this.labelNgayBatDau.Name = "labelNgayBatDau";
            this.labelNgayBatDau.Size = new System.Drawing.Size(107, 20);
            this.labelNgayBatDau.TabIndex = 62;
            this.labelNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // labelTenNhanVien
            // 
            this.labelTenNhanVien.AutoSize = true;
            this.labelTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNhanVien.Location = new System.Drawing.Point(30, 346);
            this.labelTenNhanVien.Name = "labelTenNhanVien";
            this.labelTenNhanVien.Size = new System.Drawing.Size(112, 20);
            this.labelTenNhanVien.TabIndex = 60;
            this.labelTenNhanVien.Text = "Tên nhân viên:";
            // 
            // textBoxTenNhanVien
            // 
            this.textBoxTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(160, 346);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(303, 22);
            this.textBoxTenNhanVien.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "Danh sách hợp đồng";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(29, 81);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(927, 233);
            this.dataGridViewNhanVien.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 22);
            this.textBox1.TabIndex = 80;
            // 
            // textBoxDonGiaNgayCong
            // 
            this.textBoxDonGiaNgayCong.Location = new System.Drawing.Point(716, 385);
            this.textBoxDonGiaNgayCong.Name = "textBoxDonGiaNgayCong";
            this.textBoxDonGiaNgayCong.Size = new System.Drawing.Size(192, 20);
            this.textBoxDonGiaNgayCong.TabIndex = 81;
            // 
            // labelDonGiaNgayCong
            // 
            this.labelDonGiaNgayCong.AutoSize = true;
            this.labelDonGiaNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGiaNgayCong.Location = new System.Drawing.Point(565, 383);
            this.labelDonGiaNgayCong.Name = "labelDonGiaNgayCong";
            this.labelDonGiaNgayCong.Size = new System.Drawing.Size(145, 20);
            this.labelDonGiaNgayCong.TabIndex = 82;
            this.labelDonGiaNgayCong.Text = "Đơn giá ngày công:";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(841, 35);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(114, 30);
            this.buttonTimKiem.TabIndex = 83;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // DanhSachHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.labelDonGiaNgayCong);
            this.Controls.Add(this.textBoxDonGiaNgayCong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.comboBoxTenPhongBan);
            this.Controls.Add(this.comboBoxTenChucVu);
            this.Controls.Add(this.labelTenChucVu);
            this.Controls.Add(this.labelTenPhongBan);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxMaNhanVien);
            this.Controls.Add(this.labelMaNhanVien);
            this.Controls.Add(this.labelNgayKetThuc);
            this.Controls.Add(this.labelNgayBatDau);
            this.Controls.Add(this.labelTenNhanVien);
            this.Controls.Add(this.textBoxTenNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Name = "DanhSachHopDong";
            this.Text = "Danh sách hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ComboBox comboBoxTenPhongBan;
        private System.Windows.Forms.ComboBox comboBoxTenChucVu;
        private System.Windows.Forms.Label labelTenChucVu;
        private System.Windows.Forms.Label labelTenPhongBan;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label labelMaNhanVien;
        private System.Windows.Forms.Label labelNgayKetThuc;
        private System.Windows.Forms.Label labelNgayBatDau;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxDonGiaNgayCong;
        private System.Windows.Forms.Label labelDonGiaNgayCong;
        private System.Windows.Forms.Button buttonTimKiem;
    }
}