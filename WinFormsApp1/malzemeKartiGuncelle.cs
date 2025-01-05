using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class malzemeKartiGuncelle : Form
    {
        public malzemeKartiGuncelle()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

        // Form yüklenirken ComboBox'ları doldur

        // Seçilen firma bilgilerini formdaki alanlara aktarır
        public void SetMalzemeBilgileri(string firmaKodu, string dilKodu, string malzemeNumarasi, string malzemeTipi, DateTime gecBaslangic, DateTime gecBitis, string tedarikTipi, string kisaAciklama, string uzunAciklama, bool pasif, decimal netAgirlik, string netAgirlikBirimi, string brutAgirlikBirimi, decimal brutAgirlik, bool urunAgaciVarMi, bool rotaVarMi, string malStokBirimi, string urunAgaciTipi, string urunAgaciNum, string rotaTipi, string rotaNumarasi, bool silindi)
        {
            cmbFirmaKodu.Text = firmaKodu;
            cmbDilKodu.Text = dilKodu;
            malzeme_karti_txt.Text = malzemeNumarasi;
            cmbMalzemeTipi.Text = malzemeTipi;
            dtpBasTarih.Value = gecBaslangic;
            dtpBitisTarih.Value = gecBitis;
            tedarik_tipi_txt.Text = tedarikTipi;
            malzeme_kısa_acik_txt.Text = kisaAciklama;
            malzeme_uzun_acik_txt.Text = uzunAciklama;
            chkPasif.Checked = pasif;
            net_agirlik_txt.Text = netAgirlik.ToString();
            cmbNetAgirlikBirimi.Text = netAgirlikBirimi;
            cmbBrutAgirlikBirimi.Text = brutAgirlikBirimi;
            brut_agirlik_txt.Text = brutAgirlik.ToString();
            chkIsBom.Checked = urunAgaciVarMi;
            chkRota.Checked = rotaVarMi;
            cmbMalzemeStokBirimi.Text = malStokBirimi;
            cmbUrunAgaci.Text = urunAgaciTipi;
            urun_agaci_kodu_txt.Text = urunAgaciNum;
            cmbRotaTipi.Text = rotaTipi;
            rota_numarasi_txt.Text = rotaNumarasi;
            chkSil.Checked = silindi;

        }

        // Güncelleme butonuna tıklandığında veritabanı güncelleme işlemi


        // Güncelleme sayfasına gönderilen veriler


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al

            string yeniDilKodu = cmbDilKodu.SelectedValue.ToString();
            string yenimalzemeNumarasi = malzeme_karti_txt.Text;
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();
            string yenimalzemeTipi = cmbMalzemeTipi.SelectedValue.ToString();
            DateTime yenigecBaslangic = dtpBasTarih.Value;
            DateTime yeniBitis = dtpBitisTarih.Value;
            string yenitedarikTipi = tedarik_tipi_txt.Text;
            string yenikisaAciklama = malzeme_kısa_acik_txt.Text;
            string yeniuzunAciklama = malzeme_uzun_acik_txt.Text;
            bool yeniPasifDurum = chkPasif.Checked;
            string yeniMalzemeStokBirimi = cmbMalzemeStokBirimi.SelectedValue.ToString();
            decimal yeniNetAgirlik = decimal.Parse(net_agirlik_txt.Text);
            string yeniNetAgirlikBirimi = cmbNetAgirlikBirimi.SelectedValue.ToString();
            decimal yeniBrütAgirlik = decimal.Parse(brut_agirlik_txt.Text);
            string yeniBrütAgirlikBirimi = cmbBrutAgirlikBirimi.SelectedValue.ToString();
            bool yeniUrunAgaciMi = chkIsBom.Checked;
            string yeniUrunAgaci = cmbUrunAgaci.SelectedValue.ToString();
            string yeniUrunAgaciKodu = urun_agaci_kodu_txt.Text;
            bool yeniRotaMi = chkRota.Checked;
            string yeniRotaTipi = cmbRotaTipi.SelectedValue.ToString();
            string yeniRotaNumarasi = rota_numarasi_txt.Text;
            bool yeniSil = chkSil.Checked;





            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = @"
                UPDATE BSMSMEMATTEXT SET MATDOCTYPE =@MalzemeTipi, MATDOCFROM= @GBaslangic, MATDOCUNTIL = @GBitis, LANCODE= @DilKodu, MATLTEXT = @MalzemeUzunAciklama, MATSTEXT = @MalzemeKisaAciklama WHERE COMCODE = @FirmaKodu AND MATDOCNUM = @MalzemeKodu
                UPDATE BSMSMEMATHEAD SET  MATDOCTYPE = @MalzemeTipi, MATDOCFROM = @GBaslangic, MATDOCUNTIL = @GBitis, SUPPLYTYPE = @TedarikTipi, STUNIT = @MalzemeStokBirimi, 
                    NETWEIGHT =@NetAgirlik, NWUNIT = @NetAgirlikBirimi, BRUTWEIGHT = @BrutAgirlik, BWUNIT = @BrutAgirlikBirimi, ISBOM = @UrunAgaciVarMi, BOMDOCTYPE =@UrunAgaci, 
                    BOMDOCNUM = @UrunAgaciKodu, ISROUTE =@RotaVarMi, ROTDOCTYPE = @RotaTipi, ROTDOCNUM = @RotaNumarasi, ISDELETED = @Silindi, ISPASSIVE = @PasifMi WHERE COMCODE = @FirmaKodu AND MATDOCNUM = @MalzemeKodu

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

                        command.Parameters.AddWithValue("@MalzemeTipi", yenimalzemeTipi);
                        command.Parameters.AddWithValue("@MalzemeKodu", yenimalzemeNumarasi);
                        command.Parameters.AddWithValue("@GBaslangic", yenigecBaslangic);
                        command.Parameters.AddWithValue("@GBitis", yeniBitis);
                        command.Parameters.AddWithValue("@TedarikTipi", yenitedarikTipi);
                        command.Parameters.AddWithValue("@DilKodu", yeniDilKodu);

                        command.Parameters.AddWithValue("@MalzemeStokBirimi", yeniMalzemeStokBirimi);
                        command.Parameters.AddWithValue("@NetAgirlik", yeniNetAgirlik);
                        command.Parameters.AddWithValue("@NetAgirlikBirimi", yeniNetAgirlikBirimi);
                        command.Parameters.AddWithValue("@BrutAgirlik", yeniBrütAgirlik);
                        command.Parameters.AddWithValue("@BrutAgirlikBirimi", yeniBrütAgirlikBirimi);
                        command.Parameters.AddWithValue("@UrunAgaciVarMi", yeniUrunAgaciMi);
                        command.Parameters.AddWithValue("@UrunAgaci", yeniUrunAgaci);
                        command.Parameters.AddWithValue("@UrunAgaciKodu", yeniUrunAgaciKodu);
                        command.Parameters.AddWithValue("@RotaVarMi", yeniRotaMi);
                        command.Parameters.AddWithValue("@RotaTipi", yeniRotaTipi);

                        command.Parameters.AddWithValue("@RotaNumarasi", yeniRotaNumarasi);
                        command.Parameters.AddWithValue("@Silindi", yeniSil);
                        command.Parameters.AddWithValue("@PasifMi", yeniPasifDurum);
                        command.Parameters.AddWithValue("@MalzemeUzunAciklama", yeniuzunAciklama);
                        command.Parameters.AddWithValue("@MalzemeKisaAciklama", yenikisaAciklama);



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
        private void malzemeKartiGuncelle_Load(object sender, EventArgs e)
        {
            PopulateComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMCODE", "COMTEXT");
            PopulateComboBox("SELECT LANCODE, LANTEXT FROM BSMSMEGEN002", cmbDilKodu, "LANCODE", "LANTEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEMAT001", cmbMalzemeTipi, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT UNITCODE, UNITTEXT FROM BSMSMEGEN005", cmbNetAgirlikBirimi, "UNITCODE", "UNITTEXT");
            PopulateComboBox("SELECT UNITCODE, UNITTEXT FROM BSMSMEGEN005", cmbBrutAgirlikBirimi, "UNITCODE", "UNITTEXT");
            PopulateComboBox("SELECT UNITCODE, UNITTEXT FROM BSMSMEGEN005", cmbMalzemeStokBirimi, "UNITCODE", "UNITTEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEBOM001", cmbUrunAgaci, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEROT001", cmbRotaTipi, "DOCTYPE", "DOCTYPETEXT");


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

        private void malzemeKartiGuncelle_Load_1(object sender, EventArgs e)
        {

        }

        private void D(object sender, EventArgs e)
        {

        }

        private void chkIsBom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsBom.Checked)
            {
                cmbUrunAgaci.Enabled = true;
                urun_agaci_kodu_txt.Enabled = true;
            }
            else
            {
                cmbUrunAgaci.Enabled = false;
                urun_agaci_kodu_txt.Enabled = false;
            }
        }

        private void chkRota_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRota.Checked)
            {
                cmbRotaTipi.Enabled = true;
                rota_numarasi_txt.Enabled = true;
            }
            else
            {
                cmbRotaTipi.Enabled = false;
                rota_numarasi_txt.Enabled = false;
            }
        }
    }
}
