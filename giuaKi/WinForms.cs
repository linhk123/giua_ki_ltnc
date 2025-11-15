using giuaKi.bus;
using giuaKi.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giuaKi
{
    public partial class WinForms : Form
    {
        private KhoaBUS khoaBUS = new KhoaBUS();
        private MonHocBUS monHocBUS = new MonHocBUS();

        public WinForms()
        {
            InitializeComponent();
            butThoat.Click += ButThoat_Click;
            this.FormClosing += Form1_FormClosing;
            txtMaMH.KeyDown += TxtMaMH_KeyDown;
            txtTenMH.KeyDown += TxtTenMH_KeyDown;
            txtSoTinChi.KeyDown += TxtSoTinChi_KeyDown;

        }

        private void WinForms_Load(object sender, EventArgs e)
        {
            var dsKhoa = khoaBUS.GetAll();
            cboMaKhoa.DataSource = dsKhoa;
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
            cboMaKhoa.SelectedIndex = -1;

            // Load tất cả môn học
            monHocBUS.LoadAll();
            BindGrid(monHocBUS.GetAll());

            // Khi chọn khoa, lọc môn học
            cboMaKhoa.SelectedIndexChanged += CboMaKhoa_SelectedIndexChanged;

        }
        private void ButThoat_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void butNhap_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var dsKhoa = khoaBUS.GetAll();
            cboMaKhoa.DataSource = dsKhoa;
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";
            cboMaKhoa.SelectedIndex = -1;

            // Load tất cả môn học
            monHocBUS.LoadAll();
            BindGrid(monHocBUS.GetAll());

            // Khi chọn khoa, lọc môn học
            cboMaKhoa.SelectedIndexChanged += CboMaKhoa_SelectedIndexChanged;

        }
        private void BindGrid(List<MonHoc> ds)
        {
            dgvHienThi.DataSource = null;
            dgvHienThi.DataSource = ds;
        }

        private void CboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaKhoa.SelectedIndex >= 0)
            {
                var ma = ((Khoa)cboMaKhoa.SelectedItem).MaKhoa;
                var ds = monHocBUS.GetByKhoa(ma);
                BindGrid(ds);
            }
            else
            {
                BindGrid(monHocBUS.GetAll());
            }
        }
        private void TxtMaMH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTenMH.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true; // tránh tiếng "ding"
            }
        }

        private void TxtTenMH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSoTinChi.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtSoTinChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHocKy.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Nếu muốn txtHocKy Enter chuyển đến nút Nhập
        private void TxtHocKy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butNhap.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


    }
}
