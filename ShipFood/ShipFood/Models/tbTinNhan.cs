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
    
    public partial class tbTinNhan
    {
        public int matn { get; set; }
        public Nullable<int> madh { get; set; }
        public string noidung { get; set; }
        public Nullable<int> mashipper { get; set; }
        public Nullable<int> makh { get; set; }
    
        public virtual tbDonHang tbDonHang { get; set; }
        public virtual tbKhachHang tbKhachHang { get; set; }
        public virtual tbShipper tbShipper { get; set; }
    }
}
