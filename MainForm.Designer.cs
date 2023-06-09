/*
 * Created by SharpDevelop.
 * User: Alunos
 * Date: 06/04/2023
 * Time: 21:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projetoDunderMiflin
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Setor:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Vendas",
			"Contabilidade",
			"Gerência",
			"RH",
			"Estoque"});
			this.comboBox1.Location = new System.Drawing.Point(15, 104);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Contribuição:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(15, 179);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 5;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(185, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(422, 355);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(40, 257);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 34);
			this.button1.TabIndex = 7;
			this.button1.Text = "Add >>";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.MenuBar;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(646, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Setor:";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(643, 68);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(391, 299);
			this.richTextBox2.TabIndex = 10;
			this.richTextBox2.Text = "";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Menu;
			this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(130, 403);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 33);
			this.button2.TabIndex = 11;
			this.button2.Text = "Calcular";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Menu;
			this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(261, 410);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Total:";
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Location = new System.Drawing.Point(844, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 32);
			this.button3.TabIndex = 14;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"Vendas",
			"Contabilidade",
			"Gerência",
			"RH",
			"Estoque"});
			this.comboBox2.Location = new System.Drawing.Point(717, 37);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Menu;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(159, 310);
			this.panel1.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Menu;
			this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(551, 410);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Média:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1082, 472);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.Text = "projetoDunderMiflin";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
