namespace sql_project
{
	partial class LoginForm
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			label3 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(92, 88);
			label1.Name = "label1";
			label1.Size = new Size(41, 20);
			label1.TabIndex = 0;
			label1.Text = "Mail:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(92, 126);
			label2.Name = "label2";
			label2.Size = new Size(53, 20);
			label2.TabIndex = 1;
			label2.Text = "Parola:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(157, 90);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "deneme@gmail.com";
			textBox1.Size = new Size(188, 27);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(157, 123);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 3;
			textBox2.UseSystemPasswordChar = true;
			// 
			// button1
			// 
			button1.Location = new Point(170, 178);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 4;
			button1.Text = "Giriş Yap";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(106, 239);
			label3.Name = "label3";
			label3.Size = new Size(225, 20);
			label3.TabIndex = 5;
			label3.Text = "Kayıl Olmak İçin Lütfen Tıklayınız";
			// 
			// button2
			// 
			button2.Location = new Point(337, 235);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 6;
			button2.Text = "Kayıt Ol";
			button2.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(510, 326);
			Controls.Add(button2);
			Controls.Add(label3);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "LoginForm";
			Text = "LoginForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private Label label3;
		private Button button2;
	}
}