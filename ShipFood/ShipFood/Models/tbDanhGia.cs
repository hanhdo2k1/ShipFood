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
    
    public partial class tbDanhGia
    {
        public int madg { get; set; }
        public Nullable<int> mactdh { get; set; }
        public Nullable<int> diemdanhgia { get; set; }
        public string nhanxet { get; set; }
        public string hinhanh { get; set; }
    
        public virtual tbChiTietDonHang tbChiTietDonHang { get; set; }
    }
}
