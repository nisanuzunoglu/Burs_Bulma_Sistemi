using bursbulma;
using System.Diagnostics.Eventing.Reader;

namespace projeburs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 kayitFormu = new Form2();
            kayitFormu.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenTC = int.Parse(textBox1.Text);
            string girilensifre = textBox2.Text;
            string secilenrol = comboBox1.SelectedItem.ToString();

            if (secilenrol == "Öðrenci")
            {
                var ogrenci = VeriYoneticisi.OgrenciListesi.FirstOrDefault(o => o.TC == girilenTC && o.Sifre == girilensifre);
                if (ogrenci != null)
                {
                    VeriYoneticisi.MevcutOgrenci = ogrenci;
                    MessageBox.Show(ogrenci.GirisYap());

                    Form3 ogrenciPaneli = new Form3();
                    ogrenciPaneli.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Hatalý tc yada þifre girdiniz ."); }


            }
            else if (secilenrol == "Kurum")
            {
                var kurum = VeriYoneticisi.KurumListesi.FirstOrDefault(k => k.TC == girilenTC && k.Sifre == girilensifre);
                if (kurum != null)
                {
                    VeriYoneticisi.MevcutKurum = kurum;
                    MessageBox.Show(kurum.GirisYap());

                    Form4 kurumPaneli = new Form4();
                    kurumPaneli.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Hatalý Kimlik veya Þifre!"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }

}
