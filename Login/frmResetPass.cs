using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmResetPass : DevExpress.XtraEditors.XtraForm
    {
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

        }

        private void ctButton1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}