using Main.Full;
using System.Collections.Generic;

namespace QuanLy.Reports
{
    public partial class rptHopDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDong()
        {
            InitializeComponent();
        }
        public rptHopDong (List<cls_Report_Full> rpt)
        {
            InitializeComponent();
            this.DataSource = rpt;
        }

    }
}
