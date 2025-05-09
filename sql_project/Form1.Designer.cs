namespace sql_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            ürünlereGitToolStripMenuItem = new ToolStripMenuItem();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            ürünlereGitToolStripMenuItem1 = new ToolStripMenuItem();
            kategorilereGitToolStripMenuItem = new ToolStripMenuItem();
            kategorilereGitToolStripMenuItem1 = new ToolStripMenuItem();
            kategoriEkleToolStripMenuItem = new ToolStripMenuItem();
            kumaşlaraGitToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 117);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(580, 305);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkKhaki;
            textBox1.Location = new Point(677, 118);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ad-Soyad";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkKhaki;
            textBox2.Location = new Point(677, 155);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mail";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkKhaki;
            textBox3.Location = new Point(677, 231);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Kullanıcı Rol";
            textBox3.Size = new Size(121, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkKhaki;
            textBox4.Location = new Point(677, 194);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Tel No";
            textBox4.Size = new Size(121, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkKhaki;
            textBox5.Location = new Point(677, 306);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Parola";
            textBox5.Size = new Size(121, 27);
            textBox5.TabIndex = 7;
            textBox5.UseSystemPasswordChar = true;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DarkKhaki;
            textBox6.Location = new Point(677, 268);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Bakiye";
            textBox6.Size = new Size(121, 27);
            textBox6.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(683, 358);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(114, 33);
            button2.TabIndex = 8;
            button2.Text = "Kullanici Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ürünlereGitToolStripMenuItem, kategorilereGitToolStripMenuItem, kumaşlaraGitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(866, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // ürünlereGitToolStripMenuItem
            // 
            ürünlereGitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünEkleToolStripMenuItem, ürünlereGitToolStripMenuItem1 });
            ürünlereGitToolStripMenuItem.Name = "ürünlereGitToolStripMenuItem";
            ürünlereGitToolStripMenuItem.Size = new Size(71, 24);
            ürünlereGitToolStripMenuItem.Text = "Ürünler";
            ürünlereGitToolStripMenuItem.Click += ürünlereGitToolStripMenuItem_Click;
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(171, 26);
            ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // ürünlereGitToolStripMenuItem1
            // 
            ürünlereGitToolStripMenuItem1.Name = "ürünlereGitToolStripMenuItem1";
            ürünlereGitToolStripMenuItem1.Size = new Size(171, 26);
            ürünlereGitToolStripMenuItem1.Text = "Ürünlere Git";
            ürünlereGitToolStripMenuItem1.Click += ürünlereGitToolStripMenuItem1_Click;
            // 
            // kategorilereGitToolStripMenuItem
            // 
            kategorilereGitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategorilereGitToolStripMenuItem1, kategoriEkleToolStripMenuItem });
            kategorilereGitToolStripMenuItem.Name = "kategorilereGitToolStripMenuItem";
            kategorilereGitToolStripMenuItem.Size = new Size(128, 24);
            kategorilereGitToolStripMenuItem.Text = "Kategorilere Git";
            kategorilereGitToolStripMenuItem.Click += kategorilereGitToolStripMenuItem_Click;
            // 
            // kategorilereGitToolStripMenuItem1
            // 
            kategorilereGitToolStripMenuItem1.Name = "kategorilereGitToolStripMenuItem1";
            kategorilereGitToolStripMenuItem1.Size = new Size(197, 26);
            kategorilereGitToolStripMenuItem1.Text = "Kategorilere Git";
            kategorilereGitToolStripMenuItem1.Click += kategorilereGitToolStripMenuItem1_Click;
            // 
            // kategoriEkleToolStripMenuItem
            // 
            kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            kategoriEkleToolStripMenuItem.Size = new Size(197, 26);
            kategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            kategoriEkleToolStripMenuItem.Click += kategoriEkleToolStripMenuItem_Click;
            // 
            // kumaşlaraGitToolStripMenuItem
            // 
            kumaşlaraGitToolStripMenuItem.Name = "kumaşlaraGitToolStripMenuItem";
            kumaşlaraGitToolStripMenuItem.Size = new Size(115, 24);
            kumaşlaraGitToolStripMenuItem.Text = "Kumaşlara Git";
            kumaşlaraGitToolStripMenuItem.Click += kumaşlaraGitToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(19, 46);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(158, 57);
            button1.TabIndex = 11;
            button1.Text = "Seçili Kullanıcıyı Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(866, 452);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünlereGitToolStripMenuItem;
        private ToolStripMenuItem kategorilereGitToolStripMenuItem;
        private ToolStripMenuItem kumaşlaraGitToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ürünlereGitToolStripMenuItem1;
        private ToolStripMenuItem kategorilereGitToolStripMenuItem1;
        private ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private Button button1;
    }
}
