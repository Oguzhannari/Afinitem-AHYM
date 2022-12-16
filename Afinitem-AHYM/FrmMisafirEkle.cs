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
	public partial class FrmMisafirEkle : Form
	{
		public FrmMisafirEkle()
		{
			InitializeComponent();
		}

		private void btn_kaydet_Click(object sender, EventArgs e)
		{
			MisafirEkle misafir = new MisafirEkle();
			misafir.hekimTc = tb_hekimTc.Texts;
			misafir.hekimAd = tb_hekimAd.Texts;
			misafir.hekimSoyad = tb_hekimSoyad.Texts;
			misafir.hastaTc = tb_hastaTc.Texts;
			misafir.hastaAd = tb_hastaAd.Texts;
			misafir.HastaSoyad = tb_hastaSoyad.Texts;
			misafir.hastaAnneAd = tb_hastaAnneAd.Texts;
			misafir.hastaBabaAd = tb_hastaBabaAd.Texts;
			misafir.hastaDogumTarih = dp_dogumTarihi.Value.ToString("yyyy-MM-dd HH:mm:ss");
			Sql.misafirEkle(misafir);
		}
	}
}
