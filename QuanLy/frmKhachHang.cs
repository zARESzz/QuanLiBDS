using Data;
using DevExpress.XtraEditors;
using Main;
using QuanLy.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using System.Configuration;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UserConfiguration;
using DevExpress.DataProcessing;
using ExcelDataReader;
using DevExpress.XtraExport.Xls;
using DataTable = System.Data.DataTable;
using DevExpress.Office.Utils;
using Z.Dapper.Plus;
using File = System.IO.File;
using System.Data.Sql;
using System.Net.Configuration;
using System.Text.RegularExpressions;

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
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                MessageBox.Show(ex.Message);
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            ShowHide(false);
            splitContainer1.Panel1Collapsed = false;
            btnTim.Visible = true;
        }

        DataTableCollection tableCollection;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtDiaChi.Visible = false;
            txtEmail.Visible = false;
            txtHoTen.Visible = false;
            txtSDT.Visible = false;
            labelControl1.Visible = false;
            labelControl2.Visible = false;
            labelControl3.Visible = false;
            labelControl4.Visible = false;
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            ShowHide(false);
            splitContainer1.Panel1Collapsed = false;
            btnTim.Visible = false;
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
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            //gcKHACHHANG.DataSource = dt;
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
                    MessageBox.Show("Finish!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}