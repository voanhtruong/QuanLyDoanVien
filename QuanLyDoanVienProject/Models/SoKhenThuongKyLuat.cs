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
    
    public partial class SoKhenThuongKyLuat
    {
        public SoKhenThuongKyLuat()
        {
            this.KhenThuongKyLuatDoanViens = new HashSet<KhenThuongKyLuatDoanVien>();
        }
    
        public int MaSoKhenThuongKyLuat { get; set; }
        public string MoTa { get; set; }
    
        public virtual ICollection<KhenThuongKyLuatDoanVien> KhenThuongKyLuatDoanViens { get; set; }
    }
}