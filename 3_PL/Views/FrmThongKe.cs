using _2_BUS.IServices;
using _2_BUS.Services;
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
    public partial class FrmThongKe : Form
    {
        private IThongKeServices _idtnvser;
        public FrmThongKe()
        {
            InitializeComponent();
            _idtnvser = new ThongKeServices();
            loaddoanhthu();
            loadThang();
            loadnam();
            loadngay();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {

        }

        public string[] Getnam()
        {
            string[] TempNs = new string[2030 - 2010];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(2010 + i);
            }
            return TempNs;
        }
        public string[] Getngay()
        {
            string[] TempNs = new string[32 - 1];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(1 + i);
            }
            return TempNs;
        }
        void loadngay()
        {
            foreach (var x in Getngay())
            {
                cbngay.Items.Add(x);
            }

        }
        void loadnam()
        {
            foreach (var x in Getnam())
            {
                cbnam.Items.Add(x);
            }

        }
        void loadThang()
        {

            string[] lstmon = new string[12];
            lstmon[0] = "1";
            lstmon[1] = "2";
            lstmon[2] = "3";
            lstmon[3] = "4";
            lstmon[4] = "5";
            lstmon[5] = "6";
            lstmon[6] = "7";
            lstmon[7] = "8";
            lstmon[8] = "9";
            lstmon[9] = "10";
            lstmon[10] = "11";
            lstmon[11] = "12";

            foreach (var x in lstmon)
            {
                cbthang.Items.Add(x);
            }

        }

        void loaddoanhthu()
        {
            dgvThongKe.ColumnCount = 3;
            dgvThongKe.Columns[0].Name = "Mã Nhân Viên";
            dgvThongKe.Columns[1].Name = "Tên Nhân Viên";
            dgvThongKe.Columns[2].Name = "Tổng Doanh Thu";
            dgvThongKe.Rows.Clear();
            foreach (var x in _idtnvser.GetList().OrderByDescending(c => c.TongSoTien))
            {
                dgvThongKe.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }

        private void cbngay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbthang.Text == "" && cbnam.Text == "")
            {
                loaddataforlocngay(cbngay.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cbngay.Text, cbthang.Text, cbnam.Text);
                return;
            }

        }

        private void cbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbngay.Text == "" && cbnam.Text == "")
            {
                loaddataforlocthang(cbthang.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cbngay.Text, cbthang.Text, cbnam.Text);
                return;
            }
        }

        private void cbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbthang.Text == "" && cbngay.Text == "")
            {
                loaddataforlocnam(cbnam.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cbngay.Text, cbthang.Text, cbnam.Text);
                return;
            }
        }

        void loaddoanhthuforlocall(string ngay, string thang, string nam)
        {
            dgvThongKe.ColumnCount = 3;
            dgvThongKe.Columns[0].Name = "Mã Nhân Viên";
            dgvThongKe.Columns[1].Name = "Tên Nhân Viên";
            dgvThongKe.Columns[2].Name = "Tổng Doanh Thu";
            dgvThongKe.Rows.Clear();
            foreach (var x in _idtnvser.GetList().Where(c => c.Ngaytt.Value.Day.ToString() == ngay && c.Ngaytt.Value.Month.ToString() == thang && c.Ngaytt.Value.Year.ToString() == nam).OrderByDescending(c => c.TongSoTien))
            {
                dgvThongKe.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }


        //ngày
        void loaddataforlocngay(string ngay)
        {
            dgvThongKe.ColumnCount = 3;
            dgvThongKe.Columns[0].Name = "Mã Nhân Viên";
            dgvThongKe.Columns[1].Name = "Tên Nhân Viên";
            dgvThongKe.Columns[2].Name = "Tổng Doanh Thu";
            dgvThongKe.Rows.Clear();
            foreach (var x in _idtnvser.GetList().Where(c => c.Ngaytt.Value.Day.ToString() == ngay).OrderByDescending(c => c.TongSoTien))
            {
                dgvThongKe.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }
        //tháng
        void loaddataforlocthang(string thang)
        {
           dgvThongKe.ColumnCount = 3;
           dgvThongKe.Columns[0].Name = "Mã Nhân Viên";
           dgvThongKe.Columns[1].Name = "Tên Nhân Viên";
           dgvThongKe.Columns[2].Name = "Tổng Doanh Thu";
           dgvThongKe.Rows.Clear();
            foreach (var x in _idtnvser.GetList().Where(c => c.Ngaytt.Value.Month.ToString() == thang).OrderByDescending(c => c.TongSoTien))
            {
                dgvThongKe.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }
        //năm
        void loaddataforlocnam(string nam)
        {
            dgvThongKe.ColumnCount = 3;
            dgvThongKe.Columns[0].Name = "Mã Nhân Viên";
            dgvThongKe.Columns[1].Name = "Tên Nhân Viên";
            dgvThongKe.Columns[2].Name = "Tổng Doanh Thu";
            dgvThongKe.Rows.Clear();
            foreach (var x in _idtnvser.GetList().Where(c => c.Ngaytt.Value.Year.ToString() == nam).OrderByDescending(c => c.TongSoTien))
            {
                dgvThongKe.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }

    }
}
