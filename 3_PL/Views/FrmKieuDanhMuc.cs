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
    public partial class FrmKieuDanhMuc : Form
    {
        private IKieuDanhMucServices _lstKieuDanhMucServices;
        private IDanhMucServices _lstDanhMucServices;
        private ISanPhamServices _lstanPhamServices;
        private string Id = "";
        private List<KieuDanhMucViewModels> _lstkieuDMViewModels;

        private KieuDanhMucViewModels kieuDanhMucViewModels;
        public FrmKieuDanhMuc()
        {
            InitializeComponent();
            initGridView();
            _lstKieuDanhMucServices = new KieuDanhMucServices();
            _lstDanhMucServices = new DanhMucServices();
            _lstanPhamServices = new SanPhamServices();

            LoadDanhSach();

            LoadData();
        }
        private void initGridView()
        {
            dgvKieuDM.ColumnCount = 6;
            dgvKieuDM.Columns[0].Name = "Id";
            dgvKieuDM.Columns[0].Visible = false;
            dgvKieuDM.Columns[1].Name = "STT";
            dgvKieuDM.Columns[2].Name = "Thể Loại GT ";
            dgvKieuDM.Columns[3].Name = "Trạng Thái";
            dgvKieuDM.Columns[4].Name = "Danh Mục";
            dgvKieuDM.Columns[5].Name = "Sản Phẩm";
            dgvKieuDM.AllowUserToAddRows = false;
            dgvKieuDM.Rows.Clear();
        }

        public void LoadData()
        {
            dgvKieuDM.Rows.Clear();
            int stt = 1;
            var listData = _lstKieuDanhMucServices.GetAll();
            foreach (var item in listData)
            {
                dgvKieuDM.Rows.Add(
                     item.Id,
                     stt++,
                     item.TheLoaiGioiTinh,
                     item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động",
                     item.IdDanhMuc,
                     item.IdSanPham
                     );
            }
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {

            var listDanhMuc = _lstDanhMucServices.GetAll();
            cbxDanhMuc.DataSource = listDanhMuc;
            cbxDanhMuc.DisplayMember = "Ten";
            cbxDanhMuc.ValueMember = "Id";


            var listSanPham = _lstanPhamServices.GetAll();
            cbxSanPham.DataSource = listSanPham;
            cbxSanPham.DisplayMember = "Ten";
            cbxSanPham.ValueMember = "Id";
        }

        private void clearForm()
        {
            rdbNam.Text = rdbNu.Text = " ";
            ckHoatdong.Checked = true;
            rdbNam.Focus();
            Id = "";
        }

        private void ckHoatdong_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHoatdong.Checked)
            {
                ckHoatdong.Checked = true;
                ckKHD.Checked = false;
            }
        }

        private void ckKHD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKHD.Checked)
            {
                ckHoatdong.Checked = false;
                ckKHD.Checked = true;
            }
        }

        private void dgvKieuDM_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvKieuDM.Rows[e.RowIndex];
                Id = r.Cells[0].Value.ToString();
                if (r.Cells[1].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }

                if (r.Cells[2].Value.ToString() == "Hoạt động")
                {
                    ckHoatdong.Checked = true;
                }
                else
                {
                    ckKHD.Checked = true;
                }

                string iddanhMuc = r.Cells[3].Value.ToString();
                string idSanPham = r.Cells[4].Value.ToString();

                cbxDanhMuc.SelectedValue = iddanhMuc;
                cbxSanPham.SelectedValue = idSanPham;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm kiểu danh mục không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {

                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                int GT = 1;
                if(rdbNam.Checked)
                    GT = 0;
                string iddanhMuc = cbxDanhMuc.SelectedValue.ToString();
                string idSanPham = cbxSanPham.SelectedValue.ToString();

                var ketQua = _lstKieuDanhMucServices.Them(GT, trangThai, iddanhMuc, idSanPham);

                if (ketQua)
                {
                    MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearForm();
                }
                else
                    MessageBox.Show("Thêm mới không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa kiểu danh mục không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                int trangThai = ckKHD.Checked ? 0 : 1;
                int GT = rdbNam.Checked ? 1 : 0;

                // Lấy giá trị của Id của nhà sản xuất và chất liệu từ ComboBox
                string iddanhMuc = cbxDanhMuc.SelectedValue != null ? cbxDanhMuc.SelectedValue.ToString() : null;
                string idSanPham = cbxSanPham.SelectedValue != null ? cbxSanPham.SelectedValue.ToString() : null;
                Guid id = Guid.Parse(Id);
                var ketQua = _lstKieuDanhMucServices.Sua(id, GT, trangThai, iddanhMuc, idSanPham);

                if (ketQua)
                {
                    MessageBox.Show("Sửa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearForm();
                }
                else
                    MessageBox.Show("Sửa không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Id))
            {
                MessageBox.Show("Vui lòng chọn kiểu danh mục muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoa kiểu danh mục không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(Id);
                var ketQua = _lstanPhamServices.Xoa(id);
                if (ketQua)
                {
                    MessageBox.Show("xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearForm();
                }
                else
                    MessageBox.Show("Xóa không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbNam.Text = rdbNu.Text = " ";
            ckHoatdong.Checked = ckKHD.Checked = false;
            Id = "";
        }
    }
}
