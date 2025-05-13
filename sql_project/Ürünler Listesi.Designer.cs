namespace sql_project
{
    partial class Ürünler_Listesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 26);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(799, 309);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Location = new Point(698, 390);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(123, 27);
            button1.TabIndex = 1;
            button1.Text = "Sepete Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Location = new Point(713, 437);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(90, 27);
            button4.TabIndex = 4;
            button4.Text = "Sepete Git";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumAquamarine;
            button5.Location = new Point(383, 390);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(90, 27);
            button5.TabIndex = 5;
            button5.Text = "Bul";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumAquamarine;
            textBox1.Location = new Point(22, 393);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumAquamarine;
            button2.Location = new Point(713, 339);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 47);
            button2.TabIndex = 7;
            button2.Text = "Yenile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Ürünler_Listesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(846, 525);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Ürünler_Listesi";
            Text = "Ürünler_Listesi";
            Load += Ürünler_Listesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Button button2;
    }
}