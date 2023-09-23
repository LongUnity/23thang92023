using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2va3
{
    internal class TamGiac
    {
        public Toado A{get; set;}
        public Toado B { get; set;}
        public Toado C { get; set;}
        
        public TamGiac() { }

        public void nhap()
        {
            Console.WriteLine("Nhap toa do dinh A:");
            this.A = new Toado();
            A.nhap();
            Console.WriteLine("Nhap toa do dinh B:");
            this.B = new Toado();
            B.nhap();
            Console.WriteLine("Nhap toa do dinh C:");
            this.C = new Toado();
            C.nhap();

        }
        public void xuat()
        {
            Console.WriteLine("Toa do dinh A,B,C của tam giác:");
            A.xuat();
            B.xuat();
            C.xuat();
        }

        public double AB => this.A.khoangCach(this.B);
        public double BC => this.B.khoangCach(this.C);
        public double CA => this.C.khoangCach(this.A);
        public double chuVi => AB + BC + CA;
        public double p => (chuVi / 2);
        public double dienTich => Math.Sqrt(p* (p - AB) * (p - BC) * (p - CA));

        /*public double chuVi()
        {
            double AB = this.A.khoangCach(this.B);
            double BC = this.B.khoangCach(this.C);
            double CA = this.C.khoangCach(this.A);

            return AB + BC + CA;
        }*/
        /*public double dienTich()
        {
            double p = this.chuVi() / 2;
            double AB = this.A.khoangCach(this.B);
            double BC = this.B.khoangCach(this.C);
            double CA = this.C.khoangCach(this.A);

            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
        }*/

        public Boolean checkTamgiacvuong()
        {    
            if (AB * AB == BC * BC + CA * CA)
            {
                Console.WriteLine("Vuông tại đỉnh C");
                return true;
            }
            else if (BC * BC == AB * AB + CA * CA)
            {
                Console.WriteLine("Vuông tại đỉnh A");
                return true;
            }
            else if (CA * CA == BC * BC + AB * AB)
            {
                Console.WriteLine("Vuông tại đỉnh B");
                return true;
            }
            Console.WriteLine("Không phải là tam giác vuông");
            return false;
        }
        public Boolean checkTamgiaccan()
        {
            if (AB == CA)
            {
                Console.WriteLine("Cân tại đỉnh A");
                return true;
            }
            else if (BC == AB)
            {
                Console.WriteLine("Cân tại đỉnh B");
                return true;
            }
            else if (CA == BC)
            {
                Console.WriteLine("Cân tại đỉnh C");
                return true;
            }
            Console.WriteLine("Không phải là tam giác cân");
            return false;
        }
    }
}
