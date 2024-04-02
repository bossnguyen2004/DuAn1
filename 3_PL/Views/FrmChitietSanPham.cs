using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class FrmChitietSanPham : Form
    {
        private IChatLieuServices _lstChatLieuServices;
        private INhaSanXuatServices _lstnhaSanXuatServices;
        private ISanPhamServices _lstanPhamServices;
        private ILoaiGiayServices _loaiGiayServices;
        private ISizeGiayServices _sizeGiayServices;
        private IMauSacServices _mauSacServices;
        private IAnhServices _anhServices;
        private ISanPhamChiTietServices _lstsanPhamChiTietServices;
        private string Id = "";
        private List<SanPhamCTViewModels> _lstsanPhamCTViewModels;
        private SanPhamCTViewModels SanPhamCTViewModels;

        public FrmChitietSanPham()
        {
            InitializeComponent();
            initGridView();

            _lstanPhamServices = new SanPhamServices();
            _lstChatLieuServices = new ChatLieuServices();
            _lstnhaSanXuatServices = new NhaSanXuatServices();
            _loaiGiayServices = new LoaiGiayServices();
            _anhServices = new AnhServices();
            _mauSacServices = new MauSacServices();
            _sizeGiayServices = new SizeGiayServices();
            _lstsanPhamChiTietServices = new SanPhamCTServices();
            _lstsanPhamCTViewModels = new List<SanPhamCTViewModels>();
            SanPhamCTViewModels = new SanPhamCTViewModels();


            LoadDanhSach();
            LoadData();
        }

        private void FrmChitietSanPham_Load(object sender, EventArgs e)
        {

        }


        private void initGridView()
        {
            dgvChitietsanPham.ColumnCount = 16;
            dgvChitietsanPham.Columns[0].Name = "Id";
            dgvChitietsanPham.Columns[0].Visible = false;
            dgvChitietsanPham.Columns[1].Name = "STT";
            dgvChitietsanPham.Columns[2].Name = "Mã Sản Phẩm ";
            dgvChitietsanPham.Columns[3].Name = "Tên Sản Phẩm";
            dgvChitietsanPham.Columns[4].Name = "Mô Tả";
            dgvChitietsanPham.Columns[5].Name = "Số Lượng";
            dgvChitietsanPham.Columns[6].Name = "Giá Nhập";
            dgvChitietsanPham.Columns[7].Name = "Giá Bán";
            dgvChitietsanPham.Columns[8].Name = "Bảo Hành";
            dgvChitietsanPham.Columns[9].Name = "Trạng thái";
            dgvChitietsanPham.Columns[10].Name = "Nhà Sản Xuất";
            dgvChitietsanPham.Columns[11].Name = "Chất Liệu";
            dgvChitietsanPham.Columns[12].Name = "Loại Giày";
            dgvChitietsanPham.Columns[13].Name = "Size Giày";
            dgvChitietsanPham.Columns[14].Name = "Màu Sắc";
            dgvChitietsanPham.Columns[15].Name = "Ảnh";
            dgvChitietsanPham.AllowUserToAddRows = false;
            dgvChitietsanPham.Rows.Clear();
        }


        public void LoadData()
        {
            dgvChitietsanPham.Rows.Clear();
            int stt = 1;
            var listData = _lstsanPhamChiTietServices.GetAll();
            foreach (var item in listData)
            {
                dgvChitietsanPham.Rows.Add(
                     item.Id,
                     stt++,
                     item.Ma,
                     item.Ten,
                     item.MoTa,
                     item.NamBh,
                     item.SoLuongTon,
                     item.GiaBan,
                     item.GiaNhap,
                     item.TrangThai == 1 ? "Còn Hàng" : "Hết Hàng",
                     item.IdNsx,
                     item.IdChatLieu,
                     item.IdAnh,
                     item.IdLoaiGiay,
                     item.IdSizeGiay,
                     item.IdMauSac,
                     item.IdSp
                     );
            }
            LoadDanhSach();

            if (dgvChitietsanPham.Rows.Count > 0)
            {
                DataGridViewRow firstRow = dgvChitietsanPham.Rows[0];
                LoadInfoFromRow(firstRow);
            }
        }

        private void LoadDanhSach()
        {
            var listSanPham = _lstanPhamServices.GetAll();
            cbbTenSP.DataSource = listSanPham;
            cbbTenSP.DisplayMember = "Ten";
            cbbTenSP.ValueMember = "Ten";

            var listAnh = _anhServices.GetAll();
            cbduongDan.DataSource = listAnh;
            cbduongDan.DisplayMember = "DuongDan";
            cbduongDan.ValueMember = "DuongDan";

            var lstLoaiGiay = _loaiGiayServices.GetAll();
            cbLoaiGiay.DataSource = lstLoaiGiay;
            cbLoaiGiay.DisplayMember = "Ten";
            cbLoaiGiay.ValueMember = "Ten";


            var lstSizeGiay = _sizeGiayServices.GetAll();
            cbSizeGiay.DataSource = lstSizeGiay;
            cbSizeGiay.DisplayMember = "SoSize";
            cbSizeGiay.ValueMember = "SoSize";

            var lstMauSac = _mauSacServices.GetAll();
            cbMauSac.DataSource = lstMauSac;
            cbMauSac.DisplayMember = "Ten";
            cbMauSac.ValueMember = "Ten";

            var listNhaSanXuat = _lstnhaSanXuatServices.GetAll();
            cbnsx.DataSource = listNhaSanXuat;
            cbnsx.DisplayMember = "Ten";
            cbnsx.ValueMember = "Ten";

            var listChatLieu = _lstChatLieuServices.GetAll();
            cbChatLieu.DataSource = listChatLieu;
            cbChatLieu.DisplayMember = "Ten";
            cbChatLieu.ValueMember = "Ten";
        }

        private void ckConHang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckConHang.Checked)
            {
                ckConHang.Checked = true;
                ckHetHang.Checked = false;
            }

        }

        private void ckHetHang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHetHang.Checked)
            {
                ckConHang.Checked = false;
                ckHetHang.Checked = true;
            }
        }

        private void LoadInfoFromRow(DataGridViewRow r)
        {
            string imagePath = Convert.ToString(r.Cells[15].Value);

            if (!string.IsNullOrEmpty(imagePath))
            {
                cbduongDan.Text = imagePath;
                pckAnh.Image = Image.FromFile(imagePath);
            }
            Id = r.Cells[0].Value.ToString();
            txtMaSP.Text = r.Cells[2].Value.ToString();
            txtBaoHanh.Text = r.Cells[3].Value.ToString();

            if (r.Cells[4].Value.ToString() == "Còn Hàng")
            {
                ckConHang.Checked = true;
            }
            else
            {
                ckHetHang.Checked = true;
            }
            txtGiaBan.Text = r.Cells[4].Value.ToString();
            txtGiaNhap.Text = r.Cells[5].Value.ToString();
            txtMota.Text = r.Cells[6].Value.ToString();
            txtSoLuong.Text = r.Cells[7].Value.ToString();

            string idSanPham = r.Cells[8].Value.ToString();
            cbbTenSP.SelectedValue = idSanPham;
            string idAnh = r.Cells[9].Value.ToString();
            cbduongDan.SelectedValue = idAnh;
            string idLoaiGiay = r.Cells[10].Value.ToString();
            cbLoaiGiay.SelectedValue = idLoaiGiay;
            string idSizeGiay = r.Cells[11].Value.ToString();
            cbSizeGiay.SelectedValue = idSizeGiay;
            string idMauSac = r.Cells[12].Value.ToString();
            cbMauSac.SelectedValue = idMauSac;
            string idNhaSanXuat = r.Cells[13].Value.ToString();
            cbnsx.SelectedValue = idNhaSanXuat;
            string idChatLieu = r.Cells[14].Value.ToString();
            cbChatLieu.SelectedValue = idChatLieu;

        }




        private void dgvChitietsanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChitietsanPham.Rows[e.RowIndex];
                LoadInfoFromRow(row);
            }
        }

        private void pckAnh_Click(object sender, EventArgs e)
        {
            
        }

        private void cbduongDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedImagePath = cbduongDan.Text.Trim(); 
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    if (System.IO.File.Exists(selectedImagePath) && IsImageFile(selectedImagePath))
                    {
                        using (var img = Image.FromFile(selectedImagePath))
                        {
                            pckAnh.Image = new Bitmap(img);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ảnh không tồn tại hoặc không hợp lệ.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                }
            }
        }

        private bool IsImageFile(string filePath)
        {
            string extension = System.IO.Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(extension))
                return false;

            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return allowedExtensions.Contains(extension.ToLower());
        }
    }
}
