//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhToan()
        {
            this.GoiDichVuQuangCaos = new HashSet<GoiDichVuQuangCao>();
            this.NhaQuangCaos = new HashSet<NhaQuangCao>();
            this.NhaQuangCaos1 = new HashSet<NhaQuangCao>();
        }
    
        public int MaGiaoDich { get; set; }
        public Nullable<int> MaTaiKhoan { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<System.DateTime> NgayGiaoDich { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoiDichVuQuangCao> GoiDichVuQuangCaos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhaQuangCao> NhaQuangCaos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhaQuangCao> NhaQuangCaos1 { get; set; }
    }
}
