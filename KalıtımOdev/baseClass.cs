using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımOdev
{
    public class baseClass
    {
        public static int sayac = 1; 
        private int _id;
        public int id { get { return _id; } private set {  } } // get değeri içeriden dışarıya gönderme

        private string _barkod;
        public string barkod { 
        get { return _barkod; }
            set
            {
                bool kontrolIslemi = SanalDataBase.dbBarkodKontrol(value);
                if (!kontrolIslemi)
                {
                    _barkod = value;
                }else
                {
                    Console.WriteLine("sanal database içerisine bu barkod değeri daha önce girilimiştir");
                }
            }
        }

        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }


    }
}
