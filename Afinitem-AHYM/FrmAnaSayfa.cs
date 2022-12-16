using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aile_Hekimligi_Bilgi_Yonetim_Sistemi
{
	public partial class FrmAnaSayfa : Form
	{
		public FrmAnaSayfa()
		{
			InitializeComponent();
			dataGridView1.DataSource = Sql.tabloGetir();
		}

		private void btn_hasta_giris_ekrani_getir_Click(object sender, EventArgs e)
		{
            this.Hide();
            FrmHasta a = new FrmHasta();

            a.ShowDialog();
            this.Show();
        }

		private void afiButton1_Click(object sender, EventArgs e)
		{
		}

		private void btn_misafir_ekle_Click(object sender, EventArgs e)
		{
            FrmMisafirEkle form = new FrmMisafirEkle();
            form.Show();
        }

		private void btn_sira_no_kaldir_Click(object sender, EventArgs e)
		{
			Sql.tabloSil();
		}
	}
}
