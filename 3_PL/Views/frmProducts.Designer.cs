namespace _3_PL.Views
{
    partial class frmProducts
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
            dgvSanPham = new DataGridView();
            label1 = new Label();
            txtTen = new TextBox();
            groupBox2 = new GroupBox();
            cbChatLieu = new ComboBox();
            cbMauSac = new ComboBox();
            cbSize = new ComboBox();
            cbNSX = new ComboBox();
            cbLoaiSanPham = new ComboBox();
            ptbSanPham = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            txtGiaBan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnBanHang = new Button();
            btnClear = new Button();
            btnThemVaoGio = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSanPham);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(2, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1014, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(3, 19);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.Size = new Size(1008, 193);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(67, 34);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(98, 31);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(285, 23);
            txtTen.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbChatLieu);
            groupBox2.Controls.Add(cbMauSac);
            groupBox2.Controls.Add(cbSize);
            groupBox2.Controls.Add(cbNSX);
            groupBox2.Controls.Add(cbLoaiSanPham);
            groupBox2.Controls.Add(ptbSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtMa);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtGiaBan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTen);
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
            cbChatLieu.Location = new Point(511, 70);
            cbChatLieu.Name = "cbChatLieu";
            cbChatLieu.Size = new Size(278, 23);
            cbChatLieu.TabIndex = 5;
            // 
            // cbMauSac
            // 
            cbMauSac.FormattingEnabled = true;
            cbMauSac.Location = new Point(511, 31);
            cbMauSac.Name = "cbMauSac";
            cbMauSac.Size = new Size(278, 23);
            cbMauSac.TabIndex = 5;
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(512, 110);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(278, 23);
            cbSize.TabIndex = 5;
            // 
            // cbNSX
            // 
            cbNSX.FormattingEnabled = true;
            cbNSX.Location = new Point(97, 148);
            cbNSX.Name = "cbNSX";
            cbNSX.Size = new Size(286, 23);
            cbNSX.TabIndex = 4;
            // 
            // cbLoaiSanPham
            // 
            cbLoaiSanPham.FormattingEnabled = true;
            cbLoaiSanPham.Location = new Point(97, 110);
            cbLoaiSanPham.Name = "cbLoaiSanPham";
            cbLoaiSanPham.Size = new Size(286, 23);
            cbLoaiSanPham.TabIndex = 4;
            // 
            // ptbSanPham
            // 
            ptbSanPham.BorderStyle = BorderStyle.FixedSingle;
            ptbSanPham.Image = Properties.Resources._default;
            ptbSanPham.Location = new Point(832, 31);
            ptbSanPham.Name = "ptbSanPham";
            ptbSanPham.Size = new Size(160, 140);
            ptbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSanPham.TabIndex = 3;
            ptbSanPham.TabStop = false;
            ptbSanPham.Click += ptbSanPham_Click;
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
            // txtMa
            // 
            txtMa.Location = new Point(98, 70);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(285, 23);
            txtMa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(67, 73);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(512, 148);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(277, 23);
            txtGiaBan.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(432, 151);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 1;
            label8.Text = "Giá bán(đ)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(430, 113);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 1;
            label7.Text = "Kích thước";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(440, 73);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 1;
            label6.Text = "Chất liệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(443, 34);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 1;
            label5.Text = "Màu sắc";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Location = new Point(208, 194);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 32);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Gold;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(324, 194);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 32);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(440, 194);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 32);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = SystemColors.ActiveCaption;
            btnBanHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBanHang.Location = new Point(896, 194);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(98, 32);
            btnBanHang.TabIndex = 4;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(557, 194);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 32);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnThemVaoGio
            // 
            btnThemVaoGio.BackColor = SystemColors.ActiveCaption;
            btnThemVaoGio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemVaoGio.Location = new Point(896, 194);
            btnThemVaoGio.Name = "btnThemVaoGio";
            btnThemVaoGio.Size = new Size(98, 32);
            btnThemVaoGio.TabIndex = 4;
            btnThemVaoGio.Text = "Thêm vào giỏ";
            btnThemVaoGio.UseVisualStyleBackColor = false;
            btnThemVaoGio.Click += btnThemVaoGio_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 451);
            Controls.Add(btnThemVaoGio);
            Controls.Add(btnBanHang);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTen;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private TextBox txtMa;
        private Label label2;
        private TextBox txtGiaBan;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox ptbSanPham;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnBanHang;
        private Button btnClear;
        private DataGridView dgvSanPham;
        private ComboBox cbLoaiSanPham;
        private ComboBox cbSize;
        private ComboBox cbMauSac;
        private ComboBox cbNSX;
        private ComboBox cbChatLieu;
        private Button btnThemVaoGio;
    }
}