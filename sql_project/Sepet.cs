using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_project
{
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kaydet

            database.sepet_sil(id);
            dataGridView1.DataSource = database.sepetler();
            MessageBox.Show("Ürün satın alım başarılı.");

        }
        DatabaseManagement database = new DatabaseManagement();
        private void Sepet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.sepetler();
        }
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
