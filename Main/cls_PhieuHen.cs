using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Main.Full;

namespace Main
{
    public class cls_PhieuHen
    {
        data_BDSEntities db = new data_BDSEntities();
        public PHIEUHEN getItem(string id)
        {
            return db.PHIEUHENs.FirstOrDefault(x => x.MaPH == id);
        }
        public List<PHIEUHEN> getList()
        {
            return db.PHIEUHENs.ToList();
        }
        public List<cls_PhieuHen_Full> getListFull()
        {
            var listPH = db.PHIEUHENs.ToList();
            List<cls_PhieuHen_Full> ListFull = new List<cls_PhieuHen_Full>();
            cls_PhieuHen_Full phFull;
            foreach (var item in listPH)
            {
                phFull = new cls_PhieuHen_Full();
                phFull.MaPH = item.MaPH;
                phFull.DIADIEM = item.DIADIEM;
                phFull.NGAYGIO = item.NGAYGIO;
                phFull.MaTN = item.MaTN;
                var tn = db.KHTNs.FirstOrDefault(p => p.MaTN == item.MaTN);
                phFull.HoTenTN = tn.HoTenTN;
                phFull.MaTK = item.MaTK;
                var nv = db.NHANVIENs.FirstOrDefault(p => p.MaTK == item.MaTK);
                phFull.HoTenNV = nv.HoTenNV;
                ListFull.Add(phFull);
            }
            return ListFull;
        }
        public PHIEUHEN Add(PHIEUHEN ph)
        {
            try
            {
                db.PHIEUHENs.Add(ph);
                db.SaveChanges();
                return ph;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public PHIEUHEN Updata(PHIEUHEN ph)
        {

            try
            {
                var _ph = db.PHIEUHENs.FirstOrDefault(x => x.MaPH == ph.MaPH);
                _ph.DIADIEM = ph.DIADIEM;
                _ph.NGAYGIO = ph.NGAYGIO;
                db.SaveChanges();
                return ph;
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
                var _ph = db.PHIEUHENs.FirstOrDefault(x => x.MaPH == id);
                db.PHIEUHENs.Remove(_ph);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public List<cls_PhieuHen_Full> getLichHen()
        {
            return getListFull().Where(x => x.NGAYGIO.Value.Day == DateTime.Now.Day && x.NGAYGIO.Value.Month == DateTime.Now.Month && x.NGAYGIO.Value.Year == DateTime.Now.Year).ToList();
        }
    }
}
