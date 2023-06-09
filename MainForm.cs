/*
 * Created by SharpDevelop.
 * User: Alunos
 * Date: 06/04/2023
 * Time: 21:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projetoDunderMiflin
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Limpar() {
			textBox1.Clear();
			textBox2.Clear();
		}
		void Button1Click(object sender, EventArgs e)
		{	
			if (textBox1.Text != "" && comboBox1.Text != "" && textBox2.Text != "" ) {
				
			string registro = textBox1.Text + "\t" + comboBox1.Text + "\t" + textBox2.Text;
			richTextBox1.Text += registro + "\n";
			Limpar();
			textBox1.Focus();
			
			richTextBox1.SaveFile("Contribuicao_funcionarios.txt", RichTextBoxStreamType.PlainText);
			MessageBox.Show("Arquivo salvo!");
			}
			else {
				MessageBox.Show("Preencha todos os campos!");
			}
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try 
			{
				richTextBox1.LoadFile("Contribuicao_funcionarios.txt", RichTextBoxStreamType.PlainText);
			} catch
			{
				
			}
		}
		void Button3Click(object sender, EventArgs e)
		{	
			if (comboBox2.Text == "Gerência") {
				richTextBox2.Clear();
			
				for (int i=0; i<richTextBox1.Lines.Length-1; i++) {
					string[] dados1 = richTextBox1.Lines[i].Split('\t');
				
					if (dados1[1] == "Gerência") {
						richTextBox2.Text += dados1[0] + "\t" + dados1[1] + "\t" + dados1[2] + "\n";
					}
				}
			}
			if (comboBox2.Text == "Vendas") {
				richTextBox2.Clear();
			
				for (int i=0; i<richTextBox1.Lines.Length-1; i++) {
					string[] dados2 = richTextBox1.Lines[i].Split('\t');
				
					if (dados2[1] == "Vendas") {
						richTextBox2.Text += dados2[0] + "\t" + dados2[1] + "\t" + dados2[2] + "\n";
					}
				}
			}
			if (comboBox2.Text == "Contabilidade") {
				richTextBox2.Clear();
			
				for (int i=0; i<richTextBox1.Lines.Length-1; i++) {
					string[] dados3 = richTextBox1.Lines[i].Split('\t');
				
					if (dados3[1] == "Contabilidade") {
						richTextBox2.Text += dados3[0] + "\t" + dados3[1] + "\t" + dados3[2] + "\n";
					}
				}		
			}
			if (comboBox2.Text == "RH") {
				richTextBox2.Clear();
			
				for (int i=0; i<richTextBox1.Lines.Length-1; i++) {
					string[] dados3 = richTextBox1.Lines[i].Split('\t');
				
					if (dados3[1] == "RH") {
						richTextBox2.Text += dados3[0] + "\t" + dados3[1] + "\t" + dados3[2] + "\n";
					}
				}		
			}
			if (comboBox2.Text == "Estoque") {
				richTextBox2.Clear();
			
				for (int i=0; i<richTextBox1.Lines.Length-1; i++) {
					string[] dados3 = richTextBox1.Lines[i].Split('\t');
				
					if (dados3[1] == "Estoque") {
						richTextBox2.Text += dados3[0] + "\t" + dados3[1] + "\t" + dados3[2] + "\n";
					}
				}		
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			float valores = 0;
			
			for (int i=0; i<richTextBox1.Lines.Length-1; i++) {
				string[] dados4 = richTextBox1.Lines[i].Split('\t');
				
				valores += float.Parse(dados4[2]);
			}
			float media = valores / (richTextBox1.Lines.Length-1);
			
			label5.Text = "Total:" + valores.ToString("R$ #, ###, ##0.00");
			label6.Text = "Média:" + media.ToString("R$ #, ###, ##0.00");
			
		}
	}
}
