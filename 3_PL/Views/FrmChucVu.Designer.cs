namespace _3_PL.Views
{
    partial class FrmChucVu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtMa = new TextBox();
            btnThem = new Button();
            txtTen = new TextBox();
            label2 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            chbHoatdong = new CheckBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txtTimKiem = new TextBox();
            dgvChucVu = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            trangThaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chucVuViewModelsBindingSource = new BindingSource(components);
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chucVuViewModelsBindingSource).BeginInit();
            SuspendLayout();
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
            // txtMa
            // 
            txtMa.Location = new Point(80, 34);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(173, 23);
            txtMa.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(32, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 26);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(80, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(173, 23);
            txtTen.TabIndex = 4;
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
            // btnSua
            // 
            btnSua.Location = new Point(32, 76);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(32, 111);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 28);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(32, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(32, 185);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(105, 33);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chbHoatdong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 232);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // chbHoatdong
            // 
            chbHoatdong.AutoSize = true;
            chbHoatdong.Location = new Point(86, 132);
            chbHoatdong.Name = "chbHoatdong";
            chbHoatdong.Size = new Size(84, 19);
            chbHoatdong.TabIndex = 5;
            chbHoatdong.Text = "Hoạt Động";
            chbHoatdong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Location = new Point(648, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 232);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 198);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 11;
            label3.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(86, 195);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(173, 23);
            txtTimKiem.TabIndex = 12;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvChucVu
            // 
            dgvChucVu.AutoGenerateColumns = false;
            dgvChucVu.BackgroundColor = Color.White;
            dgvChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChucVu.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, maDataGridViewTextBoxColumn, tenDataGridViewTextBoxColumn, trangThaiDataGridViewTextBoxColumn });
            dgvChucVu.DataSource = chucVuViewModelsBindingSource;
            dgvChucVu.Location = new Point(24, 250);
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.RowHeadersWidth = 51;
            dgvChucVu.Size = new Size(804, 153);
            dgvChucVu.TabIndex = 34;
            dgvChucVu.CellClick += dgvChucVu_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // maDataGridViewTextBoxColumn
            // 
            maDataGridViewTextBoxColumn.DataPropertyName = "Ma";
            maDataGridViewTextBoxColumn.HeaderText = "Ma";
            maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            // 
            // chucVuViewModelsBindingSource
            // 
            chucVuViewModelsBindingSource.DataSource = typeof(_2_BUS.ViewModels.ChucVuViewModels);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 133);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 23;
            label4.Text = "Trạng Thái:";
            // 
            // FrmChucVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 400);
            Controls.Add(dgvChucVu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmChucVu";
            Text = "FrmChucVu";
            Load += FrmChucVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)chucVuViewModelsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMa;
        private Button btnThem;
        private TextBox txtTen;
        private Label label2;
        private Button btnSua;
        private Button btnXoa;
        private Button btnClear;
        private Button btnLuu;
        private GroupBox groupBox1;
        private CheckBox chbHoatdong;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtTimKiem;
        private DataGridView dgvChucVu;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private BindingSource chucVuViewModelsBindingSource;
        private Label label4;
    }
}