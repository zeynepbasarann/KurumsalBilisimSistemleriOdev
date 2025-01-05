using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class maliyetMerkeziGuncelleme : Form
    {
        public maliyetMerkeziGuncelleme()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde firma kodlarını ComboBox'a yükler
        private void maliyetMerkeziGuncelleme_Load(object sender, EventArgs e)
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
        public void SetMaliyetMerkeziBilgileri(string firmaKodu, string maliyetMerkeziKodu, string maliyetMerkeziAdi, bool Pasif)
        {
            // Firma kodunu ComboBox'ta seçili hale getiriyoruz
            cmbFirmaKodu.SelectedValue = firmaKodu;

            // Dil kodu ve dil adını TextBox'lara aktarıyoruz
            maliyet_merkezi_kodu_txt.Text = maliyetMerkeziKodu;
            maliyet_merkezi_aciklamasi_txt.Text = maliyetMerkeziAdi;
            chkPasif.Checked = Pasif;
        }

        // Güncelleme butonuna tıklandığında güncelleme işlemini yapar
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yenimaliyetMerkeziKodu = maliyet_merkezi_kodu_txt.Text;
            string yenimaliyetMerkeziAdi = maliyet_merkezi_aciklamasi_txt.Text;
            bool yeniPasifDurum = chkPasif.Checked;

            // Veritabanına güncelleme işlemini yapalım
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = "UPDATE BSMSMECCM001 SET DOCTYPETEXT = @MaliyetMerkeziAdi ,ISPASSIVE = @Pasif  " +
                "WHERE COMCODE = @FirmaKodu AND DOCTYPE = @MaliyetMerkeziKodu";

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
                        command.Parameters.AddWithValue("@MaliyetMerkeziKodu", yenimaliyetMerkeziKodu);
                        command.Parameters.AddWithValue("@MaliyetMerkeziAdi", yenimaliyetMerkeziAdi);
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
