using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Hocsinh
    {
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public float DT { get; set; }
        public float DL { get; set; }
        public float DH { get; set; }

        public Hocsinh() { }
        /*public Hocsinh(string Hoten, int Tuoi, float DT, float DL, float DH) {
            this.Hoten = Hoten;
            this.Tuoi = Tuoi;
            this.DT = DT;
            this.DL = DL;
            this.DH = DH;
        }*/
        public void nhap()
        {
            Console.Write("Nhập Họ và tên: ");
            this.Hoten = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            this.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Toán: ");
            this.DT = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Lý: ");
            this.DL = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Hóa: ");
            this.DH = float.Parse(Console.ReadLine());
        }
        public string HTHocsinh => $"Họ và tên học sinh: {Hoten}";
        public string TuoiHocsinh => $"Tuổi: {Tuoi}";
        public string DiemTLH => $"Điểm Toán, Lý, Hóa: {DT}, {DL}, {DH}";

        public float diemTB => (DT + DL + DH) / 3;
        
        public Boolean ketQua()
        {
            if(this.diemTB < 5)
            {
                Console.WriteLine("Học Sinh phải thi lại!!!");
                return false;
            }
            else
            {
                Console.WriteLine("Học Sinh Đậu!!!");
                return true;
            }
        }
    }
}
