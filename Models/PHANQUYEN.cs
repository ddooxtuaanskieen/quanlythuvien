//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYTHUVIEN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHANQUYEN
    {
        public string MaNhanVien { get; set; }
        public string MaQuyen { get; set; }
        public string NguoiLap { get; set; }
        public System.DateTime NgayLap { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual NHANVIEN NHANVIEN1 { get; set; }
        public virtual QUYEN QUYEN { get; set; }
    }
}