using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3352
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Sutarman", "20113352", 5000000);
            Karyawan karyawan2 = new Karyawan("Paidi", "20113315", -100);

            Console.WriteLine("NO   NIK / NAMA\t\t          Gaji ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Gaji);
            Console.WriteLine("2. {0} {1}\t {2}\t ", karyawan2.NIK, karyawan2.Nama, karyawan2.Gaji);
            Console.WriteLine();
            Console.WriteLine("Alhamdulillah Naik Gaji 10%");
            Console.WriteLine();
            Console.WriteLine("NO   NIK / NAMA\t\t          Gaji ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Naik);
            Console.WriteLine("2. {0} {1}\t {2}\t ", karyawan2.NIK, karyawan2.Nama, karyawan2.Naik);

            Console.ReadKey();
        }
    }
}
