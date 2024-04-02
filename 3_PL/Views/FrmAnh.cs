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
    public partial class FrmAnh : Form
    {
        private IAnhServices _lstAnhServices;
        private string Id = "";
        private List<AnhViewModels> _lstAnhViewModels;
        private AnhViewModels AnhViewModels;

        public FrmAnh()
        {
            InitializeComponent();
            _lstAnhServices = new AnhServices();
            _lstAnhViewModels = new List<AnhViewModels>();
            AnhViewModels = new AnhViewModels();


            initGridView();
            LoadData();
        }
        private void initGridView()
        {
            dgvAnh.ColumnCount = 6;
            dgvAnh.Columns[0].Name = "Id";
            dgvAnh.Columns[0].Visible = false;
            dgvAnh.Columns[1].Name = "STT";
            dgvAnh.Columns[2].Name = "Mã Ảnh";
            dgvAnh.Columns[3].Name = "Tên Ảnh";
            dgvAnh.Columns[4].Name = "Đường Link";
            dgvAnh.Columns[5].Name = "Trạng thái";
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
                     item.DuongDan,
                     item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                     );
            }
            if (dgvAnh.Rows.Count > 0)
            {
                DataGridViewRow firstRow = dgvAnh.Rows[0];
                LoadInfoFromRow(firstRow);
            }

        }
        private void clearForm()
        {
            txtMa.Text = txtTen.Text = " ";
            ckHoatdong.Checked = true;
            txtMa.Focus();
            Id = "";
        }



        private void LoadInfoFromRow(DataGridViewRow row)
        {
            string imagePath = Convert.ToString(row.Cells[4].Value);

            if (!string.IsNullOrEmpty(imagePath))
            {
                txtduongdan.Text = imagePath;
                pckAnh.Image = Image.FromFile(imagePath);
            }
            Id = row.Cells[0].Value.ToString();
            txtMa.Text = row.Cells[2].Value.ToString();
            txtTen.Text = row.Cells[3].Value.ToString();
            if (row.Cells[5].Value.ToString() == "Hoạt động")
            {
                ckHoatdong.Checked = true;
            }
            else
            {
                ckKHD.Checked = true;
            }
        }



        private void dgvAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAnh.Rows[e.RowIndex];
                LoadInfoFromRow(row);
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
                var ketQua = _lstAnhServices.Them(txtMa.Text, txtTen.Text, txtduongdan.Text, trangThai);
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
                var ketQua = _lstAnhServices.Sua(id, txtMa.Text, txtTen.Text, txtduongdan.Text, trangThai);
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

        private void FrmAnh_Load(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog open = new OpenFileDialog();
            //    if (open.ShowDialog() == DialogResult.OK)
            //    {
            //        pckAnh.Image = Image.FromFile(open.FileName);
            //        txtduongdan.Text = open.FileName;

            //        if (dgvAnh.CurrentRow != null)
            //        {
            //            dgvAnh.CurrentRow.Cells[4].Value = open.FileName;
            //        }
            //        else
            //        {
            //            int rowIndex = dgvAnh.Rows.Add();
            //            dgvAnh.Rows[rowIndex].Cells[4].Value = open.FileName;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(Convert.ToString(ex.Message), "Liên hệ khắc phục");
            //}


            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pckAnh.Image = Image.FromFile(open.FileName);
                    txtduongdan.Text = open.FileName;

                    if (dgvAnh.CurrentRow != null)
                    {
                        dgvAnh.CurrentRow.Cells[4].Value = open.FileName;
                    }
                    else
                    {
                        int rowIndex = dgvAnh.Rows.Add();
                        dgvAnh.Rows[rowIndex].Cells[4].Value = open.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message), "Liên hệ khắc phục");
            }
        }
    }
}
