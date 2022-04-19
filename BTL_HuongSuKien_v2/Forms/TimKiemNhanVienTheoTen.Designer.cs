
namespace BTL_HuongSuKien_v2.Forms
{
    partial class TimKiemNhanVienTheoTen
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
            this.textBoxNhapTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(841, 35);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(114, 30);
            this.buttonTimKiem.TabIndex = 105;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(29, 35);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(58, 31);
            this.buttonQuayLai.TabIndex = 101;
            this.buttonQuayLai.Text = "<";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.clickQuayLai);
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemChiTiet.Location = new System.Drawing.Point(867, 493);
            this.buttonXemChiTiet.Name = "buttonXemChiTiet";
            this.buttonXemChiTiet.Size = new System.Drawing.Size(89, 31);
            this.buttonXemChiTiet.TabIndex = 100;
            this.buttonXemChiTiet.Text = "Xem chi tiết";
            this.buttonXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // buttonIn
            // 
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIn.Location = new System.Drawing.Point(111, 35);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(89, 31);
            this.buttonIn.TabIndex = 98;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(28, 155);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(927, 318);
            this.dataGridViewNhanVien.TabIndex = 84;
            // 
            // textBoxNhapTen
            // 
            this.textBoxNhapTen.Location = new System.Drawing.Point(28, 114);
            this.textBoxNhapTen.Name = "textBoxNhapTen";
            this.textBoxNhapTen.Size = new System.Drawing.Size(927, 20);
            this.textBoxNhapTen.TabIndex = 106;
            this.textBoxNhapTen.Text = "Nhập tên nhân viên ...";
            // 
            // TimKiemNhanVienTheoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.textBoxNhapTen);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonXemChiTiet);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Name = "TimKiemNhanVienTheoTen";
            this.Text = "Tìm kiếm theo tên";
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
        private System.Windows.Forms.TextBox textBoxNhapTen;
    }
}