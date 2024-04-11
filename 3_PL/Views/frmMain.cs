using _2_BUS.ViewModels;
using _3_PL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class frmMain : Form
    {
        private UserViewModel _userLogin = new UserViewModel();
        private Form currentForm;

        public frmMain()
        {
            InitializeComponent();
            hideTab();

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu4.IsMainMenu = true;
        }
        private void hideTab()
        {
            _userLogin = Helpers.AccountHelper.Instance.GetUserLoged();
            if (_userLogin.IsCutomer)
            {
                btnKhachHang.Visible = btnDanhMuc.Visible = btnThongKe.Visible = false;
                btnDonHang.Text = "Giỏ Hàng";
            }
            lblUserName.Text = _userLogin.Ho + " " + _userLogin.Ten;
            var frmProduct = new frmProducts();
            openChildForm(frmProduct);
        }
        private void openChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnContent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            var frmCart = new frmCarts();
            openChildForm(frmCart);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            var frmBills = new frmBills();
            openChildForm(frmBills);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            var frmProduct = new frmProducts();
            openChildForm(frmProduct);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(btnDanhMuc, btnDanhMuc.Width, 0);
        }

        private void kieuDanhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmKieuDanhMuc = new FrmKieuDanhMuc();
            openChildForm(frmKieuDanhMuc);
        }


        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDanhMuc = new FrmDanhMuc();
            openChildForm(frmDanhMuc);
        }

        private void loaiGiayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLoaiGiay = new FrmLoaiGiay();
            openChildForm(frmLoaiGiay);
        }

        private void sizeGiayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSizeGiay = new FrmSizeGiay();
            openChildForm(frmSizeGiay);
        }

        private void chatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmChatLieu = new FrmChatLieu();
            openChildForm(frmChatLieu);
        }

        private void nhaSanXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNSX = new FrmNhaSanXuat();
            openChildForm(frmNSX);
        }

        private void mauSacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMauSac = new FrmMauSac();
            openChildForm(frmMauSac);
        }

        private void anhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAnh = new FrmAnh();
            openChildForm(frmAnh);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            rjDropdownMenu4.Show(btnCaiDat, btnCaiDat.Width, 0);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dangxuat = MessageBox.Show("Ban co muon dang xuat khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dangxuat == DialogResult.Yes)
            {
                FrmLogin frmlogin = new FrmLogin();
                this.Hide();
                frmlogin.ShowDialog();
                this.Close();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var frmthongke = new FrmThongKe();
            openChildForm(frmthongke);
        }
    }
}
