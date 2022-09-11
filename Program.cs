using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstract classların Interface'e göre kullanımı.

           Ocak ocak = new Ocak();
            Console.WriteLine("Ocak GÜn Saati: "+ocak.GunSaati());

            Subat subat = new Subat();
            Console.WriteLine("Şubat GÜn Saati: " + subat.GunSaati());

            Mart mart = new Mart();
            Console.WriteLine("Mart Gün Saati: "+mart.GunSaati());

            Console.ReadLine();
        }
    }
}
