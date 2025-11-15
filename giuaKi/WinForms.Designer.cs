namespace giuaKi
{
    partial class WinForms
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
            cboMaKhoa = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtHocKy = new TextBox();
            txtSoTinChi = new TextBox();
            txtTenMH = new TextBox();
            txtMaMH = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            dgvHienThi = new DataGridView();
            butNhap = new Button();
            butSua = new Button();
            butXoa = new Button();
            butTim = new Button();
            butThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            SuspendLayout();
            // 
            // cboMaKhoa
            // 
            cboMaKhoa.FormattingEnabled = true;
            cboMaKhoa.Location = new Point(175, 29);
            cboMaKhoa.Name = "cboMaKhoa";
            cboMaKhoa.Size = new Size(308, 28);
            cboMaKhoa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Khoa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 74);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã Môn Học: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 119);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên Môn Học:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 204);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 4;
            label4.Text = "Học Kỳ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 159);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 5;
            label5.Text = "Số Tín Chỉ:";
            // 
            // txtHocKy
            // 
            txtHocKy.Location = new Point(175, 204);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(308, 27);
            txtHocKy.TabIndex = 6;
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(175, 159);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(308, 27);
            txtSoTinChi.TabIndex = 7;
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(175, 119);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(308, 27);
            txtTenMH.TabIndex = 8;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(175, 74);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(308, 27);
            txtMaMH.TabIndex = 9;
            // 
            // dgvHienThi
            // 
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Location = new Point(38, 268);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.Size = new Size(821, 241);
            dgvHienThi.TabIndex = 11;
            // 
            // butNhap
            // 
            butNhap.Location = new Point(537, 29);
            butNhap.Name = "butNhap";
            butNhap.Size = new Size(94, 29);
            butNhap.TabIndex = 12;
            butNhap.Text = "Nhập";
            butNhap.UseVisualStyleBackColor = true;
            butNhap.Click += butNhap_Click;
            // 
            // butSua
            // 
            butSua.Location = new Point(668, 29);
            butSua.Name = "butSua";
            butSua.Size = new Size(94, 29);
            butSua.TabIndex = 13;
            butSua.Text = "Sửa ";
            butSua.UseVisualStyleBackColor = true;
            // 
            // butXoa
            // 
            butXoa.Location = new Point(798, 29);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(94, 29);
            butXoa.TabIndex = 14;
            butXoa.Text = "Xóa";
            butXoa.UseVisualStyleBackColor = true;
            // 
            // butTim
            // 
            butTim.Location = new Point(595, 97);
            butTim.Name = "butTim";
            butTim.Size = new Size(94, 29);
            butTim.TabIndex = 15;
            butTim.Text = "Tìm";
            butTim.UseVisualStyleBackColor = true;
            // 
            // butThoat
            // 
            butThoat.Location = new Point(736, 97);
            butThoat.Name = "butThoat";
            butThoat.Size = new Size(94, 29);
            butThoat.TabIndex = 16;
            butThoat.Text = "Thoát";
            butThoat.UseVisualStyleBackColor = true;
            // 
            // WinForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 565);
            Controls.Add(butThoat);
            Controls.Add(butTim);
            Controls.Add(butXoa);
            Controls.Add(butSua);
            Controls.Add(butNhap);
            Controls.Add(dgvHienThi);
            Controls.Add(txtMaMH);
            Controls.Add(txtTenMH);
            Controls.Add(txtSoTinChi);
            Controls.Add(txtHocKy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboMaKhoa);
            Name = "WinForms";
            Text = "WinForms";
            TopMost = true;
            Load += WinForms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMaKhoa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHocKy;
        private TextBox txtSoTinChi;
        private TextBox txtTenMH;
        private TextBox txtMaMH;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DataGridView dgvHienThi;
        private Button butNhap;
        private Button butSua;
        private Button butXoa;
        private Button butTim;
        private Button butThoat;
    }
}