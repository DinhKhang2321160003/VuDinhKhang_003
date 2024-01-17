using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public int SoNgayCong { get; set; }
        public int SoNgayLamThem { get; set; }
        public string XepLoai { get; set; }
        public string BoPhan { get; set; }
        public NhanVien()
        {
        }
        public NhanVien(string hoTen, int soNgayCong, int soNgayLamThem, string xepLoai, string boPhan)
        {
            hoTen = HoTen;
            soNgayCong = SoNgayCong;
            soNgayLamThem = SoNgayLamThem;
            xepLoai = XepLoai;
            boPhan = BoPhan;
           
        }
        public double TinhLuong()
        {
            double phanTramTang = (BoPhan == "Truc tiep") ? 3.0 : 2.0;
            double luongMotNgay = 100000;
            return (SoNgayCong + SoNgayLamThem * (phanTramTang / 100)) * luongMotNgay;
        }
        public double TinhThuNhap()
        {
            switch (XepLoai)
            {
                case "A":return 1.5 * TinhLuong();
                case "B":return 1.2 * TinhLuong();
                case "C":return TinhLuong();
                default: return 0;
            }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ho Ten: {HoTen}");
            Console.WriteLine($"Bo Phan: {BoPhan}");
            Console.WriteLine($"Thu Nhap: {TinhThuNhap()}VND");


    }
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanvien1 = new NhanVien();
            Console.Write("Nhap Ho Ten: ");
            nhanvien1.HoTen = Console.ReadLine();
            Console.Write("Nhap So Ngay Cong: ");
            nhanvien1.SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Ngay Lam Them: ");
            nhanvien1.SoNgayLamThem = int.Parse(Console.ReadLine());
            Console.Write("Nhap Xep Loai (A/B/C): ");
            nhanvien1.XepLoai = Console.ReadLine();
            Console.Write("Nhap Bo Phan (TrucTiep/GianTiep): ");
            nhanvien1.BoPhan = Console.ReadLine();
            nhanvien1.InThongTin();
            NhanVien nhanVien2 = new NhanVien("Nguyen Van B", 25, 5, "B", "GianTiep");
            nhanVien2.InThongTin();
            Console.ReadLine();
            }
        }
    }
 }

