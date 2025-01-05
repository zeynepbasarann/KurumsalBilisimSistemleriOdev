using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class urunAgaciGuncelleme : Form
    {
        public urunAgaciGuncelleme()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde firma kodlarını ComboBox'a yükler
        private void urunAgaciGuncelleme_Load(object sender, EventArgs e)
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
        public void SetUrunAgaciBilgileri(string firmaKodu, string urunAgaciKodu, string urunAgaciAdi, bool Pasif)
        {
            // Firma kodunu ComboBox'ta seçili hale getiriyoruz
            cmbFirmaKodu.SelectedValue = firmaKodu;

            // Dil kodu ve dil adını TextBox'lara aktarıyoruz
            urun_agaci_tipi_txt.Text = urunAgaciKodu;
            urun_agaci_aciklamasi_txt.Text = urunAgaciAdi;
            chkPasif.Checked = Pasif;
        }

        // Güncelleme butonuna tıklandığında güncelleme işlemini yapar
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yeniurunAgaciKodu = urun_agaci_tipi_txt.Text;
            string yeniurunAgaciAdi = urun_agaci_aciklamasi_txt.Text;
            bool yeniPasifDurum = chkPasif.Checked;

            // Veritabanına güncelleme işlemini yapalım
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = "UPDATE BSMSMEBOM001 SET DOCTYPETEXT = @UrunAgaciAdi ,ISPASSIVE = @Pasif  " +
                "WHERE COMCODE = @FirmaKodu AND DOCTYPE = @UrunAgaciKodu";

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
                        command.Parameters.AddWithValue("@UrunAgaciKodu", yeniurunAgaciKodu);
                        command.Parameters.AddWithValue("@UrunAgaciAdi", yeniurunAgaciAdi);
                        command.Parameters.AddWithValue("@Pasif", yeniPasifDurum);

                        // Veritabanına kaydet
                        int rowsAffected = command.ExecuteNonQuery();

                        // Güncelleme başarılıysa kullanıcıyı bilgilendir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Malzeme tipi bilgileri başarıyla güncellendi.");
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
