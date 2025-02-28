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

        private void button2_Click(object sender, EventArgs e)
        {
            // kumaş güncelle
        }
        DatabaseManagement dbm = new DatabaseManagement();
        private void button3_Click(object sender, EventArgs e)
        {
            // kumaş sil    

            dbm.kumas_sil(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ürünlere git
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bul
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string kumas_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kumas_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
