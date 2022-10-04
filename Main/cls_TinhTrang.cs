using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Main
{
    public class cls_TinhTrang
    {
        data_BDSEntities db = new data_BDSEntities();
        public TINHTRANG getItem(string id)
        {
            return db.TINHTRANGs.FirstOrDefault(x => x.MaTT == id);
        }
        public List<TINHTRANG> getList()
        {
            return db.TINHTRANGs.ToList();
        }
        public TINHTRANG Add(TINHTRANG cv)
        {
            try
            {
                db.TINHTRANGs.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public TINHTRANG Updata(TINHTRANG cv)
        {

            try
            {
                var _cv = db.TINHTRANGs.FirstOrDefault(x => x.MaTT == cv.MaTT);
                _cv.TenTT = cv.TenTT;
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
                var _cv = db.TINHTRANGs.FirstOrDefault(x => x.MaTT == id);
                db.TINHTRANGs.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
