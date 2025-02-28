﻿using System;
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
    public partial class Ürünler_Listesi : Form
    {
        public Ürünler_Listesi()
        {
            InitializeComponent();
        }
        DatabaseManagement database = new DatabaseManagement();
        private void button4_Click(object sender, EventArgs e)
        {
            // Sepete git
            Sepet sepet = new Sepet();
            sepet.Show();
        }

        string toplam_tutar = "";
        string ürün_id = "";
        private void button1_Click(object sender, EventArgs e)
        {
            // Sepete ekle
            string adet = "1";
            string kullanicilar_id = "1";
            database.sepet_ekle(adet, toplam_tutar, ürün_id, kullanicilar_id);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ürünü güncelle
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ürünü sil
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // bul
        }

        private void Ürünler_Listesi_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = database.urunler();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ürün_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            toplam_tutar = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
