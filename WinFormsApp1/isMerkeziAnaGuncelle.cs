using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class isMerkeziAnaGuncelle : Form
    {
        public isMerkeziAnaGuncelle()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

        // Form yüklenirken ComboBox'ları doldur

        // Seçilen firma bilgilerini formdaki alanlara aktarır
        public void SetIsMerkeziBilgileri(string firmaKodu,string dilKodu,string isMerkeziTipi,string isMerkeziKodu,
            DateTime gecBaslangic,DateTime gecBitis,
            string anaIsMerkeziTipi,string kisaAciklama,string uzunAciklama,bool pasif,
            string anaIsMerkeziKodu,string maliyetMerkeziTipi,
            string maliyetMerkeziKodu,decimal calismaSuresi,bool silindi, string operasyonKodu)
        {
            cmbFirmaKodu.Text = firmaKodu;
            cmbDilKodu.Text = dilKodu;
            cmbIsMerkeziTipi.Text = isMerkeziTipi;
            is_merkezi_kodu_txt.Text = isMerkeziKodu;
            dtpGBas.Value = gecBaslangic;
            dtpGBitis.Value = gecBitis;
            ana_is_merkezi_tipi.Text = anaIsMerkeziTipi;
            kisa_aciklama_txt.Text = kisaAciklama;
            uzun_aciklama_txt.Text = uzunAciklama;
            chkPasif.Checked = pasif;
            ana_is_merkezi_kodu.Text = anaIsMerkeziKodu;
            cmbMaliyetMerkeziTipi.Text = maliyetMerkeziTipi;
            maliyet_merkezi_kodu.Text = maliyetMerkeziKodu;
            calisma_suresi_txt.Text = calismaSuresi.ToString();
            chkSil.Checked = silindi;
            operasyon_kodu_txt.Text = operasyonKodu;

        }

        // Güncelleme butonuna tıklandığında veritabanı güncelleme işlemi


        // Güncelleme sayfasına gönderilen veriler


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al

            string yeniDilKodu = cmbDilKodu.SelectedValue.ToString();
            string yeniIsMerkeziTipi = cmbIsMerkeziTipi.SelectedValue.ToString();
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yeniIsMerkeziKodu = is_merkezi_kodu_txt.Text;
            DateTime yenigecBaslangic = dtpGBas.Value;
            DateTime yeniBitis = dtpGBitis.Value;
            string yeniAnaIsMerkeziTipi = ana_is_merkezi_tipi.Text;
            string yeniAnaIsMerkeziKodu = ana_is_merkezi_kodu.Text;
            string yeniuzunAciklama = uzun_aciklama_txt.Text;
            string yenikisaAciklama = kisa_aciklama_txt.Text;
            bool yeniPasifDurum = chkPasif.Checked;
            string yeniMaliyetMerkezi = cmbMaliyetMerkeziTipi.SelectedValue.ToString();
            string yeniMaliyetMerkeziKodu = maliyet_merkezi_kodu.Text;
            decimal yeniCalismaSuresi = decimal.Parse(calisma_suresi_txt.Text);
            bool yeniSil = chkSil.Checked;
            string yeniOperasyonKodu = operasyon_kodu_txt.Text;





            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = @"
                UPDATE BSMSMEWCMTEXT SET WCMDOCTYPE =@IsMerkeziTipi, WCMDOCFROM= @GBaslangic, WCMDOCUNTIL = @GBitis, LANCODE= @DilKodu, WCMLTEXT = @UzunAciklama, WCMSTEXT = @KisaAciklama WHERE COMCODE = @FirmaKodu AND WCMDOCNUM = @IsMerkeziKodu;
                UPDATE BSMSMEWCMHEAD SET WCMDOCTYPE = @IsMerkeziTipi, WCMDOCFROM = @GBaslangic, WCMDOCUNTIL = @GBitis  
                   ,MAINWCMDOCTYPE = @AnaIsMerkeziTipi ,MAINWCMDOCNUM = @AnaIsMerkeziKodu ,CCMDOCTYPE = @MaliyetMerkezi ,CCMDOCNUM = @MaliyetMerkeziKodu ,WORKTIME = @CalismaSuresi , 
                   ISDELETED = @Silindi, ISPASSIVE = @PasifMi WHERE COMCODE = @FirmaKodu AND WCMDOCNUM = @IsMerkeziKodu;
                UPDATE BSMSMEWCMOPR SET WCMDOCTYPE =@IsMerkeziTipi, WCMDOCFROM= @GBaslangic, WCMDOCUNTIL = @GBitis, OPRDOCTYPE = @OperasyonKodu WHERE COMCODE = @FirmaKodu AND WCMDOCNUM = @IsMerkeziKodu;
";
                
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FirmaKodu", yeniFirmaKodu);
                        command.Parameters.AddWithValue("@IsMerkeziTipi", yeniIsMerkeziTipi);
                        command.Parameters.AddWithValue("@IsMerkeziKodu", yeniIsMerkeziKodu);
                        command.Parameters.AddWithValue("@GBaslangic", yenigecBaslangic);
                        command.Parameters.AddWithValue("@GBitis", yeniBitis);
                        command.Parameters.AddWithValue("@AnaIsMerkeziTipi", yeniAnaIsMerkeziTipi);
                        command.Parameters.AddWithValue("@DilKodu", yeniDilKodu);
                        command.Parameters.AddWithValue("@AnaIsMerkeziKodu", yeniAnaIsMerkeziKodu);
                        command.Parameters.AddWithValue("@MaliyetMerkezi", yeniMaliyetMerkezi);
                        command.Parameters.AddWithValue("@MaliyetMerkeziKodu", yeniMaliyetMerkeziKodu);
                        command.Parameters.AddWithValue("@CalismaSuresi", yeniCalismaSuresi);
                        command.Parameters.AddWithValue("@Silindi", yeniSil);
                        command.Parameters.AddWithValue("@PasifMi", yeniPasifDurum);
                        command.Parameters.AddWithValue("@UzunAciklama", yeniuzunAciklama);
                        command.Parameters.AddWithValue("@KisaAciklama", yenikisaAciklama);
                        command.Parameters.AddWithValue("@OperasyonKodu", yeniOperasyonKodu);



                        // Sorguyu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Veri başarıyla kaydedildi." : "Kayıt işlemi başarısız oldu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }
        private void isMerkeziAnaGuncelle_Load(object sender, EventArgs e)
        {
            PopulateComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMCODE", "COMTEXT");
            PopulateComboBox("SELECT LANCODE, LANTEXT FROM BSMSMEGEN002", cmbDilKodu, "LANCODE", "LANTEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEWCM001", cmbIsMerkeziTipi, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMECCM001", cmbMaliyetMerkeziTipi, "DOCTYPE", "DOCTYPETEXT");
           


        }

        // ComboBox doldurma metodu
        private void PopulateComboBox(string query, ComboBox comboBox, string valueMember, string displayMember)
        {
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
                        comboBox.DataSource = dataTable;
                        comboBox.ValueMember = valueMember;
                        comboBox.DisplayMember = displayMember;
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
