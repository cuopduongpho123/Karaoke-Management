namespace laptrinhwin
{
    partial class HoaDon
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTienGio = new System.Windows.Forms.TextBox();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTienGio = new System.Windows.Forms.Label();
            this.lblLabelTong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(355, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(30, 90);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(93, 20);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Chọn Phòng:";
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(140, 87);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(180, 28);
            this.cboMaPhong.TabIndex = 2;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(30, 140);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(102, 20);
            this.lblNhanVien.TabIndex = 3;
            this.lblNhanVien.Text = "Nhân viên lập:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(140, 137);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(180, 28);
            this.cboNhanVien.TabIndex = 4;
            // 
            // lblTienGio
            // 
            this.lblTienGio.AutoSize = true;
            this.lblTienGio.Location = new System.Drawing.Point(30, 190);
            this.lblTienGio.Name = "lblTienGio";
            this.lblTienGio.Size = new System.Drawing.Size(107, 20);
            this.lblTienGio.TabIndex = 5;
            this.lblTienGio.Text = "Tiền giờ (VNĐ):";
            // 
            // txtTienGio
            // 
            this.txtTienGio.Location = new System.Drawing.Point(140, 187);
            this.txtTienGio.Name = "txtTienGio";
            this.txtTienGio.Size = new System.Drawing.Size(180, 27);
            this.txtTienGio.TabIndex = 6;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(350, 80);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(580, 240);
            this.dgvDichVu.TabIndex = 7;
            // 
            // lblLabelTong
            // 
            this.lblLabelTong.AutoSize = true;
            this.lblLabelTong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLabelTong.Location = new System.Drawing.Point(350, 340);
            this.lblLabelTong.Name = "lblLabelTong";
            this.lblLabelTong.Size = new System.Drawing.Size(211, 28);
            this.lblLabelTong.TabIndex = 8;
            this.lblLabelTong.Text = "Tổng cộng thanh toán:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblTongTien.Location = new System.Drawing.Point(350, 370);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(142, 54);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(710, 350);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(220, 60);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "XUẤT HÓA ĐƠN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblLabelTong);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.txtTienGio);
            this.Controls.Add(this.lblTienGio);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblTitle);
            this.Name = "HoaDon";
            this.Text = "Hệ thống Quản lý Karaoke - Thanh toán";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTienGio;
        private System.Windows.Forms.ComboBox cboMaPhong;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTienGio;
        private System.Windows.Forms.Label lblLabelTong;
    }
}