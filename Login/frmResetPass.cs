using Data;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using CustomMessageBox;

namespace Login
{
    public partial class frmResetPass : DevExpress.XtraEditors.XtraForm
    {
       
        data_BDSEntities db=new data_BDSEntities();
        public frmResetPass()
        {
            InitializeComponent();
        }

        private void btnGuiEmail_MouseLeave(object sender, EventArgs e)
        {
            btnGuiEmail.BackColor = Color.CornflowerBlue;
        }

       

        private void btnGuiEmail_MouseMove(object sender, MouseEventArgs e)
        {
            btnGuiEmail.BackColor = Color.RoyalBlue;
        }



        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
                var check = db.NHANVIENs.FirstOrDefault(p => p.Email == txtName.Text);
                if (check != null)
              {
                try { 
                    string fromMail = "lokino.00002@gmail.com";
                    string fromPassword = "guawysqdcrvfgvuy";

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromMail);
                    message.Subject = "Mật khẩu";
                    message.To.Add(new MailAddress(txtName.Text));
                    //   message.Body = "<html><body> 1234567890 </body></html>";
                    message.Body = "<html><body> "+check.MK+ "</body></html>";
                    message.IsBodyHtml = true;

                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(fromMail, fromPassword),
                        EnableSsl = true,
                    };

                    smtpClient.Send(message);
                    RJMessageBox.Show("Mật khẩu đã được gửi về Gmail thành công",
                                               "Cảm ơn",
                                               MessageBoxButtons.OK);
                    DialogResult dlr = RJMessageBox.Show("Bạn có muốn quay lại để đăng nhập ?", "Thông báo",
                                               MessageBoxButtons.OKCancel);
                    if (dlr == DialogResult.OK)
                        this.Close();
                }
                catch
                {
                    RJMessageBox.Show("Gửi không thành công", "Lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                RJMessageBox.Show("Không tìm thấy Email","Lỗi",MessageBoxButtons.OK);
            }
            
        }
        
                private void SendPasswordToMail(string sFrom,string SPass,string STo,string sSubject,string sBody)
        {
            try
            {
                var client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential(sFrom, SPass),
                    EnableSsl = true,
                };
                var message  = new System.Net.Mail.MailMessage(sFrom, STo, sSubject, sBody);
                message.IsBodyHtml = true;
                client.Host = "smtp.gmail.com";
                client.Send(message);
                RJMessageBox.Show("Gửi mail thành công");
                client.Dispose();
            }
            catch(Exception ex)
            {
                RJMessageBox.Show(ex.Message);
                return;
            }
        }
        private void ctButton1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void ctButton1_Click_1(object sender, EventArgs e)
        {
            RJMessageBox.Show("Bạn có muốn thoát ra màn hình đăng nhập",
                                           "Thông báo",
                                           MessageBoxButtons.OK);
            this.Close();
        }

        private void frmResetPass_Load(object sender, EventArgs e)
        {

        }
    }
}