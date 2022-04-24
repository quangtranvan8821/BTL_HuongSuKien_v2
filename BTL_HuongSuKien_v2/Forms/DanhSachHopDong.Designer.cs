
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
            this.components = new System.ComponentModel.Container();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.labelNgayKetThuc = new System.Windows.Forms.Label();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHopDong = new System.Windows.Forms.DataGridView();
            this.textBoxDonGiaNgayCong = new System.Windows.Forms.TextBox();
            this.labelDonGiaNgayCong = new System.Windows.Forms.Label();
            this.labelNgayBatDau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.comboBoxLoaiHopDong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(850, 480);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(89, 31);
            this.buttonXoa.TabIndex = 78;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(703, 480);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(89, 31);
            this.buttonSua.TabIndex = 77;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(552, 481);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(89, 31);
            this.buttonThem.TabIndex = 75;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // labelNgayKetThuc
            // 
            this.labelNgayKetThuc.AutoSize = true;
            this.labelNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayKetThuc.Location = new System.Drawing.Point(32, 431);
            this.labelNgayKetThuc.Name = "labelNgayKetThuc";
            this.labelNgayKetThuc.Size = new System.Drawing.Size(110, 20);
            this.labelNgayKetThuc.TabIndex = 63;
            this.labelNgayKetThuc.Text = "Ngày kết thúc:";
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
            // dataGridViewHopDong
            // 
            this.dataGridViewHopDong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewHopDong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHopDong.Location = new System.Drawing.Point(29, 81);
            this.dataGridViewHopDong.Name = "dataGridViewHopDong";
            this.dataGridViewHopDong.Size = new System.Drawing.Size(927, 233);
            this.dataGridViewHopDong.TabIndex = 58;
            this.dataGridViewHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHopDong_CellClick);
            // 
            // textBoxDonGiaNgayCong
            // 
            this.textBoxDonGiaNgayCong.Location = new System.Drawing.Point(709, 392);
            this.textBoxDonGiaNgayCong.Name = "textBoxDonGiaNgayCong";
            this.textBoxDonGiaNgayCong.Size = new System.Drawing.Size(240, 20);
            this.textBoxDonGiaNgayCong.TabIndex = 81;
            // 
            // labelDonGiaNgayCong
            // 
            this.labelDonGiaNgayCong.AutoSize = true;
            this.labelDonGiaNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGiaNgayCong.Location = new System.Drawing.Point(558, 392);
            this.labelDonGiaNgayCong.Name = "labelDonGiaNgayCong";
            this.labelDonGiaNgayCong.Size = new System.Drawing.Size(145, 20);
            this.labelDonGiaNgayCong.TabIndex = 82;
            this.labelDonGiaNgayCong.Text = "Đơn giá ngày công:";
            // 
            // labelNgayBatDau
            // 
            this.labelNgayBatDau.AutoSize = true;
            this.labelNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayBatDau.Location = new System.Drawing.Point(32, 392);
            this.labelNgayBatDau.Name = "labelNgayBatDau";
            this.labelNgayBatDau.Size = new System.Drawing.Size(107, 20);
            this.labelNgayBatDau.TabIndex = 62;
            this.labelNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Loại hợp đồng:";
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(160, 389);
            this.dateTimePickerNgayBatDau.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(303, 20);
            this.dateTimePickerNgayBatDau.TabIndex = 86;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(160, 431);
            this.dateTimePickerNgayKetThuc.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(303, 20);
            this.dateTimePickerNgayKetThuc.TabIndex = 87;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(29, 35);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(58, 31);
            this.buttonQuayLai.TabIndex = 88;
            this.buttonQuayLai.Text = "Trờ về";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // comboBoxLoaiHopDong
            // 
            this.comboBoxLoaiHopDong.FormattingEnabled = true;
            this.comboBoxLoaiHopDong.Items.AddRange(new object[] {
            "Chinh thuc",
            "Thu viec"});
            this.comboBoxLoaiHopDong.Location = new System.Drawing.Point(709, 350);
            this.comboBoxLoaiHopDong.Name = "comboBoxLoaiHopDong";
            this.comboBoxLoaiHopDong.Size = new System.Drawing.Size(240, 21);
            this.comboBoxLoaiHopDong.TabIndex = 89;
            this.comboBoxLoaiHopDong.Text = "Chọn loại hợp đồng";
            // 
            // DanhSachHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.comboBoxLoaiHopDong);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.Controls.Add(this.dateTimePickerNgayBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDonGiaNgayCong);
            this.Controls.Add(this.textBoxDonGiaNgayCong);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.labelNgayKetThuc);
            this.Controls.Add(this.labelNgayBatDau);
            this.Controls.Add(this.labelTenNhanVien);
            this.Controls.Add(this.textBoxTenNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHopDong);
            this.Name = "DanhSachHopDong";
            this.Text = "Danh sách hợp đồng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachHopDong_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label labelNgayKetThuc;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHopDong;
        private System.Windows.Forms.TextBox textBoxDonGiaNgayCong;
        private System.Windows.Forms.Label labelDonGiaNgayCong;
        private System.Windows.Forms.Label labelNgayBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.ComboBox comboBoxLoaiHopDong;
    }
}