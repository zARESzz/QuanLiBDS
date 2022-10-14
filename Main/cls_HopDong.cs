using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Main.Full;

namespace Main
{
    public class cls_HopDong
    {
        data_BDSEntities db = new data_BDSEntities();
        public HOPDONG getItem(string id)
        {
            return db.HOPDONGs.FirstOrDefault(x => x.MaHD == id);
        }
        public List<HOPDONG> getList()
        {
            return db.HOPDONGs.ToList();
        }

        public List<cls_HopDong_Full> getListFull()
        {
            var listHD = db.HOPDONGs.ToList();
            List<cls_HopDong_Full> ListFull = new List<cls_HopDong_Full>();
            cls_HopDong_Full hdFull;
            foreach (var item in listHD)
            {
                hdFull = new cls_HopDong_Full();
                hdFull.MaHD = item.MaHD;
                hdFull.MaNC = item.MaNC;
                var nc = db.NHUCAUs.FirstOrDefault(p => p.MaNC == item.MaNC);
                hdFull.TenNC = nc.TenNC;
                var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == item.MaBDS);
                hdFull.MaBDS = bds.MaBDS;
                hdFull.TenBDS = bds.TenBDS;
                hdFull.MaKH = bds.MaKH;
                var kh = db.KHACHHANGs.FirstOrDefault(p => p.MaKH == bds.MaKH);
                hdFull.TenKH = kh.HoTenKH;
                hdFull.MaLoai = bds.MaLoai;
                var loai = db.LOAIBDS.FirstOrDefault(p => p.MaLoai == bds.MaLoai);
                hdFull.TenLoai = loai.TenLoai;
                hdFull.MaTT = bds.MaTT;
                var tt = db.TINHTRANGs.FirstOrDefault(p => p.MaTT == bds.MaTT);
                hdFull.TenTT = tt.TenTT;
                hdFull.DiaChi = bds.DiaChi;
                hdFull.DienTich = bds.DienTich;
                var hd = db.CHITIETNHUCAUs.FirstOrDefault(p => p.MaBDS == item.MaBDS && p.MaNC == item.MaNC);
                hdFull.DinhGia = hd.DinhGia;
                hdFull.NgayLap = item.NgayLap;
                hdFull.ChiTiet = item.ChiTiet;
                hdFull.NgayBD = item.NgayBD;
                hdFull.NgayKT = item.NgayKT;
                hdFull.MaTK = item.MaTK;
                hdFull.Phi = item.Phi;
                var nv = db.NHANVIENs.FirstOrDefault(p => p.MaTK == item.MaTK);
                hdFull.HoTenNV = nv.HoTenNV;
                ListFull.Add(hdFull);
            }
            return ListFull;
        }
        public HOPDONG Add(HOPDONG hd)
        {
            try
            {
                db.HOPDONGs.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public HOPDONG Updata(HOPDONG hd)
        {

            try
            {
                var _hd = db.HOPDONGs.FirstOrDefault(x => x.MaHD == hd.MaHD);
                _hd.NgayLap = hd.NgayLap;
                _hd.NgayBD = hd.NgayBD;
                _hd.NgayKT = hd.NgayKT;
                _hd.Phi = hd.Phi;
                _hd.ChiTiet = hd.ChiTiet;
                db.SaveChanges();
                return hd;
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
                var _hd = db.HOPDONGs.FirstOrDefault(x => x.MaHD == id);
                db.HOPDONGs.Remove(_hd);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public List<cls_HopDong_Full> getHopDong()
        {
            return getListFull().Where(x => (x.NgayKT.Value.Day - DateTime.Now.Day < 7)  && x.NgayKT.Value.Month == DateTime.Now.Month && x.NgayKT.Value.Year == DateTime.Now.Year).ToList();
        }
    }
}
