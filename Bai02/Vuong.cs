using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Vuong : ChuNhat
    {
        private double canh;
        public Vuong(double canh) : base(canh, canh)
        {
        }
        public double tinhChuVi()
        {
            return (canh + canh) * 2;
        }
        public double tinhDienTich()
        {
            return canh * canh;
        }
        public void Xuat()
        {
            Console.WriteLine("Canh: {0}\t Chu vi: {1}\t Dien tich: {2}", canh, tinhChuVi(), tinhDienTich());
        }
    }
}