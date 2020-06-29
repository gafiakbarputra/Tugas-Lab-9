using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Tugas_Lab_8.ClassAnak;
using Tugas_Lab_8.ClassInduk;
namespace Tugas_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            
            
            
            List<Karyawan> listKaryawan = new List<Karyawan>();
            while (true)
            {
                Console.WriteLine("Pilih Menu Aplikasi: ");
                Console.WriteLine("1.Tambah Data Karyawan:");
                Console.WriteLine("2.Hapus Data Karyawan:");
                Console.WriteLine("3.Tampilkan Data Karyawan:");
                Console.WriteLine("4.Keluar:");
                Console.Write("Nomor Menu [1..4]: ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                    ulang:
                        Console.WriteLine("Tambah Data Karyawan \n");
                        Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2.Karyawan Harian, 3.Sales] : ");
                        int pil = Convert.ToInt32(Console.ReadLine());
                        if (pil == 1)
                        {
                            KaryawanTetap karyawanTetap = new KaryawanTetap();
                            Console.Write("Nik:");
                            karyawanTetap.Nik = Console.ReadLine();
                            Console.Write("Nama:");
                            karyawanTetap.Nama = Console.ReadLine();
                            Console.Write("Gaji:");
                            karyawanTetap.GajiBulanan = Convert.ToInt32(Console.ReadLine());
                            karyawanTetap.jenis = "Karyawan Tetap";
                            listKaryawan.Add(karyawanTetap);

                        }
                        else if (pil == 2)
                        {
                            KaryawanHarian karyawanHarian = new KaryawanHarian();
                            Console.Write("Nik:");
                            karyawanHarian.Nik = Console.ReadLine();
                            Console.Write("Nama:");
                            karyawanHarian.Nama = Console.ReadLine();
                            Console.Write("Jumlah Jam kerja:");
                            karyawanHarian.JumlahJamKerja = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Upah Per jam:");
                            karyawanHarian.UpahPerJam = Convert.ToInt32(Console.ReadLine());
                            karyawanHarian.jenis = "Karyawan Harian";
                            listKaryawan.Add(karyawanHarian);
                             
                        }
                        else if (pil == 3)
                        {
                            Sales sales = new Sales();
                            Console.Write("Nik:");
                            sales.Nik = Console.ReadLine();
                            Console.Write("Nama:");
                            sales.Nama = Console.ReadLine();
                            Console.Write("Jumlah Penjualan:");
                            sales.JumlahPenjualan = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Komisi:");
                            sales.Komisi = Convert.ToInt32(Console.ReadLine());
                            sales.jenis = "Sales";
                            listKaryawan.Add(sales);
                             

                        }
                        else
                        {
                            Console.WriteLine("Inputan Salah");
                            goto ulang;
                        }
                        break;
                    case 2:
                        ulang1:
                        Console.Write("Hapus berdasarkan Nomor Urutan : ");
                        int cari = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(listKaryawan.Count);
                        if (cari < listKaryawan.Count)
                        {
                            listKaryawan.RemoveAt(cari);
                        }
                        else
                        {
                            goto ulang1;
                        }
                        break;
                    case 3:

                        int noUrut = 0;
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3},{4} ", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(),karyawan.jenis);
                            noUrut++;
                        }
                        break;
                    case 4:
                        System.Environment.Exit(1);
                        break;
                }
                Console.WriteLine("Tekan sembarang key untuk kembali ke menu:");
                Console.ReadKey();
            }
        }
    }
}
