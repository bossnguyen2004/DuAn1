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

namespace _3_PL.Views
{
    public partial class frmBills : Form
    {
        private UserViewModel _userLogin = new UserViewModel();

        private IChatLieuServices chatLieuService;
        private INhaSanXuatServices nhaSanXuatServices;
        private ISanPhamServices sanPhamServices;
        private ILoaiGiayServices loaiGiayServices;
        private ISizeGiayServices sizeGiayServices;
        private IMauSacServices mauSacServices;
        private IAnhServices anhServices;
        private ISanPhamChiTietServices sanPhamChiTietServices;
        private IHoaDonServices hoaDonServices;
        private IHoaDonCTServices hoaDonCTServices;
        private IKhachHangServices khachHangServices;

        private int index = -1;
        private string imagePath = "";

        private List<Anh> _lstAnh;
        private List<LoaiGiay> _lstLoaiGiay;
        private List<ChatLieu> _lstChatLieu;
        private List<NhaSanXuat> _lstNSX;
        private List<SizeGiay> _lstSize;
        private List<MauSac> _lstMauSac;
        private List<SanPham> _lstSanPham;
        private List<ProductsViewModel> _lstsanPhamViewModels;
        private List<SanPhamChiTiet> _lstChiTietSanPham;
        private List<HoaDon> _lstHoaDon;
        private List<HoaDonChiTiet> _lstHoaDonChiTiet;
        private List<KhachHang> _lstKhachHang;

        private List<HoaDonViewModels> _lstHoaDonViewModel;

        public frmBills()
        {
            InitializeComponent();
        }

        private void frmBills_Load(object sender, EventArgs e)
        {
            _userLogin = Helpers.AccountHelper.Instance.GetUserLoged();
            visibleControl();
            initGridView();

            // khoi tao service
            sanPhamServices = new SanPhamServices();
            chatLieuService = new ChatLieuServices();
            nhaSanXuatServices = new NhaSanXuatServices();
            loaiGiayServices = new LoaiGiayServices();
            anhServices = new AnhServices();
            mauSacServices = new MauSacServices();
            sizeGiayServices = new SizeGiayServices();
            sanPhamChiTietServices = new SanPhamCTServices();
            hoaDonServices = new HoaDonServices();
            hoaDonCTServices = new HoaDonChiTietServices();
            khachHangServices = new KhachHangServices();

            _lstSanPham = new List<SanPham>();
            _lstAnh = new List<Anh>();
            _lstLoaiGiay = new List<LoaiGiay>();
            _lstChatLieu = new List<ChatLieu>();
            _lstNSX = new List<NhaSanXuat>();
            _lstSize = new List<SizeGiay>();
            _lstMauSac = new List<MauSac>();
            _lstsanPhamViewModels = new List<ProductsViewModel>();
            _lstChiTietSanPham = new List<SanPhamChiTiet>();
            _lstHoaDonViewModel = new List<HoaDonViewModels>();
            _lstKhachHang = new List<KhachHang>();

            initData();
            initDataComboBox();
            initDataBills();
            intDataGridView();
        }

        private void visibleControl()
        {
            if (_userLogin.IsCutomer)
            {
                txtDiaChi.Enabled = txtEmail.Enabled = txtGhiChu.Enabled = txtGiaBan.Enabled = txtMa.Enabled
                    = txtSdtNhan.Enabled = txtSoLuong.Enabled = txtTen.Enabled = cbChatLieu.Enabled
                    = cbLoaiSanPham.Enabled = cbMauSac.Enabled = cbNSX.Enabled = cbSize.Enabled = false;
            }
        }

        private void initGridView()
        {
            dgvCart.Rows.Clear();
            dgvCart.ColumnCount = 13;
            dgvCart.Columns[0].Name = "Id";
            dgvCart.Columns[0].Visible = false;
            dgvCart.Columns[1].Name = "Mã sản phẩm";
            dgvCart.Columns[2].Name = "Tên sản phẩm";
            dgvCart.Columns[3].Name = "Trạng thái";
            dgvCart.Columns[3].Visible = false;
            dgvCart.Columns[4].Name = "Loại";
            dgvCart.Columns[5].Name = "Nhà sản xuất";
            dgvCart.Columns[6].Name = "Chất liệu";
            dgvCart.Columns[7].Name = "Size";
            dgvCart.Columns[8].Name = "Màu sắc";
            dgvCart.Columns[9].Name = "Giá";
            dgvCart.Columns[10].Name = "Số lượng";
            dgvCart.Columns[11].Name = "SĐT";
            dgvCart.Columns[12].Name = "Địa chỉ";
            dgvCart.AllowUserToAddRows = false;
        }

