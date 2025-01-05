﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class birimEkle : Form
    {
        public birimEkle()
        {
            InitializeComponent();
        }

        private void birimEkle_Load(object sender, EventArgs e)
        {
            // Firma kodlarını ComboBox'a doldur
            LoadFirmaKodlari();
        }

        private void LoadFirmaKodlari()
        {
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = "SELECT COMCODE, COMTEXT FROM BSMSMEGEN001"; // Firma kodu ve adı sorgusu

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Combine COMCODE and COMTEXT into a single column for display
                        dataTable.Columns.Add("Display", typeof(string));
                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Display"] = row["COMCODE"].ToString() + " - " + row["COMTEXT"].ToString();
                        }

                        // Bind the ComboBox to the new Display column
                        cmbFirmaKodu.DataSource = dataTable;
                        cmbFirmaKodu.DisplayMember = "Display"; // Show the combined value
                        cmbFirmaKodu.ValueMember = "COMCODE"; // Use the COMCODE as the value
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Seçilen firma kodunu al
            string selectedFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();

            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

            // Insert sorgusu (Bu örnek sadece Firma Kodu ekliyor, eklemek istediğiniz diğer alanları da ekleyebilirsiniz)
            string query = "INSERT INTO BSMSMEGEN005 (COMCODE, UNITCODE, UNITTEXT, ISMAINUNIT, MAINUNITCODE) VALUES (@FirmaKodu, @BirimKodu, @BirimAdı, @AnaBirim, @AnaBirimKodu)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL komutunu oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreyi ekle
                        command.Parameters.AddWithValue("@FirmaKodu", selectedFirmaKodu);
                        command.Parameters.AddWithValue("@BirimKodu", birim_kodu_txt.Text);
                        command.Parameters.AddWithValue("@BirimAdı", birim_adi_txt.Text);
                        command.Parameters.AddWithValue("@AnaBirimKodu", ana_birim_kodu_txt.Text);
                        command.Parameters.AddWithValue("@AnaBirim", chkAnaBirim.Checked); // Aktif mi? bilgisi
                        // Veritabanına kaydet
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kayıt işlemi başarılıysa kullanıcıyı bilgilendir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Firma Kodu başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt işlemi başarısız oldu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

    }
}
