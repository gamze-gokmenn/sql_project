namespace sql_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseManagement dbm = new DatabaseManagement();
        string global_id = "";



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

            //dataGridView1.DataSource = dbm.kullaniciler();
            dataGridView1.DataSource = dbm.tüm_kullanıcılar();

            //dbm.kapat();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dbm.kullaniciler();
            dataGridView1.DataSource = dbm.tüm_kullanıcılar();


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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            global_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //dbm.kullanici_sil(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbm.kullanici_sil(global_id);
            dataGridView1.DataSource = dbm.tüm_kullanıcılar();
        }

        private void kumaşlaraGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kumas kumas = new Kumas();
            kumas.Show();
        }
    }
}
