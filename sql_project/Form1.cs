namespace sql_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.PlaceholderText = "Ad Soyad";
            textBox2.PlaceholderText = "Mail";
            textBox3.PlaceholderText = "Tel No";
            textBox4.PlaceholderText = "Parola";
            textBox5.PlaceholderText = "Bakiye";
            textBox6.PlaceholderText = "Kullanici Rol";

            textBox4.UseSystemPasswordChar = true;
        }
        DatabaseManagement dbm = new DatabaseManagement();

        private void button1_Click(object sender, EventArgs e)
        {
            dbm.baslat();
            dataGridView1.DataSource = dbm.urunler();
            dbm.kapat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			string isim = textBox1.Text;
			string mail = textBox2.Text;
			string tel = textBox3.Text;
			string parola = textBox4.Text;
			string bakiye = textBox5.Text;
			string rol = textBox6.Text;
			dbm.baslat();

			dbm.kullanici_ekle(isim, mail, tel, parola, bakiye, rol);

			dbm.kapat();

		}
	}
}
