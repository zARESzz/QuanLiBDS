using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Main.Full;

namespace Main
{
    public class cls_CTNC
    {
        data_BDSEntities db = new data_BDSEntities();
        public CHITIETNHUCAU getItem(string id)
        {
            return db.CHITIETNHUCAUs.FirstOrDefault(x => x.MaBDS == id );
        }
        public CHITIETNHUCAU getItemNC(string id)
        {
            return db.CHITIETNHUCAUs.FirstOrDefault(x => x.MaNC == id);
        }
        public List<CHITIETNHUCAU> getList()
        {
            return db.CHITIETNHUCAUs.ToList();
        }

        public List<cls_CTNC_Full> getListFull()
        {
            var listCT = db.CHITIETNHUCAUs.ToList();
            List<cls_CTNC_Full> ListFull = new List<cls_CTNC_Full>();
            cls_CTNC_Full ctFull;
            foreach (var item in listCT)
            {
                ctFull = new cls_CTNC_Full();
                ctFull.MaNC = item.MaNC;
                var nc = db.NHUCAUs.FirstOrDefault(p => p.MaNC == item.MaNC);
                ctFull.TenNC = nc.TenNC;
                var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == item.MaBDS);
                ctFull.MaBDS = bds.MaBDS;
                ctFull.TenBDS = bds.TenBDS;
                ctFull.MaKH =  bds.MaKH;
                var kh = db.KHACHHANGs.FirstOrDefault(p => p.MaKH == bds.MaKH);
                ctFull.TenKH = kh.HoTenKH;
                ctFull.MaLoai = bds.MaLoai;
                var loai = db.LOAIBDS.FirstOrDefault(p => p.MaLoai == bds.MaLoai);
                ctFull.TenLoai = loai.TenLoai;
                ctFull.MaTT = bds.MaTT;
                var tt = db.TINHTRANGs.FirstOrDefault(p => p.MaTT == bds.MaTT);
                ctFull.TenTT = tt.TenTT;
                ctFull.DiaChi = bds.DiaChi;
                ctFull.DienTich = bds.DienTich;
                ctFull.GioiThieu = bds.GioiThieu;
                ctFull.HinhAnh = bds.HinhAnh;
                ctFull.DinhGia = item.DinhGia;
                ListFull.Add(ctFull);
            }
            return ListFull;
        }
        public CHITIETNHUCAU Add(CHITIETNHUCAU ct)
        {
            try
            {
                db.CHITIETNHUCAUs.Add(ct);
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public CHITIETNHUCAU Updata(CHITIETNHUCAU ct)
        {

            try
            {
                var _ct = db.CHITIETNHUCAUs.FirstOrDefault(x => x.MaBDS == ct.MaBDS);
                _ct.DinhGia = ct.DinhGia;
                db.SaveChanges();
                return ct;
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
                var _ct = db.CHITIETNHUCAUs.FirstOrDefault(x => x.MaBDS == id);
                db.CHITIETNHUCAUs.Remove(_ct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
