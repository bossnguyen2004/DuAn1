namespace _3_PL.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            txtMail = new TextBox();
            txtmatKhau = new TextBox();
            label2 = new Label();
            btnDangKy = new Button();
            btnDangNhap = new Button();
            ckbHTMK = new CheckBox();
            linkQMK = new LinkLabel();
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(58, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "Mail:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(61, 43);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(219, 23);
            txtMail.TabIndex = 1;
            txtMail.Text = "tranvannguyen12@gmail.com";
            // 
            // txtmatKhau
            // 
            txtmatKhau.Location = new Point(61, 114);
            txtmatKhau.Name = "txtmatKhau";
            txtmatKhau.Size = new Size(219, 23);
            txtmatKhau.TabIndex = 3;
            txtmatKhau.Text = "1111";
            txtmatKhau.TextChanged += txtmatKhau_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(58, 89);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu:";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.White;
            btnDangKy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.Red;
            btnDangKy.Location = new Point(182, 188);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(98, 40);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.White;
            btnDangNhap.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Red;
            btnDangNhap.Location = new Point(58, 188);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(101, 40);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // ckbHTMK
            // 
            ckbHTMK.AutoSize = true;
            ckbHTMK.Location = new Point(58, 153);
            ckbHTMK.Name = "ckbHTMK";
            ckbHTMK.Size = new Size(121, 19);
            ckbHTMK.TabIndex = 6;
            ckbHTMK.Text = "Hiển thị mật khẩu";
            ckbHTMK.UseVisualStyleBackColor = true;
            ckbHTMK.CheckedChanged += ckbHTMK_CheckedChanged;
            // 
            // linkQMK
            // 
            linkQMK.AutoSize = true;
            linkQMK.Location = new Point(191, 153);
            linkQMK.Name = "linkQMK";
            linkQMK.Size = new Size(89, 15);
            linkQMK.TabIndex = 7;
            linkQMK.TabStop = true;
            linkQMK.Text = "Quên mật khẩu";
            linkQMK.Click += linkQMK_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(txtMail);
            splitContainer1.Panel2.Controls.Add(linkQMK);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(ckbHTMK);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(btnDangNhap);
            splitContainer1.Panel2.Controls.Add(txtmatKhau);
            splitContainer1.Panel2.Controls.Add(btnDangKy);
            splitContainer1.Size = new Size(602, 291);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(25, 18);
            label3.Name = "label3";
            label3.Size = new Size(150, 32);
            label3.TabIndex = 1;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 199);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 315);
            Controls.Add(splitContainer1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += FrmLogin_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private TextBox txtmatKhau;
        private Label label2;
        private Button btnDangKy;
        private Button btnDangNhap;
        private CheckBox ckbHTMK;
        private LinkLabel linkQMK;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}