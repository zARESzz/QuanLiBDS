using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data;
using QuanLy;
using Main;
using CustomMessageBox;

namespace Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        data_BDSEntities db;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db= new data_BDSEntities();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cls_MatKhau mk = new cls_MatKhau();
            var checkTK = db.NHANVIENs.FirstOrDefault(p =>p.MaTK == txtTK.Text);
            if(checkTK==null)
            {
                RJMessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            
            if (mk.GiaiMa(checkTK.MK) == txtPass.Text)
            {
                frmQuanLy ql = new frmQuanLy();
                if (checkTK.CHUCVU.TenCV.Equals("Quản Lý"))
                {
                    notifyIcon.ShowBalloonTip(5000, "Thông báo", "Đây là tài khoản Quản Lý", ToolTipIcon.Info);
                    ql.rbQLNS.Visible = true;
                    ql.rbQLBDS.Visible = true;
                    ql.rbQLKH.Visible = true;
                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }
                else if (checkTK.CHUCVU.TenCV.Equals("Nhân Viên"))
                {
                    notifyIcon.ShowBalloonTip(5000, "Thông báo", "Đây là tài khoản Nhân Viên", ToolTipIcon.Info);
                    ql.rbQLHD.Visible = true;
                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }
                else if (checkTK.CHUCVU.TenCV.Equals("Giám Đốc"))
                {
                    notifyIcon.ShowBalloonTip(5000, "Thông báo", "Đây là tài khoản Giám Đốc", ToolTipIcon.Info);
                    ql.rbQLHD.Visible = true;
                    ql.rbQLTK.Visible = true;
                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }
                else
                    RJMessageBox.Show("Tài khoản không có quyền đăng nhập vào hệ thống","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                RJMessageBox.Show("Mật khẩu sai", "Thông báo", MessageBoxButtons.OK);
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
