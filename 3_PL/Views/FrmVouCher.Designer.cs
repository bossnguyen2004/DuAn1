namespace _3_PL.Views
{
    partial class FrmVouCher
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
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtma = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            txtGiaTri = new TextBox();
            label3 = new Label();
            txtSoTien = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtbatDau = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            ckbatDau = new CheckBox();
            ckketthuc = new CheckBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnClear = new Button();
            dgvVoucher = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(ckketthuc);
            groupBox1.Controls.Add(ckbatDau);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dtbatDau);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoTien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGiaTri);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtma);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(674, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 251);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Giảm Giá:";
            // 
            // txtma
            // 
            txtma.Location = new Point(116, 37);
            txtma.Name = "txtma";
            txtma.Size = new Size(163, 23);
            txtma.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(116, 75);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(163, 23);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 83);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên Chương Trình:";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Location = new Point(116, 114);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(163, 23);
            txtGiaTri.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 122);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Giá Trị VouCher:";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(116, 153);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(163, 23);
            txtSoTien.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 161);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Số Tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 47);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 8;
            label5.Text = "Ngày Bắt Đầu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(342, 93);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 9;
            label6.Text = "Ngày Kết Thúc:";
            // 
            // dtbatDau
            // 
            dtbatDau.Format = DateTimePickerFormat.Custom;
            dtbatDau.Location = new Point(428, 39);
            dtbatDau.Name = "dtbatDau";
            dtbatDau.Size = new Size(161, 23);
            dtbatDau.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(428, 87);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(161, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 156);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 12;
            label7.Text = "Trạng Thái:";
            // 
            // ckbatDau
            // 
            ckbatDau.AutoSize = true;
            ckbatDau.Location = new Point(428, 153);
            ckbatDau.Name = "ckbatDau";
            ckbatDau.Size = new Size(66, 19);
            ckbatDau.TabIndex = 13;
            ckbatDau.Text = "Bắt đầu";
            ckbatDau.UseVisualStyleBackColor = true;
            // 
            // ckketthuc
            // 
            ckketthuc.AutoSize = true;
            ckketthuc.Location = new Point(519, 153);
            ckketthuc.Name = "ckketthuc";
            ckketthuc.Size = new Size(70, 19);
            ckketthuc.TabIndex = 14;
            ckketthuc.Text = "Kết thúc";
            ckketthuc.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(46, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 36);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(46, 84);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 36);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(46, 144);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 36);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(46, 200);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvVoucher
            // 
            dgvVoucher.BackgroundColor = Color.White;
            dgvVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoucher.Location = new Point(31, 295);
            dgvVoucher.Name = "dgvVoucher";
            dgvVoucher.Size = new Size(832, 195);
            dgvVoucher.TabIndex = 2;
            // 
            // FrmVouCher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 494);
            Controls.Add(dgvVoucher);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVouCher";
            Text = "FrmVouCher";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtma;
        private Label label1;
        private TextBox txtSoTien;
        private Label label4;
        private TextBox txtGiaTri;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtbatDau;
        private Label label6;
        private Label label5;
        private Label label7;
        private CheckBox ckketthuc;
        private CheckBox ckbatDau;
        private Button btnClear;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvVoucher;
    }
}