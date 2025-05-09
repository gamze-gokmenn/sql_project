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
        DatabaseManagement dbm = new DatabaseManagement();

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text; // TextBox adlarını senin formundaki ile değiştir
            string password = textBox2.Text;

            dbm.login(email, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kayıt ol
        }
    }
}
