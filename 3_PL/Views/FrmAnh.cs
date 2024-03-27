using _2_BUS.IServices;
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
    public partial class FrmAnh : Form
    {
        private IAnhServices _lstAnhServices;
        private string Id = "";
        private List<ChatLieuViewModels> _lstAnhViewModels;
        private AnhViewModels AnhViewModels;

        public FrmAnh()
        {
            InitializeComponent();
        }
        private void initGridView()
        {
            dgvAnh.ColumnCount = 5;
            dgvAnh.Columns[0].Name = "Id";
            dgvAnh.Columns[0].Visible = false;
            dgvAnh.Columns[1].Name = "STT";
            dgvAnh.Columns[2].Name = "Mã Ảnh";
            dgvAnh.Columns[3].Name = "Tên Ảnh";
            dgvAnh.Columns[4].Name = "Trạng thái";
            dgvAnh.AllowUserToAddRows = false;
            dgvAnh.Rows.Clear();
        }
        public void LoadData()
        {
            dgvAnh.Rows.Clear();
            int stt = 1;
            var listData = _lstAnhServices.GetAll();
            foreach (var item in listData)
            {
                dgvAnh.Rows.Add(
                     item.ID,
                     stt++,
                     item.MaAnh,
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

        private void dgvAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvAnh.Rows[e.RowIndex];
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm ảnh  không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {

                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                var ketQua = _lstAnhServices.Them(txtMa.Text, txtTen.Text, trangThai);
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
                MessageBox.Show("Vui lòng chọn ảnh muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa ảnh không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                Guid id = Guid.Parse(Id);
                var ketQua = _lstAnhServices.Sua(id, txtMa.Text, txtTen.Text, trangThai);
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
                MessageBox.Show("Vui lòng chọn ảnh muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ảnh không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(Id);
                var ketQua = _lstAnhServices.Xoa(id);
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
