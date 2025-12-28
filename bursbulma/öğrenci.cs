using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace bursbulma
{
    public class öğrenci:Kullanıcı,IbaşvuruYapabilir,IFavorile
    {
        public string AdSoyad {  get; set; }
        public string TCNO { get; set; }
        public string TelNo {  get; set; }
        public string Sehir {  get; set;}
        public string Okul { get; set;}
        public string Bölüm {  get; set;}
        public int Sınıf {  get; set;}
        public float NotOrt {  get; set;}
        public float YksSıralama {  get; set;}
        public float Gelir {  get; set;}

        public override string GirisYap()
        {
            return "öğrenci girişi yapıldı hoşgeldiniz";
        }

        public override string Guncelle()
        {
            return "bilgileriniz başarıyla güncellendi";
        }

        public override string KayıtOl()
        {
            return " kaydınız başarılı ";
        }

        string IbaşvuruYapabilir.başvuruYap(string burs)
        {
            return "başvurunuz alınmıştır ";
        }

        string IFavorile.favorile(string burs)
        {
            return "burs favorilerilerineze eklenmiştir ";
        }
    }
}
