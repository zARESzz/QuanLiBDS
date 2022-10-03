using Data;
using Main.Full;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class cls_NhanVien
    {
        data_BDSEntities db = new data_BDSEntities();
        public NHANVIEN getItem(string id)
        {
            return db.NHANVIENs.FirstOrDefault(x => x.MaTK == id);
        }
        public List<NHANVIEN> getList()
        {
            return db.NHANVIENs.ToList();
        }
        public List<cls_NhanVien_Full> getListFull()
        {
            var listNV = db.NHANVIENs.ToList();
            List<cls_NhanVien_Full> ListFull = new List<cls_NhanVien_Full>();
            cls_NhanVien_Full nvFull;
            foreach (var item in listNV)
            {
                nvFull = new cls_NhanVien_Full();
                nvFull.MaTK = item.MaTK;
                nvFull.MK = item.MK;
                nvFull.HoTenNV = item.HoTenNV;
                nvFull.GioiTinh = item.GioiTinh;
                nvFull.NgaySinh = item.NgaySinh;
                nvFull.SDT = item.SDT;
                nvFull.DiaChi = item.DiaChi;
                nvFull.Email = item.Email;
                nvFull.MaCV =  item.MaCV;
                var cv = db.CHUCVUs.FirstOrDefault(p => p.MaCV == item.MaCV);
                nvFull.TenCV = cv.TenCV;
                ListFull.Add(nvFull);
            }
            return ListFull;
        }
        public NHANVIEN Add(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public NHANVIEN Updata(NHANVIEN nv)
        {

            try
            {
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MaTK == nv.MaTK);
                _nv.MK = nv.MK;
                _nv.HoTenNV = nv.HoTenNV;
                _nv.MaCV = nv.MaCV;
                _nv.GioiTinh = nv.GioiTinh;
                _nv.NgaySinh = nv.NgaySinh;
                _nv.SDT = nv.SDT;
                _nv.Email = nv.Email;
                _nv.DiaChi = nv.DiaChi;
                db.SaveChanges();
                return nv;
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
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MaTK == id);
                db.NHANVIENs.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
