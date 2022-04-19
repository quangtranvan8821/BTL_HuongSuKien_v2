
namespace BTL_HuongSuKien_v2.Forms
{
    partial class DanhSachLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.labelThang = new System.Windows.Forms.Label();
            this.labelNam = new System.Windows.Forms.Label();
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
            this.buttonThem.Location = new System.Drawing.Point(566, 493);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(89, 31);
            this.buttonThem.TabIndex = 75;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "Danh sách lương";
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
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(100, 348);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(100, 20);
            this.textBoxThang.TabIndex = 80;
            // 
            // textBoxNam
            // 
            this.textBoxNam.Location = new System.Drawing.Point(100, 412);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(100, 20);
            this.textBoxNam.TabIndex = 81;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.Location = new System.Drawing.Point(29, 348);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(58, 20);
            this.labelThang.TabIndex = 82;
            this.labelThang.Text = "Tháng:";
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.Location = new System.Drawing.Point(29, 412);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(46, 20);
            this.labelNam.TabIndex = 83;
            this.labelNam.Text = "Năm:";
            // 
            // DanhSachLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.textBoxThang);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Name = "DanhSachLuong";
            this.Text = "Bảng lương";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label labelNam;
    }
}