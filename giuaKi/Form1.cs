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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtMaMH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaMH_KeyDown);
            this.txtTenMH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenMH_KeyDown);
            this.txtSoTinChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTinChi_KeyDown);
            this.txtHocKy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHocKy_KeyDown);
        }


        private void butThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtSoTinChi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHocKy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaMH_KeyDown(object sender, EventArgs e)
        {
            
        }

        private void txtTenMH_KeyDown(object sender, EventArgs e)
        {
            
        }

        private void txtSoTinChi_KeyDown(object sender, EventArgs e)
        {
        
        }

        private void txtMaMH_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    if (string.IsNullOrWhiteSpace(txtMaMH.Text))
                    {
                        MessageBox.Show("Mã môn học không được để trống!");
                        txtMaMH.Focus();
                    }
                    else
                    {
                        txtTenMH.Focus();
                    }

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtTenMH_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    if (string.IsNullOrWhiteSpace(txtTenMH.Text))
                    {
                        MessageBox.Show("Tên môn học không được để trống!");
                        txtTenMH.Focus();
                    }
                    else
                    {
                        txtSoTinChi.Focus();
                    }

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        
        private void txtSoTinChi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    if (!int.TryParse(txtSoTinChi.Text, out int soTinChi))
                    {
                        MessageBox.Show("Số tín chỉ phải là số nguyên!");
                        txtSoTinChi.Focus();
                    }
                    else
                    {
                        txtHocKy.Focus();
                    }

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        
        private void txtHocKy_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    if (!int.TryParse(txtHocKy.Text, out int hocKy))
                    {
                        MessageBox.Show("Học kỳ phải là số nguyên!");
                        txtHocKy.Focus();
                    }
                    else
                    {
                        butNhap.Focus(); 
                    }

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


    }
}
