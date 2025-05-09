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
    public partial class Kumas_Guncelle : Form
    {
        public Kumas_Guncelle(string id)
        {
            InitializeComponent();
            kumas_id    = id;
        }
        DatabaseManagement dbm = new DatabaseManagement();
        string kumas_id = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string tip = comboBox1.Text;
            string miktar = textBox1.Text;
            string renk = comboBox2.Text;
            string fiyat = textBox2.Text;
            string kul_id = textBox3.Text;
            dbm.kumas_guncelle(kumas_id, tip, miktar, renk, fiyat, kul_id);
        }
    }
}
