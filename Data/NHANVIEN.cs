//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public string MaTK { get; set; }
        public string TenNV { get; set; }
        public Nullable<bool> GT { get; set; }
        public System.DateTime NS { get; set; }
        public string SDT { get; set; }
        public string Emaill { get; set; }
        public string DiaChi { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
