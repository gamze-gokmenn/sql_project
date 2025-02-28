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



        private void button2_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string mail = textBox2.Text;
            string tel = textBox3.Text;
            string parola = textBox4.Text;
            string bakiye = textBox5.Text;
            string rol = textBox6.Text;
            //dbm.baslat();

            dbm.kullanici_ekle(isim, mail, tel, parola, bakiye, rol);

            dataGridView1.DataSource = dbm.kullaniciler();

            //dbm.kapat();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbm.kullaniciler();

        }

        private void ürünlereGitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
        }

        private void ürünlereGitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ürünler_Listesi urunler = new Ürünler_Listesi();
            urunler.Show();
        }

        private void kategorilereGitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategorıler kategoriler = new Kategorıler();
            kategoriler.Show();
        }

        private void kategorilereGitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kategoriler_Listesi kategoriler_Listesi = new Kategoriler_Listesi();
            kategoriler_Listesi.Show();
        }
    }
}
