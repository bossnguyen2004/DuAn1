using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _3_PL.Views
{
    public partial class FrmKhachHang : Form
    {

        private IKhachHangServices _lstkhachHangService;
        private string Id = "";
        private List<KhachHangViewModels> lstKhachHangViewModels;
        private KhachHangViewModels khachHangViewModel;

        public FrmKhachHang()
        {
            InitializeComponent();
            initGridView();
            _lstkhachHangService = new KhachHangServices();

            lstKhachHangViewModels = new List<KhachHangViewModels>();
            khachHangViewModel = new KhachHangViewModels();
            LoadData();
        }

        // vẽ grid view
        private void initGridView()
        {
            dgvKhachHang.ColumnCount = 10;
            dgvKhachHang.Columns[0].Name = "Id";
            dgvKhachHang.Columns[0].Visible = false;
            dgvKhachHang.Columns[1].Name = "STT";
            dgvKhachHang.Columns[2].Name = "Mã ";
            dgvKhachHang.Columns[3].Name = "Tên KH";
            dgvKhachHang.Columns[4].Name = "Địa chỉ";
            dgvKhachHang.Columns[5].Name = "SDT";
            dgvKhachHang.Columns[6].Name = "Email";
            dgvKhachHang.Columns[7].Name = "Giới tính";
            dgvKhachHang.Columns[8].Name = "Năm Sinh";
            dgvKhachHang.Columns[9].Name = "Trạng thái";
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.Rows.Clear();
        }

        public void LoadData()
        {
            dgvKhachHang.Rows.Clear();
            int stt = 1;
            var listData = _lstkhachHangService.GetAll();
            foreach (var item in listData)
            {
                dgvKhachHang.Rows.Add(
                     item.Id,
                     stt++,
                     item.Ma,
                     item.Ten,
                     item.DiaChi,
                     item.Sdt,
                     item.Email,
                     item.GioiTinh == 1 ? "Nam" : "Nữ",
                     item.NamSinh,
                     item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                     );
            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];
                Id = r.Cells[0].Value.ToString();
                txtMa.Text = r.Cells[2].Value.ToString();
                txtTen.Text = r.Cells[3].Value.ToString();
                txtDiaChi.Text = r.Cells[4].Value.ToString();
                txtSDT.Text = r.Cells[5].Value.ToString();
                txtEmail.Text = r.Cells[6].Value.ToString();
                if (r.Cells[7].Value.ToString() == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }

                dtNamSinh.Text = r.Cells[8].Value.ToString();

                if (r.Cells[9].Value.ToString() == "Hoạt động")
                {
                    ckHD.Checked = true;
                }
                else
                {
                    ckKHD.Checked = true;
                }

            }
        }



        private void clearForm()
        {
            txtMa.Text = txtTen.Text = txtDiaChi.Text = txtSDT.Text = txtEmail.Text = String.Empty;
            ckHD.Checked = true;
            dtNamSinh.Value = DateTime.Now;
            txtMa.Focus();
            Id = "";
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ckHD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKHD.Checked)
            {
                ckKHD.Checked = true;
                ckKHD.Checked = false;
            }
        }

        private void ckKHD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKHD.Checked)
            {
                ckKHD.Checked = false;
                ckKHD.Checked = true;
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
            {
                rdNam.Checked = false;
                rdNu.Checked = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


        }

        private void btnClaer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm khách hàng không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                int gioiTinh = 1;
                if (rdNu.Checked)
                    gioiTinh = 0;
                int trangThai = 1;
                if (!ckHD.Checked)
                    trangThai = 0;
                var ketQua = _lstkhachHangService.Add(txtMa.Text, txtTen.Text, txtSDT.Text,
                    txtDiaChi.Text, txtEmail.Text, gioiTinh, dtNamSinh.Value, trangThai);
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
                MessageBox.Show("Vui lòng chọn khách hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa khách hàng không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int gioiTinh = 1;
                if (rdNu.Checked)
                    gioiTinh = 0;
                int trangThai = 1;
                if (!ckHD.Checked)
                    trangThai = 0;
                Guid id = Guid.Parse(Id);
                var ketQua = _lstkhachHangService.Update(id, txtMa.Text, txtTen.Text, txtSDT.Text,
                    txtDiaChi.Text, txtEmail.Text, gioiTinh, dtNamSinh.Value, trangThai);
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
                MessageBox.Show("Vui lòng chọn khách hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa khách hàng không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(Id);
                var ketQua = _lstkhachHangService.Delete(id);
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
    }
}
