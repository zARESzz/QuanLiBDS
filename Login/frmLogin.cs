using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Main.Custom;
using QuanLy;

namespace Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmQuanLy ql = new frmQuanLy();
            ql.ShowDialog();
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
            this.Close();
        }
    }
}
