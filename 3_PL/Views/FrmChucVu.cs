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
using System.Windows.Forms.Design;

namespace _3_PL.Views
{
    public partial class FrmChucVu : Form
    {
        private const string caption = "Thông báo";

        private IChucVuServices _chucVuServices;
        private List<ChucVuViewModels> _lstchucVuVM;
        private ChucVuViewModels objSelected;

        private ACTION_CLICK _actionClick = ACTION_CLICK.NONE;

        public FrmChucVu()
        {
            InitializeComponent();
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objSelected = _lstchucVuVM[e.RowIndex];
            if (objSelected != null)
            {
                _actionClick = ACTION_CLICK.NONE;
                bindingDataForControl(objSelected);
            }

        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            visiblecontrol(false);
            _chucVuServices = new ChucVuServices();
            _lstchucVuVM = new List<ChucVuViewModels>();
            enablecontrolInput(false);
            loadData();
        }


        private void loadData()
        {
            bindingData();

            if (_lstchucVuVM.Count > 0)
            {
                objSelected = _lstchucVuVM[0];
                bindingDataForControl(objSelected);
            }
        }

        private void visiblecontrol(bool isVisible)
        {
            btnClear.Visible = btnLuu.Visible = isVisible;
        }

        private void enablecontrolInput(bool isEnable)
        {
            txtMa.Enabled = txtTen.Enabled = chbHoatdong.Enabled = isEnable;
        }

        private void clearForm()
        {
            txtMa.Text = txtTen.Text = String.Empty;
            chbHoatdong.Checked = true;
            txtTen.Focus();
        }

        private void bindingData()
        {
            if (_lstchucVuVM != null)
            {
                _lstchucVuVM.Clear();
            }
            _lstchucVuVM = _chucVuServices.GetAll();
            this.dgvChucVu.DataSource = _lstchucVuVM;
        }

        private void bindingDataForControl(ChucVuViewModels obj)
        {
            this.txtMa.Text = obj.Ma;
            this.txtTen.Text = obj.Ten;
            this.chbHoatdong.Checked = obj.TrangThai == 0;
        }

        private void getForm()
        {
            if (objSelected == null)
            {
                objSelected = new ChucVuViewModels();
            }
            objSelected.Ma = txtMa.Text;
            objSelected.Ten = txtTen.Text;
            objSelected.TrangThai = chbHoatdong.Checked ? 0 : 1;
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
                    mess = $"Bạn có chắc chắn muốn thêm mới chức vụ {objSelected.Ten} không ?";
                    resultConfirm = MessageBox.Show(mess, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultConfirm == DialogResult.Yes)
                    {
                        result = _chucVuServices.Them(objSelected);
                        if (result)
                        {
                            mess = $"Thêm mới chức vụ {objSelected.Ten} thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            mess = $"Thêm mới chức vụ {objSelected.Ten} không thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else if (_actionClick == ACTION_CLICK.UPDATE)
                {
                    mess = $"Bạn có chắc chắn muốn sửa chức vụ {objSelected.Ten} không ?";
                    resultConfirm = MessageBox.Show(mess, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultConfirm == DialogResult.Yes)
                    {
                        result = _chucVuServices.Sua(objSelected);
                        if (result)
                        {
                            mess = $"Sửa chức vụ {objSelected.Ten} thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            mess = $"Sửa chức vụ {objSelected.Ten} không thành công !!!";
                            MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                if (result)
                {

                    enablecontrolInput(false);
                    visiblecontrol(false);

                    _actionClick = ACTION_CLICK.NONE;
                    loadData();
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            visiblecontrol(true);
            clearForm();
            enablecontrolInput(true);
            _actionClick = ACTION_CLICK.ADD;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            visiblecontrol(true);
            enablecontrolInput(true);
            _actionClick = ACTION_CLICK.UPDATE;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var resultConfirm = MessageBox.Show($"Bạn có chắc chắn muốn xoá chức vụ {objSelected.Ten} không?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultConfirm == DialogResult.Yes)
            {
                var result = _chucVuServices.Xoa(objSelected.Id);
                if (result)
                {
                    MessageBox.Show($"Xoá thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show($"Xoá chức vụ không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var search = txtTimKiem.Text;
            if (string.IsNullOrEmpty(search))
            {
                this.dgvChucVu.DataSource = _lstchucVuVM;
                return;
            }
            var dataTemp = _lstchucVuVM.Where(x => x.Ma.ToLower().Contains(txtTimKiem.Text.ToLower()) || x.Ten.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            this.dgvChucVu.DataSource = dataTemp;
        }

        enum ACTION_CLICK
        {
            NONE,
            ADD,
            UPDATE
        }
    }
}
