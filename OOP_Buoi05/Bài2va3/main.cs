using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2va3
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //ví dụ ArrayList
            /*ArrayList  a = new ArrayList();
            a.Add(10);
            a.Add(2);
            a.Add(9);
            a.Sort();
            a.Insert(1, 80);
            foreach (int value in a) 
            { 
                Console.WriteLine(value);
            }*/
            //Bài 2
            /*Hcn hcn = new Hcn();
            hcn.nhap();
            hcn.xuat();
            Console.WriteLine("Chu vi HCN: " + hcn.ChuVi);
            Console.WriteLine("Diện tích HCN: " + hcn.DienTich);*/

            TamGiac tamgiac = new TamGiac();
            tamgiac.nhap();
            tamgiac.xuat();
            Console.WriteLine("Chu Vi: "+tamgiac.chuVi());
            Console.WriteLine("Chu Vi: "+tamgiac.dienTich());
            tamgiac.checkTamgiacvuong();



            Console.ReadKey();
        }        
    }
}
