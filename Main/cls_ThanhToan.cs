using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Main.Full;

namespace Main
{
    public class cls_ThanhToan
    {
        data_BDSEntities db = new data_BDSEntities();
        public THANHTOAN getItem(string id)
        {
            return db.THANHTOANs.FirstOrDefault(x => x.MATT == id);
        }
        public List<THANHTOAN> getList()
        {
            return db.THANHTOANs.ToList();
        }
        public List<cls_ThanhToan_Full> getListFull()
        {
            var listTT = db.THANHTOANs.ToList();
            List<cls_ThanhToan_Full> ListFull = new List<cls_ThanhToan_Full>();
            cls_ThanhToan_Full ttFull;
            foreach (var item in listTT)
            {
                ttFull = new cls_ThanhToan_Full();
                ttFull.MATT = item.MATT;
                ttFull.TongTien = item.TongTien;
                ttFull.NgayTT = item.NgayTT;
                ttFull.MaHD = item.MaHD;
                var hd = db.HOPDONGs.FirstOrDefault(p => p.MaHD == item.MaHD);
                ttFull.MaBDS = hd.MaBDS;
                ttFull.MaTK=hd.MaTK;
                var nv=db.NHANVIENs.FirstOrDefault(p=>p.MaTK==hd.MaTK);
                ttFull.TenNV=nv.HoTenNV;

                var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == hd.MaBDS);
                ttFull.TenBDS = bds.TenBDS;
                ttFull.DiaChi = bds.DiaChi;
                ttFull.NoiDung = item.NoiDung;
                ttFull.MaKH = hd.MaKH;
                var kh = db.KHACHHANGs.FirstOrDefault(p => p.MaKH == hd.MaKH);
                ttFull.TenKH = kh.HoTenKH;
                ListFull.Add(ttFull);
            }
            return ListFull;
        }
        public THANHTOAN Add(THANHTOAN tt)
        {
            try
            {
                db.THANHTOANs.Add(tt);
                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public THANHTOAN Updata(THANHTOAN tt)
        {

            try
            {
                var _tt = db.THANHTOANs.FirstOrDefault(x => x.MATT == tt.MATT);
                _tt.NgayTT = tt.NgayTT;
                _tt.TongTien = tt.TongTien;
                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string id)
        {

            try
            {
                var _tt = db.THANHTOANs.FirstOrDefault(x => x.MATT == id);
                db.THANHTOANs.Remove(_tt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
