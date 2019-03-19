using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassdanObject
{
    class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Ipk { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("Nim: {0}", Nim);
            Console.WriteLine("Ipk: {0}", Ipk);
            Console.WriteLine("Telah Melakukan registrasi");
        }
        public void Isikrs()
        {
            Console.WriteLine("{0} sedang melakukan proses kes\n", Nama);
        }
    }
}
