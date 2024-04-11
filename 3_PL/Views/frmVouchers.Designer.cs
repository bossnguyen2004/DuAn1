namespace _3_PL.Views
{
    partial class frmVouchers
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
            dgvVouCher = new DataGridView();
            label1 = new Label();
            txtMa = new TextBox();
            groupBox2 = new GroupBox();
            rdHet = new RadioButton();
            rdCon = new RadioButton();
            label7 = new Label();
            dtNgayKetThuc = new DateTimePicker();
            dtbatDau = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            txtSoTien = new TextBox();
            txtGiaTri = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVouCher).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvVouCher);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(2, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // dgvVouCher
            // 
            dgvVouCher.BackgroundColor = Color.White;
            dgvVouCher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVouCher.Dock = DockStyle.Fill;
            dgvVouCher.Location = new Point(3, 19);
            dgvVouCher.Name = "dgvVouCher";
            dgvVouCher.RowHeadersVisible = false;
            dgvVouCher.Size = new Size(1002, 192);
            dgvVouCher.TabIndex = 0;
            dgvVouCher.CellClick += dgvVouCher_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(126, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã Giảm Giá";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(241, 22);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(160, 23);
            txtMa.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(rdHet);
            groupBox2.Controls.Add(rdCon);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dtNgayKetThuc);
            groupBox2.Controls.Add(dtbatDau);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSoTien);
            groupBox2.Controls.Add(txtGiaTri);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label2);
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
            // rdHet
            // 
            rdHet.AutoSize = true;
            rdHet.Location = new Point(685, 135);
            rdHet.Name = "rdHet";
            rdHet.Size = new Size(97, 19);
            rdHet.TabIndex = 21;
            rdHet.TabStop = true;
            rdHet.Text = "Hết Sử Dụng";
            rdHet.UseVisualStyleBackColor = true;
            // 
            // rdCon
            // 
            rdCon.AutoSize = true;
            rdCon.Location = new Point(582, 135);
            rdCon.Name = "rdCon";
            rdCon.Size = new Size(97, 19);
            rdCon.TabIndex = 20;
            rdCon.TabStop = true;
            rdCon.Text = "Còn Sử Dụng";
            rdCon.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(509, 139);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 19;
            label7.Text = "Trạng Thái:";
            // 
            // dtNgayKetThuc
            // 
            dtNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtNgayKetThuc.Location = new Point(608, 70);
            dtNgayKetThuc.Name = "dtNgayKetThuc";
            dtNgayKetThuc.Size = new Size(174, 23);
            dtNgayKetThuc.TabIndex = 18;
            // 
            // dtbatDau
            // 
            dtbatDau.Format = DateTimePickerFormat.Custom;
            dtbatDau.Location = new Point(597, 22);
            dtbatDau.Name = "dtbatDau";
            dtbatDau.Size = new Size(185, 23);
            dtbatDau.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 76);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 16;
            label6.Text = "Ngày Kết Thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 30);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 15;
            label5.Text = "Ngày Bắt Đầu:";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(241, 146);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(160, 23);
            txtSoTien.TabIndex = 4;
            // 
            // txtGiaTri
            // 
            txtGiaTri.Location = new Point(241, 111);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(160, 23);
            txtGiaTri.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(155, 154);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 1;
            label4.Text = "Số Tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(112, 111);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 1;
            label3.Text = "Giá Trị Voucher";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(241, 65);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(160, 23);
            txtTen.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(98, 68);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Chương Trình";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(588, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 35);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(443, 192);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 35);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(304, 192);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 35);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmVouchers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1019, 451);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmVouchers";
            Text = "frmVouCher";
            Load += frmBills_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVouCher).EndInit();
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
        private DataGridView dgvVouCher;
        private TextBox txtSoTien;
        private TextBox txtGiaTri;
        private Label label7;
        private DateTimePicker dtNgayKetThuc;
        private DateTimePicker dtbatDau;
        private Label label6;
        private Label label5;
        private RadioButton rdHet;
        private RadioButton rdCon;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}