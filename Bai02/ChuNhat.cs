using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class ChuNhat
    {
        private double rong;
        private double dai;
        public ChuNhat(double rong, double dai)
        {
            this.rong = rong;
            this.dai = dai;
        }
        public double tinhChuVi()
        {
            return (dai + rong) * 2;
        }
        public double tinhDienTich()
        {
            return dai * rong;
        }
        public void Xuat()
        {
            Console.WriteLine("Dai: {0}\t Rong: {1}\t Chu vi: {2}\t Dien tich: {3}", dai, rong, tinhChuVi(), tinhDienTich());

        }
    }
}