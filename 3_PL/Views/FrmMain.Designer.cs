namespace _3_PL.Views
{
    partial class FrmMain
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
            pnlThan = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            lblUserName = new Label();
            label5 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ellipseControlArtan = new Helpers.EllipseControlArtan();
            ellipseControlArtanMenu = new Helpers.EllipseControlArtan();
            pnMenu = new Panel();
            pnlSanPham = new Panel();
            btnSP = new Button();
            btnNhaSanXuat = new Button();
            btnChatLieu = new Button();
            btnSanPham = new Button();
            pnlNhanVien = new Panel();
            btnNhanVien = new Button();
            btnChucVu = new Button();
            btnQLNhanVien = new Button();
            btnBanHang = new Button();
            btnThongKe = new Button();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            pnMenu.SuspendLayout();
            pnlSanPham.SuspendLayout();
            pnlNhanVien.SuspendLayout();
            SuspendLayout();
            // 
            // pnlThan
            // 
            pnlThan.BackColor = SystemColors.ButtonHighlight;
            pnlThan.BorderStyle = BorderStyle.FixedSingle;
            pnlThan.Location = new Point(309, 75);
            pnlThan.Name = "pnlThan";
            pnlThan.Size = new Size(795, 492);
            pnlThan.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 57);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 0;
            label4.Text = "Shoes-Sneakers";
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(221, 221, 221);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(309, 573);
            panel5.Name = "panel5";
            panel5.Size = new Size(795, 39);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(306, 9);
            label3.Name = "label3";
            label3.Size = new Size(397, 21);
            label3.TabIndex = 0;
            label3.Text = "Shoes - Sneakes  xin cảm ơn quý khách đã ủng hộ shop";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(221, 221, 221);
            panel3.Controls.Add(lblUserName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(328, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 58);
            panel3.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.Black;
            lblUserName.Location = new Point(68, 12);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 21);
            lblUserName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(284, 10);
            label5.Name = "label5";
            label5.Size = new Size(291, 31);
            label5.TabIndex = 4;
            label5.Text = "Nhà Shoes-Sneakers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-161, 18);
            label1.Name = "label1";
            label1.Size = new Size(159, 26);
            label1.TabIndex = 0;
            label1.Text = "Shoes-Sneakers";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(644, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(4, 18);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Xin Chào:";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // ellipseControlArtan
            // 
            ellipseControlArtan.CornerRedius = 25;
            ellipseControlArtan.TargetControl = this;
            // 
            // ellipseControlArtanMenu
            // 
            ellipseControlArtanMenu.CornerRedius = 25;
            ellipseControlArtanMenu.TargetControl = pnMenu;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.LightGray;
            pnMenu.BorderStyle = BorderStyle.FixedSingle;
            pnMenu.Controls.Add(pnlSanPham);
            pnMenu.Controls.Add(pnlNhanVien);
            pnMenu.Controls.Add(btnBanHang);
            pnMenu.Controls.Add(btnThongKe);
            pnMenu.Controls.Add(btnHome);
            pnMenu.Location = new Point(12, 75);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(151, 528);
            pnMenu.TabIndex = 0;
            // 
            // pnlSanPham
            // 
            pnlSanPham.BackColor = Color.MediumSpringGreen;
            pnlSanPham.Controls.Add(btnSP);
            pnlSanPham.Controls.Add(btnNhaSanXuat);
            pnlSanPham.Controls.Add(btnChatLieu);
            pnlSanPham.Controls.Add(btnSanPham);
            pnlSanPham.Dock = DockStyle.Top;
            pnlSanPham.Location = new Point(0, 258);
            pnlSanPham.Margin = new Padding(0);
            pnlSanPham.Name = "pnlSanPham";
            pnlSanPham.Size = new Size(149, 150);
            pnlSanPham.TabIndex = 9;
            // 
            // btnSP
            // 
            btnSP.BackColor = Color.White;
            btnSP.Dock = DockStyle.Top;
            btnSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSP.Location = new Point(0, 103);
            btnSP.Name = "btnSP";
            btnSP.Padding = new Padding(20, 0, 0, 0);
            btnSP.Size = new Size(149, 33);
            btnSP.TabIndex = 5;
            btnSP.Text = "Sản Phẩm";
            btnSP.TextAlign = ContentAlignment.MiddleLeft;
            btnSP.UseVisualStyleBackColor = false;
            btnSP.Click += btnSP_Click;
            // 
            // btnNhaSanXuat
            // 
            btnNhaSanXuat.BackColor = Color.White;
            btnNhaSanXuat.Dock = DockStyle.Top;
            btnNhaSanXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.Location = new Point(0, 75);
            btnNhaSanXuat.Name = "btnNhaSanXuat";
            btnNhaSanXuat.Padding = new Padding(20, 0, 0, 0);
            btnNhaSanXuat.Size = new Size(149, 28);
            btnNhaSanXuat.TabIndex = 4;
            btnNhaSanXuat.Text = "Nhà Sản Xuất";
            btnNhaSanXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.UseVisualStyleBackColor = false;
            btnNhaSanXuat.Click += btnNhaSanXuat_Click_1;
            // 
            // btnChatLieu
            // 
            btnChatLieu.BackColor = Color.White;
            btnChatLieu.Dock = DockStyle.Top;
            btnChatLieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnChatLieu.Location = new Point(0, 45);
            btnChatLieu.Name = "btnChatLieu";
            btnChatLieu.Padding = new Padding(20, 0, 0, 0);
            btnChatLieu.Size = new Size(149, 30);
            btnChatLieu.TabIndex = 3;
            btnChatLieu.Text = "Chất Liệu";
            btnChatLieu.TextAlign = ContentAlignment.MiddleLeft;
            btnChatLieu.UseVisualStyleBackColor = false;
            btnChatLieu.Click += btnChatLieu_Click_1;
            // 
            // btnSanPham
            // 
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.ImageAlign = ContentAlignment.MiddleRight;
            btnSanPham.Location = new Point(0, 0);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(5, 0, 0, 0);
            btnSanPham.Size = new Size(149, 45);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "    QL Sản Phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click_1;
            // 
            // pnlNhanVien
            // 
            pnlNhanVien.BackColor = Color.LightPink;
            pnlNhanVien.Controls.Add(btnNhanVien);
            pnlNhanVien.Controls.Add(btnChucVu);
            pnlNhanVien.Controls.Add(btnQLNhanVien);
            pnlNhanVien.Dock = DockStyle.Top;
            pnlNhanVien.Location = new Point(0, 144);
            pnlNhanVien.Margin = new Padding(0);
            pnlNhanVien.Name = "pnlNhanVien";
            pnlNhanVien.Size = new Size(149, 114);
            pnlNhanVien.TabIndex = 8;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.White;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 77);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(20, 0, 0, 0);
            btnNhanVien.Size = new Size(149, 30);
            btnNhanVien.TabIndex = 4;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click_1;
            // 
            // btnChucVu
            // 
            btnChucVu.BackColor = Color.White;
            btnChucVu.Dock = DockStyle.Top;
            btnChucVu.ImageAlign = ContentAlignment.MiddleLeft;
            btnChucVu.Location = new Point(0, 45);
            btnChucVu.Name = "btnChucVu";
            btnChucVu.Padding = new Padding(20, 0, 0, 0);
            btnChucVu.Size = new Size(149, 32);
            btnChucVu.TabIndex = 3;
            btnChucVu.Text = " Chức Vụ";
            btnChucVu.TextAlign = ContentAlignment.MiddleLeft;
            btnChucVu.UseVisualStyleBackColor = false;
            btnChucVu.Click += btnChucVu_Click_1;
            // 
            // btnQLNhanVien
            // 
            btnQLNhanVien.Dock = DockStyle.Top;
            btnQLNhanVien.ImageAlign = ContentAlignment.MiddleRight;
            btnQLNhanVien.Location = new Point(0, 0);
            btnQLNhanVien.Name = "btnQLNhanVien";
            btnQLNhanVien.Padding = new Padding(5, 0, 0, 0);
            btnQLNhanVien.Size = new Size(149, 45);
            btnQLNhanVien.TabIndex = 2;
            btnQLNhanVien.Text = "    QL Nhân Viên";
            btnQLNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnQLNhanVien.UseVisualStyleBackColor = true;
            btnQLNhanVien.Click += btnQLNhanVien_Click_1;
            // 
            // btnBanHang
            // 
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 96);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(5, 0, 0, 0);
            btnBanHang.Size = new Size(149, 48);
            btnBanHang.TabIndex = 5;
            btnBanHang.Text = "          Bán Hàng";
            btnBanHang.TextAlign = ContentAlignment.MiddleLeft;
            btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 48);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(5, 0, 0, 0);
            btnThongKe.Size = new Size(149, 48);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "          Thống Kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5, 0, 0, 0);
            btnHome.Size = new Size(149, 48);
            btnHome.TabIndex = 1;
            btnHome.Text = "          Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 749);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(pnlThan);
            Controls.Add(pnMenu);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnMenu.ResumeLayout(false);
            pnlSanPham.ResumeLayout(false);
            pnlNhanVien.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlThan;
        private Panel panel3;
        private Label label2;
        private TextBox textBox2;
        private Panel panel5;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Helpers.EllipseControlArtan ellipseControlArtan;
        private Helpers.EllipseControlArtan ellipseControlArtanMenu;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label lblUserName;
        private Panel pnMenu;
        private Panel pnlSanPham;
        private Button btnSP;
        private Button btnNhaSanXuat;
        private Button btnChatLieu;
        private Button btnSanPham;
        private Panel pnlNhanVien;
        private Button btnNhanVien;
        private Button btnChucVu;
        private Button btnQLNhanVien;
        private Button btnBanHang;
        private Button btnThongKe;
        private Button btnHome;
    }
}