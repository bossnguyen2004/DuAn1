using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class FrmDangKy : Form
    {
        private IKhachHangServices _lstkhachHangService;
        private string Id = "";
        private List<KhachHangViewModels> lstKhachHangViewModels;
        private KhachHangViewModels khachHangViewModel;

        public FrmDangKy()
        {
            InitializeComponent();
            _lstkhachHangService = new KhachHangServices();

            lstKhachHangViewModels = new List<KhachHangViewModels>();
            khachHangViewModel = new KhachHangViewModels();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu.Checked)
            {
                rdbNam.Checked = false;
                rdbNu.Checked = true;
            }
        }

        private void ckHD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHD.Checked)
            {
                ckHD.Checked = true;
                ckKHD.Checked = false;
            }
        }

        private void ckKHD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKHD.Checked)
            {
                ckHD.Checked = false;
                ckKHD.Checked = true;
            }
        }

        private void btnĐangKy_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string hoTen = txtHo.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtQuequan.Text;
            string email = txtEmail.Text;
            int gioiTinh = rdbNam.Checked ? 1 : 0;
            string password = txtMatKhau.Text;
            int trangThai = ckHD.Checked ? 1 : 0; 
            DateTime namSinh = dtnamSinh.Value;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            bool success = _lstkhachHangService.Add(ma, hoTen, sdt, diaChi, email, gioiTinh, namSinh, password, trangThai);
            if (success)
            {
                MessageBox.Show("Đăng ký thành công!");
                FrmLogin frmDangNhap = new FrmLogin();
                frmDangNhap.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
