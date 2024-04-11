namespace _3_PL.Views
{
    partial class FrmSizeGiay
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
            label3 = new Label();
            txtTimKiem = new TextBox();
            dgvSizeGiay = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            ckKHD = new CheckBox();
            ckHoatdong = new CheckBox();
            txtMa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSoSize = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSizeGiay).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 224);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 28;
            label3.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(122, 219);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(173, 23);
            txtTimKiem.TabIndex = 29;
            // 
            // dgvSizeGiay
            // 
            dgvSizeGiay.BackgroundColor = Color.White;
            dgvSizeGiay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSizeGiay.Location = new Point(12, 248);
            dgvSizeGiay.Name = "dgvSizeGiay";
            dgvSizeGiay.RowHeadersWidth = 51;
            dgvSizeGiay.Size = new Size(986, 191);
            dgvSizeGiay.TabIndex = 27;
            dgvSizeGiay.CellContentClick += dgvSizeGiay_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(356, 216);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 26);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(492, 213);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(640, 214);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 28);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(769, 213);
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
            groupBox1.Controls.Add(ckKHD);
            groupBox1.Controls.Add(ckHoatdong);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSoSize);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(986, 187);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 120);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 30;
            label4.Text = "Trạng Thái:";
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.Location = new Point(344, 119);
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
            ckHoatdong.Location = new Point(254, 119);
            ckHoatdong.Name = "ckHoatdong";
            ckHoatdong.Size = new Size(84, 19);
            ckHoatdong.TabIndex = 5;
            ckHoatdong.Text = "Hoạt Động";
            ckHoatdong.UseVisualStyleBackColor = true;
            ckHoatdong.CheckedChanged += ckHoatdong_CheckedChanged;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(253, 22);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(173, 23);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 32);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 75);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Số Size:";
            // 
            // txtSoSize
            // 
            txtSoSize.Location = new Point(253, 73);
            txtSoSize.Name = "txtSoSize";
            txtSoSize.Size = new Size(173, 23);
            txtSoSize.TabIndex = 4;
            // 
            // FrmSizeGiay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1019, 451);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvSizeGiay);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txtTimKiem);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmSizeGiay";
            Text = "FrmSizeGiay";
            Load += FrmSizeGiay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSizeGiay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtTimKiem;
        private DataGridView dgvSizeGiay;
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
        private TextBox txtSoSize;
        private Label label4;
    }
}