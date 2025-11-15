namespace giuaKi
{
    partial class Form1
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
            txtTenMH = new TextBox();
            txtSoTinChi = new TextBox();
            txtHocKy = new TextBox();
            txtMaMH = new TextBox();
            butSua = new Button();
            butNhap = new Button();
            butXoa = new Button();
            butThoat = new Button();
            btnTim = new Button();
            dgvHienThi = new DataGridView();
            cboMaKhoa = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            SuspendLayout();
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(134, 144);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(219, 27);
            txtTenMH.TabIndex = 0;
            txtTenMH.TextChanged += txtTenMH_KeyDown;
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(134, 201);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(219, 27);
            txtSoTinChi.TabIndex = 1;
            txtSoTinChi.TextChanged += txtSoTinChi_KeyDown;
            // 
            // txtHocKy
            // 
            txtHocKy.Location = new Point(134, 255);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(219, 27);
            txtHocKy.TabIndex = 2;
            txtHocKy.TextChanged += txtHocKy_TextChanged;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(134, 87);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(219, 27);
            txtMaMH.TabIndex = 3;
            txtMaMH.TextChanged += txtMaMH_KeyDown;
            // 
            // butSua
            // 
            butSua.Location = new Point(165, 318);
            butSua.Name = "butSua";
            butSua.Size = new Size(94, 29);
            butSua.TabIndex = 4;
            butSua.Text = "Sửa ";
            butSua.UseVisualStyleBackColor = true;
            // 
            // butNhap
            // 
            butNhap.Location = new Point(39, 318);
            butNhap.Name = "butNhap";
            butNhap.Size = new Size(94, 29);
            butNhap.TabIndex = 5;
            butNhap.Text = "Nhập";
            butNhap.UseVisualStyleBackColor = true;
            // 
            // butXoa
            // 
            butXoa.Location = new Point(301, 318);
            butXoa.Name = "butXoa";
            butXoa.Size = new Size(94, 29);
            butXoa.TabIndex = 6;
            butXoa.Text = "Xóa";
            butXoa.UseVisualStyleBackColor = true;
            // 
            // butThoat
            // 
            butThoat.Location = new Point(165, 375);
            butThoat.Name = "butThoat";
            butThoat.Size = new Size(94, 29);
            butThoat.TabIndex = 7;
            butThoat.Text = "Thoát";
            butThoat.UseVisualStyleBackColor = true;
            butThoat.Click += butThoat_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(40, 375);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // dgvHienThi
            // 
            dgvHienThi.AllowUserToOrderColumns = true;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Location = new Point(424, 8);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.Size = new Size(409, 396);
            dgvHienThi.TabIndex = 9;
            // 
            // cboMaKhoa
            // 
            cboMaKhoa.FormattingEnabled = true;
            cboMaKhoa.Location = new Point(134, 37);
            cboMaKhoa.Name = "cboMaKhoa";
            cboMaKhoa.Size = new Size(219, 28);
            cboMaKhoa.TabIndex = 10;
            cboMaKhoa.SelectedIndexChanged += cboMaKhoa_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 11;
            label1.Text = " Mã khoa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 87);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 12;
            label2.Text = " Mã Môn Học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 147);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 13;
            label3.Text = "Tên Môn Học:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 201);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 14;
            label4.Text = "Số Tín Chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 255);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 15;
            label5.Text = "Học Kỳ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboMaKhoa);
            Controls.Add(dgvHienThi);
            Controls.Add(btnTim);
            Controls.Add(butThoat);
            Controls.Add(butXoa);
            Controls.Add(butNhap);
            Controls.Add(butSua);
            Controls.Add(txtMaMH);
            Controls.Add(txtHocKy);
            Controls.Add(txtSoTinChi);
            Controls.Add(txtTenMH);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenMH;
        private TextBox txtSoTinChi;
        private TextBox txtHocKy;
        private TextBox txtMaMH;
        private Button butSua;
        private Button butNhap;
        private Button butXoa;
        private Button butThoat;
        private Button btnTim;
        private DataGridView dgvHienThi;
        private ComboBox cboMaKhoa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}