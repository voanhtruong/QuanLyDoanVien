//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDoanVienProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CapHoatDong
    {
        public CapHoatDong()
        {
            this.HoatDongs = new HashSet<HoatDong>();
        }
    
        public int MaCapHoatDong { get; set; }
        public string CapHoatDong1 { get; set; }
        public string MoTa { get; set; }
    
        public virtual ICollection<HoatDong> HoatDongs { get; set; }
    }
}
