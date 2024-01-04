using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımOdev
{
    public class Urun:baseClass
    {
        decimal _alisfiyat;
        public decimal alisFiyat
        {
            get
            {
                return _alisfiyat;
            }
            set
            {
                if(value <= 0)
                {
                    
                    Console.WriteLine(" 0 dan kucuk veya esit olamaz");
                }else
                {
                    _alisfiyat = value;
                }
            }
        }// 0 dan kucuk olmamalı
        decimal _satisfiyat;
        public decimal satisFiyat // alıs fiyatından kucuk olamaz
        {
            get
            {
                return _satisfiyat;
            }
            set
            { if(value < _alisfiyat)
                {
                    Console.WriteLine("Aliş fiyatından düşük olamaz");
                }
                else{
                    _satisfiyat = value;
                }
            }
        }
        decimal _kampanyafiyat;
        public decimal kampanyaFiyat {
            get
            {
                return _kampanyafiyat;
            }
            set{
                if(value <= 0)
                {
                    Console.WriteLine("kampanya fiyatı 0 dan küçük veya eşit  olamaz");
                }
            }
        }// o dan kucuk olmamalı
        public string marka { get; set; } // belirtmiş oldugumuz markalar içerisinde ürün eklenebilir
        public string model { get; set; }
    }
}
