namespace _3_PL.Views
{
    partial class FrmKieuDanhMuc
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
            dgvKieuDM = new DataGridView();
            groupBox2 = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            label6 = new Label();
            label3 = new Label();
            cbxSanPham = new ComboBox();
            txtTimKiem = new TextBox();
            cbxDanhMuc = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            ckKHD = new CheckBox();
            ckHoatdong = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKieuDM).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKieuDM
            // 
            dgvKieuDM.BackgroundColor = Color.White;
            dgvKieuDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKieuDM.Location = new Point(49, 259);
            dgvKieuDM.Name = "dgvKieuDM";
            dgvKieuDM.Size = new Size(739, 179);
            dgvKieuDM.TabIndex = 25;
            dgvKieuDM.CellClick += dgvKieuDM_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Location = new Point(623, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(165, 241);
            groupBox2.TabIndex = 24;
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
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbxSanPham);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(cbxDanhMuc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ckKHD);
            groupBox1.Controls.Add(ckHoatdong);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(49, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 241);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(211, 120);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(41, 19);
            rdbNu.TabIndex = 23;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(99, 120);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(51, 19);
            rdbNam.TabIndex = 22;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 163);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 21;
            label6.Text = "Trạng Thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 222);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 20;
            label3.Text = "Tìm Kiếm:";
            // 
            // cbxSanPham
            // 
            cbxSanPham.FormattingEnabled = true;
            cbxSanPham.Location = new Point(101, 79);
            cbxSanPham.Name = "cbxSanPham";
            cbxSanPham.Size = new Size(172, 23);
            cbxSanPham.TabIndex = 20;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(281, 212);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(173, 23);
            txtTimKiem.TabIndex = 21;
            // 
            // cbxDanhMuc
            // 
            cbxDanhMuc.FormattingEnabled = true;
            cbxDanhMuc.Location = new Point(101, 33);
            cbxDanhMuc.Name = "cbxDanhMuc";
            cbxDanhMuc.Size = new Size(172, 23);
            cbxDanhMuc.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 87);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 18;
            label5.Text = "Tên Sản Phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 36);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 17;
            label4.Text = "Tên Danh Mục:";
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.Location = new Point(179, 159);
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
            ckHoatdong.Location = new Point(89, 159);
            ckHoatdong.Name = "ckHoatdong";
            ckHoatdong.Size = new Size(84, 19);
            ckHoatdong.TabIndex = 5;
            ckHoatdong.Text = "Hoạt Động";
            ckHoatdong.UseVisualStyleBackColor = true;
            ckHoatdong.CheckedChanged += ckHoatdong_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 122);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Thể Loại GT:";
            // 
            // FrmKieuDanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKieuDM);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmKieuDanhMuc";
            Text = "FrmKieuDanhMuc";
            ((System.ComponentModel.ISupportInitialize)dgvKieuDM).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKieuDM;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnClear;
        private GroupBox groupBox1;
        private Label label6;
        private Label label3;
        private ComboBox cbxSanPham;
        private TextBox txtTimKiem;
        private ComboBox cbxDanhMuc;
        private Label label5;
        private Label label4;
        private CheckBox ckKHD;
        private CheckBox ckHoatdong;
        private Label label1;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
    }
}