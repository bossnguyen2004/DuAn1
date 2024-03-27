namespace _3_PL.Views
{
    partial class FrmKhachHang
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
            txtEmail = new TextBox();
            label9 = new Label();
            txtTimKiem = new TextBox();
            label8 = new Label();
            ckKHD = new CheckBox();
            ckHD = new CheckBox();
            label7 = new Label();
            dtNamSinh = new DateTimePicker();
            label6 = new Label();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            label5 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtMa = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClaer = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvKhachHang = new DataGridView();
            txtPassword = new TextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ckKHD);
            groupBox1.Controls.Add(ckHD);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtNamSinh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(rdNu);
            groupBox1.Controls.Add(rdNam);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 212);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 18;
            label9.Text = "Email:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(69, 233);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 23);
            txtTimKiem.TabIndex = 17;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 241);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 16;
            label8.Text = "Tìm Kiếm:";
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.Location = new Point(411, 166);
            ckKHD.Name = "ckKHD";
            ckKHD.Size = new Size(122, 19);
            ckKHD.TabIndex = 15;
            ckKHD.Text = "Không Hoạt Động";
            ckKHD.UseVisualStyleBackColor = true;
            ckKHD.CheckedChanged += ckKHD_CheckedChanged;
            // 
            // ckHD
            // 
            ckHD.AutoSize = true;
            ckHD.Location = new Point(317, 167);
            ckHD.Name = "ckHD";
            ckHD.Size = new Size(84, 19);
            ckHD.TabIndex = 14;
            ckHD.Text = "Hoạt Động";
            ckHD.UseVisualStyleBackColor = true;
            ckHD.CheckedChanged += ckHD_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 169);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 13;
            label7.Text = "Trạng Thái:";
            // 
            // dtNamSinh
            // 
            dtNamSinh.Format = DateTimePickerFormat.Custom;
            dtNamSinh.Location = new Point(317, 22);
            dtNamSinh.Name = "dtNamSinh";
            dtNamSinh.Size = new Size(130, 23);
            dtNamSinh.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 31);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 11;
            label6.Text = "Năm Sinh:";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(383, 118);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(41, 19);
            rdNu.TabIndex = 10;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            rdNu.CheckedChanged += rdNu_CheckedChanged;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(317, 117);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(51, 19);
            rdNam.TabIndex = 9;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            rdNam.CheckedChanged += rdNam_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 116);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Giới Tính:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(69, 164);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(152, 23);
            txtSDT.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 172);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 6;
            label4.Text = "SDT:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(69, 116);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(152, 23);
            txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 124);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Địa Chỉ:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(69, 73);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(152, 23);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 81);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên KH:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(69, 27);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(152, 23);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnClaer);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(568, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 264);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnClaer
            // 
            btnClaer.Location = new Point(13, 191);
            btnClaer.Name = "btnClaer";
            btnClaer.Size = new Size(79, 29);
            btnClaer.TabIndex = 3;
            btnClaer.Text = "Clear";
            btnClaer.UseVisualStyleBackColor = true;
            btnClaer.Click += btnClaer_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(13, 134);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(79, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(13, 81);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(79, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(13, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(79, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.BackgroundColor = SystemColors.Control;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.GridColor = Color.White;
            dgvKhachHang.Location = new Point(12, 291);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(724, 169);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(306, 62);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(141, 23);
            txtPassword.TabIndex = 21;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(249, 70);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 20;
            label10.Text = "Password:";
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 472);
            Controls.Add(dgvKhachHang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
        private Label label6;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label label5;
        private CheckBox ckKHD;
        private CheckBox ckHD;
        private Label label7;
        private DateTimePicker dtNamSinh;
        private GroupBox groupBox2;
        private Button btnClaer;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvKhachHang;
        private TextBox txtTimKiem;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtPassword;
        private Label label10;
    }
}