using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aile_Hekimligi_Bilgi_Yonetim_Sistemi
{
	public static class Sql
	{
		private static readonly string ConnectionString = "Server=DESKTOP-VMGC71J;Database=AHYM;Uid=sa;Password=11;";

        public static HekimSira hastaSorgula(string hastaTc)
        {
            SqlConnection newCon = new SqlConnection(ConnectionString);
            newCon.Open();
            MessageBox.Show(hastaTc, hastaTc);
            string sorgu = "select hekimAd, hekimSoyad, hekimTc from DoktorHastalari where hastaTc=@hastaTc";
            HekimSira hekim_sira = new HekimSira(hastaTc);
            SqlCommand command = new SqlCommand(sorgu, newCon);
            command.Parameters.AddWithValue("@hastaTc", hastaTc);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    hekim_sira.hekimAd = reader.GetString(0);
                    hekim_sira.hekimSoyad = reader.GetString(1);
                    hekim_sira.hekimTc = reader.GetString(2);
                    newCon.Close();
                    return (hekim_sira);


                }
            }
            newCon.Close();
            return (hekim_sira);
        }
        public static DataTable tabloGetir()
        {
            SqlConnection newCon = new SqlConnection(ConnectionString);
            newCon.Open();
            string sorgu = "SELECT * FROM BekleyenHastalar";
            SqlCommand command = new SqlCommand(sorgu, newCon);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adap_obj = new SqlDataAdapter(command);
            adap_obj.Fill(dataTable);
            newCon.Close();
            return (dataTable);
        }

        public static bool misafirEkle(MisafirEkle misafir)
        {
            SqlConnection newCon = new SqlConnection(ConnectionString);
            newCon.Open();
            string sorgu = "INSERT DoktorHastalari (hekimTc, hekimAd, hekimSoyad, hastaTc, hastaAd, hastaSoyad, hastaAnneAd, hastaBabaAd, hastaDogumTarih) VALUES (@hekimTc, @hekimAd, @hekimSoyad, @hastaTc, @hastaAd, @hastaSoyad, @hastaAnneAd, @hastaBabaAd, @hastaDogumTarihi)";
            SqlCommand command = new SqlCommand(sorgu, newCon);
            command.Parameters.AddWithValue("@hekimTc", misafir.hekimTc);
            command.Parameters.AddWithValue("@hekimAd", misafir.hekimAd);
            command.Parameters.AddWithValue("@hekimSoyad", misafir.hekimSoyad);
            command.Parameters.AddWithValue("@hastaTc", misafir.hastaTc);
            command.Parameters.AddWithValue("@hastaAd", misafir.hastaAd);
            command.Parameters.AddWithValue("@hastaSoyad", misafir.HastaSoyad);
            command.Parameters.AddWithValue("@hastaAnneAd", misafir.hastaAnneAd);
            command.Parameters.AddWithValue("@hastaBabaAd", misafir.hastaBabaAd);
            command.Parameters.AddWithValue("@hastaDogumTarihi", misafir.hastaDogumTarih);

            MessageBox.Show("!!!!!!!!", "!!!!!");
            command.ExecuteNonQuery();
            newCon.Close();
            return true;

        }
        public static bool sirayaYaz(HekimSira hekim_sira)
        {
            SqlConnection newCon = new SqlConnection(ConnectionString);
            newCon.Open();
            string sorgu = "INSERT BekleyenHastalar (hastaTc, bagliHekimTc, siraNo, durum) VALUES (@hastaTc, @bagliHekimTc, @siraNo, @durum)";
            SqlCommand command = new SqlCommand(sorgu);
            command.Connection = newCon;
            command.Parameters.AddWithValue("@hastaTc", hekim_sira.hastaTc);
            command.Parameters.AddWithValue("@bagliHekimTc", hekim_sira.hekimTc);
            command.Parameters.AddWithValue("@siraNo", 2);
            command.Parameters.AddWithValue("@durum", "Bekliyor");


            command.ExecuteNonQuery();
            newCon.Close();
            return true;

        }

    }
}
