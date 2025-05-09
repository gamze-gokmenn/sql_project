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
    public partial class Kategoriler_Listesi : Form
    {
        public Kategoriler_Listesi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // kategori güncelle

            Kategori_Guncelle kg = new Kategori_Guncelle   (kategori_id);
            kg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // kategori sil
            DialogResult dialogResult = MessageBox.Show($"{kategori_id} Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dbm.kategori_sil(kategori_id);
            }
            dataGridView1.DataSource = dbm.kategoriler();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ürünlere git
            Urunler urunler = new Urunler();
            urunler.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bul 
            string aranan = textBox1.Text;
            dataGridView1.DataSource = dbm.aranan_kategoriler(aranan);
        }
        DatabaseManagement dbm = new DatabaseManagement();

        private void Kategoriler_Listesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbm.kategoriler();
        }
        string kategori_id = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kategori_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
