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
    
    public partial class PHANLOAI
    {
        public string MaSach { get; set; }
        public string MaTheloai { get; set; }
        public string NguoiLap { get; set; }
        public System.DateTime NgayLap { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual SACH SACH { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}
