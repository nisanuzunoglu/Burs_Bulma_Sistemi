using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bursbulma
{
    public abstract class Kullanıcı
    {
        public int TC {  get; set; }
        public string Sifre {  get; set; }
        public abstract string GirisYap();
        public abstract string KayıtOl();
        public abstract string Guncelle();


    }
}
