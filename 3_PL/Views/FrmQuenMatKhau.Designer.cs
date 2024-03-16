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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtEmail = new TextBox();
            btnSend = new Button();
            btnNhapMa = new Button();
            btnXacNhan = new Button();
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
            splitContainer1.Panel1.BackColor = Color.FromArgb(255, 192, 128);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel2.Controls.Add(btnXacNhan);
            splitContainer1.Panel2.Controls.Add(btnNhapMa);
            splitContainer1.Panel2.Controls.Add(btnSend);
            splitContainer1.Panel2.Controls.Add(txtEmail);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(638, 378);
            splitContainer1.SplitterDistance = 212;
            splitContainer1.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 205);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 1;
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
            // 
            // btnNhapMa
            // 
            btnNhapMa.BackColor = SystemColors.ButtonHighlight;
            btnNhapMa.ForeColor = Color.Red;
            btnNhapMa.Location = new Point(82, 196);
            btnNhapMa.Name = "btnNhapMa";
            btnNhapMa.Size = new Size(90, 37);
            btnNhapMa.TabIndex = 3;
            btnNhapMa.Text = "Nhập Mã OTP";
            btnNhapMa.UseVisualStyleBackColor = false;
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
        private Button btnNhapMa;
        private Button btnSend;
        private TextBox txtEmail;
        private Label label2;
    }
}