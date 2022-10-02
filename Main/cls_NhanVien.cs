using Data;
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
