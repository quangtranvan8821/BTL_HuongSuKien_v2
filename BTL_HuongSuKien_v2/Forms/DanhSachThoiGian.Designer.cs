
namespace BTL_HuongSuKien_v2.Forms
{
    partial class DanhSachThoiGian
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
            this.labelTenPhongBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewThoiGian = new System.Windows.Forms.DataGridView();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTenPhongBan
            // 
            this.labelTenPhongBan.AutoSize = true;
            this.labelTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhongBan.Location = new System.Drawing.Point(25, 433);
            this.labelTenPhongBan.Name = "labelTenPhongBan";
            this.labelTenPhongBan.Size = new System.Drawing.Size(62, 20);
            this.labelTenPhongBan.TabIndex = 68;
            this.labelTenPhongBan.Text = "Tháng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "Danh sách thời gian";
            // 
            // dataGridViewThoiGian
            // 
            this.dataGridViewThoiGian.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewThoiGian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewThoiGian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThoiGian.Location = new System.Drawing.Point(29, 81);
            this.dataGridViewThoiGian.Name = "dataGridViewThoiGian";
            this.dataGridViewThoiGian.Size = new System.Drawing.Size(927, 309);
            this.dataGridViewThoiGian.TabIndex = 58;
            // 
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(111, 433);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(144, 20);
            this.textBoxThang.TabIndex = 80;
            // 
            // textBoxNam
            // 
            this.textBoxNam.Location = new System.Drawing.Point(361, 433);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(178, 20);
            this.textBoxNam.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Năm :";
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(829, 490);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(127, 31);
            this.buttonThem.TabIndex = 83;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
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
            this.buttonQuayLai.TabIndex = 84;
            this.buttonQuayLai.Text = "Trờ về";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // DanhSachThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.textBoxThang);
            this.Controls.Add(this.labelTenPhongBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewThoiGian);
            this.Name = "DanhSachThoiGian";
            this.Text = "Thời gian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachThoiGian_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTenPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewThoiGian;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}