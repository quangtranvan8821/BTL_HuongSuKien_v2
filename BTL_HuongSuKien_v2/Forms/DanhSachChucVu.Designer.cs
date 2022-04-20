
namespace BTL_HuongSuKien_v2.Forms
{
    partial class DanhSachChucVu
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
            this.buttonXemChiTiet = new System.Windows.Forms.Button();
            this.buttonIn = new System.Windows.Forms.Button();
            this.comboBoxTenChucVu = new System.Windows.Forms.ComboBox();
            this.labelTenChucVu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewChucVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).BeginInit();
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
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemChiTiet.Location = new System.Drawing.Point(829, 490);
            this.buttonXemChiTiet.Name = "buttonXemChiTiet";
            this.buttonXemChiTiet.Size = new System.Drawing.Size(127, 31);
            this.buttonXemChiTiet.TabIndex = 78;
            this.buttonXemChiTiet.Text = "Xem chi tiết";
            this.buttonXemChiTiet.UseVisualStyleBackColor = true;
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
            // comboBoxTenChucVu
            // 
            this.comboBoxTenChucVu.FormattingEnabled = true;
            this.comboBoxTenChucVu.Items.AddRange(new object[] {
            "Phòng kinh doanh",
            "Phòng nhân sự",
            "Phòng kế toán",
            "Phòng marketing",
            "Phòng kỹ thuật"});
            this.comboBoxTenChucVu.Location = new System.Drawing.Point(166, 499);
            this.comboBoxTenChucVu.Name = "comboBoxTenChucVu";
            this.comboBoxTenChucVu.Size = new System.Drawing.Size(303, 21);
            this.comboBoxTenChucVu.TabIndex = 71;
            // 
            // labelTenChucVu
            // 
            this.labelTenChucVu.AutoSize = true;
            this.labelTenChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChucVu.Location = new System.Drawing.Point(36, 501);
            this.labelTenChucVu.Name = "labelTenChucVu";
            this.labelTenChucVu.Size = new System.Drawing.Size(98, 20);
            this.labelTenChucVu.TabIndex = 68;
            this.labelTenChucVu.Text = "Tên chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "Danh sách chức vụ";
            // 
            // dataGridViewChucVu
            // 
            this.dataGridViewChucVu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewChucVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChucVu.Location = new System.Drawing.Point(29, 81);
            this.dataGridViewChucVu.Name = "dataGridViewChucVu";
            this.dataGridViewChucVu.Size = new System.Drawing.Size(927, 369);
            this.dataGridViewChucVu.TabIndex = 58;
            // 
            // DanhSachChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonXemChiTiet);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.comboBoxTenChucVu);
            this.Controls.Add(this.labelTenChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewChucVu);
            this.Name = "DanhSachChucVu";
            this.Text = "Phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonXemChiTiet;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.ComboBox comboBoxTenChucVu;
        private System.Windows.Forms.Label labelTenChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewChucVu;
    }
}