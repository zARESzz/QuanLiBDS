using Data;
using DurableTask.Core.Common;
using Main.Full;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class cls_ThongKe
    {
        data_BDSEntities db;
        public cls_ThongKe()
        {
            db = new data_BDSEntities();
        }
        public List<cls_ThongKe_Full> DoanhThuTheoNhomBDS()
        {
            cls_ThongKe_Full nhomBDS ;
            List<cls_ThongKe_Full> listTK = new List<cls_ThongKe_Full>();
            DateTime ngayD = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var list = db.F_THONGKETHANG(ngayD, DateTime.Now.AddDays(1)).ToList();
            foreach(var item in list)
            {
                nhomBDS = new cls_ThongKe_Full();
                nhomBDS.TenLoai = item.TenLoai;
                nhomBDS.ThanhTien = item.THANHTIEN;
                listTK.Add(nhomBDS);
            }    
            return listTK;
        }
    }
}
