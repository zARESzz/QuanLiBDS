using Data;
using Main.Full;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    public class cls_ThongKe
    {
        data_BDSEntities db;
        public cls_ThongKe()
        {
            db = new data_BDSEntities();
        }
        public List<cls_ThongKe_Full> DoanhThuTheoNhomBDS(DateTime NgayD, DateTime NgayC)
        {
            cls_ThongKe_Full nhomBDS ;
            List<cls_ThongKe_Full> listTK = new List<cls_ThongKe_Full>();
            var list = db.F_THONGKETHANG(NgayD, NgayC).ToList();
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
