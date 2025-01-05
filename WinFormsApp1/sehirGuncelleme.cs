using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class sehirGuncelleme : Form
    {
        public sehirGuncelleme()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde firma kodlarını ComboBox'a yükler
        private void sehirGuncelleme_Load(object sender, EventArgs e)
        {
            LoadFirmaKodlari(); // Firma kodlarını yükle
        }

        // Firma kodlarını ComboBox'a yükler
        private void LoadFirmaKodlari()
        {
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = "SELECT COMCODE, COMTEXT FROM BSMSMEGEN001"; // Firma kodu ve adı sorgusu
            string query2 = "SELECT COUNTRYCODE, COUNTRYTEXT FROM BSMSMEGEN003";

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
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Combine COMCODE and COMTEXT into a single column for display
                        dataTable.Columns.Add("Display", typeof(string));
                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Display"] = row["COUNTRYCODE"].ToString() + " - " + row["COUNTRYTEXT"].ToString();
                        }

                        // Bind the ComboBox to the new Display column
                        cmbUlkeKodu.DataSource = dataTable;
                        cmbUlkeKodu.DisplayMember = "Display"; // Show the combined value
                        cmbUlkeKodu.ValueMember = "COUNTRYCODE"; // Use the COMCODE as the value
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        // Seçilen firma bilgilerini formdaki alanlara aktarır
        public void SetSehirBilgileri(string firmaKodu, string sehirKodu, string sehirAdi, string ulkeKodu)
        {
            // Firma kodunu ComboBox'ta seçili hale getiriyoruz
            cmbFirmaKodu.SelectedValue = firmaKodu;
            cmbUlkeKodu.SelectedValue = ulkeKodu;

            // Dil kodu ve dil adını TextBox'lara aktarıyoruz
            sehir_kodu_txt.Text = sehirKodu;
            sehir_adi_txt.Text = sehirAdi;
        }

        // Güncelleme butonuna tıklandığında güncelleme işlemini yapar
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yeniUlkeKodu = cmbUlkeKodu.SelectedValue.ToString();
            string yeniSehirKodu = sehir_kodu_txt.Text;
            string yeniSehirAdi = sehir_adi_txt.Text;

            // Veritabanına güncelleme işlemini yapalım
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = "UPDATE BSMSMEGEN004 SET CITYTEXT = @SehirAdi WHERE COMCODE = @FirmaKodu AND CITYCODE = @SehirKodu AND COUNTRYCODE = @UlkeKodu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL komutunu oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FirmaKodu", yeniFirmaKodu);
                        command.Parameters.AddWithValue("@SehirKodu", yeniSehirKodu);
                        command.Parameters.AddWithValue("@SehirAdi", yeniSehirAdi);
                        command.Parameters.AddWithValue("@UlkeKodu", yeniUlkeKodu);

                        // Veritabanına kaydet
                        int rowsAffected = command.ExecuteNonQuery();

                        // Güncelleme başarılıysa kullanıcıyı bilgilendir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dil bilgileri başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu.");
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
