﻿
namespace BTL_HuongSuKien_v2.Forms
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.menuStripTrangChu = new System.Windows.Forms.MenuStrip();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênTheoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênTheoPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênTheoPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTrangChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTrangChu
            // 
            this.menuStripTrangChu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStripTrangChu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStripTrangChu.Location = new System.Drawing.Point(0, 0);
            this.menuStripTrangChu.Name = "menuStripTrangChu";
            this.menuStripTrangChu.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.menuStripTrangChu.Size = new System.Drawing.Size(984, 45);
            this.menuStripTrangChu.TabIndex = 0;
            this.menuStripTrangChu.Text = "menuStrip1";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.lươngToolStripMenuItem,
            this.hợpĐồngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênTheoTênToolStripMenuItem,
            this.nhânViênTheoPhòngBanToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênTheoPhòngToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.clickNhanVien);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.clickPhongBan);
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.lươngToolStripMenuItem.Text = "Lương";
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp đồng";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // nhânViênTheoTênToolStripMenuItem
            // 
            this.nhânViênTheoTênToolStripMenuItem.Name = "nhânViênTheoTênToolStripMenuItem";
            this.nhânViênTheoTênToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.nhânViênTheoTênToolStripMenuItem.Text = "Nhân viên theo tên";
            // 
            // nhânViênTheoPhòngBanToolStripMenuItem
            // 
            this.nhânViênTheoPhòngBanToolStripMenuItem.Name = "nhânViênTheoPhòngBanToolStripMenuItem";
            this.nhânViênTheoPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.nhânViênTheoPhòngBanToolStripMenuItem.Text = "Nhân viên theo phòng ban";
            // 
            // nhânViênTheoPhòngToolStripMenuItem
            // 
            this.nhânViênTheoPhòngToolStripMenuItem.Name = "nhânViênTheoPhòngToolStripMenuItem";
            this.nhânViênTheoPhòngToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.nhânViênTheoPhòngToolStripMenuItem.Text = "Nhân viên theo phòng";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStripTrangChu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStripTrangChu;
            this.Name = "TrangChu";
            this.Text = "Trang chủ";
            this.menuStripTrangChu.ResumeLayout(false);
            this.menuStripTrangChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTrangChu;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênTheoTênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênTheoPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênTheoPhòngToolStripMenuItem;
    }
}