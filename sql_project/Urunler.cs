using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_project
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        DatabaseManagement dbm = new DatabaseManagement();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
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

            string[] cinsiyet = { "Erkek", "Kadın", "Erkek Çocuk", "Kız Çocuk", "Bebek", "Unisex" };
            for (int i = 0; i < cinsiyet.Length; i++)
            {
                comboBox6.Items.Add(cinsiyet[i]);
            }

            foreach (string i in dbm.kategori_adları())
            {
                comboBox2.Items.Add(i);
            }
            foreach (string i in dbm.kumas_adları())
            {
                comboBox4.Items.Add(i);
            }
            dataGridView1.DataSource = dbm.urunler();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ekle
            string ad = textBox1.Text;
            string beden = comboBox1.Text;
            string fiyat = textBox2.Text;
            string stok = textBox3.Text;
            string kategori = comboBox2.Text;
            string renk = comboBox3.Text;
            string kumas = comboBox4.Text;
            string marka = textBox4.Text;
            string cinsiyet = comboBox6.Text;
            string maliyet = textBox5.Text;
            string kullanici_id = textBox6.Text;

            int kategori_id = dbm.kategori_find_id(kategori);
            int kumas_id = dbm.kumas_find_id(kumas);

            if (kategori_id != 0 && kumas_id != 0)
            {
                dbm.urun_ekle(ad, beden, fiyat, stok, kategori_id.ToString(), renk, kumas_id.ToString(), marka, cinsiyet, maliyet, kullanici_id);
            }

            dataGridView1.DataSource = dbm.urunler();
        }
        int urun_id;

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

        private void button2_Click(object sender, EventArgs e)
        {
            //Güncelle 

            //ad = textBox1.Text;
            //beden = comboBox1.Text;
            //fiyat = textBox2.Text;
            //stok = textBox3.Text;
            //kategori = comboBox2.Text;
            //renk = comboBox3.Text;
            //kumas = comboBox4.Text;
            //marka = textBox4.Text;
            //cinsiyet = comboBox6.Text;
            //maliyet = textBox5.Text;
            //kullanici_id = textBox6.Text;

            Urun_Guncelle ug = new Urun_Guncelle(urun_id, ad, beden, fiyat, stok, kategori, renk, kumas, marka, cinsiyet, maliyet, kullanici_id);
            ug.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sil
            dbm.urun_sil(urun_id.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urun_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            beden = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fiyat = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            stok = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kategori = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            renk = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            kumas = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            marka = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cinsiyet = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            maliyet = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            kullanici_id = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            //ad = textBox1.Text;
            //beden = comboBox1.Text;
            //fiyat = textBox2.Text;
            //stok = textBox3.Text;
            //kategori = comboBox2.Text;
            //renk = comboBox3.Text;
            //kumas = comboBox4.Text;
            //marka = textBox4.Text;
            //cinsiyet = comboBox6.Text;
            //maliyet = textBox5.Text;
            //kullanici_id = textBox6.Text;

        }
    }
}
