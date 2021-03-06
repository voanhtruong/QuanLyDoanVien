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
    
    public partial class DoanVien
    {
        public DoanVien()
        {
            this.ChucVuChiDoans = new HashSet<ChucVuChiDoan>();
            this.ChucVuDoanCoSoes = new HashSet<ChucVuDoanCoSo>();
            this.DangKyChuyenSinhHoats = new HashSet<DangKyChuyenSinhHoat>();
            this.DangKyHoatDongs = new HashSet<DangKyHoatDong>();
            this.DongDoanPhis = new HashSet<DongDoanPhi>();
            this.KhenThuongKyLuatDoanViens = new HashSet<KhenThuongKyLuatDoanVien>();
        }
    
        public string MaSinhVien { get; set; }
        public string HoTenDoanVien { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QueQuan { get; set; }
        public string NoiOHienNay { get; set; }
        public Nullable<System.DateTime> NgayVaoDang { get; set; }
        public string SoDienThoai { get; set; }
        public Nullable<int> MaSoDoan { get; set; }
        public string AccountID { get; set; }
        public int MaChiDoan { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ChiDoan ChiDoan { get; set; }
        public virtual ICollection<ChucVuChiDoan> ChucVuChiDoans { get; set; }
        public virtual ICollection<ChucVuDoanCoSo> ChucVuDoanCoSoes { get; set; }
        public virtual ICollection<DangKyChuyenSinhHoat> DangKyChuyenSinhHoats { get; set; }
        public virtual ICollection<DangKyHoatDong> DangKyHoatDongs { get; set; }
        public virtual SoDoan SoDoan { get; set; }
        public virtual ICollection<DongDoanPhi> DongDoanPhis { get; set; }
        public virtual ICollection<KhenThuongKyLuatDoanVien> KhenThuongKyLuatDoanViens { get; set; }
    }
}
