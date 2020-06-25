using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			zmon = new List<ManoVisiZmones>()
			{
				new ManoVisiZmones(){id=1, Vardas = "Roka", UserName = "fbla"},
				new ManoVisiZmones(){id=1, Vardas = "Rogka", UserName = "bsla" },
				new ManoVisiZmones(){id=1, Vardas = "Rodka", UserName = "blfa" }
			};

		}

		private void button1_Click(object sender, EventArgs e)
		{
			mygtukas.Text = "Paspaudziau mygutką!";
			string tekstas = "Jus ivedete " + userText.Text + " " + pswrdText.Text;
			MessageBox.Show("Mano sugeneruotas message boksas!");
			if (Varnele_checkBox.Checked)
			{
				duomenuAtvaizdavimas.DataSource = zmon;
			}
			loginBox1.Visible = !loginBox1.Visible;
			pictureBoxNuotrauka.BackgroundImage = Image.FromFile(@"D:\Pictures\Deep-Blue-Gradient-4K-Wallpaper-7103.jpg");
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}


	class ManoVisiZmones
	{
		public int id { get; set; }
		public string Vardas { get; set; }
		public string UserName { get; set; }
	}
}
