//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShipFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbThongTinDatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbThongTinDatHang()
        {
            this.tbDonHang = new HashSet<tbDonHang>();
        }
    
        public int mattdh { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public System.Data.Entity.Spatial.DbGeography toado { get; set; }
        public string tennguoinhan { get; set; }
        public Nullable<int> userid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDonHang> tbDonHang { get; set; }
        public virtual tbKhachHang tbKhachHang { get; set; }
    }
}
