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
    public partial class Form4 : Form
    {
        private object dateTimePickerSonTarih;
        private burslar yeniBurs;

        public Form4()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            burslar yeniBurs = new burslar()
            {
                BursAdı = textBox3.Text,
                KurumAdı = bursbulma.VeriYoneticisi.MevcutKurum.KurumAdı,
                Sıralama = float.Parse(textBox6.Text),
                SehirAdı = textBox4.Text,
                Gelir = float.Parse(textBox8.Text)

            };

            bursbulma.VeriYoneticisi.TumBurslar.Add(yeniBurs);
            bursbulma.VeriYoneticisi.MevcutKurum.BursAdedi++;
            MessageBox.Show("Burs başarıyla eklendi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kurum = VeriYoneticisi.MevcutKurum;
            kurum.KurumAdı = textBox1.Text;
            kurum.İletisimBilgileri = textBox2.Text;
            MessageBox.Show(kurum.Guncelle());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // Bu kurumun adına açılmış başvuruları filtrele
            var basvurular = VeriYoneticisi.YapilanBasvurular
                             .Where(b => b.KurumAdı == VeriYoneticisi.MevcutKurum.KurumAdı);

            foreach (var b in basvurular)
            {
                listView1.Items.Add($"Burs: {b.BursAdı} - Tarih: {b.BaşvuruTarihi.ToShortDateString()}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Giriş ekranını (Form1) yeniden oluştur
            Form1 girisEkrani = new Form1();

            // 2. Giriş ekranını göster
            girisEkrani.Show();

            // 3. Şu anki paneli (Kurum Paneli) kapat
            this.Close();
        }
    }
}
