using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài 1,4:
            DSHS dsA = new DSHS();
            DSHS dsB = new DSHS();


            Console.WriteLine("Lớp 1-A: ");            
            dsA.nhap();
            Console.WriteLine(dsA.SL);
            dsA.xuat();

            //nhập 3 người cho biết người ở vị trí thứ 2 bao nhiêu tuổi            
            Console.WriteLine(((Hocsinh)dsA.arr[1]).Tuoi);

            //dsA.checkTuoi();
            //dsA.tongDiemTB();

            /*Console.WriteLine("Lớp 1-B: ");
            dsB.nhap();
            dsB.xuat();*/


            Console.ReadKey();
        }
    }
}
