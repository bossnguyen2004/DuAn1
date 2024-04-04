
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _3_PL.Views
{
    public partial class FrmHome : Form
    {
        private INhanVienServices nhanVienServices;
        private IChucVuServices chucVuServices;
        private bool thoigian;
        private Form Allform;
        //private Button currentButton;
        private bool isSubMenuOpen = false;
        private bool isEmployeeLoggedIn = false;

        private UserViewModel userViewModel;

        private bool isCustomerLoggedIn = false;

        public FrmHome()
        {
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
            chucVuServices = new ChucVuServices();
            userViewModel = Helpers.AccountHelper.Instance.GetUserLoged();

            HideSubMenu();
            loginKhachHang();
            //loginNhanVien();
        }




        private void loginKhachHang()
        {
            isCustomerLoggedIn = true;
            HideSubMenu();
        }

        //private void loginNhanVien()
        //{
        //    isEmployeeLoggedIn = true;
        //    HideSubMenu();
        //}



        public void HideSubMenu()
        {


            //lblUserName.Text = userViewModel.Ten;

            //if (isCustomerLoggedIn)
            //{
            //    bntQLChucVu.Enabled = false;
            //    btnSanPham.Enabled = false;
            //}

            //else
            //{
            //    // Nếu không phải là khách hàng, hiển thị các nút quản lý chức vụ và quản lý sản phẩm
            //    bntQLChucVu.Visible = true;
            //    btnSanPham.Visible = true;
            //}


        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (Allform != null)
            {
                Allform.Close();
            }
            Allform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlThan.Controls.Add(childForm);
            this.pnlThan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu2.IsMainMenu = true;
            rjDropdownMenu3.IsMainMenu = true;
            rjDropdownMenu5.IsMainMenu = true;
        }


        // Chức vụ

        private void bntQLChucVu_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(bntQLChucVu, bntQLChucVu.Width, 0);

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien(), sender);
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChucVu(), sender);
        }
        private void giaoCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGiaoCa(), sender);
        }


        // Sản Phảm

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            rjDropdownMenu2.Show(btnSanPham, btnSanPham.Width, 0);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhaSanXuat(), sender);
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChatLieu(), sender);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham(), sender);
        }

        /// San Pham Chi tiết

        private void sảnPhẩmChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ảnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAnh(), sender);
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMauSac(), sender);
        }

        private void loạiGiàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLoaiGiay(), sender);
        }

        private void sizeGiàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSizeGiay(), sender);
        }



        // Danh Muc

        private void btnQlDanhMuc_Click(object sender, EventArgs e)
        {
            rjDropdownMenu3.Show(btnQlDanhMuc, btnQlDanhMuc.Width, 0);
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhMuc(), sender);
        }

        private void kiểuDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKieuDanhMuc(), sender);
        }




        private void btnQLKhachang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhachHang(), sender);
        }





        /// Cài đặt

        private void btnCaidat_Click(object sender, EventArgs e)
        {
            rjDropdownMenu5.Show(btnCaidat, btnCaidat.Width, 0);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dangxuat = MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dangxuat == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                this.Hide();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe(), sender);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBanHang(), sender);
        }
    }
}
