namespace _3_PL.Views
{
    partial class FrmLayLaiMatKhau
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
            label1 = new Label();
            txtMKMoi = new TextBox();
            txtNhapLaiMK = new TextBox();
            label2 = new Label();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(59, 50);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập Mật Khẩu Mới:";
            // 
            // txtMKMoi
            // 
            txtMKMoi.Location = new Point(181, 47);
            txtMKMoi.Name = "txtMKMoi";
            txtMKMoi.Size = new Size(191, 23);
            txtMKMoi.TabIndex = 1;
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.Location = new Point(181, 97);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.Size = new Size(191, 23);
            txtNhapLaiMK.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(59, 100);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhập Lại Mật Khẩu:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.ControlLightLight;
            btnXacNhan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.Red;
            btnXacNhan.Location = new Point(282, 138);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(90, 38);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // FrmLayLaiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(522, 247);
            Controls.Add(btnXacNhan);
            Controls.Add(txtNhapLaiMK);
            Controls.Add(label2);
            Controls.Add(txtMKMoi);
            Controls.Add(label1);
            Name = "FrmLayLaiMatKhau";
            Text = "FrmLayLaiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMKMoi;
        private TextBox txtNhapLaiMK;
        private Label label2;
        private Button btnXacNhan;
    }
}