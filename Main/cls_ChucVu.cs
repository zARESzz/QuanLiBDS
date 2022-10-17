using System;
using System.Collections.Generic;
using System.Linq;
using Data;
namespace Main
{
    public class cls_ChucVu
    {
        data_BDSEntities db = new data_BDSEntities();
        public CHUCVU getItem(string id)
        {
            return db.CHUCVUs.FirstOrDefault(x => x.MaCV == id);
        }    
        public List<CHUCVU> getList()
        {
            return db.CHUCVUs.ToList();
        }
        public CHUCVU Add(CHUCVU cv)
        {
            try
            {
                db.CHUCVUs.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public CHUCVU Updata(CHUCVU cv)
        {
            
            try
            {
                var _cv = db.CHUCVUs.FirstOrDefault(x => x.MaCV == cv.MaCV);
                _cv.TenCV = cv.TenCV;
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
                var _cv = db.CHUCVUs.FirstOrDefault(x => x.MaCV == id);
                db.CHUCVUs.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
