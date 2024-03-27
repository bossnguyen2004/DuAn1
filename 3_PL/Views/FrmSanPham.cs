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
    public partial class FrmSanPham : Form
    {
        private IChatLieuServices _lstChatLieuServices;
        private INhaSanXuatServices _lstnhaSanXuatServices;
        private ISanPhamServices _lstanPhamServices;
        private string Id = "";
        private List<SanPhamViewModels> _lstsanPhamViewModels;

        private SanPhamViewModels SanPhamViewModels;

        public FrmSanPham()
        {
            InitializeComponent();
            initGridView();
            _lstanPhamServices = new SanPhamServices();
            _lstChatLieuServices = new ChatLieuServices();
            _lstnhaSanXuatServices = new NhaSanXuatServices();
            _lstsanPhamViewModels = new List<SanPhamViewModels>();
            SanPhamViewModels = new SanPhamViewModels();

            LoadDanhSach();
            LoadData();

        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }


        private void initGridView()
        {
            dgvChatLieu.ColumnCount = 7;
            dgvChatLieu.Columns[0].Name = "Id";
            dgvChatLieu.Columns[0].Visible = false;
            dgvChatLieu.Columns[1].Name = "STT";
            dgvChatLieu.Columns[2].Name = "Mã ";
            dgvChatLieu.Columns[3].Name = "Tên Sản Phẩm";
            dgvChatLieu.Columns[4].Name = "Trạng thái";
            dgvChatLieu.Columns[5].Name = "Nhà Sản Xuất";
            dgvChatLieu.Columns[6].Name = "Chất Liệu";
            dgvChatLieu.AllowUserToAddRows = false;
            dgvChatLieu.Rows.Clear();
        }



        public void LoadData()
        {
            dgvChatLieu.Rows.Clear();
            int stt = 1;
            var listData = _lstanPhamServices.GetAll();
            foreach (var item in listData)
            {
                dgvChatLieu.Rows.Add(
                     item.Id,
                     stt++,
                     item.Ma,
                     item.Ten,
                     item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động",
                     item.IdNhaSanXuat,
                     item.idChatLieu
                     );
            }
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {

            var listNhaSanXuat = _lstnhaSanXuatServices.GetAll();
            cbNhaSanXuat.DataSource = listNhaSanXuat;
            cbNhaSanXuat.DisplayMember = "Ten";
            cbNhaSanXuat.ValueMember = "Id";


            var listChatLieu = _lstChatLieuServices.GetAll();
            cbxChatLieu.DataSource = listChatLieu;
            cbxChatLieu.DisplayMember = "Ten";
            cbxChatLieu.ValueMember = "Id";
        }



        private void clearForm()
        {
            txtMa.Text = txtTen.Text = " ";
            ckHoatdong.Checked = true;
            txtMa.Focus();
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

        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvChatLieu.Rows[e.RowIndex];
                Id = r.Cells[0].Value.ToString();
                txtMa.Text = r.Cells[2].Value.ToString();
                txtTen.Text = r.Cells[3].Value.ToString();

                if (r.Cells[4].Value.ToString() == "Hoạt động")
                {
                    ckHoatdong.Checked = true;
                }
                else
                {
                    ckKHD.Checked = true;
                }

                string idNhaSanXuat = r.Cells[5].Value.ToString();
                string idChatLieu = r.Cells[6].Value.ToString();

                cbNhaSanXuat.SelectedValue = idNhaSanXuat;
                cbxChatLieu.SelectedValue = idChatLieu;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm Sản Phẩm  không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {

                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                string idNhaSanXuat = cbNhaSanXuat.SelectedValue.ToString();
                string idChatLieu = cbxChatLieu.SelectedValue.ToString();

                var ketQua = _lstanPhamServices.Them(txtMa.Text, txtTen.Text, trangThai, idNhaSanXuat, idChatLieu);

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

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa Sản Phẩm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                int trangThai = ckKHD.Checked ? 0 : 1;

                // Lấy giá trị của Id của nhà sản xuất và chất liệu từ ComboBox
                string idNhaSanXuat = cbNhaSanXuat.SelectedValue != null ? cbNhaSanXuat.SelectedValue.ToString() : null;
                string idChatLieu = cbxChatLieu.SelectedValue != null ? cbxChatLieu.SelectedValue.ToString() : null;
                Guid id = Guid.Parse(Id);
                var ketQua = _lstanPhamServices.Sua(id, txtMa.Text, txtTen.Text, trangThai, idNhaSanXuat, idChatLieu);

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
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoa sản phẩm không?", "Thông Báo", MessageBoxButtons.YesNo);
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
            txtMa.Text = txtTen.Text = " ";
            ckHoatdong.Checked = ckKHD.Checked = false;
            Id = "";
        }
    }
}
