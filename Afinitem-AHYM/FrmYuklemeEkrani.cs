using Afinitem_AHYM;
using Aile_Hekimligi_Bilgi_Yonetim_Sistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sunum
{
	public partial class FrmYuklemeEkrani : Form
	{
		public FrmYuklemeEkrani()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.Opacity < 1) this.Opacity += 0.05;
			circularProgressBar2.Value += 1;
			circularProgressBar2.Text = circularProgressBar2.Value.ToString(); 
			if (circularProgressBar2.Value == 100) 
			{
				timer1.Stop();
				timer2.Start();
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			this.Opacity -= 0.1;
			if (this.Opacity == 0)
			{
				timer2.Stop();
				this.Hide();
                FrmAnaSayfa a = new FrmAnaSayfa();
				a.ShowDialog();
				this.Close();
			}

		}

		private void FormWelcome_Load(object sender, EventArgs e)
		{
			this.Opacity = 0.0;
			circularProgressBar2.Value = 0;
			circularProgressBar2.Minimum = 0;
			circularProgressBar2.Maximum = 100;
			timer1.Start();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
