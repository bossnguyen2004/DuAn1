namespace _3_PL.Views
{
    partial class FrmSanPham2
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
            groupBox1 = new GroupBox();
            dgvDanhSach = new DataGridView();
            groupBox2 = new GroupBox();
            txtTen = new TextBox();
            cbTrangThai = new CheckBox();
            cbMauSac = new ComboBox();
            label8 = new Label();
            cbSize = new ComboBox();
            label7 = new Label();
            cbChatLieu = new ComboBox();
            label6 = new Label();
            cbLoaiSanPham = new ComboBox();
            label5 = new Label();
            cbNSX = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtMa = new TextBox();
            ptbAnh = new PictureBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnAnh = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSach);
            groupBox1.Location = new Point(2, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 19);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.Size = new Size(789, 241);
            dgvDanhSach.TabIndex = 0;
            dgvDanhSach.CellClick += dgvDanhSach_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(cbTrangThai);
            groupBox2.Controls.Add(cbMauSac);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbSize);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbChatLieu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbLoaiSanPham);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbNSX);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMa);
            groupBox2.Controls.Add(ptbAnh);
            groupBox2.Location = new Point(2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(792, 170);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(96, 17);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(206, 23);
            txtTen.TabIndex = 5;
            // 
            // cbTrangThai
            // 
            cbTrangThai.AutoSize = true;
            cbTrangThai.Location = new Point(410, 133);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(78, 19);
            cbTrangThai.TabIndex = 4;
            cbTrangThai.Text = "Còn hàng";
            cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // cbMauSac
            // 
            cbMauSac.FormattingEnabled = true;
            cbMauSac.Location = new Point(410, 93);
            cbMauSac.Name = "cbMauSac";
            cbMauSac.Size = new Size(221, 23);
            cbMauSac.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 96);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 2;
            label8.Text = "Màu sắc";
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(410, 55);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(221, 23);
            cbSize.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(324, 58);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 2;
            label7.Text = "Kích thước";
            // 
            // cbChatLieu
            // 
            cbChatLieu.FormattingEnabled = true;
            cbChatLieu.Location = new Point(410, 17);
            cbChatLieu.Name = "cbChatLieu";
            cbChatLieu.Size = new Size(221, 23);
            cbChatLieu.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 20);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 2;
            label6.Text = "Chất liệu";
            // 
            // cbLoaiSanPham
            // 
            cbLoaiSanPham.FormattingEnabled = true;
            cbLoaiSanPham.Location = new Point(96, 93);
            cbLoaiSanPham.Name = "cbLoaiSanPham";
            cbLoaiSanPham.Size = new Size(206, 23);
            cbLoaiSanPham.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 96);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 2;
            label5.Text = "Loại sản phẩm";
            // 
            // cbNSX
            // 
            cbNSX.FormattingEnabled = true;
            cbNSX.Location = new Point(96, 131);
            cbNSX.Name = "cbNSX";
            cbNSX.Size = new Size(206, 23);
            cbNSX.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 134);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 2;
            label4.Text = "Nhà sản xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 58);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 20);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(96, 55);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(206, 23);
            txtMa.TabIndex = 1;
            // 
            // ptbAnh
            // 
            ptbAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbAnh.Location = new Point(637, 14);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(149, 147);
            ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAnh.TabIndex = 0;
            ptbAnh.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(98, 179);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 35);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(237, 179);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 35);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(382, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 35);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(662, 179);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(99, 35);
            btnAnh.TabIndex = 2;
            btnAnh.Text = "Chọn ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // FrmSanPham2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(btnAnh);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 534);
            MinimizeBox = false;
            MinimumSize = new Size(816, 534);
            Name = "FrmSanPham2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += FrmSanPham2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDanhSach;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label1;
        private Label label2;
        private TextBox txtMa;
        private TextBox textBox2;
        private PictureBox ptbAnh;
        private Label label3;
        private ComboBox cbMauSac;
        private Label label8;
        private ComboBox cbSize;
        private Label label7;
        private ComboBox cbChatLieu;
        private Label label6;
        private ComboBox cbLoaiSanPham;
        private Label label5;
        private ComboBox cbNSX;
        private Label label4;
        private CheckBox cbTrangThai;
        private TextBox txtTen;
        private Button btnAnh;
    }
}