using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bursbulma
{
    public class kurum:Kullanıcı
    {
        public string TCNO {  get; set; }
        public string KurumAdı {  get; set; }
        public string İletisimBilgileri {  get; set; }

        public  int BursAdedi {  get; set; }

        public override string GirisYap()
        {
            return "kurum girişi yapıldı hoşgeldiniz";
        }

        public override string Guncelle()
        {
            return "bilgileriniz başarıyla güncellenmiştir";
        }

        public override string KayıtOl()
        {
            return"kaydınız başarılı ";
        }
    }
}
