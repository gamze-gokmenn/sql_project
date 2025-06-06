﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Crypto.Macs;

namespace sql_project
{
    public class DatabaseManagement
    {
        string conStr = "server=localhost ; Uid = root; pwd = gmz7042; Database= gamze_minikod";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;


        public List<string> kategori_adları()
        {
            string query = "select * from kategoriler ";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                cmd = new MySqlCommand(query, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                List<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["Giyim_Tipi"].ToString());
                }
                conn.Close();
                return list;
            }
        }
        public List<string> kumas_adları()
        {
            string query = "select * from kumas ";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                cmd = new MySqlCommand(query, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                List<string> list = new List<string>();
                while (dr.Read())
                {
                    list.Add(dr["Tip"].ToString());
                }
                conn.Close();
                return list;
            }
        }
        public int kategori_find_id(string ad)
        {
            string query = "SELECT id FROM kategoriler WHERE Giyim_Tipi = @ad";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", ad);

                        object result = cmd.ExecuteScalar(); 
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Kategori bulunamadı.");
                            return 0;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hata: " + e.Message);
                    return 0;
                }
            }
        }

        public int kumas_find_id(string ad)
        {
            string query = "SELECT id FROM kumas WHERE tip = @ad";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", ad);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Böyle bir kumaş bulunamadı.");
                            return 0;
                        }
                    }
                    conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hata: " + e.Message);
                    return 0;
                }
            }
        }

        public void login(string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM kullanıcılar WHERE Mail = @mail AND Parola = @parola";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@parola", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Giriş başarılı!");
                        Form1 frm = new Form1();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı e-posta veya parola.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        public void başlat()
        {
            conn = new MySqlConnection(conStr);
            conn.Open();
        }

        public void kapat()
        {
            conn.Close();
        }

        public DataTable kullaniciler()
        {
            string query = "select * from kullanıcılar ";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                cmd = new MySqlCommand(query, conn);
                DataTable dataTable = new DataTable();

                da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable urunler()
        {
            string query = "select * from ürünler ";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                cmd = new MySqlCommand(query, conn);
                DataTable dataTable = new DataTable();

                da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable aranan_urun(string aranan)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("aranan_ürünler", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@paranan", aranan);
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable tüm_ürünler()
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("tüm_ürünler", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                //conn.Close();
            }

        }
        public void urun_guncelle(string id, string ad, string beden, string fiyat, string stok, string kategori, string renk, string kumas, string marka, string cinsiyet, string maliyet, string kul_id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("ürünler_güncelle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@gad", ad);
                    cmd.Parameters.AddWithValue("@gbeden", beden);
                    cmd.Parameters.AddWithValue("@gfiyat", fiyat);
                    cmd.Parameters.AddWithValue("@gstok", stok);
                    cmd.Parameters.AddWithValue("@gkategori", kategori);
                    cmd.Parameters.AddWithValue("@grenk", renk);
                    cmd.Parameters.AddWithValue("@gkumaş", kumas);
                    cmd.Parameters.AddWithValue("@gmarka", marka);
                    cmd.Parameters.AddWithValue("@gcinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@gmaliyet", maliyet);
                    cmd.Parameters.AddWithValue("@gkullanıcılar_id", kul_id);
                    cmd.Parameters.AddWithValue("@gid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Ürün Güncellendi");
                }
            }
        }

        public void urun_ekle(string ad, string beden, string fiyat, string stok, string kategori, string renk, string kumas, string marka, string cinsiyet, string maliyet, string kul_id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("ürünler_ekle", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pad", ad);
                    cmd.Parameters.AddWithValue("@pbeden", beden);
                    cmd.Parameters.AddWithValue("@pfiyat", fiyat);
                    cmd.Parameters.AddWithValue("@pstok", stok);
                    cmd.Parameters.AddWithValue("@pkategori", kategori);
                    cmd.Parameters.AddWithValue("@prenk", renk);
                    cmd.Parameters.AddWithValue("@pkumaş", kumas);
                    cmd.Parameters.AddWithValue("@pmarka", marka);
                    cmd.Parameters.AddWithValue("@pcinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@pmaliyet", maliyet);
                    cmd.Parameters.AddWithValue("@pkullanıcılar_id", kul_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarılı bir şekilde eklendi");
                    conn.Close();
                }
            }
        }
        public void urun_sil(string id)
        {
            //using (MySqlConnection conn = new MySqlConnection(conStr))
            başlat();
            {
                cmd = new MySqlCommand("ürünler_sil", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pid", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");
            }
            kapat();
        }


        public DataTable sepetler()
        {
            string query = "select * from sepet ";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                cmd = new MySqlCommand(query, conn);
                DataTable dataTable = new DataTable();

                da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);
                return dataTable;
            }
        }


        public DataTable tüm_sepet()
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("tüm_sepetler", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                //conn.Close();
            }

        }
        public void sepet_guncelle(string id, string adet, string toplam_tutar, string urun_id, string kul_id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("sepet_güncelle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@gadet", adet);
                    cmd.Parameters.AddWithValue("@gtoplam_tutar", toplam_tutar);
                    cmd.Parameters.AddWithValue("@gürün_id", urun_id);
                    cmd.Parameters.AddWithValue("@gkullanıcılar_id", kul_id);
                    cmd.Parameters.AddWithValue("@gid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void sepet_ekle(string adet, string toplam_tutar, string urun_id, string kul_id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("sepet_ekle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@padet", adet);
                    cmd.Parameters.AddWithValue("@ptoplam_tutar", toplam_tutar);
                    cmd.Parameters.AddWithValue("@pürün_id", urun_id);
                    cmd.Parameters.AddWithValue("@pkullanıcılar_id", kul_id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Ürün sepete başarılı bir şekilde eklendi");

                }
            }
        }
        public void sepet_sil(string id)
        {
            //using (MySqlConnection conn = new MySqlConnection(conStr))
            başlat();
            {
                cmd = new MySqlCommand("sepet_sil", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pid", id);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Silindi");
            }
            kapat();
        }

        public DataTable kategoriler()
        {
            string query = "select * from kategoriler ";
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                cmd = new MySqlCommand(query, conn);
                DataTable dataTable = new DataTable();

                da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);
                return dataTable;
            }
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
        public DataTable aranan_kumaslar(string aranan)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("aranan_kumaslar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@paranan", aranan);
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable tüm_kumaslar()
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("tüm_kumaslar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                //conn.Close();
            }

        }
        public void kumas_guncelle(string id, string tip, string miktar, string renk, string fiyat, string kul_id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("kumas_güncelle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@gtip", tip);
                    cmd.Parameters.AddWithValue("@gmiktar", miktar);
                    cmd.Parameters.AddWithValue("@grenk", renk);
                    cmd.Parameters.AddWithValue("@gfiyat", fiyat);
                    cmd.Parameters.AddWithValue("@gkullanıcılar_id", kul_id);
                    cmd.Parameters.AddWithValue("@gid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void kumas_ekle(string tip, string miktar, string renk, string fiyat, string kullanıcı_id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("kumas_ekle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pTip", tip);
                    cmd.Parameters.AddWithValue("@pMiktar", miktar);
                    cmd.Parameters.AddWithValue("@pRenk", renk);
                    cmd.Parameters.AddWithValue("@pFiyat", fiyat);
                    cmd.Parameters.AddWithValue("@pKullanıcılar_id", kullanıcı_id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kumaş başarılı bir şekilde eklendi");

                }
            }
        }
        public void kumas_sil(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            //başlat();
            {
                cmd = new MySqlCommand("kumas_sil", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pid", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Silindi");
            }
            //kapat();
        }
        public DataTable aranan_kategoriler(string aranan)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("aranan_kategoriler", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@paranan", aranan);
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable tüm_kategoriler()
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("tüm_kategoriler", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                //conn.Close();
            }

        }
        public void kategori_guncelle(string id, string giyim_tipi)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("kullanıcı_güncelle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ggiyim_tipi", giyim_tipi);
                    cmd.Parameters.AddWithValue("@gid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void kategori_sil(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("kategoriler_sil", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Silindi");
                }
            }
        }

        public void kategori_ekle(string giyim_tipi)
        {
            //using (MySqlConnection conn = new MySqlConnection(conStr))
            başlat();
            {
                cmd = new MySqlCommand("kategoriler_ekle", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pGiyim_Tipi", giyim_tipi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kategori başarılı bir şekilde eklendi");
            }
            kapat();
        }
        //public void urun_ekle(string ad, string beden, string fiyat, string stok, string kategori, string renk, string kumas, string marka, string cinsiyet, string maliyet, string kullanıcılar_id)
        //{
        //    using (MySqlConnection conn = new MySqlConnection(conStr))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand("ürünler_ekle", conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cmd.Parameters.AddWithValue("@pAd", ad);
        //            cmd.Parameters.AddWithValue("@pBeden", beden);
        //            cmd.Parameters.AddWithValue("@pfiyat", fiyat);
        //            cmd.Parameters.AddWithValue("@pstok", stok);
        //            cmd.Parameters.AddWithValue("@pkategori", kategori);
        //            cmd.Parameters.AddWithValue("@prenk", renk);
        //            cmd.Parameters.AddWithValue("@pkumas", kumas);
        //            cmd.Parameters.AddWithValue("@pmarka", marka);
        //            cmd.Parameters.AddWithValue("@pcinsiyet", cinsiyet);
        //            cmd.Parameters.AddWithValue("@pmaliyet", maliyet);
        //            cmd.Parameters.AddWithValue("@pkullanıcılar_id", kullanıcılar_id);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Ürün başarılı bir şekilde eklendi");

        //        }
        //    }
        ////}
        //public void sepet_ekle(string adet, string toplam_tutar, string urun_id, string kullanicilar_id)
        //{
        //    using (MySqlConnection conn = new MySqlConnection(conStr))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand("sepet_ekle", conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cmd.Parameters.AddWithValue("@pAdet", adet);
        //            cmd.Parameters.AddWithValue("@pToplam_Tutar", toplam_tutar);
        //            cmd.Parameters.AddWithValue("@pÜrün_id", urun_id);
        //            cmd.Parameters.AddWithValue("@pKullanıcılar_id", kullanicilar_id);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Sepete başarılı bir şekilde eklendi");
        //        }
        //    }
        //}

        public DataTable aranan_kullanıcılar(string aranan)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("aranan_kullanıcılar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@paranan", aranan);
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable tüm_kullanıcılar()
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                //conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("tüm_kullanıcılar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                //conn.Close();
            }

        }
        public void kullanici_guncelle(string id, string ad_soyad, string mail, string parola, string bakiye, string kullanıcı_rol, string tel)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("kullanıcı_güncelle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@gad_soyad", ad_soyad);
                    cmd.Parameters.AddWithValue("@gmail", mail);
                    cmd.Parameters.AddWithValue("@gparola", parola);
                    cmd.Parameters.AddWithValue("@gbakiye", bakiye);
                    cmd.Parameters.AddWithValue("@gkullanıcı_rol", kullanıcı_rol);
                    cmd.Parameters.AddWithValue("@gtel_no", tel);
                    cmd.Parameters.AddWithValue("@gid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void kullanici_sil(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("kullanıcı_sil", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pid", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Silindi");
                }
            }
        }
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
