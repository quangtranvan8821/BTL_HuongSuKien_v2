
namespace BTL_HuongSuKien_v2.Forms
{
    partial class TimKiemNhanVienTheoPhongBan
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
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonXemChiTiet = new System.Windows.Forms.Button();
            this.buttonIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.comboBoxTenPhongBan = new System.Windows.Forms.ComboBox();
            this.comboBoxTenChucVu = new System.Windows.Forms.ComboBox();
            this.labelTenChucVu = new System.Windows.Forms.Label();
            this.labelTenPhongBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(841, 36);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(114, 30);
            this.buttonTimKiem.TabIndex = 112;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(29, 36);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(58, 31);
            this.buttonQuayLai.TabIndex = 111;
            this.buttonQuayLai.Text = "<";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.clickQuayLai);
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemChiTiet.Location = new System.Drawing.Point(866, 494);
            this.buttonXemChiTiet.Name = "buttonXemChiTiet";
            this.buttonXemChiTiet.Size = new System.Drawing.Size(89, 31);
            this.buttonXemChiTiet.TabIndex = 110;
            this.buttonXemChiTiet.Text = "Xem chi tiết";
            this.buttonXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // buttonIn
            // 
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIn.Location = new System.Drawing.Point(111, 36);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(89, 31);
            this.buttonIn.TabIndex = 109;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 108;
            this.label1.Text = "Tìm kiếm theo phòng ban";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(29, 95);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(927, 276);
            this.dataGridViewNhanVien.TabIndex = 107;
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
            this.comboBoxTenPhongBan.Location = new System.Drawing.Point(157, 433);
            this.comboBoxTenPhongBan.Name = "comboBoxTenPhongBan";
            this.comboBoxTenPhongBan.Size = new System.Drawing.Size(303, 21);
            this.comboBoxTenPhongBan.TabIndex = 116;
            // 
            // comboBoxTenChucVu
            // 
            this.comboBoxTenChucVu.FormattingEnabled = true;
            this.comboBoxTenChucVu.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Phó phòng",
            "Nhân viên",
            "Thực tập"});
            this.comboBoxTenChucVu.Location = new System.Drawing.Point(157, 393);
            this.comboBoxTenChucVu.Name = "comboBoxTenChucVu";
            this.comboBoxTenChucVu.Size = new System.Drawing.Size(303, 21);
            this.comboBoxTenChucVu.TabIndex = 115;
            // 
            // labelTenChucVu
            // 
            this.labelTenChucVu.AutoSize = true;
            this.labelTenChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChucVu.Location = new System.Drawing.Point(27, 391);
            this.labelTenChucVu.Name = "labelTenChucVu";
            this.labelTenChucVu.Size = new System.Drawing.Size(98, 20);
            this.labelTenChucVu.TabIndex = 114;
            this.labelTenChucVu.Text = "Tên chức vụ:";
            // 
            // labelTenPhongBan
            // 
            this.labelTenPhongBan.AutoSize = true;
            this.labelTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhongBan.Location = new System.Drawing.Point(27, 435);
            this.labelTenPhongBan.Name = "labelTenPhongBan";
            this.labelTenPhongBan.Size = new System.Drawing.Size(120, 20);
            this.labelTenPhongBan.TabIndex = 113;
            this.labelTenPhongBan.Text = "Tên phòng ban:";
            // 
            // TimKiemNhanVienTheoPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.comboBoxTenPhongBan);
            this.Controls.Add(this.comboBoxTenChucVu);
            this.Controls.Add(this.labelTenChucVu);
            this.Controls.Add(this.labelTenPhongBan);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonXemChiTiet);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Name = "TimKiemNhanVienTheoPhongBan";
            this.Text = "Tìm kiếm theo phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonXemChiTiet;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.ComboBox comboBoxTenPhongBan;
        private System.Windows.Forms.ComboBox comboBoxTenChucVu;
        private System.Windows.Forms.Label labelTenChucVu;
        private System.Windows.Forms.Label labelTenPhongBan;
    }
}