using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class cls_KHTN
    {
        data_BDSEntities db = new data_BDSEntities();
        public KHTN getItem(int id)
        {
            return db.KHTNs.FirstOrDefault(x => x.MaTN == id);
        }
        public List<KHTN> getList()
        {
            return db.KHTNs.ToList();
        }
        public KHTN Add(KHTN kh)
        {
            try
            {
                db.KHTNs.Add(kh);
                db.SaveChanges();
                return kh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public KHTN Updata(KHTN kh)
        {

            try
            {
                var _kh = db.KHTNs.FirstOrDefault(x => x.MaTN == kh.MaTN);
                _kh.HoTenTN = kh.HoTenTN;
                _kh.SDT = kh.SDT;
                _kh.Email = kh.Email;
                _kh.DiaChi = kh.DiaChi;
                db.SaveChanges();
                return kh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {

            try
            {
                var _kh = db.KHTNs.FirstOrDefault(x => x.MaTN == id);
                db.KHTNs.Remove(_kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
