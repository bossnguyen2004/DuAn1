using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace _3_PL.Views
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienServices _nhanVienServices;
        private IChucVuServices _iChucVuService;
        private List<NhanVienViewModels> _lstnhanVienVM;
        private List<ChucVuViewModels> _lstchucVuVM;
        private NhanVienViewModels objSelected;

        private const string caption = "Thông báo";
        private ACTION_CLICK _actionClick = ACTION_CLICK.NONE;

        //Mã OTP
        //private const string mailAddress = "trannguyen2004ns@gmail.com";
        //private const string fromPass = "iekmmjfguxfgtzia";
        //private const string subjectMail = "OTP code";
        //private int _code;
        //private static int _countSteps = 0;
        //private static Timer _timer;
        private static FrmNhanVien _instance;





        public FrmNhanVien()
        {
            InitializeComponent();
            _instance = this;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            _nhanVienServices = new NhanVienServices();
            _iChucVuService = new ChucVuServices();
            _lstchucVuVM = new List<ChucVuViewModels>();
            _lstnhanVienVM = new List<NhanVienViewModels>();

            enableControlInput(false);

            loadDataChucVu();
            loadData();
        }

        private byte[] ChonAnh()
        {
            try
            {
                MemoryStream anh = new MemoryStream();
                ptbAnh.Image.Save(anh, ptbAnh.Image.RawFormat);
                byte[] img = anh.ToArray();
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
        }

        private void visibleButton(bool isVisible)
        {
            btnClear.Visible = btnLuu.Visible = isVisible;
        }

        private void loadData()
        {
            bindingData();

            if (_lstnhanVienVM.Count > 0)
            {
                objSelected = _lstnhanVienVM[0];
                bindingDataForControl(objSelected);
            }
        }

        private void loadDataChucVu()
        {
            _lstchucVuVM = _iChucVuService.GetAll().Where(x => x.TrangThai == 0).ToList();
            cmbChuVu.DataSource = _lstchucVuVM;
            cmbChuVu.ValueMember = "Id";
            cmbChuVu.DisplayMember = "Ten";
        }


        private void enableControlInput(bool isEnable)
        {
            txtMa.Enabled = txtCMND.Enabled
                = txtHo.Enabled = txtEmail.Enabled
                = txtQueQuan.Enabled = txtSDT.Enabled
                = txtTen.Enabled = dtNamSinh.Enabled = cmbChuVu.Enabled
                = chkbHoatdong.Enabled = rdbnam.Enabled = ptbAnh.Enabled
                = rdbNu.Enabled = isEnable;
        }


        private void clearForm()
        {
            txtCMND.Text = txtEmail.Text = txtHo.Text
                = txtMa.Text = txtMatKhau.Text
                = txtQueQuan.Text = txtSDT.Text
                = txtTen.Text = String.Empty;
            dtNamSinh.Value = DateTime.Now;
            rdbnam.Checked = true;
            txtTen.Focus();
            cmbChuVu.SelectedIndex = 0;
            ptbAnh.Image = null;

        }
        public Image ConvertByteArrayToImg(byte[] data)
        {
            if (data == null) return null;
            else
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    if (ms == null) return null;
                    else
                        return Image.FromStream(ms);
                }
            }
        }

        private void bindingData()
        {
            if (_lstnhanVienVM != null)
            {
                _lstnhanVienVM.Clear();
            }
            _lstnhanVienVM = _nhanVienServices.GetAll();
            this.dgvNhanVien.DataSource = _lstnhanVienVM;
        }



        private void bindingDataForControl(NhanVienViewModels obj)
        {
            this.txtMa.Text = obj.Ma;
            this.txtTen.Text = obj.Ten;
            this.txtCMND.Text = obj.CMND;
            this.txtEmail.Text = obj.Email;
            this.txtHo.Text = obj.Ho;
            this.txtMatKhau.Text = obj.MatKhau;
            this.txtSDT.Text = obj.Sdt;
            this.dtNamSinh.Text = Convert.ToString(obj.NamSinh);
            this.txtQueQuan.Text = obj.QueQuan;


            var chucVu = _lstchucVuVM.Where(x => x.Id.ToString() == obj.IdCv?.ToString()).FirstOrDefault();
            if (chucVu != null)
            {
                cmbChuVu.SelectedItem = chucVu;
            }

            this.rdbnam.Checked = obj.GioiTinh == 1;
            this.rdbNu.Checked = obj.GioiTinh == 0;

            this.chkbHoatdong.Checked = (obj.TrangThai != null && obj.TrangThai == 0);

        }



        private void getForm()
        {
            if (objSelected == null)
            {
                objSelected = new NhanVienViewModels();
            }
            objSelected.Ten = txtTen.Text;
            objSelected.Ma = txtMa.Text;
            objSelected.Email = txtEmail.Text;
            objSelected.CMND = txtCMND.Text;
            objSelected.Ho = txtHo.Text;
            objSelected.QueQuan = txtQueQuan.Text;
            objSelected.MatKhau = txtMatKhau.Text;
            objSelected.Sdt = txtSDT.Text;
            var idChucVu = cmbChuVu.SelectedValue;
            objSelected.IdCv = Guid.Parse(idChucVu.ToString());
            objSelected.TrangThai = chkbHoatdong.Checked ? 0 : 1;
            objSelected.NamSinh = dtNamSinh.Value.Date;
            objSelected.GioiTinh = rdbnam.Checked ? 1 : 0;
            objSelected.Anh = ChonAnh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _actionClick = ACTION_CLICK.ADD;
            clearForm();
            cmbChuVu.SelectedIndex = 0;
            enableControlInput(true);
            visibleButton(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _actionClick = ACTION_CLICK.UPDATE;
            visibleButton(true);
            enableControlInput(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var resultConfirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa {objSelected.Ten} không?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultConfirm == DialogResult.Yes)
            {
                var result = _nhanVienServices.Xoa(objSelected.Id);
                if (result)
                {
                    MessageBox.Show($"Xoá thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show($"Xoá giao ca không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getForm();
            if (objSelected != null)
            {
                var mess = string.Empty;
                var result = true;
                var resultConfirm = DialogResult.No;
                if (_actionClick == ACTION_CLICK.ADD)
                {
                    mess = $"Bạn có chắc chắn muốn thêm mới nhân viên {objSelected.Ten} không ?";
                    resultConfirm = MessageBox.Show(mess, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultConfirm == DialogResult.Yes)
                    {
                        result = _nhanVienServices.Them(objSelected);
                        if (result)
                        {
                            mess = $"Thêm mới nhân viên {objSelected.Ten} thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            mess = $"Thêm mới nhân viên {objSelected.Ten} không thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else if (_actionClick == ACTION_CLICK.UPDATE)
                {
                    mess = $"Bạn có chắc chắn muốn sửa nhân viên {objSelected.Ten} không ?";
                    resultConfirm = MessageBox.Show(mess, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultConfirm == DialogResult.Yes)
                    {
                        result = _nhanVienServices.Sua(objSelected);
                        if (result)
                        {
                            mess = $"Sửa nhân viên {objSelected.Ten} thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            mess = $"Sửa nhân viên {objSelected.Ten} không thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                if (result)
                {
                    enableControlInput(false);
                    visibleButton(false);
                    _actionClick = ACTION_CLICK.NONE;
                    loadData();
                }
            }

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            this.ptbAnh.Image = ConvertByteArrayToImg((byte[])row.Cells[14].Value);
            objSelected = _lstnhanVienVM[e.RowIndex];
            if (objSelected != null)
            {
                bindingDataForControl(objSelected);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opt = new OpenFileDialog();
            opt.Filter = "Chon Anh(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opt.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(opt.FileName);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var timKiem = txtTimKiem.Text;
            var rutl = _lstnhanVienVM.FirstOrDefault(nv => nv.Ma == timKiem);
            dgvNhanVien.DataSource = _lstnhanVienVM;
            dgvNhanVien.DataSource = _lstnhanVienVM;

        }

        enum ACTION_CLICK
        {
            NONE,
            ADD,
            UPDATE
        }
    }
}
