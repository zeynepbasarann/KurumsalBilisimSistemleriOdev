using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class birimGuncelleme : Form
    {
        public birimGuncelleme()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde firma kodlarını ComboBox'a yükler
        private void birimGuncelleme_Load(object sender, EventArgs e)
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
        public void SetBirimBilgileri(string firmaKodu, string birimKodu, string birimAdi, bool AnaBirim, string anaBirimKodu)
        {
            // Firma kodunu ComboBox'ta seçili hale getiriyoruz
            cmbFirmaKodu.SelectedValue = firmaKodu;

            // Dil kodu ve dil adını TextBox'lara aktarıyoruz
            birim_kodu_txt.Text = birimKodu;
            ana_birim_kodu_txt.Text = anaBirimKodu;
            birim_adi_txt.Text = birimAdi;
            chkAnaBirim.Checked = AnaBirim;
        }

        // Güncelleme butonuna tıklandığında güncelleme işlemini yapar
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yenibirimKodu = birim_kodu_txt.Text;
            string yenibirimAdi = birim_adi_txt.Text;
            bool yeniAnaBirimDurum = chkAnaBirim.Checked;
            string yenianaBirimKodu = ana_birim_kodu_txt.Text;

            // Veritabanına güncelleme işlemini yapalım
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = "UPDATE BSMSMEGEN005 SET UNITTEXT = @BirimAdi ,ISMAINUNIT = @AnaBirim  " +
                "WHERE COMCODE = @FirmaKodu AND UNITCODE = @BirimKodu";

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
                        command.Parameters.AddWithValue("@BirimKodu", yenibirimKodu);
                        command.Parameters.AddWithValue("@BirimAdi", yenibirimAdi);
                        command.Parameters.AddWithValue("@AnaBirim", yeniAnaBirimDurum);
                        command.Parameters.AddWithValue("@AnaBirimKodu", yenianaBirimKodu);

                        // Veritabanına kaydet
                        int rowsAffected = command.ExecuteNonQuery();

                        // Güncelleme başarılıysa kullanıcıyı bilgilendir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Rota tipi bilgileri başarıyla güncellendi.");
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
