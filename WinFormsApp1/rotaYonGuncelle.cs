using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class rotaYonGuncelle : Form
    {
        public rotaYonGuncelle()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

        // Form yüklenirken ComboBox'ları doldur

        // Seçilen firma bilgilerini formdaki alanlara aktarır
        public void SetRotaYonetimiBilgileri(string firmaKodu, string isMerkeziTipi, string isMerkeziKodu,
            DateTime GBaslangic, DateTime GBitis,
            string malzemeTipi, string malzemeKodu, string rotaTipi, bool pasif,
            string rotaKodu, string operasyonNumarasi,
            string icerikNumarasi, decimal bilesenMiktari, string urunAgaciTipi, string urunAgaciKodu,
            string operasyonKodu, decimal hazirlikSuresi, decimal makineSuresi, decimal iscilikSuresi, string bilesenKodu,
            string cizimNumarasi, bool silindi, decimal temelMiktar)

        {
            cmbFirmaKodu.Text = firmaKodu;
            cmbIsMerkeziTipi.Text = isMerkeziTipi;
            is_merekezi_kodu_txt.Text = isMerkeziKodu;
            dtpGBas.Value = GBaslangic;
            dtpGBitis.Value = GBitis;
            cmbMalzemeTipi.Text = malzemeTipi;
            malzeme_kodu_txt.Text = malzemeKodu;
            cmbRotaTipi.Text = rotaTipi;
            chkPasif.Checked = pasif;
            rota_kodu_txt.Text = rotaKodu;
            operasyon_numarasi_txt.Text = operasyonNumarasi;
            icerik_numarasi_txt.Text = icerikNumarasi;
            bilesen_miktar_txt.Text = bilesenMiktari.ToString();
            cmbUrunAgaciTipi.Text = urunAgaciTipi;
            urun_agaci_kodu_txt.Text = urunAgaciKodu;
            operasyon_kodu_txt.Text = operasyonKodu;
            hazirlik_suresi_txt.Text = hazirlikSuresi.ToString();
            makine_suresi_txt.Text = makineSuresi.ToString();
            iscilik_suresi_txt.Text = iscilikSuresi.ToString();
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


            string yeniIsMerkeziTipi = cmbIsMerkeziTipi.SelectedValue.ToString();
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yeniIsMerkeziKodu = is_merekezi_kodu_txt.Text;
            DateTime yenigecBaslangic = dtpGBas.Value;
            DateTime yeniBitis = dtpGBitis.Value;
            string yeniMalzemeKodu = malzeme_kodu_txt.Text;
            string yeniMalzemeTipi = cmbMalzemeTipi.SelectedValue.ToString();
            string yeniRotaTipi = cmbRotaTipi.SelectedValue.ToString();
            bool yeniPasif = chkPasif.Checked;
            string yeniRotaKodu = rota_kodu_txt.Text;
            string yeniOperasyonKodu = operasyon_kodu_txt.Text;
            string yeniOperasyonNumarasi = operasyon_numarasi_txt.Text;
            decimal yeniTemelMiktar = decimal.Parse(temel_miktar_txt.Text);
            decimal yeniBilesenMiktar = decimal.Parse(bilesen_miktar_txt.Text);
            string yeniBilesenKodu = bilesen_kodu_txt.Text;
            string yeniIcerikNumarasi = icerik_numarasi_txt.Text;
            string yeniUrunAgaciKodu = urun_agaci_kodu_txt.Text;
            string yeniUrunAgaciTipi = cmbUrunAgaciTipi.SelectedValue.ToString();
            string yeniCizimNumarasi = cizim_numarasi_txt.Text;
            decimal yeniHazirlikSuresi = decimal.Parse(hazirlik_suresi_txt.Text);
            decimal yeniMakineSuresi = decimal.Parse(makine_suresi_txt.Text);
            decimal yeniIscilikSuresi = decimal.Parse(iscilik_suresi_txt.Text);

            bool yeniSil = chkSil.Checked;


            if (string.IsNullOrWhiteSpace(yeniFirmaKodu) || string.IsNullOrWhiteSpace(yeniRotaKodu))
            {
                MessageBox.Show("Firma Kodu veya Rota Kodu eksik.");
                return;
            }


            // Veritabanı bağlantı dizesi
            //string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = @"
                UPDATE BSMSMEROTHEAD SET ROTDOCTYPE =@RotaTipi,ROTDOCNUM = @RotaKodu ,ROTDOCFROM= @GBaslangic, ROTDOCUNTIL = @GBitis,MATDOCTYPE = @MalzemeTipi, MATDOCNUM = @MalzemeKodu,QUANTITY = @TemelMiktar, ISDELETED = @Silindi, ISPASSIVE = @Pasif, DRAWNUM = @CizimNumarasi  WHERE COMCODE = @FirmaKodu AND ROTDOCNUM = @RotaKodu;
                UPDATE BSMSMEROTOPRCONTENT  SET ROTDOCTYPE =@RotaTipi,ROTDOCNUM = @RotaKodu ,ROTDOCFROM= @GBaslangic, ROTDOCUNTIL = @GBitis, MATDOCNUM = @MalzemeKodu, WCMDOCTYPE = @IsMerkeziTipi, WCMDOCNUM = @IsMerkeziKodu, OPRDOCTYPE = @OperasyonKodu, SETUPTIME = @HazirlikSuresi, MACHINETIME = @MakineSuresi, LABOURTIME=@IscilikSuresi  WHERE COMCODE = @FirmaKodu AND ROTDOCNUM = @RotaKodu ;
                UPDATE BSMSMEROTBOMCONTENT SET ROTDOCTYPE =@RotaTipi,ROTDOCNUM = @RotaKodu ,ROTDOCFROM= @GBaslangic, ROTDOCUNTIL = @GBitis,MATDOCTYPE = @MalzemeTipi, MATDOCNUM = @MalzemeKodu, BOMDOCTYPE = @UrunAgaciTipi, BOMDOCNUM =  @UrunAgaciKodu , CONTENTNUM = @IcerikNumarasi ,QUANTITY = @BilesenMiktar , COMPONENT = @BilesenKodu  WHERE COMCODE = @FirmaKodu AND ROTDOCNUM = @RotaKodu;";
                
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
                        command.Parameters.AddWithValue("@IsMerkeziTipi", yeniIsMerkeziTipi);
                        command.Parameters.AddWithValue("@IsMerkeziKodu", yeniIsMerkeziKodu);
                        command.Parameters.AddWithValue("@GBaslangic", yenigecBaslangic);
                        command.Parameters.AddWithValue("@GBitis", yeniBitis);
                        command.Parameters.AddWithValue("@MalzemeKodu", yeniMalzemeKodu);
                        command.Parameters.AddWithValue("@MalzemeTipi", yeniMalzemeTipi);
                        command.Parameters.AddWithValue("@RotaTipi", yeniRotaTipi);
                        command.Parameters.AddWithValue("@Pasif", yeniPasif);
                        command.Parameters.AddWithValue("@RotaKodu", yeniRotaKodu);
                        command.Parameters.AddWithValue("@OperasyonKodu", yeniOperasyonKodu);
                        command.Parameters.AddWithValue("@OperasyonNumarasi", yeniOperasyonNumarasi);
                        command.Parameters.AddWithValue("@IcerikNumarasi", yeniIcerikNumarasi);
                        command.Parameters.AddWithValue("@UrunAgaciKodu", yeniUrunAgaciKodu);
                        command.Parameters.AddWithValue("@UrunAgaciTipi", yeniUrunAgaciTipi);
                        command.Parameters.AddWithValue("@HazirlikSuresi", yeniHazirlikSuresi);
                        command.Parameters.AddWithValue("@CizimNumarasi", yeniCizimNumarasi);
                        command.Parameters.AddWithValue("@MakineSuresi", yeniMakineSuresi);
                        command.Parameters.AddWithValue("@IscilikSuresi", yeniIscilikSuresi);
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
        private void rotaYonGuncelle_Load(object sender, EventArgs e)
        {
            PopulateComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMCODE", "COMTEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEWCM001", cmbIsMerkeziTipi, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEMAT001", cmbMalzemeTipi, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEROT001", cmbRotaTipi, "DOCTYPE", "DOCTYPETEXT");
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
