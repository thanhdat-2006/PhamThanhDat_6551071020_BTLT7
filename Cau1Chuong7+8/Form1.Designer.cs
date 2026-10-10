namespace TriThucBooksApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaTL = new Label();
            lblTenTL = new Label();
            lblMoTa = new Label();
            lblNgayTao = new Label();
            txtMaTL = new TextBox();
            txtTenTL = new TextBox();
            txtMoTa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            dgvTheLoaiSach = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).BeginInit();
            SuspendLayout();
            // 
            // lblMaTL
            // 
            lblMaTL.AutoSize = true;
            lblMaTL.Location = new Point(79, 24);
            lblMaTL.Name = "lblMaTL";
            lblMaTL.Size = new Size(100, 25);
            lblMaTL.TabIndex = 0;
            lblMaTL.Text = "Mã thể loại";
            // 
            // lblTenTL
            // 
            lblTenTL.AutoSize = true;
            lblTenTL.Location = new Point(79, 86);
            lblTenTL.Name = "lblTenTL";
            lblTenTL.Size = new Size(101, 25);
            lblTenTL.TabIndex = 1;
            lblTenTL.Text = "Tên thể loại";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(79, 163);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(59, 25);
            lblMoTa.TabIndex = 2;
            lblMoTa.Text = "Mô tả";
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(81, 270);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(89, 25);
            lblNgayTao.TabIndex = 3;
            lblNgayTao.Text = "Ngày tạo:";
            // 
            // txtMaTL
            // 
            txtMaTL.Location = new Point(218, 21);
            txtMaTL.Name = "txtMaTL";
            txtMaTL.ReadOnly = true;
            txtMaTL.Size = new Size(246, 31);
            txtMaTL.TabIndex = 4;
            // 
            // txtTenTL
            // 
            txtTenTL.Location = new Point(218, 83);
            txtTenTL.Name = "txtTenTL";
            txtTenTL.Size = new Size(246, 31);
            txtTenTL.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(218, 160);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(246, 98);
            txtMoTa.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(522, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(640, 29);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(758, 29);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(876, 29);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 34);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(522, 309);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(81, 312);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(383, 31);
            txtTimKiem.TabIndex = 12;
            // 
            // dgvTheLoaiSach
            // 
            dgvTheLoaiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoaiSach.Location = new Point(79, 395);
            dgvTheLoaiSach.Name = "dgvTheLoaiSach";
            dgvTheLoaiSach.RowHeadersWidth = 62;
            dgvTheLoaiSach.Size = new Size(909, 225);
            dgvTheLoaiSach.TabIndex = 13;
            dgvTheLoaiSach.SelectionChanged += dgvTheLoaiSach_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 674);
            Controls.Add(dgvTheLoaiSach);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenTL);
            Controls.Add(txtMaTL);
            Controls.Add(lblNgayTao);
            Controls.Add(lblMoTa);
            Controls.Add(lblTenTL);
            Controls.Add(lblMaTL);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaTL;
        private Label lblTenTL;
        private Label lblMoTa;
        private Label lblNgayTao;
        private TextBox txtMaTL;
        private TextBox txtTenTL;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvTheLoaiSach;
    }
}
