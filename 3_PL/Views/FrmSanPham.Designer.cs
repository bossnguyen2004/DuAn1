namespace _3_PL.Views
{
    partial class FrmSanPham
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
            dgvChatLieu = new DataGridView();
            label3 = new Label();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cbNhaSanXuat = new ComboBox();
            cbxChatLieu = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            ckKHD = new CheckBox();
            ckHoatdong = new CheckBox();
            txtMa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvChatLieu
            // 
            dgvChatLieu.BackgroundColor = Color.White;
            dgvChatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChatLieu.Location = new Point(12, 259);
            dgvChatLieu.Name = "dgvChatLieu";
            dgvChatLieu.Size = new Size(805, 179);
            dgvChatLieu.TabIndex = 22;
            dgvChatLieu.CellClick += dgvChatLieu_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 182);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 20;
            label3.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(106, 172);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(173, 23);
            txtTimKiem.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Location = new Point(637, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 241);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 26);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(25, 79);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(25, 120);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 28);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(25, 168);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbNhaSanXuat);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(cbxChatLieu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ckKHD);
            groupBox1.Controls.Add(ckHoatdong);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 241);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 133);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 21;
            label6.Text = "Trạng Thái:";
            // 
            // cbNhaSanXuat
            // 
            cbNhaSanXuat.FormattingEnabled = true;
            cbNhaSanXuat.Location = new Point(389, 85);
            cbNhaSanXuat.Name = "cbNhaSanXuat";
            cbNhaSanXuat.Size = new Size(172, 23);
            cbNhaSanXuat.TabIndex = 20;
            // 
            // cbxChatLieu
            // 
            cbxChatLieu.FormattingEnabled = true;
            cbxChatLieu.Location = new Point(389, 39);
            cbxChatLieu.Name = "cbxChatLieu";
            cbxChatLieu.Size = new Size(172, 23);
            cbxChatLieu.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 93);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 18;
            label5.Text = "Tên Nhà SX:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 42);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 17;
            label4.Text = "Tên Chất Liệu:";
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.Location = new Point(193, 129);
            ckKHD.Name = "ckKHD";
            ckKHD.Size = new Size(122, 19);
            ckKHD.TabIndex = 16;
            ckKHD.Text = "Không Hoạt Động";
            ckKHD.UseVisualStyleBackColor = true;
            ckKHD.CheckedChanged += ckKHD_CheckedChanged;
            // 
            // ckHoatdong
            // 
            ckHoatdong.AutoSize = true;
            ckHoatdong.Location = new Point(103, 129);
            ckHoatdong.Name = "ckHoatdong";
            ckHoatdong.Size = new Size(84, 19);
            ckHoatdong.TabIndex = 5;
            ckHoatdong.Text = "Hoạt Động";
            ckHoatdong.UseVisualStyleBackColor = true;
            ckHoatdong.CheckedChanged += ckHoatdong_CheckedChanged;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(106, 34);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(173, 23);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Sản Phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 95);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên Sản Phẩm:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(106, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(173, 23);
            txtTen.TabIndex = 4;
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 450);
            Controls.Add(dgvChatLieu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSanPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSanPham";
            Load += FrmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChatLieu;
        private Label label3;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnClear;
        private GroupBox groupBox1;
        private CheckBox ckKHD;
        private CheckBox ckHoatdong;
        private TextBox txtMa;
        private Label label1;
        private Label label2;
        private TextBox txtTen;
        private Label label5;
        private Label label4;
        private ComboBox cbxChatLieu;
        private ComboBox cbNhaSanXuat;
        private Label label6;
    }
}