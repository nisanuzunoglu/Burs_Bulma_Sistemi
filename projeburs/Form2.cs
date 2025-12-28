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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır!");
                return;
            }
            foreach (char karakter in textBox1.Text)
            {
                if (!char.IsDigit(karakter))
                {
                    MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");
                    return;
                }
            }
            string tc = textBox1.Text;
            string sifre = textBox2.Text;
            string tur = comboBox1.SelectedItem.ToString();

            if (tur == "Öğrenci")
            {
                öğrenci yeniOgrenci = new öğrenci { TCNO = tc, Sifre = sifre };
                VeriYoneticisi.OgrenciListesi.Add(yeniOgrenci);
                MessageBox.Show(yeniOgrenci.KayıtOl()); 
            }
            else if (tur == "Kurum")
            {
                kurum yeniKurum = new kurum { TCNO = tc, Sifre = sifre };
                VeriYoneticisi.KurumListesi.Add(yeniKurum);
                MessageBox.Show(yeniKurum.KayıtOl()); 
            }

            
            Form1 giris = new Form1();
            giris.Show();
            this.Close();
        }
    }
    
}
