using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laptrinhwin
{
    public partial class HoaDon : Form
    {
        DataTable dtDichVu = new DataTable();

        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            // Thiết lập giao diện hiện đại
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.BackColor = Color.FromArgb(240, 245, 249);

            KhoiTaoBangDichVu();
            // Load dữ liệu mẫu cho ComboBox (Sau này lấy từ Database)
            cboMaPhong.Items.AddRange(new object[] { "Phòng 101", "Phòng 102", "Phòng VIP 1" });
            cboNhanVien.Items.AddRange(new object[] { "Nguyễn Văn A", "Trần Thị B" });
        }

        void KhoiTaoBangDichVu()
        {
            dtDichVu.Columns.Add("TenDV", typeof(string));
            dtDichVu.Columns.Add("SoLuong", typeof(int));
            dtDichVu.Columns.Add("DonGia", typeof(double));
            dtDichVu.Columns.Add("ThanhTien", typeof(double), "SoLuong * DonGia");

            dgvDichVu.DataSource = dtDichVu;
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            // 1. Tính tổng tiền dịch vụ
            double tongDV = 0;
            foreach (DataRow row in dtDichVu.Rows)
            {
                tongDV += Convert.ToDouble(row["ThanhTien"]);
            }

            // 2. Lấy tiền giờ (giả sử nhập tay hoặc tính theo thời gian)
            double tienGio = string.IsNullOrEmpty(txtTienGio.Text) ? 0 : Convert.ToDouble(txtTienGio.Text);

            // 3. Tổng hợp thanh toán
            double tongCong = tongDV + tienGio;
            lblTongTien.Text = string.Format("{0:N0} VNĐ", tongCong);
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            // Thêm nhanh dịch vụ để test
            dtDichVu.Rows.Add("Bia Heineken", 5, 25000);
            dtDichVu.Rows.Add("Đĩa trái cây", 1, 150000);
        }
    }
}