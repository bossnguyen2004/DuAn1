namespace _3_PL.Views
{
    partial class FrmAnh
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
            dgvAnh = new DataGridView();
            groupBox2 = new GroupBox();
            btnChonAnh = new Button();
            pckAnh = new PictureBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtduongdan = new TextBox();
            label3 = new Label();
            ckKHD = new CheckBox();
            ckHoatdong = new CheckBox();
            txtMa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pckAnh).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAnh
            // 
            dgvAnh.BackgroundColor = Color.White;
            dgvAnh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnh.Location = new Point(15, 270);
            dgvAnh.Name = "dgvAnh";
            dgvAnh.Size = new Size(715, 168);
            dgvAnh.TabIndex = 22;
            dgvAnh.CellClick += dgvAnh_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnChonAnh);
            groupBox2.Controls.Add(pckAnh);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Location = new Point(357, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 252);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(202, 217);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(105, 29);
            btnChonAnh.TabIndex = 9;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // pckAnh
            // 
            pckAnh.BackColor = Color.FromArgb(192, 255, 255);
            pckAnh.BorderStyle = BorderStyle.Fixed3D;
            pckAnh.Location = new Point(160, 22);
            pckAnh.Name = "pckAnh";
            pckAnh.Size = new Size(200, 189);
            pckAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pckAnh.TabIndex = 8;
            pckAnh.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 26);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(6, 79);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(6, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 28);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 170);
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtduongdan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ckKHD);
            groupBox1.Controls.Add(ckHoatdong);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 252);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 137);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 18;
            label4.Text = "Đường dẫn:";
            // 
            // txtduongdan
            // 
            txtduongdan.Location = new Point(95, 129);
            txtduongdan.Name = "txtduongdan";
            txtduongdan.Size = new Size(173, 23);
            txtduongdan.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 184);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 17;
            label3.Text = "Trạng Thái:";
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.Location = new Point(168, 184);
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
            ckHoatdong.Location = new Point(78, 184);
            ckHoatdong.Name = "ckHoatdong";
            ckHoatdong.Size = new Size(84, 19);
            ckHoatdong.TabIndex = 5;
            ckHoatdong.Text = "Hoạt Động";
            ckHoatdong.UseVisualStyleBackColor = true;
            ckHoatdong.CheckedChanged += ckHoatdong_CheckedChanged;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(95, 34);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(173, 23);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Ảnh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 93);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên Ảnh:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(95, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(173, 23);
            txtTen.TabIndex = 4;
            // 
            // FrmAnh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(769, 450);
            Controls.Add(dgvAnh);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmAnh";
            Text = "FrmAnh";
            Load += FrmAnh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnh).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pckAnh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAnh;
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
        private Label label3;
        private Button btnChonAnh;
        private PictureBox pckAnh;
        private Label label4;
        private TextBox txtduongdan;
    }
}