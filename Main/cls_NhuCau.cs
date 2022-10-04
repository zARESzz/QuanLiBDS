using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Main
{
    public class cls_NhuCau
    {
        data_BDSEntities db = new data_BDSEntities();
        public NHUCAU getItem(string id)
        {
            return db.NHUCAUs.FirstOrDefault(x => x.MaNC == id);
        }
        public List<NHUCAU> getList()
        {
            return db.NHUCAUs.ToList();
        }
        public NHUCAU Add(NHUCAU cv)
        {
            try
            {
                db.NHUCAUs.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public NHUCAU Updata(NHUCAU cv)
        {

            try
            {
                var _cv = db.NHUCAUs.FirstOrDefault(x => x.MaNC == cv.MaNC);
                _cv.TenNC = cv.TenNC;
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
                var _cv = db.NHUCAUs.FirstOrDefault(x => x.MaNC == id);
                db.NHUCAUs.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
