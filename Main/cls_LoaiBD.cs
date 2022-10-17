using System;
using System.Collections.Generic;
using System.Linq;
using Data;
namespace Main
{
    public class cls_LoaiBD
    {
        data_BDSEntities db = new data_BDSEntities();
        public LOAIBD getItem(string id)
        {
            return db.LOAIBDS.FirstOrDefault(x => x.MaLoai == id);
        }
        public List<LOAIBD> getList()
        {
            return db.LOAIBDS.ToList();
        }
        public LOAIBD Add(LOAIBD cv)
        {
            try
            {
                db.LOAIBDS.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public LOAIBD Updata(LOAIBD cv)
        {

            try
            {
                var _cv = db.LOAIBDS.FirstOrDefault(x => x.MaLoai == cv.MaLoai);
                _cv.TenLoai = cv.TenLoai;
                db.SaveChanges();
                return cv;
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
                var _cv = db.LOAIBDS.FirstOrDefault(x => x.MaLoai == id);
                db.LOAIBDS.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
