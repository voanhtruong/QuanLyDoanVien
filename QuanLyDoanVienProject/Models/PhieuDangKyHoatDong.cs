using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDoanVienProject.Models
{
    public class PhieuDangKyHoatDong
    {
        public int MaHoatDong { get; set; }
        public string TenHoatDong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string DiaDiem { get; set; }
        public DateTime NgayDangKy { get; set; }
        public PhieuDangKyHoatDong(int iMaHoatDong)
        {
            using (QuanLyDoanVienEntities db = new QuanLyDoanVienEntities())
            {
                HoatDong hd = db.HoatDongs.Single(n => n.MaHoatDong == iMaHoatDong);
                this.MaHoatDong = iMaHoatDong;
                this.TenHoatDong = hd.TenHoatDong;
                this.NgayBatDau = hd.ThoiGianBauDau.Value;
                this.NgayKetThuc = hd.ThoiGianKetThuc.Value;
                this.DiaDiem = hd.DiaDiem;
                this.NgayDangKy = DateTime.Now;
            }
        }
        public PhieuDangKyHoatDong()
        {

        }

    }
}