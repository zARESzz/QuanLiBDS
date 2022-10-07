using Data;
using Main.Full;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class cls_BDS
    {
        data_BDSEntities db = new data_BDSEntities();
        public BATDONGSAN getItem(string id)
        {
            return db.BATDONGSANs.FirstOrDefault(x => x.MaBDS == id);
        }
        public List<BATDONGSAN> getList()
        {
            return db.BATDONGSANs.ToList();
        }
        public BATDONGSAN Add(BATDONGSAN bds)
        {
            try
            {
                db.BATDONGSANs.Add(bds);
                db.SaveChanges();
                return bds;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public BATDONGSAN Updata(BATDONGSAN bds)
        {

            try
            {
                var _bds = db.BATDONGSANs.FirstOrDefault(x => x.MaBDS == bds.MaBDS);
                _bds.MaBDS = bds.MaBDS;
                _bds.TenBDS = bds.TenBDS;
                _bds.MaKH = bds.MaKH;
                _bds.MaLoai = bds.MaLoai;
                _bds.MaTT = bds.MaTT;
                _bds.DiaChi = bds.DiaChi;
                _bds.DienTich = bds.DienTich;
                _bds.GioiThieu = bds.GioiThieu;
                _bds.HinhAnh = bds.HinhAnh;
                db.SaveChanges();
                return bds;
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
                var _bds = db.BATDONGSANs.FirstOrDefault(x => x.MaBDS == id);
                db.BATDONGSANs.Remove(_bds);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