        private void initData()
        {
            _lstLoaiGiay = loaiGiayServices.GetAll();
            _lstChatLieu = chatLieuService.GetAll();
            _lstNSX = nhaSanXuatServices.GetAll();
            _lstSize = sizeGiayServices.GetAll();
            _lstMauSac = mauSacServices.GetAll();
            _lstSanPham = sanPhamServices.GetAllSanPham();
            _lstChiTietSanPham = sanPhamChiTietServices.GetAllChiTiet();
            if (_userLogin.IsCutomer)
            {
                _lstHoaDon = hoaDonServices.GetAll().Where(x => x.IdKh != null && x.IdKh.Value == _userLogin.Id && x.TinhTrang == 1).ToList();
            }
            else
            {
                _lstHoaDon = hoaDonServices.GetAll().Where(x => x.TinhTrang == 1).ToList();
            }
            _lstHoaDonChiTiet = hoaDonCTServices.GetAll();
            _lstKhachHang = khachHangServices.GetAll();
        }

        private void initDataComboBox()
        {
            cbLoaiSanPham.DataSource = _lstLoaiGiay;
            cbLoaiSanPham.DisplayMember = "Ten";
            cbLoaiSanPham.ValueMember = "Id";

            cbSize.DataSource = _lstSize;
            cbSize.DisplayMember = "SoSize";
            cbSize.ValueMember = "Id";

            cbMauSac.DataSource = _lstMauSac;
            cbMauSac.DisplayMember = "Ten";
            cbMauSac.ValueMember = "Id";

            cbNSX.DataSource = _lstNSX;
            cbNSX.DisplayMember = "Ten";
            cbNSX.ValueMember = "Id";

            cbChatLieu.DataSource = _lstChatLieu;
            cbChatLieu.DisplayMember = "Ten";
            cbChatLieu.ValueMember = "Id";
        }

        private void initDataBills()
        {
            _lstHoaDonViewModel.Clear();
            foreach (var b in _lstHoaDon)
            {
                var bill = new HoaDonViewModels();
                bill.MoTa = b.MoTa;
                bill.Ma = b.Ma;
                bill.SDT = b.SDT;
                bill.DiaChi = b.DiaChi;
                bill.IdKh = b.IdKh;
                bill.IdNv = b.IdNv;
                bill.DiaChi = b.DiaChi;

                var hdChiTiet = _lstHoaDonChiTiet.Where(x => x.IdHoaDon == b.Id).FirstOrDefault();
                if (hdChiTiet != null)
                {
                    bill.SoLuong = hdChiTiet.SoLuong.Value;
                    bill.TongTienTrongCa = hdChiTiet.ThanhTien.Value;

                    var sp = _lstChiTietSanPham.Where(x => x.Id == hdChiTiet.IdChiTietSanPham).FirstOrDefault();
                    if (sp != null)
                    {
                        bill.IdAnh = sp.IdAnh;
                        var anh = _lstAnh.Where(x => x.ID == sp.IdAnh).FirstOrDefault();
                        if (anh != null)
                        {
                            bill.Anh = anh.DuongDan;
                        }
                        bill.IdMauSac = sp.IdMauSac;
                        var mau = _lstMauSac.Where(x => x.Id == sp.IdMauSac).FirstOrDefault();
                        if (mau != null)
                        {
                            bill.TenMauSac = mau.Ten;
                        }
                        bill.IdLoaiSanPham = sp.IdLoaiGiay;
                        var loai = _lstLoaiGiay.Where(x => x.Id == sp.IdLoaiGiay).FirstOrDefault();
                        if (loai != null)
                        {
                            bill.LoaiSanPham = loai.Ten;
                        }
                        bill.IdSize = sp.IdSizeGiay;
                        var size = _lstSize.Where(x => x.Id == sp.IdSizeGiay).FirstOrDefault();
                        if (size != null)
                        {
                            bill.Size = size.SoSize;
                        }
                        var s = _lstSanPham.Where(x => x.Id == sp.IdSanPham).FirstOrDefault();
                        if (s != null)
                        {
                            bill.Ten = s.Ten;
                            bill.IdNSX = s.IdNhaSanXuat;
                            var nsx = _lstNSX.Where(x => x.Id == s.IdNhaSanXuat).FirstOrDefault();
                            if (nsx != null)
                            {
                                bill.TenNSX = nsx.Ten;
                            }
                            bill.IdChatLieu = s.IdChatLieu;
                            var chatLieu = _lstChatLieu.Where(x => x.Id == s.IdChatLieu).FirstOrDefault();
                            if (chatLieu != null)
                            {
                                bill.TenChatLieu = chatLieu.Ten;
                            }
                        }
                    }
                }
                var kh = _lstKhachHang.Where(x => x.Id == b.IdKh).FirstOrDefault();
                if (kh != null)
                {
                    bill.Email = kh.Email;
                }

                _lstHoaDonViewModel.Add(bill);
            }
        }

        private void intDataGridView()
        {
            dgvCart.Rows.Clear();
            foreach (var item in _lstHoaDonViewModel)
            {
                dgvCart.Rows.Add(
                     item.Id,
                     item.Ma,
                     item.Ten,
                     item.TinhTrang == 1,
                     item.LoaiSanPham,
                     item.TenNSX,
                     item.TenChatLieu,
                     item.Size,
                     item.TenMauSac,
                     item.GiaBan,
                     item.SoLuong,
                     item.SDT,
                     item.DiaChi
                     );
            }
        }

        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            var hd = _lstHoaDonViewModel[index];
            bindingData(hd);
        }

