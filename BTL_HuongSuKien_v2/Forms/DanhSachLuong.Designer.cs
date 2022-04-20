
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
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLuong = new System.Windows.Forms.DataGridView();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.labelThang = new System.Windows.Forms.Label();
            this.labelNam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaHopDong = new System.Windows.Forms.TextBox();
            this.textBoxSoNgayCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(642, 447);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(89, 31);
            this.buttonSua.TabIndex = 77;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
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
            this.buttonThem.Location = new System.Drawing.Point(497, 447);
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
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(592, 350);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(139, 20);
            this.textBoxThang.TabIndex = 80;
            // 
            // textBoxNam
            // 
            this.textBoxNam.Location = new System.Drawing.Point(592, 396);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(141, 20);
            this.textBoxNam.TabIndex = 81;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.Location = new System.Drawing.Point(528, 350);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(58, 20);
            this.labelThang.TabIndex = 82;
            this.labelThang.Text = "Tháng:";
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.Location = new System.Drawing.Point(528, 392);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(46, 20);
            this.labelNam.TabIndex = 83;
            this.labelNam.Text = "Năm:";
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
            this.textBoxSoNgayCong.Location = new System.Drawing.Point(151, 394);
            this.textBoxSoNgayCong.Name = "textBoxSoNgayCong";
            this.textBoxSoNgayCong.Size = new System.Drawing.Size(305, 20);
            this.textBoxSoNgayCong.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Số ngày công:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DanhSachLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoNgayCong);
            this.Controls.Add(this.textBoxMaHopDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.textBoxThang);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLuong);
            this.Name = "DanhSachLuong";
            this.Text = "Bảng lương";
            this.Load += new System.EventHandler(this.DanhSachLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLuong;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaHopDong;
        private System.Windows.Forms.TextBox textBoxSoNgayCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}