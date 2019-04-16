using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2269
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan k1 = new Karyawan("192308","Jono",3000000);
            Cetak(k1);
            Karyawan k2 = new Karyawan("192309","Paijo",2000000);
            Cetak(k2);
            
            Console.WriteLine("\nAasikkkk gaji naik 10%\n");
            Cetak2(k1);
            Cetak2(k2);

            Console.ReadKey();
        }
        static void Cetak(Karyawan k)
        {
            if(k.Nama == "Jono")
            {
                Console.WriteLine("No.   Nik/Nama             Gaji Bulanan");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.    {0}/{1}          {2}", k.Nik, k.Nama, k.GajiBulanan);
            }
            else
            {
                Console.WriteLine("2.    {0}/{1}         {2}", k.Nik, k.Nama, k.GajiBulanan);
            }
        }
        static void Cetak2(Karyawan i)
        {
            int naik, total;
            naik = (10 * i.GajiBulanan) / 100;
            total = i.GajiBulanan + naik;
            if (i.Nama == "Jono")
            {
                Console.WriteLine("No.   Nik/Nama             Gaji Bulanan");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.    {0}/{1}          {2}", i.Nik, i.Nama, total);
            }
            else
            {
                Console.WriteLine("2.    {0}/{1}         {2}", i.Nik, i.Nama, total );
            }
        }
    }
}
