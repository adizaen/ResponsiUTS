using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2269
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        //private string nik;
        //private string nama;
        //private int gajibulanan;

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            this.Nik = nik;
            this.Nama = nama;
            if(gajibulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = gajibulanan;
            }
        }

       
    }
}
