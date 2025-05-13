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
    public partial class Kategorıler : Form
    {
        public Kategorıler()
        {
            InitializeComponent();
        }
        DatabaseManagement database = new DatabaseManagement();
        private void button1_Click(object sender, EventArgs e)
        {
            // kaydet butonu

            database.kategori_ekle(textBox2.Text);
        }

        private void Kategorıler_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
