using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace laptrinhwin
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtmahoadon.Text, txtmaphong.Text , txtmakhachhang.Text ,  txttenphong.Text , txtprice.Text , txttime.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmahoadon.Text = row.Cells[0].Value.ToString();
                txtmakhachhang.Text = row.Cells[2].Value.ToString();
                txtmaphong.Text = row.Cells[1].Value.ToString();
                txttenphong.Text = row.Cells[3].Value.ToString();
                txtprice.Text = row.Cells[4].Value.ToString();
                txttime.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmahoadon.Text = "";
            txtmakhachhang.Text = "";
            txtmaphong.Text = "";
            txtprice.Text = "";
            txttenphong.Text = "";
            txttime.Text = "";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
