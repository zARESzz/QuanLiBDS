using Data;
using Main;
using QuanLy.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;
using DataTable = System.Data.DataTable;
using Z.Dapper.Plus;
using File = System.IO.File;
using System.Text.RegularExpressions;
using CustomMessageBox;

namespace QuanLy
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        List<KHACHHANG> _listkh;
        cls_KhachHang _kh;
        bool _tt;
        string id;
        private void frmKHACHHANG_Load(object sender, EventArgs e)
        {
            _tt = false;
            _kh = new cls_KhachHang();
            ShowHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        void ShowHide(bool kt)
        {
            txtHoTen.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtSDT.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            btnThem.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDele.Enabled = kt;
            btnDong.Enabled = kt;
            btnSave.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnIn.Enabled = kt;
            btnExcel.Enabled = kt;
        }

        void loadData()
        {
            gcKHACHHANG.DataSource = _kh.getList();
            gvKHACHHANG.OptionsBehavior.Editable = false;
            _listkh = _kh.getList();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            ShowHide(false);
            _tt = true;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tt = false;
            ShowHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnDele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RJMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _kh.Delete(id);
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
                loadData();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _tt = false;
            ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tt = false;
            ShowHide(true);
            An(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            try
            {
                if (txtHoTen.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "")
                    throw new Exception("VUI lÒNG NHẬP ĐẦY ĐỦ");
                if (isEmail(txtEmail.Text))
                    throw new Exception("Sai Định Dạng Email");
                if (ktrphone(txtSDT.Text) == false)
                    throw new Exception("Sai Định Dạng SDT");
                if (_tt)
                {
                    KHACHHANG kh = new KHACHHANG();
                    data_BDSEntities db = new data_BDSEntities();
                    var list = db.P_MAKH().ToList();
                    foreach (var item in list)
                    {
                        kh.MaKH = item;
                    }
                    kh.HoTenKH = txtHoTen.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.Emaill = txtEmail.Text;
                    _kh.Add(kh);
                }
                else
                {
                    var kh = _kh.getItem(id);
                    kh.HoTenKH = txtHoTen.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.Emaill = txtEmail.Text;
                    _kh.Updata(kh);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
            }
        }
        private bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (false);
            else
                return (true);
        }
        private bool ktrphone(string check)
        {
            Regex regex = new Regex(@"^(0|84)([0-9]{9})$");
            return regex.IsMatch(check);
        }
        private void gvKHACHHANG_Click(object sender, EventArgs e)
        {
            id = gvKHACHHANG.GetFocusedRowCellValue("MaKH").ToString();
            txtHoTen.Text = gvKHACHHANG.GetFocusedRowCellValue("HoTenKH").ToString();
            txtDiaChi.Text = gvKHACHHANG.GetFocusedRowCellValue("DiaChi").ToString();
            txtEmail.Text = gvKHACHHANG.GetFocusedRowCellValue("Emaill").ToString();
            txtSDT.Text = gvKHACHHANG.GetFocusedRowCellValue("SDT").ToString();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptKhachHang rpt = new rptKhachHang(_listkh);
            rpt.ShowPreview();
        }
        DataTableCollection tableCollection;
        void An(bool tt)
        {
            txtDiaChi.Visible = tt;
            txtEmail.Visible = tt;
            txtHoTen.Visible = tt;
            txtSDT.Visible = tt;
            lblTen.Visible = tt;
            lblSDT.Visible = tt;
            lblDiaChi.Visible = tt;
            lblEmail.Visible = tt;
            lblFile.Visible = !tt;
            txtLink.Visible = !tt;
            cbxSheet.Visible = !tt;
            btnImport.Visible = !tt;
        }
        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            An(false);
            ShowHide(false);
            btnSave.Enabled = false;
            splitContainer1.Panel1Collapsed = false;
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLink.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbxSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbxSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbxSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<KHACHHANG> khachHangs = new List<KHACHHANG>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KHACHHANG kHACHHANG = new KHACHHANG();
                    kHACHHANG.MaKH = dt.Rows[i]["MaKH"].ToString();
                    kHACHHANG.HoTenKH = dt.Rows[i]["HoTenKH"].ToString();
                    kHACHHANG.SDT = dt.Rows[i]["SDT"].ToString();
                    kHACHHANG.Emaill = dt.Rows[i]["Emaill"].ToString();
                    kHACHHANG.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    khachHangs.Add(kHACHHANG);
                }
                gcKHACHHANG.DataSource = khachHangs;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string ssdada = "Server=LAPTOP-4I0T0PPN\\SQLEXPRESS;Database=data_BDS;User Id = sa;Password=123@qaz";
                DapperPlusManager.Entity<KHACHHANG>().Table("KHACHHANG");
                List<KHACHHANG> khachHangs = gcKHACHHANG.DataSource as List<KHACHHANG>;
                if (khachHangs != null)
                {
                    using (IDbConnection db = new SqlConnection(ssdada))
                    {
                        db.BulkInsert(khachHangs);
                    }
                    RJMessageBox.Show("Lưu thành Công!!!");
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == 8 || e.KeyChar == 32)
                e.Handled = false;
        }
    }
}