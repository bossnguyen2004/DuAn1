namespace _3_PL.Views
{
    partial class FrmGiaoCa
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
            label12 = new Label();
            txtTienBanDau = new TextBox();
            label4 = new Label();
            dtNhanCa = new DateTimePicker();
            dtgiaoCa = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtNhanVienCa = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            txtghichu = new TextBox();
            label10 = new Label();
            txtTienRut = new TextBox();
            label9 = new Label();
            txtTienphatsinh = new TextBox();
            txtTiencatruoc = new TextBox();
            txtTienMat = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvGiaoCa = new DataGridView();
            groupBox3 = new GroupBox();
            btnClear = new Button();
            btnLuu = new Button();
            btnGiaoCa = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoCa).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtTienBanDau);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtNhanCa);
            groupBox1.Controls.Add(dtgiaoCa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNhanVienCa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Nhân Viên";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(288, 19);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 8;
            label12.Text = "label12";
            // 
            // txtTienBanDau
            // 
            txtTienBanDau.Location = new Point(370, 102);
            txtTienBanDau.Name = "txtTienBanDau";
            txtTienBanDau.Size = new Size(145, 23);
            txtTienBanDau.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 105);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Tiền Ban Đầu:";
            // 
            // dtNhanCa
            // 
            dtNhanCa.CustomFormat = "dd/MM/yyyy";
            dtNhanCa.Format = DateTimePickerFormat.Custom;
            dtNhanCa.Location = new Point(370, 63);
            dtNhanCa.Name = "dtNhanCa";
            dtNhanCa.Size = new Size(145, 23);
            dtNhanCa.TabIndex = 5;
            // 
            // dtgiaoCa
            // 
            dtgiaoCa.CustomFormat = "dd/MM/yyyy";
            dtgiaoCa.Format = DateTimePickerFormat.Custom;
            dtgiaoCa.Location = new Point(100, 76);
            dtgiaoCa.Name = "dtgiaoCa";
            dtgiaoCa.Size = new Size(151, 23);
            dtgiaoCa.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 66);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 3;
            label3.Text = "Thơi Gian Nhân:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 80);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Thời Gian Ca:";
            // 
            // txtNhanVienCa
            // 
            txtNhanVienCa.Location = new Point(100, 33);
            txtNhanVienCa.Name = "txtNhanVienCa";
            txtNhanVienCa.Size = new Size(151, 23);
            txtNhanVienCa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhân Viên:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtghichu);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTienRut);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtTienphatsinh);
            groupBox2.Controls.Add(txtTiencatruoc);
            groupBox2.Controls.Add(txtTienMat);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thu chi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(96, 34);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 11;
            label11.Text = "label11";
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(345, 99);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(178, 23);
            txtghichu.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(282, 99);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 9;
            label10.Text = "Ghi Chú:";
            // 
            // txtTienRut
            // 
            txtTienRut.Location = new Point(349, 59);
            txtTienRut.Name = "txtTienRut";
            txtTienRut.Size = new Size(150, 23);
            txtTienRut.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 67);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 7;
            label9.Text = "Tiền Rút:";
            // 
            // txtTienphatsinh
            // 
            txtTienphatsinh.Location = new Point(103, 131);
            txtTienphatsinh.Name = "txtTienphatsinh";
            txtTienphatsinh.Size = new Size(150, 23);
            txtTienphatsinh.TabIndex = 6;
            // 
            // txtTiencatruoc
            // 
            txtTiencatruoc.Location = new Point(103, 95);
            txtTiencatruoc.Name = "txtTiencatruoc";
            txtTiencatruoc.Size = new Size(150, 23);
            txtTiencatruoc.TabIndex = 5;
            // 
            // txtTienMat
            // 
            txtTienMat.Location = new Point(75, 59);
            txtTienMat.Name = "txtTienMat";
            txtTienMat.Size = new Size(178, 23);
            txtTienMat.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 139);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 3;
            label8.Text = "Tiền Phát Sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 103);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 2;
            label7.Text = "Tiền Ca Trước:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 67);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 1;
            label6.Text = "Tiền Mặt:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 34);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 0;
            label5.Text = "Tiền Trong Ca:";
            // 
            // dgvGiaoCa
            // 
            dgvGiaoCa.BackgroundColor = Color.White;
            dgvGiaoCa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoCa.Location = new Point(18, 371);
            dgvGiaoCa.Name = "dgvGiaoCa";
            dgvGiaoCa.Size = new Size(779, 174);
            dgvGiaoCa.TabIndex = 2;
            dgvGiaoCa.CellClick += dgvGiaoCa_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnGiaoCa);
            groupBox3.Location = new Point(561, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(222, 321);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức Năng";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(31, 198);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 46);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(30, 127);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 46);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnGiaoCa
            // 
            btnGiaoCa.Location = new Point(31, 54);
            btnGiaoCa.Name = "btnGiaoCa";
            btnGiaoCa.Size = new Size(119, 45);
            btnGiaoCa.TabIndex = 0;
            btnGiaoCa.Text = "Giao Ca";
            btnGiaoCa.UseVisualStyleBackColor = true;
            btnGiaoCa.Click += btnGiaoCa_Click;
            // 
            // FrmGiaoCa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1022, 557);
            Controls.Add(groupBox3);
            Controls.Add(dgvGiaoCa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmGiaoCa";
            Text = "FrmGiaoCa";
            Load += FrmGiaoCa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoCa).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtNhanCa;
        private DateTimePicker dtgiaoCa;
        private Label label3;
        private Label label2;
        private TextBox txtNhanVienCa;
        private Label label1;
        private TextBox txtTienBanDau;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txtTienMat;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private TextBox txtTienRut;
        private Label label9;
        private TextBox txtTienphatsinh;
        private TextBox txtTiencatruoc;
        private TextBox txtghichu;
        private DataGridView dgvGiaoCa;
        private GroupBox groupBox3;
        private Button btnGiaoCa;
        private Label label11;
        private Button btnClear;
        private Button btnLuu;
        private Label label12;
    }
}