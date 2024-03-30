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
    public partial class FrmSizeGiay : Form
    {
        private ISizeGiayServices _lstSizeGiayServices;
        private string Id = "";
        private List<SizeGiayViewModels> _lstsizeGiayViewModels;
        private SizeGiayViewModels SizeGiayViewModels;
        public FrmSizeGiay()
        {
            InitializeComponent();
            initGridView();
            _lstSizeGiayServices = new SizeGiayServices();
            _lstsizeGiayViewModels = new List<SizeGiayViewModels>();
            SizeGiayViewModels = new SizeGiayViewModels();
            LoadData();
        }
        private void initGridView()
        {
            dgvSizeGiay.ColumnCount = 5;
            dgvSizeGiay.Columns[0].Name = "Id";
            dgvSizeGiay.Columns[0].Visible = false;
            dgvSizeGiay.Columns[1].Name = "STT";
            dgvSizeGiay.Columns[2].Name = "Mã ";
            dgvSizeGiay.Columns[3].Name = "So Size ";
            dgvSizeGiay.Columns[4].Name = "Trạng thái";
            dgvSizeGiay.AllowUserToAddRows = false;
            dgvSizeGiay.Rows.Clear();
        }
        public void LoadData()
        {
            dgvSizeGiay.Rows.Clear();
            int stt = 1;
            var listData = _lstSizeGiayServices.GetAll();
            foreach (var item in listData)
            {
                dgvSizeGiay.Rows.Add(
                     item.Id,
                     stt++,
                     item.Ma,
                     item.SoSize,
                     item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                     );
            }

        }
        private void FrmSizeGiay_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Text = txtSoSize.Text = " ";
            ckHoatdong.Checked = false;
            ckKHD.Checked = false;
            txtMa.Focus();
            Id = "";
        }
        private void clearForm()
        {
            txtMa.Text = txtSoSize.Text = " ";
            ckHoatdong.Checked = true;
            txtMa.Focus();
            Id = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm size giày  không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {

                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                var ketQua = _lstSizeGiayServices.Them(txtMa.Text, Convert.ToInt32(txtSoSize.Text), trangThai);
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
                MessageBox.Show("Vui lòng chọn size giày muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa szie  giày không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                Guid id = Guid.Parse(Id);
                var ketQua = _lstSizeGiayServices.Sua(id, txtMa.Text, Convert.ToInt32(txtSoSize.Text), trangThai);
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
                MessageBox.Show("Vui lòng chọn size giày muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoa size giày không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(Id);
                var ketQua = _lstSizeGiayServices.Xoa(id);
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

        private void dgvSizeGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvSizeGiay.Rows[e.RowIndex];
                Id = r.Cells[0].Value.ToString();
                txtMa.Text = r.Cells[2].Value.ToString();
                txtSoSize.Text = r.Cells[3].Value.ToString();

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
