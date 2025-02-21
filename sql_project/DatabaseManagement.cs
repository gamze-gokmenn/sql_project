using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace sql_project
{
	internal class DatabaseManagement
	{
		string conStr = "server=localhost ; Uid = root; pwd = gmz7042; Database= gamze_minikod";
		MySqlConnection conn;
		MySqlCommand cmd;
		MySqlDataAdapter da;
		MySqlDataReader dr;
		public void baslat()
		{
			conn = new MySqlConnection(conStr);
			conn.Open();
		}
		public void kapat()
		{
			conn.Close();
		}

		public DataTable urunler()
		{
			string query = "select * from kullanıcılar";
			cmd = new MySqlCommand(query, conn);
			DataTable dataTable = new DataTable();

			da = new MySqlDataAdapter(cmd);
			da.Fill(dataTable);
			return dataTable;
		}
		public void kullanici_ekle(string ad_soyad, string mail, string tel_no, string parola, string bakiye, string kullanici_rol)
		{
			string query = "call kullanıcı_ekle(@ad_soyad,@mail,@tel_no,@parola,@bakiye,@kullanici_rol)";

			cmd = new MySqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@ad_soyad", ad_soyad);
			cmd.Parameters.AddWithValue("@mail", mail);
			cmd.Parameters.AddWithValue("@tel_no", tel_no);
			cmd.Parameters.AddWithValue("@parola", parola);
			cmd.Parameters.AddWithValue("@bakiye", bakiye);
			cmd.Parameters.AddWithValue("@kullanici_rol", kullanici_rol);

			try
			{
			cmd.ExecuteNonQuery();

			}
			catch
			{
				MessageBox.Show("Mail Adresi Kullanılmakta");
			}

			MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Eklendi");

			// update kullanıcılar set ad = gad, mail= gmail where id = gid;

		}
	}
}
