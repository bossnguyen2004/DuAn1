namespace _3_PL.Views
{
    partial class frmCarts
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
            dgvCart = new DataGridView();
            label1 = new Label();
            txtMa = new TextBox();
            groupBox2 = new GroupBox();
            cbChatLieu = new ComboBox();
            cbMauSac = new ComboBox();
            cbSize = new ComboBox();
            cbNSX = new ComboBox();
            cbLoaiSanPham = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtDiaChi = new TextBox();
            label11 = new Label();
            txtSdtNhan = new TextBox();
            label10 = new Label();
            txtGhiChu = new TextBox();
            label13 = new Label();
            txtEmail = new TextBox();
            label12 = new Label();
            txtSoLuong = new TextBox();
            label9 = new Label();
            txtGiaBan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnMuaHang = new Button();
            btnBanHang = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCart);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(2, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(3, 19);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.Size = new Size(1002, 183);
            dgvCart.TabIndex = 0;
            dgvCart.CellClick += dgvBills_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm";
            // 
            // txtMa
            // 
            txtMa.Enabled = false;
            txtMa.Location = new Point(98, 31);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(160, 23);
            txtMa.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbChatLieu);
            groupBox2.Controls.Add(cbMauSac);
            groupBox2.Controls.Add(cbSize);
            groupBox2.Controls.Add(cbNSX);
            groupBox2.Controls.Add(cbLoaiSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtSdtNhan);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtGiaBan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtMa);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1014, 186);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // cbChatLieu
            // 
            cbChatLieu.FormattingEnabled = true;
            cbChatLieu.Location = new Point(365, 70);
            cbChatLieu.Name = "cbChatLieu";
            cbChatLieu.Size = new Size(173, 23);
            cbChatLieu.TabIndex = 5;
            // 
            // cbMauSac
            // 
            cbMauSac.FormattingEnabled = true;
            cbMauSac.Location = new Point(365, 31);
            cbMauSac.Name = "cbMauSac";
            cbMauSac.Size = new Size(173, 23);
            cbMauSac.TabIndex = 5;
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(366, 110);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(173, 23);
            cbSize.TabIndex = 5;
            // 
            // cbNSX
            // 
            cbNSX.Enabled = false;
            cbNSX.FormattingEnabled = true;
            cbNSX.Location = new Point(97, 148);
            cbNSX.Name = "cbNSX";
            cbNSX.Size = new Size(161, 23);
            cbNSX.TabIndex = 4;
            // 
            // cbLoaiSanPham
            // 
            cbLoaiSanPham.Enabled = false;
            cbLoaiSanPham.FormattingEnabled = true;
            cbLoaiSanPham.Location = new Point(97, 110);
            cbLoaiSanPham.Name = "cbLoaiSanPham";
            cbLoaiSanPham.Size = new Size(161, 23);
            cbLoaiSanPham.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(16, 151);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 1;
            label4.Text = "Nhà sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(8, 113);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 1;
            label3.Text = "Loại sản phẩm";
            // 
            // txtTen
            // 
            txtTen.Enabled = false;
            txtTen.Location = new Point(98, 70);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(160, 23);
            txtTen.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(9, 73);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(623, 110);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(155, 61);
            txtDiaChi.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(573, 113);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 1;
            label11.Text = "Địa chỉ";
            // 
            // txtSdtNhan
            // 
            txtSdtNhan.Location = new Point(623, 70);
            txtSdtNhan.Name = "txtSdtNhan";
            txtSdtNhan.Size = new Size(155, 23);
            txtSdtNhan.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(557, 73);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 1;
            label10.Text = "SĐT nhận";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(853, 70);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(155, 23);
            txtGhiChu.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(798, 73);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 1;
            label13.Text = "Ghi chú";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(853, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(811, 34);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 1;
            label12.Text = "Email";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(623, 31);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(155, 23);
            txtSoLuong.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(560, 34);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 1;
            label9.Text = "Số lượng";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Enabled = false;
            txtGiaBan.Location = new Point(366, 148);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(172, 23);
            txtGiaBan.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(286, 151);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 1;
            label8.Text = "Giá bán(đ)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(284, 113);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 1;
            label7.Text = "Kích thước";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(294, 73);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 1;
            label6.Text = "Chất liệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(297, 34);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 1;
            label5.Text = "Màu sắc";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(575, 204);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 32);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(458, 204);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 32);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Gold;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(342, 204);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 32);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnMuaHang
            // 
            btnMuaHang.BackColor = SystemColors.ActiveCaption;
            btnMuaHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMuaHang.Location = new Point(895, 204);
            btnMuaHang.Name = "btnMuaHang";
            btnMuaHang.Size = new Size(98, 32);
            btnMuaHang.TabIndex = 9;
            btnMuaHang.Text = "Mua hàng";
            btnMuaHang.UseVisualStyleBackColor = false;
            btnMuaHang.Click += btnMuaHang_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = SystemColors.ActiveCaption;
            btnBanHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBanHang.Location = new Point(895, 204);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(98, 32);
            btnBanHang.TabIndex = 9;
            btnBanHang.Text = "Tạo đơn hàng";
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // frmCarts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 451);
            Controls.Add(btnBanHang);
            Controls.Add(btnMuaHang);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(1035, 490);
            MinimizeBox = false;
            MinimumSize = new Size(1035, 490);
            Name = "frmCarts";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đơn hàng";
            Load += frmBills_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMa;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtGiaBan;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvCart;
        private ComboBox cbLoaiSanPham;
        private ComboBox cbSize;
        private ComboBox cbMauSac;
        private ComboBox cbNSX;
        private ComboBox cbChatLieu;
        private TextBox txtSoLuong;
        private Label label9;
        private TextBox txtDiaChi;
        private Label label11;
        private TextBox txtSdtNhan;
        private Label label10;
        private TextBox txtGhiChu;
        private Label label13;
        private TextBox txtEmail;
        private Label label12;
        private Button btnClear;
        private Button btnXoa;
        private Button btnSua;
        private Button btnMuaHang;
        private Button btnBanHang;
    }
}