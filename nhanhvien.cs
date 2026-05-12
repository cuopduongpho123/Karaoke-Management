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
    // 1. Đổi tên class từ nhanvien -> nhanhvien
    public partial class nhanhvien : Form
    {
        DataTable dtNhanVien = new DataTable();

        // 2. Đổi tên Constructor cho khớp với tên Class
        public nhanhvien()
        {
            InitializeComponent();
        }

        // 3. Đổi tên sự kiện Load (Lưu ý: Bạn cần kiểm tra trong Properties của Form 
        // xem mục Events -> Load đã chọn đúng tên hàm này chưa)
        private void nhanhvien_Load(object sender, EventArgs e)
        {
            cboChucVu.Items.Add("Quản lý");
            cboChucVu.Items.Add("Nhân viên");

            TaoBangNhanVien();
        }

        // Tạo bảng dữ liệu
        void TaoBangNhanVien()
        {
            dtNhanVien.Columns.Add("MaNV");
            dtNhanVien.Columns.Add("TenNV");
            dtNhanVien.Columns.Add("SDT");
            dtNhanVien.Columns.Add("ChucVu");

            dgvNhanVien.DataSource = dtNhanVien;
        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            dtNhanVien.Rows.Add(
                txtMaNV.Text,
                txtTenNV.Text,
                txtSDT.Text,
                cboChucVu.Text
            );

            MessageBox.Show("Thêm thành công!");

            LamMoi();
        }

        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                int i = dgvNhanVien.CurrentRow.Index;

                dtNhanVien.Rows[i]["MaNV"] = txtMaNV.Text;
                dtNhanVien.Rows[i]["TenNV"] = txtTenNV.Text;
                dtNhanVien.Rows[i]["SDT"] = txtSDT.Text;
                dtNhanVien.Rows[i]["ChucVu"] = cboChucVu.Text;

                dgvNhanVien.DataSource = dtNhanVien;

                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
            }
        }

        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                int i = dgvNhanVien.CurrentRow.Index;

                dtNhanVien.Rows.RemoveAt(i);

                dgvNhanVien.DataSource = dtNhanVien;

                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
            }
        }

        // LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // Hàm làm mới
        void LamMoi()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();

            cboChucVu.SelectedIndex = -1;

            txtMaNV.Focus();
        }

        // Click DataGridView
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNV.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtTenNV.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtSDT.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();

                cboChucVu.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e) { }

        private void lblChucVu_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}