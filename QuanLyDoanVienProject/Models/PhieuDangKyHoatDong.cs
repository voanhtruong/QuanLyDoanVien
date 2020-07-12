using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyDoanVienProject.Models
{
    public class PhieuDangKyHoatDong
    {
        public int maHoatDong { get; set; }
        public string tenHoatDong { get; set; }
        public System.DateTime ngayBatDau { get; set; }
        public System.DateTime ngayKetThuc { get; set; }
        public string diaDiem { get; set; }
        public System.DateTime ngayDangKy { get; set; }
        public PhieuDangKyHoatDong(int imaHoatDong)
        {
            using (QuanLyDoanVienEntities db = new QuanLyDoanVienEntities())
            {
                HoatDong hd = db.HoatDongs.Single(n => n.MaHoatDong == imaHoatDong);
                this.maHoatDong = imaHoatDong;
                this.tenHoatDong = hd.TenHoatDong;
                this.ngayBatDau = hd.ThoiGianBauDau.Value;
                this.ngayKetThuc = hd.ThoiGianKetThuc.Value;
                this.diaDiem = hd.DiaDiem;
            }
        }
        public PhieuDangKyHoatDong()
        {

        }

    }
}