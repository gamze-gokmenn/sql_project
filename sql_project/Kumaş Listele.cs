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
    public partial class Kumaş_Listele : Form
    {
        public Kumaş_Listele()
        {
            InitializeComponent();
        }
        string kumas_id;
        string tip;
        string miktar;
        string renk;
        string fiyat;
        string kul_id;

        private void button2_Click(object sender, EventArgs e)
        {
            // kumaş güncelle
            Kumas_Guncelle kg = new Kumas_Guncelle(kumas_id, tip, miktar, renk, fiyat, kul_id);
            kg.Show();
        }
        DatabaseManagement dbm = new DatabaseManagement();
        private void button3_Click(object sender, EventArgs e)
        {
            // kumaş sil    

            dbm.kumas_sil(kumas_id);
            dataGridView1.DataSource = dbm.tüm_kumaslar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ürünlere git
            Urunler urunler = new Urunler();
            urunler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bul
            dataGridView1.DataSource = dbm.aranan_kumaslar(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kumas_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tip = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            miktar = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            renk = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fiyat = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kul_id = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void Kumaş_Listele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbm.tüm_kumaslar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbm.tüm_kumaslar();
        }
    }
}
