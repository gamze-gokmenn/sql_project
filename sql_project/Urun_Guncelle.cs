using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Macs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sql_project
{
    public partial class Urun_Guncelle : Form
    {
        public Urun_Guncelle(int urun_id, string ad, string beden, string fiyat, string stok, string kategori, string renk, string kumas, string marka, string cinsiyet, string maliyet, string kullanici_id)
        {
            InitializeComponent();
            this.urun_id = urun_id;
            this.ad = ad;
            this.beden = beden;
            this.fiyat = fiyat;
            this.stok = stok;
            this.kategori = kategori;
            this.renk = renk;
            this.kumas = kumas;
            this.marka = marka;
            this.cinsiyet = cinsiyet;
            this.maliyet = maliyet;
            this.kullanici_id = kullanici_id;

        }

        string ad;
        string beden;
        string fiyat;
        string stok;
        string kategori;
        string renk;
        string kumas;
        string marka;
        string cinsiyet;
        string maliyet;
        string kullanici_id;

        int urun_id;
        DatabaseManagement dbm = new DatabaseManagement();
        private void Urun_Guncelle_Load(object sender, EventArgs e)
        {
            textBox1.Text = ad;
            comboBox1.Text = beden;
            textBox2.Text = fiyat;
            textBox3.Text = stok;
            comboBox2.Text = kategori;
            comboBox3.Text = renk;
            comboBox4.Text = kumas;
            textBox4.Text = marka;
            comboBox5.Text = cinsiyet;
            textBox5.Text = maliyet;
            textBox6.Text = kullanici_id;

            string[] bedenler = { "S", "M", "L", "XL", "XXL" };
            for (int i = 0; i < bedenler.Length; i++)
            {
                comboBox1.Items.Add(bedenler[i]);
            }

            string[] renkler = { "Siyah", "Beyaz", "Mavi", "Kırmızı", "Yeşil", "Sarı", "Mor", "Pembe", "Turuncu", "Gri" };
            for (int i = 0; i < renkler.Length; i++)
            {
                comboBox3.Items.Add(renkler[i]);
            }

            string[] cinsiyetler = { "Erkek", "Kadın", "Erkek Çocuk", "Kız Çocuk", "Bebek", "Unisex" };
            for (int i = 0; i < cinsiyetler.Length; i++)
            {
                comboBox5.Items.Add(cinsiyetler[i]);
            }

            foreach (string i in dbm.kategori_adları())
            {
                comboBox2.Items.Add(i);
            }
            foreach (string i in dbm.kumas_adları())
            {
                comboBox4.Items.Add(i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // güncelle
            string ad = textBox1.Text;
            string beden = comboBox1.Text;
            string fiyat = textBox2.Text;
            string stok = textBox3.Text;
            string kategori = comboBox2.Text;
            string renk = comboBox3.Text;
            string kumas = comboBox4.Text;
            string marka = textBox4.Text;
            string cinsiyet = comboBox5.Text;
            string maliyet = textBox5.Text;
            string kullanici_id = textBox6.Text;

            int kategori_id = dbm.kategori_find_id(kategori);
            int kumas_id = dbm.kumas_find_id(kumas);

            if (kategori_id != 0 && kumas_id != 0)
            {
                dbm.urun_guncelle(urun_id.ToString(), ad, beden, fiyat, stok, kategori_id.ToString(), renk, kumas_id.ToString(), marka, cinsiyet, maliyet, kullanici_id);
            }
            Ürünler_Listesi ul = new Ürünler_Listesi();
            ul.Show();


        }
    }
}
