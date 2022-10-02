using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLy;
namespace QuanLiBDS
{
    public partial class frmNguoiDung : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLy.QuanLy ql = new QuanLy.QuanLy();
            ql.Show();
        }
    }
}
