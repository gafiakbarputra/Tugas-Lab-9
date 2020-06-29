using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public override double Gaji()
        {
            double total;
            total = UpahPerJam * JumlahJamKerja;
            return total;
        }
    }
}
