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
    
    public partial class QUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYEN()
        {
            this.PHANQUYENs = new HashSet<PHANQUYEN>();
        }
    
        public string MaQuyen { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public string NguoiLap { get; set; }
        public System.DateTime NgayLap { get; set; }
        public Nullable<System.DateTime> NgayXoa { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANQUYEN> PHANQUYENs { get; set; }
    }
}
