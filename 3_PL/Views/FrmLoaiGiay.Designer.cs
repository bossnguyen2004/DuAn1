namespace _3_PL.Views
{
    partial class FrmLoaiGiay
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
            dgvLoaiGiay = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            ckKHD = new CheckBox();
            txtTimKiem = new TextBox();
            ckHoatdong = new CheckBox();
            txtMa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiGiay).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLoaiGiay
            // 
            dgvLoaiGiay.BackgroundColor = Color.White;
            dgvLoaiGiay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiGiay.Location = new Point(74, 239);
            dgvLoaiGiay.Name = "dgvLoaiGiay";
            dgvLoaiGiay.RowHeadersWidth = 51;
            dgvLoaiGiay.Size = new Size(661, 200);
            dgvLoaiGiay.TabIndex = 22;
            dgvLoaiGiay.CellContentClick += dgvChatLieu_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(107, 207);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 26);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(252, 204);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(399, 204);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 28);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(547, 204);
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
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ckKHD);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(ckHoatdong);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(82, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 175);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 38);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 23;
            label3.Text = "Tìm Kiếm:";
            label3.Click += label3_Click_1;
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.Location = new Point(228, 126);
            ckKHD.Name = "ckKHD";
            ckKHD.Size = new Size(122, 19);
            ckKHD.TabIndex = 16;
            ckKHD.Text = "Không Hoạt Động";
            ckKHD.UseVisualStyleBackColor = true;
            ckKHD.CheckedChanged += ckKHD_CheckedChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(452, 33);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(173, 23);
            txtTimKiem.TabIndex = 24;
            // 
            // ckHoatdong
            // 
            ckHoatdong.AutoSize = true;
            ckHoatdong.Location = new Point(138, 126);
            ckHoatdong.Name = "ckHoatdong";
            ckHoatdong.Size = new Size(84, 19);
            ckHoatdong.TabIndex = 5;
            ckHoatdong.Text = "Hoạt Động";
            ckHoatdong.UseVisualStyleBackColor = true;
            ckHoatdong.CheckedChanged += ckHoatdong_CheckedChanged;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(137, 30);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(173, 23);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 39);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 90);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(137, 81);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(173, 23);
            txtTen.TabIndex = 4;
            // 
            // FrmLoaiGiay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1019, 451);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvLoaiGiay);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLoaiGiay";
            Text = "FrmLoaiGiay";
            Load += FrmLoaiGiay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiGiay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLoaiGiay;
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
        private TextBox txtTimKiem;
    }
}