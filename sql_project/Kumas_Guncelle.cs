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
    public partial class Kumas_Guncelle : Form
    {
        public Kumas_Guncelle(string id, string tip, string miktar, string renk, string fiyat,string kul_id)
        {
            InitializeComponent();
            kumas_id = id;
            this.tip = tip;
            this.miktar = miktar;
            this.fiyat = fiyat;
            this.renk = renk;   
            this.kul_id = kul_id;
        }
        DatabaseManagement dbm = new DatabaseManagement();
        string kumas_id ;
        string tip;
        string miktar;
        string renk;
        string fiyat;
        string kul_id;
        private void button1_Click(object sender, EventArgs e)
        {
            //int tip_id = dbm.kumas_find_id(kumas_id);
            tip = comboBox1.Text;
            miktar = textBox1.Text;
            renk = comboBox2.Text;
            fiyat = textBox2.Text;
            kul_id = textBox3.Text;
            dbm.kumas_guncelle(kumas_id, tip, miktar, renk, fiyat, kul_id);
            MessageBox.Show("Güncellendi");
        }

        private void Kumas_Guncelle_Load(object sender, EventArgs e)
        {
            comboBox1.Text = tip ;
            textBox1.Text =  miktar ;
            comboBox2.Text =  renk ;
            textBox2.Text =  fiyat ;
            textBox3.Text =  kul_id ;

            foreach (string i in dbm.kumas_adları())
            {
                comboBox1.Items.Add(i);
            }

            string[] renkler = { "Siyah", "Beyaz", "Mavi", "Kırmızı", "Yeşil", "Sarı", "Mor", "Pembe", "Turuncu", "Gri" };
            for (int i = 0; i < renkler.Length; i++)
            {
                comboBox2.Items.Add(renkler[i]);
            }
        }
    }
}
