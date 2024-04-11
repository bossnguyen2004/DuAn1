using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
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
        private IUserServices userServices;
        public static Guid IdNV;
        private string password = string.Empty;
        public FrmLogin()
        {
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
            userServices = new UserServices();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtmatKhau.UseSystemPasswordChar = true;
            txtMail.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMail.Text.Trim()) && !string.IsNullOrEmpty(password.Trim()))
            {
                var user = userServices.Login(txtMail.Text.Trim(), txtmatKhau.Text.Trim());
                if (user != null)
                {
                    var userViewModel = new UserViewModel();
                    try
                    {
                        var nv = (NhanVien)user;
                        userViewModel.Id = nv.Id;
                        userViewModel.IsCutomer = false;
                        userViewModel.Ho = nv.Ho;
                        userViewModel.Ten = nv.Ten;
                    }
                    catch (Exception)
                    {
                        var kh = (KhachHang)user;
                        userViewModel.Id = kh.Id.Value;
                        userViewModel.IsCutomer = true;
                        userViewModel.Ten = kh.Ten;
                    }
                    Helpers.AccountHelper.Instance.SetUserLogin(userViewModel);
                    this.Hide();
                    var formMain = new frmMain();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Email hoặc password không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
