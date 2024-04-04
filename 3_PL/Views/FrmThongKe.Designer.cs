namespace _3_PL.Views
{
    partial class FrmThongKe
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
            cbnam = new ComboBox();
            cbthang = new ComboBox();
            cbngay = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvThongKe = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbnam);
            groupBox1.Controls.Add(cbthang);
            groupBox1.Controls.Add(cbngay);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // cbnam
            // 
            cbnam.FormattingEnabled = true;
            cbnam.Location = new Point(131, 103);
            cbnam.Name = "cbnam";
            cbnam.Size = new Size(154, 23);
            cbnam.TabIndex = 5;
            cbnam.SelectedIndexChanged += cbnam_SelectedIndexChanged;
            // 
            // cbthang
            // 
            cbthang.FormattingEnabled = true;
            cbthang.Location = new Point(131, 65);
            cbthang.Name = "cbthang";
            cbthang.Size = new Size(154, 23);
            cbthang.TabIndex = 4;
            cbthang.SelectedIndexChanged += cbthang_SelectedIndexChanged;
            // 
            // cbngay
            // 
            cbngay.FormattingEnabled = true;
            cbngay.Location = new Point(131, 35);
            cbngay.Name = "cbngay";
            cbngay.Size = new Size(154, 23);
            cbngay.TabIndex = 3;
            cbngay.SelectedValueChanged += cbngay_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 111);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Theo Năm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 73);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Theo Tháng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Theo Ngày:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvThongKe);
            groupBox2.Location = new Point(29, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 210);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách";
            // 
            // dgvThongKe
            // 
            dgvThongKe.BackgroundColor = Color.White;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(27, 43);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.Size = new Size(502, 150);
            dgvThongKe.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            Load += FrmThongKe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbnam;
        private ComboBox cbthang;
        private ComboBox cbngay;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dgvThongKe;
    }
}