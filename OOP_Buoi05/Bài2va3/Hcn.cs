using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2va3
{
    internal class Hcn
    {
        public int dai { get; set; }
        public int rong { get; set; }
        public Hcn() { }
        public void nhap()
        {
            Console.WriteLine("Nhập cạnh dài: ");            
            this.dai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh rộng: ");
            this.rong = int.Parse(Console.ReadLine());            
        }
        public void xuat()
        {
            Console.WriteLine("cạnh dài: "+dai);
            Console.WriteLine("cạnh rong: "+rong);
        }
        public float ChuVi => (dai + rong) * 2;
        public float DienTich => dai * rong;

    }
}