        private void bindingData(HoaDonViewModels hd)
        {
            txtMa.Text = hd.Ma;
            txtTen.Text = hd.Ten;
            txtGiaBan.Text = hd.GiaBan;
            txtDiaChi.Text = hd.DiaChi;
            txtEmail.Text = hd.Email;
            txtGhiChu.Text = hd.MoTa;
            txtSoLuong.Text = hd.SoLuong.ToString();
            if (hd.IdChiTiet != null)
            {
                cbChatLieu.SelectedValue = hd.IdChatLieu;
            }
            if (hd.IdLoaiSanPham != null)
            {
                cbLoaiSanPham.SelectedValue = hd.IdLoaiSanPham;
            }
            if (hd.IdMauSac != null)
            {
                cbMauSac.SelectedValue = hd.IdMauSac;
            }
            if (hd.IdSize != null)
            {
                cbSize.SelectedValue = hd.IdSize;
            }
        }

        private void reloadBills()
        {
            _lstHoaDon.Clear();
            _lstHoaDonChiTiet.Clear();
            if (_userLogin.IsCutomer)
            {
                // khach hang
                _lstHoaDon = hoaDonServices.GetAll().Where(x => x.IdKh != null && x.IdKh.Value == _userLogin.Id && x.TinhTrang == 1).ToList();
            }
            else
            {
                _lstHoaDon = hoaDonServices.GetAll().Where(x => x.TinhTrang == 1).ToList();
            }
            _lstHoaDonChiTiet = hoaDonCTServices.GetAll();
            initDataBills();
            intDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                decimal giaBan = 0;
                if (txtGiaBan.Text.Trim().Length > 0)
                {
                    giaBan = decimal.Parse(txtGiaBan.Text.Trim());
                }
                Guid idChatLieu = _lstChatLieu[cbChatLieu.SelectedIndex].Id;
                Guid idNsx = _lstNSX[cbNSX.SelectedIndex].Id.Value;
                Guid idLoai = _lstLoaiGiay[cbLoaiSanPham.SelectedIndex].Id.Value;
                Guid idSize = _lstSize[cbSize.SelectedIndex].Id.Value;
                Guid idMauSac = _lstMauSac[cbMauSac.SelectedIndex].Id.Value;
                var result = sanPhamServices.Add(txtTen.Text, txtMa.Text, 1, imagePath, giaBan,
                    idChatLieu, idNsx, idLoai, idSize, idMauSac);
                if (result)
                {
                    MessageBox.Show("Thêm mới sản phẩm thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadBills();
                }
                else
                {
                    MessageBox.Show("Thêm mới sản phẩm không thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới sản phẩm không thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //ptbSanPham.Image = Image.FromFile(open.FileName);
                    imagePath = open.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message), "Liên hệ khắc phục");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Guid id = _lstsanPhamViewModels[index].Id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                var result = sanPhamServices.Delete(id);
                if (result)
                {
                    MessageBox.Show("Xóa sản phẩm thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadBills();
                }
                else
                    MessageBox.Show("Xóa sản phẩm không thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Text = txtTen.Text = txtGiaBan.Text = "";
            if (_lstChatLieu.Count > 0)
            {
                cbChatLieu.SelectedIndex = 0;
            }
            if (_lstLoaiGiay.Count > 0)
            {
                cbChatLieu.SelectedIndex = 0;
            }
            if (_lstMauSac.Count > 0)
            {
                cbMauSac.SelectedIndex = 0;
            }
            if (_lstNSX.Count > 0)
            {
                cbNSX.SelectedIndex = 0;
            }
            //ptbSanPham.Image = Image.FromFile("D:\\DuAn1\\DuAn1\\3_PL\\Resources\\default.png");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                decimal giaBan = 0;
                if (txtGiaBan.Text.Trim().Length > 0)
                {
                    giaBan = decimal.Parse(txtGiaBan.Text.Trim());
                }
                Guid id = _lstsanPhamViewModels[index].Id;
                Guid idChatLieu = _lstChatLieu[cbChatLieu.SelectedIndex].Id;
                Guid idNsx = _lstNSX[cbNSX.SelectedIndex].Id.Value;
                Guid idLoai = _lstLoaiGiay[cbLoaiSanPham.SelectedIndex].Id.Value;
                Guid idSize = _lstSize[cbSize.SelectedIndex].Id.Value;
                Guid idMauSac = _lstMauSac[cbMauSac.SelectedIndex].Id.Value;
                var result = sanPhamServices.Update(id, txtTen.Text, txtMa.Text, 1, imagePath, giaBan,
                    idChatLieu, idNsx, idLoai, idSize, idMauSac);
                if (result)
                {
                    MessageBox.Show("Sửa sản phẩm thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadBills();
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm không thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa sản phẩm không thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
