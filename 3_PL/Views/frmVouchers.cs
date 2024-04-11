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
    public partial class frmVouchers : Form
    {
        private SaleViewModel viewsale;
        private ISaleService saleService;
        private Guid Id;
        public frmVouchers()
        {
            InitializeComponent();
            saleService = new SaleServices();
            viewsale = new SaleViewModel();
            loadData();
        }

        public void loadData()
        {
            dgvVouCher.Rows.Clear();
            dgvVouCher.ColumnCount = 8;
            dgvVouCher.Columns[0].Name = "ID";
            dgvVouCher.Columns[0].Visible = false;
            dgvVouCher.Columns[1].Name = "Mã giảm giá";
            dgvVouCher.Columns[2].Name = "Tên chương trình";
            dgvVouCher.Columns[3].Name = "Giá Trị VouCher";
            dgvVouCher.Columns[4].Name = "Ngày bắt đầu";
            dgvVouCher.Columns[5].Name = "Ngày kết thúc";
            dgvVouCher.Columns[6].Name = "Trạng thái";
            dgvVouCher.Columns[7].Name = "Số Tiền";
            var lstsale = saleService.GetAll();
            foreach (var item in lstsale)
            {
                dgvVouCher.Rows.Add(item.Id, item.MaGiamGia, item.TenChuongTrinh, item.GiaTriVoucher, item.NgayBatDau, item.NgayKetThuc,
                        item.TrangThai == 1 ? "Còn hạn" : "Hết hạn", item.SoTienGiamGia);
            }
            dgvVouCher.AllowUserToAddRows = false;
        }


        private void frmBills_Load(object sender, EventArgs e)
        {

        }

        private void dgvVouCher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewsale = saleService.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgvVouCher.CurrentRow.Cells[0].Value.ToString()));
            Id = Guid.Parse(dgvVouCher.CurrentRow.Cells[0].Value.ToString());
            txtMa.Text = dgvVouCher.CurrentRow.Cells[1].Value.ToString();
            txtTen.Text = dgvVouCher.CurrentRow.Cells[2].Value.ToString();
            dtbatDau.Value = Convert.ToDateTime(dgvVouCher.CurrentRow.Cells[4].Value);
            dtNgayKetThuc.Value = Convert.ToDateTime(dgvVouCher.CurrentRow.Cells[5].Value);
            txtGiaTri.Text = dgvVouCher.CurrentRow.Cells[3].Value.ToString();

            if (dgvVouCher.CurrentRow.Cells[6].Value.ToString() == "Còn hạn")
            {
                rdCon.Checked = true;
            }
            else
            {
                rdHet.Checked = true;
            }

            txtSoTien.Text = dgvVouCher.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (saleService.GetAll().Any(c => c.MaGiamGia == txtMa.Text))
                {
                    MessageBox.Show("Tên mã bị trùng");
                }
                else if (string.IsNullOrWhiteSpace(txtTen.Text))
                {
                    MessageBox.Show("Tên không được bỏ trống");
                }
                else if (rdCon.Checked == false && rdHet.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else if (Convert.ToDecimal(txtSoTien.Text) < 0)
                {
                    MessageBox.Show("Nhập đúng mức giảm");
                }
                else if (Convert.ToDecimal(txtGiaTri.Text) < 0)
                {
                    MessageBox.Show("Nhập đúng giá trị");
                }
                else
                {
                    SaleViewModel x = new SaleViewModel()
                    {
                        Id = Guid.NewGuid(),
                        MaGiamGia = txtMa.Text,
                        TenChuongTrinh = txtTen.Text,
                        NgayBatDau = dtbatDau.Value,
                        NgayKetThuc = dtNgayKetThuc.Value,
                        SoTienGiamGia = Convert.ToInt32(txtSoTien.Text),
                        TrangThai = rdCon.Checked ? 1 : 0,
                        GiaTriVoucher = decimal.Parse(txtGiaTri.Text)
                    };
                    if (saleService.Them(x))
                    {
                        MessageBox.Show("Thêm Mã giảm giá thành công");
                        loadData();
                    };

                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                viewsale.Id = Id;
                viewsale.MaGiamGia = txtMa.Text;
                viewsale.TenChuongTrinh = txtTen.Text;
                viewsale.NgayBatDau = dtbatDau.Value;
                viewsale.NgayKetThuc = dtNgayKetThuc.Value;
                viewsale.SoTienGiamGia = Convert.ToDecimal(txtSoTien.Text);
                viewsale.TrangThai = rdCon.Checked ? 1 : 0;
                viewsale.GiaTriVoucher = decimal.Parse(txtGiaTri.Text);
                if (saleService.Sua(viewsale))
                {
                    MessageBox.Show("Sửa thành công");
                };
                loadData();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa mã giảm giá này Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (viewsale == null)
                {
                    MessageBox.Show("bạn chưa chọn mã");
                }
                else if (saleService.Xoa(viewsale))
                {
                    MessageBox.Show("Xóa thành công");
                    loadData();
                }
            }
        }
    }
}
