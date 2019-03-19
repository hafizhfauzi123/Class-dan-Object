using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassdanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.Nim = "2345";
            saya.Nama = "fauzi";
            saya.Ipk = "3.95f";

            kamu.Nim = "2317";
            kamu.Nama = "suriyadi";
            kamu.Ipk = "1.52f";

            saya.Registrasi();
            saya.Isikrs();

            kamu.Registrasi();
            kamu.Isikrs();


            Console.ReadKey();
        }
    }
}
