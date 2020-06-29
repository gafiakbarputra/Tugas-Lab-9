using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
