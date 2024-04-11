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
    public partial class frmProducts : Form
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

        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
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

            _lstSanPham = new List<SanPham>();
            _lstAnh = new List<Anh>();
            _lstLoaiGiay = new List<LoaiGiay>();
            _lstChatLieu = new List<ChatLieu>();
            _lstNSX = new List<NhaSanXuat>();
            _lstSize = new List<SizeGiay>();
            _lstMauSac = new List<MauSac>();
            _lstsanPhamViewModels = new List<ProductsViewModel>();
            _lstChiTietSanPham = new List<SanPhamChiTiet>();

            initData();
            initDataComboBox();
            initDataSanPham();
            intDataGridView();
        }

        private void visibleControl()
        {
            if (_userLogin.IsCutomer)
            {
                btnBanHang.Visible = btnThem.Visible = btnSua.Visible = btnXoa.Visible = btnClear.Visible = false;
                cbLoaiSanPham.Enabled = cbChatLieu.Enabled = cbMauSac.Enabled = cbNSX.Enabled = cbSize.Enabled =
                    txtGiaBan.Enabled = txtMa.Enabled = txtTen.Enabled = false;
                ptbSanPham.Click -= new EventHandler(ptbSanPham_Click);
                btnBanHang.Visible = false;
                btnThemVaoGio.Visible = true;
            }
            else
            {
                btnThemVaoGio.Visible = false;
                btnBanHang.Visible = true;
            }
        }

        private void initGridView()
        {
            dgvSanPham.ColumnCount = 11;
            dgvSanPham.Columns[0].Name = "Id";
            dgvSanPham.Columns[0].Visible = false;
            dgvSanPham.Columns[1].Name = "Mã";
            dgvSanPham.Columns[2].Name = "Tên sản phẩm";
            dgvSanPham.Columns[3].Name = "Trạng thái";
            dgvSanPham.Columns[4].Name = "Loại";
            dgvSanPham.Columns[5].Name = "Nhà sản xuất";
            dgvSanPham.Columns[6].Name = "Chất liệu";
            dgvSanPham.Columns[7].Name = "Size";
            dgvSanPham.Columns[8].Name = "Màu sắc";
            dgvSanPham.Columns[9].Name = "Ảnh";
            dgvSanPham.Columns[9].Visible = false;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.Columns[10].Name = "Giá";
            dgvSanPham.Rows.Clear();
        }

        private void initData()
        {
            _lstAnh = anhServices.GetAll();
            _lstLoaiGiay = loaiGiayServices.GetAll();
            _lstChatLieu = chatLieuService.GetAll();
            _lstNSX = nhaSanXuatServices.GetAll();
            _lstSize = sizeGiayServices.GetAll();
            _lstMauSac = mauSacServices.GetAll();
            _lstSanPham = sanPhamServices.GetAllSanPham();
            _lstChiTietSanPham = sanPhamChiTietServices.GetAllChiTiet();
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

        private void initDataSanPham()
        {
            foreach (var sp in _lstSanPham)
            {
                var product = new ProductsViewModel();
                product.Id = sp.Id.Value;
                product.TenSanPham = sp.Ten;
                product.MaSanPham = sp.Ma;
                product.TrangThai = sp.TrangThai;
                var chatLieu = _lstChatLieu.Where(x => x.Id == sp.IdChatLieu).FirstOrDefault();
                if (chatLieu != null)
                {
                    product.IdChatLieu = chatLieu.Id;
                    product.TenChatLieu = chatLieu.Ten;
                }
                var nsx = _lstNSX.Where(x => x.Id == sp.IdNhaSanXuat).FirstOrDefault();
                if (nsx != null)
                {
                    product.IdNSX = nsx.Id;
                    product.TenNSX = nsx.Ten;
                }
                var chiTiet = _lstChiTietSanPham.Where(x => x.IdSanPham == product.Id).FirstOrDefault();
                if (chiTiet != null)
                {
                    var anh = _lstAnh.Where(x => x.ID == chiTiet.IdAnh).FirstOrDefault();
                    if (anh != null)
                    {
                        product.IdAnh = anh.ID;
                        product.Anh = anh.DuongDan;
                    }
                    var mausac = _lstMauSac.Where(x => x.Id == chiTiet.IdMauSac).FirstOrDefault();
                    if (mausac != null)
                    {
                        product.IdMauSac = mausac.Id;
                        product.TenMauSac = mausac.Ten;
                    }
                    var loaigiay = _lstLoaiGiay.Where(x => x.Id == chiTiet.IdLoaiGiay).FirstOrDefault();
                    if (loaigiay != null)
                    {
                        product.IdLoaiSanPham = loaigiay.Id;
                        product.LoaiSanPham = loaigiay.Ten;
                    }
                    var sizegiay = _lstSize.Where(x => x.Id == chiTiet.IdSizeGiay).FirstOrDefault();
                    if (sizegiay != null)
                    {
                        product.IdSize = sizegiay.Id;
                        product.Size = sizegiay.SoSize;
                    }
                    product.GiaBan = chiTiet.GiaBan.ToString();
                }

                _lstsanPhamViewModels.Add(product);
            }
        }

        private void intDataGridView()
        {
            dgvSanPham.Rows.Clear();
            foreach (var item in _lstsanPhamViewModels)
            {
                dgvSanPham.Rows.Add(
                     item.Id,
                     item.MaSanPham,
                     item.TenSanPham,
                     item.TrangThai == 1 ? "Còn hàng" : "Hết hàng",
                     item.LoaiSanPham,
                     item.TenNSX,
                     item.TenChatLieu,
                     item.Size,
                     item.TenMauSac,
                     item.Anh,
                     item.GiaBan
                     );
            }
        }

        private void reloadSanPham()
        {
            _lstAnh.Clear();
            _lstSanPham.Clear();
            _lstChiTietSanPham.Clear();
            _lstAnh = anhServices.GetAll();
            _lstSanPham = sanPhamServices.GetAllSanPham();
            _lstChiTietSanPham = sanPhamChiTietServices.GetAllChiTiet();
            initDataSanPham();
            intDataGridView();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            var sanPham = _lstsanPhamViewModels[index];
            bindingData(sanPham);
        }

        private void bindingData(ProductsViewModel sp)
        {
            txtTen.Text = sp.TenSanPham;
            txtMa.Text = sp.MaSanPham;
            txtGiaBan.Text = sp.GiaBan;
            if (sp.IdChiTiet != null)
            {
                cbChatLieu.SelectedValue = sp.IdChatLieu;
            }
            if (sp.IdLoaiSanPham != null)
            {
                cbLoaiSanPham.SelectedValue = sp.IdLoaiSanPham;
            }
            if (sp.IdMauSac != null)
            {
                cbMauSac.SelectedValue = sp.IdMauSac;
            }
            if (sp.IdSize != null)
            {
                cbSize.SelectedValue = sp.IdSize;
            }
            if (sp.Anh != null && sp.Anh.Length > 0)
            {
                ptbSanPham.Image = System.Drawing.Image.FromFile(sp.Anh);
            }
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
                var result = sanPhamServices.Add(txtMa.Text, txtTen.Text, 1, imagePath, giaBan,
                    idChatLieu, idNsx, idLoai, idSize, idMauSac);
                if (result)
                {
                    MessageBox.Show("Thêm mới sản phẩm thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadSanPham();
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
                    ptbSanPham.Image = Image.FromFile(open.FileName);
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
                    reloadSanPham();
                }
                else
                    MessageBox.Show("Xóa sản phẩm không thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTen.Text = txtMa.Text = txtGiaBan.Text = "";
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
            ptbSanPham.Image = Image.FromFile("D:\\DuAn1\\DuAn1\\3_PL\\Resources\\default.png");
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
                var result = sanPhamServices.Update(id, txtMa.Text, txtTen.Text, 1, imagePath, giaBan,
                    idChatLieu, idNsx, idLoai, idSize, idMauSac);
                if (result)
                {
                    MessageBox.Show("Sửa sản phẩm thành không?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadSanPham();
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

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sản phẩm vào giỏ hàng không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Guid idSp = _lstsanPhamViewModels[index].Id;
                var result = sanPhamServices.AddCart(_userLogin, null, idSp);
                if (result)
                {
                    MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm vào giỏ hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            var frmCart = new frmCarts(_lstsanPhamViewModels[index]);
            frmCart.ShowDialog();
        }
    }
}
