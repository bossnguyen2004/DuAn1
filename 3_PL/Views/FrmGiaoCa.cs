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
    public partial class FrmGiaoCa : Form
    {
        private IGiaoCaServices _iGiaoCaService;
        private INhanVienServices _iNhanVienService;
        private IHoaDonServices _HoaDon;
        private List<GiaoCaViewModels> lstGiaoCa;
        private List<NhanVienViewModels> lstNhanVien;
        private IChucVuServices ichucvu;
        private GiaoCaViewModels _itemSelected;
        private UserViewModel _userLoged;
        private NhanVienViewModels _nhanVienNhanCa;
        private ACTION_CLICK _actionClick = ACTION_CLICK.NONE;
        private static string caption = "Thông báo";
        private static Guid _IdGiaoCa;
        private decimal _TienCaTruoc;
        private IUserServices userServices;
        public FrmGiaoCa()
        {
            InitializeComponent();
            _iGiaoCaService = new GiaoCaServices();
            _iNhanVienService = new NhanVienServices();
            _HoaDon = new HoaDonServices();
            lstGiaoCa = new List<GiaoCaViewModels>();
            lstNhanVien = new List<NhanVienViewModels>();
            ichucvu = new ChucVuServices();
            userServices = new UserServices();
        }

        private void FrmGiaoCa_Load(object sender, EventArgs e)
        {
            init();
            loadData();
            decimal Money = 0;
            //if (_HoaDon.Get().FirstOrDefault(p => p.Id == FrmLogin.IdNV) != null)
            //{
            //    foreach (var item in _HoaDon.Get().Where(p => p.IdNv == FrmLogin.IdNV))
            //    {
            //        Money += item.TongTienTrongCa;
            //    }
            //    label11.Text = Money.ToString();
            //}
            //else label11.Text = 0.ToString();
            //if (_iGiaoCaService.GetAll().FirstOrDefault(p => p.Time == int.Parse(dtgiaoCa.Text)) != null)
            //    txtTiencatruoc.Text = _iGiaoCaService.GetAll().FirstOrDefault(p => p.Time == int.Parse(DateTime.Now.Hour.ToString())).TongTienCaTruoc.ToString();

        }


        private void enableControl(bool isEnable)
        {
            txtghichu.Enabled
                = txtTiencatruoc.Enabled = txtTienMat.Enabled
                = dtgiaoCa.Enabled = dtNhanCa.Enabled
                = isEnable;
            if (label12.Text != "Nhân viên")
            {
                txtTienBanDau.Enabled = isEnable;
            }
        }

        private void visibleControl(bool isVisible)
        {
            btnClear.Visible = btnLuu.Visible = isVisible;
        }

        private void reloadData()
        {
            lstGiaoCa.Clear();

        }
        private void loadData()
        {

        }
        private void clearForm()
        {
            txtghichu.Text
            = txtTienMat.Text = String.Empty;
            dtgiaoCa.Value = dtNhanCa.Value = DateTime.Now;
        }

        private void init()
        {
            _iGiaoCaService = new GiaoCaServices();
            _iNhanVienService = new NhanVienServices();

            lstGiaoCa = new List<GiaoCaViewModels>();
            lstNhanVien = new List<NhanVienViewModels>();

            _itemSelected = new GiaoCaViewModels();
            _nhanVienNhanCa = new NhanVienViewModels();

            initData();
            enableControl(false);
            visibleControl(false);
        }

        private void initData()
        {
            lstNhanVien = _iNhanVienService.GetAll();

            if (lstNhanVien.Count > 0)
            {
                _nhanVienNhanCa = lstNhanVien[0];
            }

            _userLoged = Helpers.AccountHelper.Instance.GetUserLoged();
            txtNhanVienCa.Text = _userLoged.Ten;
        }

        private void getHoTen()
        {
            foreach (var item in lstGiaoCa)
            {
                var nvTrongCa = lstNhanVien.Where(x => x.Id == item.IdNvTrongCa).FirstOrDefault();
                var nvCaTiep = lstNhanVien.Where(y => y.Id == item.IdNvNhanCaTiep).FirstOrDefault();
                item.NhanVienCaTiep = nvCaTiep?.Ten;
                item.NhanVienTrongCa = nvTrongCa?.Ten;
            }
        }


        private void bindingDataToForm()
        {
            txtghichu.Text = _itemSelected.GhiChuPhatSinh;
            var nvBanGiao = lstNhanVien.Where(x => x.Id == FrmLogin.IdNV).FirstOrDefault();
            txtNhanVienCa.Text = nvBanGiao != null ? nvBanGiao.Ten : "";
            var nvNhan = lstNhanVien.Where(y => y.Id == _itemSelected.IdNvNhanCaTiep).FirstOrDefault();

            txtTiencatruoc.Text = _itemSelected.TongTienCaTruoc.HasValue ? _itemSelected.TongTienCaTruoc.Value.ToString() : "";
            txtTienMat.Text = _itemSelected.TongTienMat.HasValue ? _itemSelected.TongTienMat.Value.ToString() : "";
            txtTienphatsinh.Text = _itemSelected.TienPhatSinh.HasValue ? _itemSelected.TienPhatSinh.Value.ToString() : "";
            txtTienBanDau.Text = _itemSelected.TienBanDau.HasValue ? $"{_itemSelected.TienBanDau.ToString()}đ" : "0đ";
            dtgiaoCa.Value = _itemSelected.ThoiGianGiaoCa;
            dtNhanCa.Value = _itemSelected.ThoiGianNhanCa;

        }


        private void getDataForm()
        {
            if (_actionClick == ACTION_CLICK.ADD)
            {
                _itemSelected = new GiaoCaViewModels();
            }
            var timeNow = DateTime.Now;
            _itemSelected.Ma = $"GC{timeNow.Year}{timeNow.Month}{timeNow.Day}{timeNow.Hour}{timeNow.Minute}";
            _itemSelected.TienBanDau = Convert.ToDecimal(txtTienBanDau.Text.Replace("đ", ""))
                + decimal.Parse(label11.Text.Replace("đ", ""))
                - decimal.Parse(txtTienphatsinh.Text.Replace("đ", ""))
                - decimal.Parse(txtTienRut.Text.Replace("đ", ""));
            _itemSelected.GhiChuPhatSinh = txtghichu.Text;
            _itemSelected.TongTienCaTruoc = decimal.Parse(label11.Text);
            _itemSelected.TongTienMat = Convert.ToDecimal(!String.IsNullOrEmpty(txtTienMat.Text.Replace("đ", "")) ? txtTienMat.Text.Replace("đ", "") : "0");
            _itemSelected.IdNvNhanCaTiep = _nhanVienNhanCa.Id;
            _itemSelected.IdNvTrongCa = _userLoged.Id;
            _itemSelected.ThoiGianGiaoCa = dtgiaoCa.Value;
            _itemSelected.ThoiGianNhanCa = dtNhanCa.Value;
            _itemSelected.TongTienTrongCa = decimal.Parse(label11.Text);
        }

        private void dgvGiaoCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _itemSelected = lstGiaoCa[e.RowIndex];
            if (_itemSelected != null)
            {
                bindingDataToForm();
            }
        }

        private void btnGiaoCa_Click(object sender, EventArgs e)
        {
            _actionClick = ACTION_CLICK.UPDATE;
            enableControl(true);
            visibleControl(true);
            clearForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getDataForm();
            var mess = string.Empty;
            var result = true;
            var resultConfirm = DialogResult.No;
            if (_actionClick == ACTION_CLICK.UPDATE)
            {
                mess = $"Bạn có chắc chắn muốn Luu không ?";
                resultConfirm = MessageBox.Show(mess, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultConfirm == DialogResult.Yes)
                {
                    result = _iGiaoCaService.Sua(_itemSelected);
                    if (result)
                    {
                        mess = $"Luu thành công !!!";
                        MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        mess = $"Luu không thành công !!!";
                        MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (result)
            {
                enableControl(false);
                visibleControl(false);
                _actionClick = ACTION_CLICK.NONE;
                reloadData();
            }

        }

        enum ACTION_CLICK
        {
            NONE,
            ADD,
            UPDATE
        }
    }
}
