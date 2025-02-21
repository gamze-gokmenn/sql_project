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


		public DataTable kullaniciler()
		{
			string query = "select * from kullanıcılar";
			cmd = new MySqlCommand(query, conn);
			DataTable dataTable = new DataTable();

			da = new MySqlDataAdapter(cmd);
			da.Fill(dataTable);
			return dataTable;
		}


		//using (MySqlCommand cmd = new MySqlCommand("GetStudentCount", conn))
		//{
		//	cmd.CommandType = CommandType.StoredProcedure;

		//	MySqlParameter outputParam = new MySqlParameter("@studentCount", MySqlDbType.Int32);
		//	outputParam.Direction = ParameterDirection.Output;
		//	cmd.Parameters.Add(outputParam);

		//	cmd.ExecuteNonQuery();

		//	int count = Convert.ToInt32(cmd.Parameters["@studentCount"].Value);
		//	Console.WriteLine($"Toplam öğrenci sayısı: {count}");
		//}
		public void kullanici_ekle(string adSoyad, string mail, string telNo, string parola, string bakiye, string kullaniciRol)
		{
			using (MySqlConnection conn = new MySqlConnection(conStr))
			{
				using (MySqlCommand cmd = new MySqlCommand("kullanıcı_ekle", conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@pAd_Soyad", adSoyad);
					cmd.Parameters.AddWithValue("@pmail", mail);
					cmd.Parameters.AddWithValue("@pTel_no", telNo);
					cmd.Parameters.AddWithValue("@pParola", parola);
					cmd.Parameters.AddWithValue("@PBakiye", bakiye);
					cmd.Parameters.AddWithValue("@pKullanıcı_rol", kullaniciRol);

					try
					{
						conn.Open();
						int affectedRows = cmd.ExecuteNonQuery();

						if (affectedRows > 0)
						{
							MessageBox.Show("Kullanıcı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Kullanıcı eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (MySqlException ex)
					{
						if (ex.Number == 1062) // Duplicate Entry Hatası (Mail Zaten Kayıtlı)
						{
							MessageBox.Show("Mail adresi zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else
						{
							MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
