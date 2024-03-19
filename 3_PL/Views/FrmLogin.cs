using _2_BUS.IServices;
using _2_BUS.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace _3_PL.Views
{
    public partial class FrmLogin : Form
    {
        private INhanVienServices nhanVienServices;
        private string password = string.Empty;
        public FrmLogin()
        {
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMail.Text.Trim()) && !string.IsNullOrEmpty(password.Trim()))
            {
                var user = nhanVienServices.Login(txtMail.Text.Trim(), password.Trim());
                if (user != null)
                {
                    Helpers.AccountHelper.Instance.SetUserLogin(user);
                    var formNhanVien = new FrmNhanVien();
                    formNhanVien.Show();
                    this.Visible = false;
                }
            }
        }

        private void ckbHTMK_CheckedChanged(object sender, EventArgs e)
        {
            txtmatKhau.UseSystemPasswordChar = !ckbHTMK.Checked;
        }

        private void txtmatKhau_TextChanged(object sender, EventArgs e)
        {
            password = txtmatKhau.Text;
        }

        private void linkQMK_Click(object sender, EventArgs e)
        {
            var quenmatKhau = new FrmQuenMatKhau();
            quenmatKhau.Show();
            this.Visible = false;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var dangKy = new FrmDangKy();
            dangKy.Show();
            this.Visible = false;
        }
    }
}
