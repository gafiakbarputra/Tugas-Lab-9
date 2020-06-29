using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8.ClassAnak
{
    class Sales : Karyawan
    {
        public override double Gaji()
        {
            double total1;
            total1 = JumlahPenjualan * Komisi;
            return total1;
        }
    }
}
