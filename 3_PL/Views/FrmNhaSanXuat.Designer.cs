namespace _3_PL.Views
{
    partial class FrmNhaSanXuat
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
            dgvNhaSanXuat = new DataGridView();
            label3 = new Label();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            ckKHD = new CheckBox();
            ckHoatdong = new CheckBox();
            txtMa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhaSanXuat).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhaSanXuat
            // 
            dgvNhaSanXuat.BackgroundColor = Color.Beige;
            dgvNhaSanXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaSanXuat.Location = new Point(27, 259);
            dgvNhaSanXuat.Name = "dgvNhaSanXuat";
            dgvNhaSanXuat.Size = new Size(484, 150);
            dgvNhaSanXuat.TabIndex = 22;
            dgvNhaSanXuat.CellClick += dgvNhaSanXuat_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 215);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 20;
            label3.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(120, 207);
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
            groupBox2.Location = new Point(372, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 232);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
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
            btnSua.Location = new Point(6, 85);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(6, 147);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 28);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 189);
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
            groupBox1.Controls.Add(ckKHD);
            groupBox1.Controls.Add(ckHoatdong);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 175);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.Location = new Point(171, 130);
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
            ckHoatdong.Location = new Point(81, 130);
            ckHoatdong.Name = "ckHoatdong";
            ckHoatdong.Size = new Size(84, 19);
            ckHoatdong.TabIndex = 5;
            ckHoatdong.Text = "Hoạt Động";
            ckHoatdong.UseVisualStyleBackColor = true;
            ckHoatdong.CheckedChanged += ckHoatdong_CheckedChanged;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(80, 34);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(173, 23);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 93);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(80, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(173, 23);
            txtTen.TabIndex = 4;
            // 
            // FrmNhaSanXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 418);
            Controls.Add(dgvNhaSanXuat);
            Controls.Add(label3);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmNhaSanXuat";
            Text = "FrmNhaSanXuat";
            ((System.ComponentModel.ISupportInitialize)dgvNhaSanXuat).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhaSanXuat;
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
    }
}