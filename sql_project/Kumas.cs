using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sql_project
{
    public partial class Kumas : Form
    {
        public Kumas()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DatabaseManagement dbm = new DatabaseManagement();
        private void button1_Click(object sender, EventArgs e)
        {
            // kaydet   

            string tür = comboBox1.Text;
            string renk = comboBox2.Text;
            string adet = textBox6.Text;
            string fiyat = textBox7.Text;
            string kullanici_id = "1";

            dbm.kumas_ekle(tür, adet, renk, fiyat, kullanici_id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // kumaşları listele
            Kumaş_Listele kumaş_Listele = new Kumaş_Listele();
            kumaş_Listele.Show();
        }

        private void Kumas_Load(object sender, EventArgs e)
        {
            string[] tür = { "Etek", "Pantolon", "Ceket", "Gömlek", "Mont", "Sweatshirt", "Tişört" };

            foreach (var item in tür)
            {
                comboBox1.Items.Add(item);
            }

            string[] renkler = { "Siyah", "Beyaz", "Mavi", "Kırmızı", "Yeşil", "Sarı", "Mor", "Pembe", "Turuncu", "Gri" };
            for (int i = 0; i < renkler.Length; i++)
            {
                comboBox2.Items.Add(renkler[i]);
            }

        }
    }
}
