using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class operasyonTipiGuncelleme : Form
    {
        public operasyonTipiGuncelleme()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde firma kodlarını ComboBox'a yükler
        private void operasyonTipiGuncelleme_Load(object sender, EventArgs e)
        {
            LoadFirmaKodlari(); // Firma kodlarını yükle
        }

        // Firma kodlarını ComboBox'a yükler
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

                        // ComboBox'ı verilerle dolduruyoruz
                        cmbFirmaKodu.DataSource = dataTable;
                        cmbFirmaKodu.DisplayMember = "COMTEXT"; // Firma adı
                        cmbFirmaKodu.ValueMember = "COMCODE"; // Firma kodu
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        // Seçilen firma bilgilerini formdaki alanlara aktarır
        public void SetOperasyonTipiBilgileri(string firmaKodu, string operasyonTipiKodu, string operasyonTipiAdi, bool Pasif)
        {
            // Firma kodunu ComboBox'ta seçili hale getiriyoruz
            cmbFirmaKodu.SelectedValue = firmaKodu;

            // Operasyon tipi kodu ve adı TextBox'lara aktarılıyor
            operasyon_tipi_txt.Text = operasyonTipiKodu;
            operasyon_tipi_aciklamasi_txt.Text = operasyonTipiAdi;

            // Aktif bilgisi CheckBox'a atanıyor
            chkPasif.Checked = Pasif;
        }

        // Güncelleme butonuna tıklandığında güncelleme işlemini yapar
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yeniOperasyonTipiKodu = operasyon_tipi_txt.Text;
            string yeniOperasyonTipiAdi = operasyon_tipi_aciklamasi_txt.Text;
            bool yeniPasifDurum = chkPasif.Checked;

            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = "UPDATE BSMSMEOPR001 SET DOCTYPETEXT = @OperasyonTipiAdi, ISPASSIVE = @Pasif " +
                           "WHERE COMCODE = @FirmaKodu AND DOCTYPE = @OperasyonTipiKodu";

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
                        command.Parameters.AddWithValue("@OperasyonTipiKodu", yeniOperasyonTipiKodu);
                        command.Parameters.AddWithValue("@OperasyonTipiAdi", yeniOperasyonTipiAdi);
                        command.Parameters.AddWithValue("@Pasif", yeniPasifDurum);

                        // Güncelleme işlemini gerçekleştir
                        int rowsAffected = command.ExecuteNonQuery();

                        // Güncelleme başarılıysa kullanıcıyı bilgilendir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Operasyon tipi bilgileri başarıyla güncellendi.");
                            this.Close(); // Formu kapat
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu. Lütfen bilgileri kontrol edin.");
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

            // Ver
