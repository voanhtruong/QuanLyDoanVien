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
    
    public partial class KhenThuongKyLuatDoanVien
    {
        public string MaSinhVien { get; set; }
        public int MaSoKhenThuongKyLuat { get; set; }
        public string SoQD { get; set; }
        public Nullable<System.DateTime> NgayQD { get; set; }
        public string DonVi { get; set; }
        public string HinhThuc { get; set; }
    
        public virtual DoanVien DoanVien { get; set; }
        public virtual SoKhenThuongKyLuat SoKhenThuongKyLuat { get; set; }
    }
}
