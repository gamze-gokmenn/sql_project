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
        }
        DatabaseManagement database = new DatabaseManagement();
        private void Sepet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.sepetler();
        }
    }
}
