using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bilgisayar b1 = new bilgisayar();
           
            b1.model = "z50";
            b1.islemci = "i5";
            b1.marka = "lenova";
            b1.alisFiyat = 1000;
            b1.satisFiyat = 900;
            b1.kampanyaFiyat = 1000M;
            b1.barkod = "1234567890";
            SanalDataBase.yeniUrunEkle(b1);
          

            bilgisayar b2 = new bilgisayar();

            b2.model = "z50";
            b2.islemci = "i5";
            b2.marka = "lenova";
            b2.alisFiyat = 1000;
            b2.satisFiyat = 1400;
            b2.kampanyaFiyat = 1300;
            b2.barkod = "1234567890";
            SanalDataBase.yeniUrunEkle(b2);
            Console.ReadLine();

        }
    }
}
