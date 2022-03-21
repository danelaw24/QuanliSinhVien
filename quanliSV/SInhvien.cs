using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanliSV
{
    internal class SInhvien
    {
        private string msv, tensv;
        private float diemLT, diemCSDL, diemTB;

        public SInhvien()
    {
            diemLT = diemCSDL = diemTB = 0;
    }
    public SInhvien(string msv, string tensv, float diemLT, float diemCSDL, float diemTB)
    {
        this.msv = msv;
        this.tensv = tensv;
        this.diemLT = diemLT;
        this.diemCSDL = diemCSDL;
        this.diemTB = (diemCSDL + diemLT) / 2;
    }
    public void inTT()
    {
        Console.WriteLine("ho va ten sinh vien la:{0}, ma sinh vien la:{1}", this.tensv, this.msv);
        Console.WriteLine("Diem so: Lap trinh : {0}, CSDL : {1}, diem TB : {2}", this.diemLT, this.diemCSDL, this.diemTB);
    }
    public void NhapTT()
    {
        Console.WriteLine("Nhap ten cua SV: ");
        this.tensv = Console.ReadLine();
        Console.WriteLine("Nhap ma sv: ");
        this.msv = Console.ReadLine();
            Console.WriteLine("Nhap diem LT: ");
        this.diemLT = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem CSDL: ");
        this.diemCSDL = Int32.Parse(Console.ReadLine());
    }

    }
}
