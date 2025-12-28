using bursbulma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeburs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bursbulma.VeriYoneticisi.MevcutOgrenci.AdSoyad = textBox1.Text;
            bursbulma.VeriYoneticisi.MevcutOgrenci.Sehir = textBox4.Text;
            bursbulma.VeriYoneticisi.MevcutOgrenci.NotOrt = float.Parse(textBox8.Text);
            bursbulma.VeriYoneticisi.MevcutOgrenci.Gelir = float.Parse(textBox6.Text);
            bursbulma.VeriYoneticisi.MevcutOgrenci.Okul = textBox5.Text;
            bursbulma.VeriYoneticisi.MevcutOgrenci.TelNo = textBox3.Text;
            bursbulma.VeriYoneticisi.MevcutOgrenci.Bölüm = textBox10.Text;
            bursbulma.VeriYoneticisi.MevcutOgrenci.Sınıf = int.Parse(textBox9.Text);
            bursbulma.VeriYoneticisi.MevcutOgrenci.YksSıralama = int.Parse(textBox7.Text);

            MessageBox.Show(bursbulma.VeriYoneticisi.MevcutOgrenci.Guncelle());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            // Eğer sistemde hiç burs yoksa
            if (VeriYoneticisi.TumBurslar.Count == 0)
            {
                MessageBox.Show("Şu an sistemde aktif burs ilanı bulunmamaktadır.");
                return;
            }

            foreach (var burs in VeriYoneticisi.TumBurslar)
            {
                // FİLTRELEME MANTIĞI:
                // Öğrencinin geliri, bursun gelir sınırından düşükse VE
                // Öğrencinin sıralaması, bursun istediği sıralamadan iyiyse (küçükse) listele.
                // Eğer kriter yoksa (0 girilmişse) herkes görebilir.

                bool gelirUygun = (burs.Gelir == 0) || (VeriYoneticisi.MevcutOgrenci.Gelir <= burs.Gelir);
                bool siralamaUygun = (burs.Sıralama == 0) || (VeriYoneticisi.MevcutOgrenci.YksSıralama <= burs.Sıralama);

                if (gelirUygun && siralamaUygun)
                {
                    ListViewItem item = new ListViewItem(burs.BursAdı);
                    item.SubItems.Add(burs.KurumAdı);
                    item.SubItems.Add(burs.SehirAdı);
                    item.SubItems.Add(burs.SonBaşvuru);

                    // Tag özelliğine bursun kendisini ekliyoruz (Başvuru yaparken kolay olsun diye)
                    item.Tag = burs;

                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (VeriYoneticisi.MevcutOgrenci != null)
            {

                label13.Text = VeriYoneticisi.MevcutOgrenci.TC.ToString();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            if (VeriYoneticisi.MevcutOgrenci != null)
            {
                // Önce listenin içini temizle ki her tıkladığında üstüne eklemesin
                listBox2.Items.Clear();

                // Yapılan tüm başvuruları tek tek kontrol et
                foreach (var basvuru in VeriYoneticisi.YapilanBasvurular)
                {

                    listBox2.Items.Add($"{basvuru.BursAdı} - {basvuru.KurumAdı} ({basvuru.SonBaşvuru})");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçilen satırdaki burs bilgilerini al
                ListViewItem secilenSatir = listView1.SelectedItems[0];
                string bursAdi = secilenSatir.Text;
                string kurumAdi = secilenSatir.SubItems[1].Text;

                // Yeni Başvuru Oluştur
                başvuru yeniBasvuru = new başvuru
                {
                    OgrenciAdSoyad = VeriYoneticisi.MevcutOgrenci.AdSoyad,
                    BursAdı = bursAdi,
                    KurumAdı = kurumAdi,
                    SonBaşvuru = DateTime.Now.ToShortDateString()
                };

                // Listeye Ekle
                VeriYoneticisi.YapilanBasvurular.Add(yeniBasvuru);
                MessageBox.Show($"{bursAdi} için başvurunuz kuruma iletildi!");
            }
            else
            {
                MessageBox.Show("Lütfen listeden başvurmak istediğiniz bursu seçiniz.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // 2. Seçilen satırın içindeki gizli "burslar" nesnesini geri al (Unboxing)
                // item.Tag bize 'object' döner, onu '(burslar)' diyerek kendi sınıfımıza çeviriyoruz.
                burslar secilenBurs = (burslar)listView1.SelectedItems[0].Tag;

                // Eğer Tag boşsa veya hata varsa işlem yapma
                if (secilenBurs == null)
                {
                    MessageBox.Show("Burs bilgisi okunamadı. Lütfen tekrar arama yapınız.");
                    return;
                }

                // 3. Bu burs zaten favorilerde var mı?
                if (VeriYoneticisi.FavoriBurslar.Contains(secilenBurs))
                {
                    MessageBox.Show("Bu burs zaten favorilerinizde ekli.");
                }
                else
                {
                    // 4. Yoksa listeye ekle
                    VeriYoneticisi.FavoriBurslar.Add(secilenBurs);
                    MessageBox.Show("Burs başarıyla favorilere eklendi!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen favoriye eklemek için listeden bir burs seçiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // 2. Favori listen boş mu kontrol et
            if (VeriYoneticisi.FavoriBurslar.Count == 0)
            {
                MessageBox.Show("Henüz favorilere eklediğiniz bir burs yok.");
                return;
            }

            // 3. Listedeki her bursu dön ve ListBox'a ekle
            foreach (var burs in VeriYoneticisi.FavoriBurslar)
            {
                // Ekranda nasıl görünmesini istiyorsan öyle formatla
                string gorunum = $"{burs.BursAdı} - {burs.KurumAdı} ({burs.SehirAdı})";

                listBox1.Items.Add(gorunum);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 1. Giriş ekranını (Form1) yeniden oluştur
            Form1 girisEkrani = new Form1();

            // 2. Giriş ekranını göster
            girisEkrani.Show();

            // 3. Şu anki paneli (Öğrenci Paneli) kapat
            this.Close();
        }
    }
}
