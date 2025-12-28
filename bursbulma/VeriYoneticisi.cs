using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bursbulma
{
    public class VeriYoneticisi
    {
        public static List<öğrenci> OgrenciListesi = new List<öğrenci>();
        public static List<kurum> KurumListesi = new List<kurum>();

        // Burslar ve Başvurular
        public static List<burslar> TumBurslar = new List<burslar>();
        public static List<başvuru> YapilanBasvurular = new List<başvuru>();
        public static List<burslar> FavoriBurslar = new List<burslar>();

        // O an giriş yapmış olan kullanıcıyı tutmak için
        public static öğrenci MevcutOgrenci;
        public static kurum MevcutKurum;
    }
}
