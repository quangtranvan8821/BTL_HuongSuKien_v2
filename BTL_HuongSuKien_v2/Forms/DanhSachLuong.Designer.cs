
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
            this.components = new System.ComponentModel.Container();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaHopDong = new System.Windows.Forms.TextBox();
            this.textBoxSoNgayCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewLuong = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(867, 499);
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
            this.buttonThem.Location = new System.Drawing.Point(729, 499);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(89, 31);
            this.buttonThem.TabIndex = 75;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Mã Hợp Đồng :";
            // 
            // textBoxMaHopDong
            // 
            this.textBoxMaHopDong.Location = new System.Drawing.Point(151, 350);
            this.textBoxMaHopDong.Name = "textBoxMaHopDong";
            this.textBoxMaHopDong.Size = new System.Drawing.Size(305, 20);
            this.textBoxMaHopDong.TabIndex = 85;
            // 
            // textBoxSoNgayCong
            // 
            this.textBoxSoNgayCong.Location = new System.Drawing.Point(651, 352);
            this.textBoxSoNgayCong.Name = "textBoxSoNgayCong";
            this.textBoxSoNgayCong.Size = new System.Drawing.Size(305, 20);
            this.textBoxSoNgayCong.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Số ngày công:";
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
            this.buttonQuayLai.TabIndex = 92;
            this.buttonQuayLai.Text = "Trờ về";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // textBoxNam
            // 
            this.textBoxNam.Location = new System.Drawing.Point(368, 391);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(88, 20);
            this.textBoxNam.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Năm:";
            // 
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(151, 391);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(77, 20);
            this.textBoxThang.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Tháng:";
            // 
            // dataGridViewLuong
            // 
            this.dataGridViewLuong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLuong.Location = new System.Drawing.Point(29, 81);
            this.dataGridViewLuong.Name = "dataGridViewLuong";
            this.dataGridViewLuong.Size = new System.Drawing.Size(927, 233);
            this.dataGridViewLuong.TabIndex = 58;
            this.dataGridViewLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLuong_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "Lương:";
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Location = new System.Drawing.Point(651, 391);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.ReadOnly = true;
            this.textBoxLuong.Size = new System.Drawing.Size(305, 20);
            this.textBoxLuong.TabIndex = 98;
            // 
            // DanhSachLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.textBoxLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxThang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoNgayCong);
            this.Controls.Add(this.textBoxMaHopDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLuong);
            this.Name = "DanhSachLuong";
            this.Text = "Bảng lương";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachLuong_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaHopDong;
        private System.Windows.Forms.TextBox textBoxSoNgayCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewLuong;
        private System.Windows.Forms.TextBox textBoxLuong;
        private System.Windows.Forms.Label label3;
    }
}