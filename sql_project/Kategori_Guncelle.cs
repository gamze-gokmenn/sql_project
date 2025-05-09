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
    public partial class Kategori_Guncelle : Form
    {
        public Kategori_Guncelle(string kategori_id)
        {
            InitializeComponent();
            id = kategori_id;   
        }
        DatabaseManagement dbm = new DatabaseManagement();
        string id = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string giyim_tipi = textBox1.Text;
            dbm.kategori_guncelle(id, giyim_tipi);

        }
    }
}
