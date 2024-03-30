using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using _3_PL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class FrmMain : Form
    {
        private INhanVienServices nhanVienServices;
        private IChucVuServices chucVuServices;
        private bool thoigian;
        private Form Allform;
        private Button currentButton;
        private bool isSubMenuOpen = false;

        private UserViewModel userViewModel;


        public FrmMain()
        {
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
            chucVuServices = new ChucVuServices();
            userViewModel = Helpers.AccountHelper.Instance.GetUserLoged();
            HideSubMenu();


        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {

                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (Allform != null)
            {
                Allform.Close();
            }
            ActivateButton(btnSender);
            Allform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlThan.Controls.Add(childForm);
            this.pnlThan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }






        public void HideSubMenu()
        {
            //lblUserName.Text = userViewModel.Ten;
            //if (userViewModel.IsCutomer)
            //{
            //    btnQLNhanVien.Visible = btnNhanVien.Visible = btnChucVu.Visible = false;
            //}
            foreach (var pnl in pnMenu.Controls.OfType<Panel>())
                pnl.Height = 45;

        }

        public void ShowSubMenu(Panel pnl)
        {
            pnl.Height = pnl.Controls.OfType<Button>().Count() * 30 + 15;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



        }

        // chức vụ

        private void btnQLNhanVien_Click_1(object sender, EventArgs e)
        {

            if (isSubMenuOpen)
            {
                HideSubMenu();
                isSubMenuOpen = false;
            }
            else
            {
                ShowSubMenu(pnlNhanVien);
                isSubMenuOpen = true;
            }
        }

        private void btnChucVu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChucVu(), sender);
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien(), sender);
        }



        // Sản phẩm
        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            if (isSubMenuOpen)
            {
                HideSubMenu();
                isSubMenuOpen = false;
            }
            else
            {
                ShowSubMenu(pnlSanPham);
                isSubMenuOpen = true;
            }

        }

        private void btnChatLieu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChatLieu(), sender);
        }

        private void btnNhaSanXuat_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhaSanXuat(), sender);
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham(), sender);
        }

        // Danh Mục
      





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
