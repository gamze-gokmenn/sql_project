namespace sql_project
{
    partial class Kumas
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            comboBox2 = new ComboBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Location = new Point(172, 438);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Moccasin;
            textBox1.Location = new Point(52, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Tip";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Moccasin;
            textBox2.Location = new Point(52, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "Miktar";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Moccasin;
            textBox3.Location = new Point(52, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 3;
            textBox3.Text = "Renk";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Moccasin;
            textBox4.Location = new Point(52, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 4;
            textBox4.Text = "Fiyat";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Moccasin;
            textBox5.Location = new Point(52, 359);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 5;
            textBox5.Text = "Kullanıcı ID";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PaleGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.PaleGreen;
            textBox6.Location = new Point(243, 119);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 31);
            textBox6.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.PaleGreen;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(243, 199);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.PaleGreen;
            textBox7.Location = new Point(243, 279);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(182, 31);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.PaleGreen;
            textBox8.Location = new Point(243, 359);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(182, 31);
            textBox8.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(148, 507);
            button2.Name = "button2";
            button2.Size = new Size(162, 34);
            button2.TabIndex = 11;
            button2.Text = "Kumaşları Listele";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Kumas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(494, 630);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(comboBox2);
            Controls.Add(textBox6);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Kumas";
            Text = "Kumas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private ComboBox comboBox2;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button2;
    }
}