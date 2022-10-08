using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBoxVB;
using Data;
using Main.Custom;
using QuanLy;

namespace Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        data_BDSEntities db = new data_BDSEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var check = db.NHANVIENs.FirstOrDefault(p => p.MaTK == txtTK.Text&&p.MK==txtPass.Text);
            if (check != null)
            {
                frmQuanLy ql = new frmQuanLy();
                ql.ShowDialog();
            }
            else
            {
                RJMessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
   
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmCreAcc creAcc = new frmCreAcc();
            this.Hide();
            creAcc.ShowDialog();
            this.Show();
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            frmResetPass resetPass = new frmResetPass();
            resetPass.ShowDialog();
        }

        private void btnForgotPass_MouseMove(object sender, MouseEventArgs e)
        {
            btnForgotPass.BackColor = Color.DarkGray;
        }

        private void btnForgotPass_MouseLeave(object sender, EventArgs e)
        {
            btnForgotPass.BackColor= Color.White;
        }

        private void btnSignup_MouseMove(object sender, MouseEventArgs e)
        {
            btnSignup.BackColor = Color.DarkGray;
        }

        private void btnSignup_MouseLeave(object sender, EventArgs e)
        {
            btnSignup.BackColor= Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = RJMessageBox.Show("Bạn có muốn thoát chương trình ?",
                                       "Thông báo",
                                       MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
                this.Close();
        }
    }
}
