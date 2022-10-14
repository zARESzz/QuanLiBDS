using CustomMessageBox;
using System;
using System.Windows.Forms;
namespace Login
{
    public partial class frmCreAcc : DevExpress.XtraEditors.XtraForm
    {
        public frmCreAcc()
        {
            InitializeComponent();
        }

        private void ctButton1_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Đây là điều khoản dài 100 dòng\n" +
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n\n\n Bấm ok để chấp nhận điều khoản của chúng tôi",
                                       "Điều khoản dài như niềm tin khi bạn nghĩ crush cũng thích mình");
            RJMessageBox.Show("Bấm ok cho vui thôi chứ tụi t chưa làm phần này ","Thông báo",MessageBoxButtons.OK);
            this.Close();
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}