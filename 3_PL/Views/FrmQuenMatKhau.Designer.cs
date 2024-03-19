namespace _3_PL.Views
{
    partial class FrmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuenMatKhau));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNhapMa = new TextBox();
            btnXacNhan = new Button();
            btnSend = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel2.Controls.Add(txtNhapMa);
            splitContainer1.Panel2.Controls.Add(btnXacNhan);
            splitContainer1.Panel2.Controls.Add(btnSend);
            splitContainer1.Panel2.Controls.Add(txtEmail);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(638, 378);
            splitContainer1.SplitterDistance = 212;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 205);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(21, 62);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 0;
            label1.Text = "Quên Mật Khẩu";
            // 
            // txtNhapMa
            // 
            txtNhapMa.Location = new Point(67, 209);
            txtNhapMa.Name = "txtNhapMa";
            txtNhapMa.Size = new Size(121, 23);
            txtNhapMa.TabIndex = 5;
            txtNhapMa.Text = "Nhập Mã OTP";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.ButtonHighlight;
            btnXacNhan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.Red;
            btnXacNhan.Location = new Point(194, 195);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(96, 37);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ButtonHighlight;
            btnSend.ForeColor = Color.Red;
            btnSend.Location = new Point(306, 153);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(60, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 0;
            label2.Text = "Email:";
            // 
            // FrmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 378);
            Controls.Add(splitContainer1);
            Name = "FrmQuenMatKhau";
            Text = "FrmQuenMatKhau";
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

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnXacNhan;
        private Button btnSend;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNhapMa;
    }
}