using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aile_Hekimligi_Bilgi_Yonetim_Sistemi
{
	public class HekimSira
	{
		public string hastaTc { get; set; }

		public string hekimAd { get; set; }
		public string hekimSoyad { get; set; }
		public string hekimTc { get; set; }
		public int siraNo { get; set; }
		public string durum { get; set; }
		public HekimSira(string m_hekimAd, string m_hekimSoyad, int m_siraNo)
		{
			hekimAd = m_hekimAd;
			hekimSoyad = m_hekimSoyad;
			siraNo = m_siraNo;
		}
		public HekimSira(string m_hastaTc)
		{
			hastaTc = m_hastaTc;
			siraNo = -1;
		}
	}
}
