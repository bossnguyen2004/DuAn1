namespace _3_PL.Views
{
    partial class FrmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKy));
            splitContainer1 = new SplitContainer();
            pictureBox2 = new PictureBox();
            label15 = new Label();
            ckKHD = new CheckBox();
            ckHD = new CheckBox();
            label2 = new Label();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            label14 = new Label();
            btnĐangKy = new Button();
            label13 = new Label();
            txtEmail = new TextBox();
            label11 = new Label();
            txtMatKhau = new TextBox();
            dtnamSinh = new DateTimePicker();
            label9 = new Label();
            label7 = new Label();
            txtQuequan = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            txtMa = new TextBox();
            label1 = new Label();
            txtHo = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(label15);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(ckKHD);
            splitContainer1.Panel2.Controls.Add(ckHD);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(rdbNu);
            splitContainer1.Panel2.Controls.Add(rdbNam);
            splitContainer1.Panel2.Controls.Add(label14);
            splitContainer1.Panel2.Controls.Add(btnĐangKy);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(txtEmail);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(txtMatKhau);
            splitContainer1.Panel2.Controls.Add(dtnamSinh);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(txtQuequan);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(txtSDT);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(txtMa);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(txtHo);
            splitContainer1.Size = new Size(767, 416);
            splitContainer1.SplitterDistance = 255;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 114);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 222);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(69, 55);
            label15.Name = "label15";
            label15.Size = new Size(114, 32);
            label15.TabIndex = 0;
            label15.Text = "ĐĂNG KÝ";
            // 
            // ckKHD
            // 
            ckKHD.AutoSize = true;
            ckKHD.ForeColor = Color.Red;
            ckKHD.Location = new Point(179, 275);
            ckKHD.Name = "ckKHD";
            ckKHD.Size = new Size(122, 19);
            ckKHD.TabIndex = 36;
            ckKHD.Text = "Không Hoạt Động";
            ckKHD.UseVisualStyleBackColor = true;
            ckKHD.CheckedChanged += ckKHD_CheckedChanged;
            // 
            // ckHD
            // 
            ckHD.AutoSize = true;
            ckHD.ForeColor = Color.Red;
            ckHD.Location = new Point(85, 276);
            ckHD.Name = "ckHD";
            ckHD.Size = new Size(84, 19);
            ckHD.TabIndex = 35;
            ckHD.Text = "Hoạt Động";
            ckHD.UseVisualStyleBackColor = true;
            ckHD.CheckedChanged += ckHD_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(16, 278);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 34;
            label2.Text = "Trạng Thái:";
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.ForeColor = Color.Red;
            rdbNu.Location = new Point(151, 239);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(41, 19);
            rdbNu.TabIndex = 33;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            rdbNu.CheckedChanged += rdbNu_CheckedChanged;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.ForeColor = Color.Red;
            rdbNam.Location = new Point(85, 239);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(51, 19);
            rdbNam.TabIndex = 32;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            rdbNam.CheckedChanged += rdbNam_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(16, 241);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 31;
            label14.Text = "Giới Tính:";
            // 
            // btnĐangKy
            // 
            btnĐangKy.BackColor = Color.Snow;
            btnĐangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnĐangKy.ForeColor = Color.Red;
            btnĐangKy.Location = new Point(138, 345);
            btnĐangKy.Name = "btnĐangKy";
            btnĐangKy.Size = new Size(128, 43);
            btnĐangKy.TabIndex = 30;
            btnĐangKy.Text = "Đăng Ký";
            btnĐangKy.UseVisualStyleBackColor = false;
            btnĐangKy.Click += btnĐangKy_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(13, 149);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 23;
            label13.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(63, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 23);
            txtEmail.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(13, 193);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 19;
            label11.Text = "Password:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(79, 185);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(145, 23);
            txtMatKhau.TabIndex = 18;
            // 
            // dtnamSinh
            // 
            dtnamSinh.Format = DateTimePickerFormat.Custom;
            dtnamSinh.Location = new Point(329, 63);
            dtnamSinh.Name = "dtnamSinh";
            dtnamSinh.Size = new Size(165, 23);
            dtnamSinh.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(241, 63);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 16;
            label9.Text = "Năm Sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(264, 162);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 13;
            label7.Text = "Địa Chỉ:";
            // 
            // txtQuequan
            // 
            txtQuequan.Location = new Point(334, 154);
            txtQuequan.Name = "txtQuequan";
            txtQuequan.Size = new Size(160, 23);
            txtQuequan.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(233, 112);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 11;
            label6.Text = "Số Điện Thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(329, 104);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(165, 23);
            txtSDT.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(13, 74);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 7;
            label4.Text = "Mã:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(63, 66);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(161, 23);
            txtMa.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 117);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Họ & Tên:";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(63, 109);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(161, 23);
            txtHo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(138, 17);
            label3.Name = "label3";
            label3.Size = new Size(215, 21);
            label3.TabIndex = 37;
            label3.Text = "Mời Nhập Các Thông Tin Sau:";
            // 
            // FrmDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 416);
            Controls.Add(splitContainer1);
            Name = "FrmDangKy";
            Text = "FrmDangKy";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label6;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtMa;
        private Label label1;
        private TextBox txtHo;
        private Label label7;
        private TextBox txtQuequan;
        private Label label13;
        private TextBox txtEmail;
        private Label label11;
        private TextBox txtMatKhau;
        private DateTimePicker dtnamSinh;
        private Label label9;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private Label label14;
        private Button btnĐangKy;
        private PictureBox pictureBox2;
        private Label label15;
        private CheckBox ckKHD;
        private CheckBox ckHD;
        private Label label2;
        private Label label3;
    }
}