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
    public partial class FrmThanhToan : Form
    {
        private IThanhToanServices _lstThanhToanServices;
        private string Id = "";
        private List<ThanhToanViewModels> _lstThanhToanViewModels;
        private ThanhToanViewModels ThanhToanViewModels;

        public FrmThanhToan()
        {
            InitializeComponent();
            _lstThanhToanServices = new ThanhToanServices();
            _lstThanhToanViewModels = new List<ThanhToanViewModels>();
            ThanhToanViewModels = new ThanhToanViewModels();
            initGridView();
            LoadData();
        }
        private void initGridView()
        {
            dgvThanhToan.ColumnCount = 5;
            dgvThanhToan.Columns[0].Name = "Id";
            dgvThanhToan.Columns[0].Visible = false;
            dgvThanhToan.Columns[1].Name = "STT";
            dgvThanhToan.Columns[2].Name = "Mã ";
            dgvThanhToan.Columns[3].Name = "Cách Thanh Toán";
            dgvThanhToan.Columns[4].Name = "Trạng Thái";
            dgvThanhToan.AllowUserToAddRows = false;
            dgvThanhToan.Rows.Clear();
        }
        public void LoadData()
        {
            dgvThanhToan.Rows.Clear();
            int stt = 1;
            var listData = _lstThanhToanServices.GetAll();
            foreach (var item in listData)
            {
                dgvThanhToan.Rows.Add(
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm thanh toán  không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {

                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                var ketQua = _lstThanhToanServices.Them(txtMa.Text, txtTen.Text, trangThai);
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
                MessageBox.Show("Vui lòng chọn chất liệu muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa Chat Lieu không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                Guid id = Guid.Parse(Id);
                var ketQua = _lstThanhToanServices.Sua(id, txtMa.Text, txtTen.Text, trangThai);
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Text = txtTen.Text = " ";
            ckHoatdong.Checked = ckKHD.Checked = false;
            txtMa.Focus();
            Id = "";
        }

        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvThanhToan.Rows[e.RowIndex];
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
    }
}
