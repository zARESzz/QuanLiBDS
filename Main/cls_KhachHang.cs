using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class cls_KhachHang
    {
        data_BDSEntities db = new data_BDSEntities();
        public KHACHHANG getItem(string id)
        {
            return db.KHACHHANGs.FirstOrDefault(x => x.MaKH == id);
        }
        public List<KHACHHANG> getList()
        {
            return db.KHACHHANGs.ToList();
        }
        public KHACHHANG Add(KHACHHANG kh)
        {
            try
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
                return kh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public KHACHHANG Updata(KHACHHANG kh)
        {

            try
            {
                var _kh = db.KHACHHANGs.FirstOrDefault(x => x.MaKH == kh.MaKH);
                _kh.HoTenKH = kh.HoTenKH;
                _kh.SDT = kh.SDT;
                _kh.Emaill = kh.Emaill;
                _kh.DiaChi = kh.DiaChi;
                db.SaveChanges();
                return kh;
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
                var _kh = db.KHACHHANGs.FirstOrDefault(x => x.MaKH == id);
                db.KHACHHANGs.Remove(_kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
