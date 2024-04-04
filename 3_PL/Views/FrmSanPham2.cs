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
    public partial class FrmSanPham2 : Form
    {
        private IChatLieuServices _lstChatLieuServices;
        private INhaSanXuatServices _lstnhaSanXuatServices;
        private ISanPhamServices _lstanPhamServices;
        private ILoaiGiayServices _loaiGiayServices;
        private ISizeGiayServices _sizeGiayServices;
        private IMauSacServices _mauSacServices;
        private IAnhServices _anhServices;
        private ISanPhamChiTietServices _lstsanPhamChiTietServices;

        private Guid Id;

        private List<Anh> _lstAnh;
        private List<LoaiGiay> _lstLoaiGiay;
        private List<ChatLieu> _lstChatLieu;
        private List<NhaSanXuat> _lstNSX;
        private List<SizeGiay> _lstSize;
        private List<MauSac> _lstMauSac;
        private List<SanPham> _lstSanPham;
        private List<ProductsViewModel> _lstsanPhamViewModels;
        private List<SanPhamChiTiet> _lstChiTietSanPham;

        public FrmSanPham2()
        {
            InitializeComponent();
            _lstanPhamServices = new SanPhamServices();
            _lstChatLieuServices = new ChatLieuServices();
            _lstnhaSanXuatServices = new NhaSanXuatServices();
            _loaiGiayServices = new LoaiGiayServices();
            _anhServices = new AnhServices();
            _mauSacServices = new MauSacServices();
            _sizeGiayServices = new SizeGiayServices();
            _lstsanPhamChiTietServices = new SanPhamCTServices();

            _lstSanPham = new List<SanPham>();
            _lstAnh = new List<Anh>();
            _lstLoaiGiay = new List<LoaiGiay>();
            _lstChatLieu = new List<ChatLieu>();
            _lstNSX = new List<NhaSanXuat>();
            _lstSize = new List<SizeGiay>();
            _lstMauSac = new List<MauSac>();
            _lstsanPhamViewModels = new List<ProductsViewModel>();
            _lstChiTietSanPham = new List<SanPhamChiTiet>();
        }

        private void FrmSanPham2_Load(object sender, EventArgs e)
        {
            initGridView();
            initData();
            initDataComboBox();
            initDataSanPham();
            intDataGridView();
        }

        private void initData()
        {
            _lstAnh = _anhServices.GetAll();
            _lstLoaiGiay = _loaiGiayServices.GetAll();
            _lstChatLieu = _lstChatLieuServices.GetAll();
            _lstNSX = _lstnhaSanXuatServices.GetAll();
            _lstSize = _sizeGiayServices.GetAll();
            _lstMauSac = _mauSacServices.GetAll();
            _lstSanPham = _lstanPhamServices.GetAllSanPham();
            _lstChiTietSanPham = _lstsanPhamChiTietServices.GetAllChiTiet();
        }

        private void initDataComboBox()
        {
            cbLoaiSanPham.DataSource = _lstLoaiGiay;
            cbLoaiSanPham.DisplayMember = "Ten";
            cbLoaiSanPham.ValueMember = "Ten";

            cbSize.DataSource = _lstSize;
            cbSize.DisplayMember = "SoSize";
            cbSize.ValueMember = "SoSize";

            cbMauSac.DataSource = _lstMauSac;
            cbMauSac.DisplayMember = "Ten";
            cbMauSac.ValueMember = "Ten";

            cbNSX.DataSource = _lstNSX;
            cbNSX.DisplayMember = "Ten";
            cbNSX.ValueMember = "Ten";

            cbChatLieu.DataSource = _lstChatLieu;
            cbChatLieu.DisplayMember = "Ten";
            cbChatLieu.ValueMember = "Ten";
        }

        private void initGridView()
        {
            dgvDanhSach.ColumnCount = 10;
            dgvDanhSach.Columns[0].Name = "Id";
            dgvDanhSach.Columns[0].Visible = false;
            dgvDanhSach.Columns[1].Name = "Mã";
            dgvDanhSach.Columns[2].Name = "Tên sản phẩm";
            dgvDanhSach.Columns[3].Name = "Trạng thái";
            dgvDanhSach.Columns[4].Name = "Loại";
            dgvDanhSach.Columns[5].Name = "Nhà sản xuất";
            dgvDanhSach.Columns[6].Name = "Chất liệu";
            dgvDanhSach.Columns[7].Name = "Size";
            dgvDanhSach.Columns[8].Name = "Màu sắc";
            dgvDanhSach.Columns[9].Name = "Anh";
            dgvDanhSach.Columns[9].Visible = false;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.Rows.Clear();
        }

        private void intDataGridView()
        {
            dgvDanhSach.Rows.Clear();
            var listData = _lstanPhamServices.GetAll();
            foreach (var item in _lstsanPhamViewModels)
            {
                dgvDanhSach.Rows.Add(
                     item.Id,
                     item.MaSanPham,
                     item.TenSanPham,
                     item.TrangThai == 1 ? "Còn hàng" : "Hết hàng",
                     item.LoaiSanPham,
                     item.TenNSX,
                     item.TenChatLieu,
                     item.Size,
                     item.TenMauSac,
                     item.Anh
                     );
            }
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

                var chiTiet = _lstChiTietSanPham.Where(x => x.IdSanPham == product.Id).FirstOrDefault();
                if (chiTiet != null)
                {
                    var anh = _lstAnh.Where(x => x.ID == chiTiet.IdAnh).FirstOrDefault();
                    var mausac = _lstMauSac.Where(x => x.Id == chiTiet.IdMauSac).FirstOrDefault();
                    var loaigiay = _lstLoaiGiay.Where(x => x.Id == chiTiet.IdLoaiGiay).FirstOrDefault();
                    var sizegiay = _lstSize.Where(x => x.Id == chiTiet.IdSizeGiay).FirstOrDefault();
                    var chatLieu = _lstChatLieu.Where(x => x.Id == sp.IdChatLieu).FirstOrDefault();
                    var nsx = _lstNSX.Where(x => x.Id == sp.IdNhaSanXuat).FirstOrDefault();

                    product.IdChatLieu = chatLieu.Id;
                    product.TenChatLieu = chatLieu.Ten;

                    product.IdNSX = nsx.Id;
                    product.TenNSX = nsx.Ten;

                    product.IdAnh = anh.ID;
                    product.Anh = anh.DuongDan;

                    product.IdMauSac = mausac.Id;
                    product.TenMauSac = mausac.Ten;

                    product.IdLoaiSanPham = loaigiay.Id;
                    product.LoaiSanPham = loaigiay.Ten;

                    product.IdSize = sizegiay.Id;
                    product.Size = sizegiay.SoSize;
                }

                _lstsanPhamViewModels.Add(product);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvDanhSach.Rows[e.RowIndex];
                Id = Guid.Parse(r.Cells[0].Value.ToString());
                txtMa.Text = r.Cells[1].Value.ToString();
                txtTen.Text = r.Cells[2].Value.ToString();
                cbTrangThai.Checked = r.Cells[3].Value.ToString() == "1";
                Guid idLoai = Guid.Parse(r.Cells[4].Value.ToString());
                cbLoaiSanPham.SelectedValue = idLoai;


                //if (r.Cells[4].Value.ToString() == "Hoạt động")
                //{
                //    ckHoatdong.Checked = true;
                //}
                //else
                //{
                //    ckKHD.Checked = true;
                //}

                //string idNhaSanXuat = r.Cells[5].Value.ToString();
                //string idChatLieu = r.Cells[6].Value.ToString();

                //cbNhaSanXuat.SelectedValue = idNhaSanXuat;
                //cbxChatLieu.SelectedValue = idChatLieu;
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    ptbAnh.Image = Image.FromFile(open.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message), "Liên hệ khắc phục");
            }
        }
    }
}
