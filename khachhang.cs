using System;
using System.Data;
using System.Windows.Forms;

namespace laptrinhwin
{
    public partial class khachhang : Form
    {
        DataTable tableKhachHang = new DataTable();

        public khachhang()
        {
            InitializeComponent();
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            TaoBangKhachHang();
        }

        private void TaoBangKhachHang()
        {
            tableKhachHang.Columns.Add("Mã khách hàng");
            tableKhachHang.Columns.Add("Họ tên");
            tableKhachHang.Columns.Add("Số điện thoại");
            tableKhachHang.Columns.Add("Địa chỉ");

            dgvKhachHang.DataSource = tableKhachHang;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" ||
                txtHoTen.Text == "" ||
                txtSDT.Text == "" ||
                txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            tableKhachHang.Rows.Add(
                txtMaKH.Text,
                txtHoTen.Text,
                txtSDT.Text,
                txtDiaChi.Text
            );

            MessageBox.Show("Thêm thành công!");

            NhapLai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Chọn khách hàng cần xóa!");
                return;
            }

            int index = dgvKhachHang.CurrentRow.Index;

            tableKhachHang.Rows[index].Delete();

            MessageBox.Show("Xóa thành công!");

            NhapLai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Chọn khách hàng cần sửa!");
                return;
            }

            int index = dgvKhachHang.CurrentRow.Index;

            tableKhachHang.Rows[index][0] = txtMaKH.Text;
            tableKhachHang.Rows[index][1] = txtHoTen.Text;
            tableKhachHang.Rows[index][2] = txtSDT.Text;
            tableKhachHang.Rows[index][3] = txtDiaChi.Text;

            MessageBox.Show("Sửa thành công!");

            NhapLai();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void NhapLai()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();

            txtMaKH.Focus();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tableKhachHang.DefaultView;

            dv.RowFilter = string.Format(
                "[Mã khách hàng] LIKE '%{0}%' OR [Họ tên] LIKE '%{0}%'",
                txtTimKiem.Text
            );

            dgvKhachHang.DataSource = dv;
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}