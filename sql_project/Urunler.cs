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
			string ad = textBox1.Text;
			string beden = comboBox1.Text;
			string fiyat = textBox2.Text;
			string stok= textBox3.Text;
			string kategori= comboBox2.Text;
			string renk = comboBox3.Text;
			string kumas = comboBox4.Text;
			string marka = textBox4.Text;
			string cinsiyet = comboBox6.Text;
			string maliyet  = textBox5.Text;
			string kullanici_id = textBox6.Text;

			dbm.urun_ekle(ad, beden, fiyat, stok, kategori, renk,kumas, marka, cinsiyet, maliyet, kullanici_id);

			dataGridView1.DataSource = dbm.urunler();
		}
	}
}
