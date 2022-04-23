
namespace BTL_HuongSuKien_v2.Forms
{
    partial class ThongKeNhanVienTheoTuoi
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
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.labelTenPhongBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.textBoxTu = new System.Windows.Forms.TextBox();
            this.textBoxDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.Location = new System.Drawing.Point(867, 42);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(89, 31);
            this.buttonThongKe.TabIndex = 87;
            this.buttonThongKe.Text = "Thống kê";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            // 
            // labelTenPhongBan
            // 
            this.labelTenPhongBan.AutoSize = true;
            this.labelTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhongBan.Location = new System.Drawing.Point(25, 483);
            this.labelTenPhongBan.Name = "labelTenPhongBan";
            this.labelTenPhongBan.Size = new System.Drawing.Size(31, 20);
            this.labelTenPhongBan.TabIndex = 82;
            this.labelTenPhongBan.Text = "Từ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 31);
            this.label1.TabIndex = 81;
            this.label1.Text = "Thống kê nhân viên theo tuổi";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(29, 82);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(927, 369);
            this.dataGridViewNhanVien.TabIndex = 80;
            // 
            // textBoxTu
            // 
            this.textBoxTu.Location = new System.Drawing.Point(62, 483);
            this.textBoxTu.Name = "textBoxTu";
            this.textBoxTu.Size = new System.Drawing.Size(100, 20);
            this.textBoxTu.TabIndex = 89;
            // 
            // textBoxDen
            // 
            this.textBoxDen.Location = new System.Drawing.Point(261, 483);
            this.textBoxDen.Name = "textBoxDen";
            this.textBoxDen.Size = new System.Drawing.Size(100, 20);
            this.textBoxDen.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Đến:";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(29, 36);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(58, 31);
            this.buttonQuayLai.TabIndex = 92;
            this.buttonQuayLai.Text = "Trờ về";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            // 
            // ThongKeNhanVienTheoTuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.textBoxDen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTu);
            this.Controls.Add(this.buttonThongKe);
            this.Controls.Add(this.labelTenPhongBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Name = "ThongKeNhanVienTheoTuoi";
            this.Text = "Thống kê nhân viên theo tuổi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Label labelTenPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.TextBox textBoxTu;
        private System.Windows.Forms.TextBox textBoxDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}