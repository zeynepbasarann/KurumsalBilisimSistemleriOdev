using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UrunAgaciAnaGuncelle : Form
    {
        public UrunAgaciAnaGuncelle()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

        // Form yüklenirken ComboBox'ları doldur

        // Seçilen firma bilgilerini formdaki alanlara aktarır
        public void SetUrunAgaciAnaBilgileri(string firmaKodu,
            DateTime GBaslangic, DateTime GBitis,
            string malzemeTipi, string malzemeKodu, bool pasif,
            string icerikNumarasi, decimal bilesenMiktari, string urunAgaciTipi, string urunAgaciKodu,
            string bilesenKodu,
            string cizimNumarasi, bool silindi, decimal temelMiktar, string kalemUrunAgaciKodu, string kalemUrunAgaciTipi)

        {
            cmbFirmaKodu.Text = firmaKodu;
            dtpGBas.Value = GBaslangic;
            dtpGBitis.Value = GBitis;
            cmbMalzemeTipi.Text = malzemeTipi;
            malzeme_kodu_txt.Text = malzemeKodu;
            chkPasif.Checked = pasif;
            icerik_numarasi_txt.Text = icerikNumarasi;
            bilesen_miktar_txt.Text = bilesenMiktari.ToString();
            cmbUrunAgaciTipi.Text = urunAgaciTipi;
            urun_agaci_kodu_txt.Text = urunAgaciKodu;
            kalem_urun_agaci_kodu.Text = kalemUrunAgaciTipi;
            cmbKalemUrunAgaciTipi.Text = kalemUrunAgaciTipi;
            bilesen_kodu_txt.Text = bilesenKodu;
            cizim_numarasi_txt.Text = cizimNumarasi;
            chkSil.Checked = silindi;
            temel_miktar_txt.Text = temelMiktar.ToString();

        }

        // Güncelleme butonuna tıklandığında veritabanı güncelleme işlemi


        // Güncelleme sayfasına gönderilen veriler


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al


            
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            DateTime yenigecBaslangic = dtpGBas.Value;
            DateTime yeniBitis = dtpGBitis.Value;
            string yeniMalzemeKodu = malzeme_kodu_txt.Text;
            string yeniMalzemeTipi = cmbMalzemeTipi.SelectedValue.ToString();
            bool yeniPasif = chkPasif.Checked;
            decimal yeniTemelMiktar = decimal.Parse(temel_miktar_txt.Text);
            decimal yeniBilesenMiktar = decimal.Parse(bilesen_miktar_txt.Text);
            string yeniBilesenKodu = bilesen_kodu_txt.Text;
            string yeniIcerikNumarasi = icerik_numarasi_txt.Text;
            string yeniUrunAgaciKodu = urun_agaci_kodu_txt.Text;
            string yeniUrunAgaciTipi = cmbUrunAgaciTipi.SelectedValue.ToString();
            string yeniCizimNumarasi = cizim_numarasi_txt.Text;
            string yeniKalemUrunAgaciTipi = cmbKalemUrunAgaciTipi.SelectedValue.ToString();
            string yeniKalemUrunAgaciKodu = kalem_urun_agaci_kodu.Text;
            bool yeniSil = chkSil.Checked;


            if (string.IsNullOrWhiteSpace(yeniFirmaKodu) || string.IsNullOrWhiteSpace(yeniUrunAgaciTipi))
            {
                MessageBox.Show("Firma Kodu veya Rota Kodu eksik.");
                return;
            }


            // Veritabanı bağlantı dizesi
            //string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = @"
                UPDATE BSMSMEBOMHEAD SET BOMDOCTYPE =@UrunAgaciTipi,BOMDOCNUM = @UrunAgaciKodu ,BOMDOCFROM= @GBaslangic, BOMDOCUNTIL = @GBitis,MATDOCTYPE = @MalzemeTipi, MATDOCNUM = @MalzemeKodu,QUANTITY = @TemelMiktar, ISDELETED = @Silindi, ISPASSIVE = @Pasif, DRAWNUM = @CizimNumarasi  WHERE COMCODE = @FirmaKodu AND BOMDOCNUM = @UrunAgaciKodu;
                UPDATE BSMSMEBOMCONTENT SET BOMDOCTYPE =@UrunAgaciTipi ,BOMDOCNUM = @UrunAgaciKodu ,BOMDOCFROM= @GBaslangic, BOMDOCUNTIL = @GBitis,MATDOCTYPE = @MalzemeTipi, MATDOCNUM = @MalzemeKodu,CONTENTNUM = @IcerikNumarasi ,COMPONENT = @BilesenKodu, COMPBOMDOCTYPE = @KalemUrunAgaciTipi, COMPBOMDOCNUM =  @KalemUrunAgaciKodu , QUANTITY = @BilesenMiktar WHERE COMCODE = @FirmaKodu AND BOMDOCNUM = @UrunAgaciKodu;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (string.IsNullOrEmpty(yeniFirmaKodu))
                    {
                        throw new ArgumentException("Firma Kodu boş bırakılamaz.");
                    }
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FirmaKodu", yeniFirmaKodu);
                        command.Parameters.AddWithValue("@GBaslangic", yenigecBaslangic);
                        command.Parameters.AddWithValue("@GBitis", yeniBitis);
                        command.Parameters.AddWithValue("@MalzemeKodu", yeniMalzemeKodu);
                        command.Parameters.AddWithValue("@MalzemeTipi", yeniMalzemeTipi);
                        command.Parameters.AddWithValue("@KalemUrunAgaciTipi", yeniKalemUrunAgaciTipi);
                        command.Parameters.AddWithValue("@Pasif", yeniPasif);
                        command.Parameters.AddWithValue("@KalemUrunAgaciKodu", yeniKalemUrunAgaciKodu);
                        command.Parameters.AddWithValue("@IcerikNumarasi", yeniIcerikNumarasi);
                        command.Parameters.AddWithValue("@UrunAgaciKodu", yeniUrunAgaciKodu);
                        command.Parameters.AddWithValue("@UrunAgaciTipi", yeniUrunAgaciTipi);
                        command.Parameters.AddWithValue("@CizimNumarasi", yeniCizimNumarasi);
                        command.Parameters.AddWithValue("@Silindi", yeniSil);
                        command.Parameters.AddWithValue("@TemelMiktar", yeniTemelMiktar);
                        command.Parameters.AddWithValue("@BilesenMiktar", yeniBilesenMiktar);
                        command.Parameters.AddWithValue("@BilesenKodu", yeniBilesenKodu);


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
        private void UrunAgaciAnaGuncelle_Load(object sender, EventArgs e)
        {
            PopulateComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMCODE", "COMTEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEBOM001", cmbKalemUrunAgaciTipi, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEMAT001", cmbMalzemeTipi, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEBOM001", cmbUrunAgaciTipi, "DOCTYPE", "DOCTYPETEXT");



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

        private void rotaYonGuncelle_Load_1(object sender, EventArgs e)
        {

        }
    }
}
