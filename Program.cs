using System;
using System.Collections.Generic;

namespace tugas_8
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawantetap karyawantetap = new karyawantetap();
            karyawantetap.Nama = "Mike tyson";
            karyawantetap.Nik = "123-234-345";
            karyawantetap.GajiBulanan= 5000000;
           


            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nama = "chris wayne";
            karyawanharian.Nik = "123-321-346";
            karyawanharian.JumlahJamKerja = 8;
            karyawanharian.UpahPerJam = 23000;
            
            

            sales sales = new sales();
            sales.Nama = "Andrewson";
            sales.Nik = "123-333-347";
            sales.Komisi = 35000;
            sales.JumlahPenjualan =  30;



            //objek collection
            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);


            int no = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1} Nama: {2} Gaji: {3:N0}",
                    no,karyawan.Nik,karyawan.Nama,karyawan.TotalGaji());

                no++;
            }


            Console.ReadKey();
        }
    }
}
