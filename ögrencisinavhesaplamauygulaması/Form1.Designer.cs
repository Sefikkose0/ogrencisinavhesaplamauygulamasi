﻿namespace ögrencisinavhesaplamauygulaması
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			button1 = new Button();
			listBox1 = new ListBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(46, 46);
			label1.Name = "label1";
			label1.Size = new Size(31, 20);
			label1.TabIndex = 0;
			label1.Text = "Ad:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(24, 89);
			label2.Name = "label2";
			label2.Size = new Size(53, 20);
			label2.TabIndex = 1;
			label2.Text = "Soyad:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(24, 151);
			label3.Name = "label3";
			label3.Size = new Size(59, 20);
			label3.TabIndex = 2;
			label3.Text = "Sınav 1:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(138, 151);
			label4.Name = "label4";
			label4.Size = new Size(59, 20);
			label4.TabIndex = 3;
			label4.Text = "Sınav 2:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(253, 151);
			label5.Name = "label5";
			label5.Size = new Size(46, 20);
			label5.TabIndex = 4;
			label5.Text = "Proje:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(83, 46);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(83, 86);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(89, 148);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(40, 27);
			textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(203, 148);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(40, 27);
			textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(305, 148);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(40, 27);
			textBox5.TabIndex = 9;
			// 
			// button1
			// 
			button1.BackColor = Color.Orange;
			button1.Location = new Point(138, 210);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 10;
			button1.Text = "Hesapla";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.Location = new Point(9, 259);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(359, 164);
			listBox1.TabIndex = 11;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(253, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(115, 101);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 12;
			pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.AppWorkspace;
			ClientSize = new Size(383, 450);
			Controls.Add(pictureBox1);
			Controls.Add(listBox1);
			Controls.Add(button1);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Not Hesaplama";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private Button button1;
		private ListBox listBox1;
		private PictureBox pictureBox1;
	}
}
