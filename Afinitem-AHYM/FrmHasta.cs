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
	public partial class FrmHasta : Form
	{
		public FrmHasta()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtHastaTc.Text.Length != 11)
			{
				MessageBox.Show("Tc Kimlik no 11 haneli olmalıdır", "Dikkat");
				return;
			}
			HekimSira hasta = Sql.hastaSorgula(txtHastaTc.Text);
			if (hasta.siraNo == -1)
			{
				MessageBox.Show("Bu ASM'ye kaydınız bulunmamaktadır. Lütfen Yetkili çağırın ve kaydınızı yaptırın.", "Dikkat");
			}
			else
			{
				Sql.sirayaYaz(hasta);
			}


		}
	}
}
