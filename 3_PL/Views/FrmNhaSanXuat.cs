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
    public partial class FrmNhaSanXuat : Form
    {
        private INhaSanXuatServices _lstNhaSanXuat;
        private string Id = "";
        private List<NhaSanXuatViewModels> _lstNhaSanXuatViewModels;
        private NhaSanXuatViewModels nhaSanXuatViewModels;

        public FrmNhaSanXuat()
        {
            InitializeComponent();
            _lstNhaSanXuat = new NhaSanXuatServices();
            _lstNhaSanXuatViewModels = new List<NhaSanXuatViewModels>();
            nhaSanXuatViewModels = new NhaSanXuatViewModels();
            initGridView();
            LoadData();
        }
        private void initGridView()
        {
            dgvNhaSanXuat.ColumnCount = 5;
            dgvNhaSanXuat.Columns[0].Name = "Id";
            dgvNhaSanXuat.Columns[0].Visible = false;
            dgvNhaSanXuat.Columns[1].Name = "STT";
            dgvNhaSanXuat.Columns[2].Name = "Mã ";
            dgvNhaSanXuat.Columns[3].Name = "Tên Nhà Sản Xuất";
            dgvNhaSanXuat.Columns[4].Name = "Trạng thái";
            dgvNhaSanXuat.AllowUserToAddRows = false;
            dgvNhaSanXuat.Rows.Clear();
        }
        public void LoadData()
        {
            dgvNhaSanXuat.Rows.Clear();
            int stt = 1;
            var listData = _lstNhaSanXuat.GetAll();
            foreach (var item in listData)
            {
                dgvNhaSanXuat.Rows.Add(
                     item.Id,
                     stt++,
                     item.Ma,
                     item.Ten,
                     item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                     );
            }

        }

        private void clearForm()
        {
            txtMa.Text = txtTen.Text = " ";
            ckHoatdong.Checked = true;
            txtMa.Focus();
            Id = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Text = txtTen.Text = " ";
            ckHoatdong.Checked = ckKHD.Checked = false;
            txtMa.Focus();
            Id = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm nha san xuat  không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {

                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                var ketQua = _lstNhaSanXuat.Them(txtMa.Text, txtTen.Text, trangThai);
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
            if (String.IsNullOrEmpty(Id))
            {
                MessageBox.Show("Vui lòng chọn nhà sản xuất muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa nha san xuat không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                Guid id = Guid.Parse(Id);
                var ketQua = _lstNhaSanXuat.Sua(id, txtMa.Text, txtTen.Text, trangThai);
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
                MessageBox.Show("Vui lòng chọn nhà sản xuất muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoa nhà sản xuất không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(Id);
                var ketQua = _lstNhaSanXuat.Xoa(id);
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

        private void dgvNhaSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvNhaSanXuat.Rows[e.RowIndex];
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
            }
        }
    }
}
