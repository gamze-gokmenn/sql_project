namespace sql_project
{
    partial class Kumas_Guncelle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSpringGreen;
            label1.Location = new Point(64, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "TÜR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSpringGreen;
            label2.Location = new Point(64, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "MİKTAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSpringGreen;
            label3.Location = new Point(64, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "RENK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSpringGreen;
            label4.Location = new Point(64, 160);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "FİYAT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSpringGreen;
            label5.Location = new Point(64, 205);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 4;
            label5.Text = "KULLANICI ID";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Aquamarine;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 19);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Aquamarine;
            textBox1.Location = new Point(176, 66);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Aquamarine;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(176, 110);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(146, 28);
            comboBox2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Aquamarine;
            textBox2.Location = new Point(176, 157);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Aquamarine;
            textBox3.Location = new Point(176, 200);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 27);
            textBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(133, 278);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 10;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Kumas_Guncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(373, 360);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Kumas_Guncelle";
            Text = "Kumas_Guncelle";
            Load += Kumas_Guncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}