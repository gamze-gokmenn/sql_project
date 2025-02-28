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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // giriş yap 
            Form1 frm = new Form1();
            frm.ShowDialog();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kayıt ol
        }
    }
}
