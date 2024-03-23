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
    public partial class FrmChatLieu : Form
    {
        private IChatLieuServices _lstChatLieuServices;
        private string Id = "";
        private List<ChatLieuViewModels> _lstchatLieuViewModels;
        private ChatLieuViewModels ChatLieuViewModels;

        public FrmChatLieu()
        {
            InitializeComponent();
            initGridView();

            _lstChatLieuServices = new ChatLieuServices();
            _lstchatLieuViewModels = new List<ChatLieuViewModels>();
            ChatLieuViewModels = new ChatLieuViewModels();
            LoadData();
        }

        private void FrmChatLieu_Load(object sender, EventArgs e)
        {

        }
        private void initGridView()
        {
            dgvChatLieu.ColumnCount = 5;
            dgvChatLieu.Columns[0].Name = "Id";
            dgvChatLieu.Columns[0].Visible = false;
            dgvChatLieu.Columns[1].Name = "STT";
            dgvChatLieu.Columns[2].Name = "Mã ";
            dgvChatLieu.Columns[3].Name = "Tên Chất Liệu";     
            dgvChatLieu.Columns[4].Name = "Trạng thái";
            dgvChatLieu.AllowUserToAddRows = false;
            dgvChatLieu.Rows.Clear();
        }
        public void LoadData()
        {
            dgvChatLieu.Rows.Clear();
            int stt = 1;
            var listData = _lstChatLieuServices.GetAll();
            foreach (var item in listData)
            {
                dgvChatLieu.Rows.Add(
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm chất liệu  không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {

                int trangThai = 1;
                if (ckKHD.Checked)
                    trangThai = 0;
                var ketQua = _lstChatLieuServices.Them(txtMa.Text, txtTen.Text, trangThai);
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
                var ketQua = _lstChatLieuServices.Sua(id, txtMa.Text, txtTen.Text, trangThai);
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
                MessageBox.Show("Vui lòng chọn chất liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoa chất liệu không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Guid id = Guid.Parse(Id);
                var ketQua = _lstChatLieuServices.Xoa(id);
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
            }
        }
    }
}
