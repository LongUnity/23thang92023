using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class DSHS
    {
        public int n { get; set; }
        public string SL => $"Số Lượng học sinh: {n}";
        //private Hocsinh[] arr { get; set; }
        public ArrayList arr { get; set; }
        public DSHS() { }

        public void nhap()
        {
            Console.WriteLine("Nhập số lượng học sinh: ");
            this.n = int.Parse(Console.ReadLine());
            //arr = new Hocsinh[this.n];
            for (int i = 0; i < n; i++)
            {
                //arr[i] = new Hocsinh();
                //arr[i].nhap();

                Hocsinh a = new Hocsinh();
                a.nhap();
                arr.Add(a);


                Console.WriteLine();
            }
        }
        public void xuat()
        {

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i].Hoten+" "+ arr[i].TuoiHocsinh+" "+ arr[i].DiemTLH);
            }*/
            foreach (Hocsinh hs in arr)
            {
                Console.WriteLine(hs.Hoten + " " + hs.TuoiHocsinh + " " + hs.DiemTLH);
            }

        }
        //cách thầy
        public Hocsinh tuoiNhoNhat()
        {
            Hocsinh min = new Hocsinh();
            min = (Hocsinh)arr[0];//Ép kiểu về học sinh do đây là kiểu arraylist
            foreach (Hocsinh hs in arr)
            {
                if (hs.Tuoi < min.Tuoi)
                {
                    min = hs;
                }
            }
            return min;
        }
        public float diemTBT()
        {
            float dtb = 0;
            foreach (Hocsinh hs in arr)
            {
                dtb += hs.diemTB;
            }
            //return dtb/arr.Length;
            return dtb/arr.Count;//ArrayList đổi từ length=> count
        }
        public int sinhVienDau()
        {
            int count = 0;
            foreach(Hocsinh hs in arr)
            {
                if (hs.ketQua() == true)
                {
                    count++;
                }
            }
            Console.WriteLine("Số học sinh đậu: " + count);
            return count;
        }
        public int sinhVienRot()
        {
            //return arr.Length - sinhVienDau();
            return arr.Count - sinhVienDau();
        }





        //tự làm
        /*
        public void checkTuoi() {
            int minTuoi = arr[0].Tuoi;
            string hoTen = arr[0].Hoten;
            for (int i = 0; i < n; i++)            {
                
                if (arr[i].Tuoi < arr[0].Tuoi)
                {
                    minTuoi = arr[i].Tuoi;
                    hoTen = arr[i].Hoten;
                }                
            }
            Console.WriteLine("Sinh viên có tuổi nhỏ nhất: "+hoTen+" với " + minTuoi +" tuổi");
        }
        public float tongDiemTB()
        {
            
            float tdTB = 0;
            for (int i = 0; i < n; i++)
            {
                tdTB += arr[i].diemTB;
            }
            Console.WriteLine("Tổng điểm trung bình cả lớp: "+(1.0*(tdTB/n)));
            return tdTB/n;
        }
        public int sinhVienDau()
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].ketQua() == true)
                {
                    count++;
                }
            }
            Console.WriteLine("Số học sinh đậu: "+count);//39260022
            return count;
        }
        public int sinhVienRot()
        {
            return arr.Length-sinhVienDau();
        }*/

    }
}
