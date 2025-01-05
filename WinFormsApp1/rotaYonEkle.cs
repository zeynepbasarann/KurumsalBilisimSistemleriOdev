using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class rotaYonEkle : Form
    {
        public rotaYonEkle()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

        private void rotaYonEkle_Load(object sender, EventArgs e)
        {
            // Firma Kodu ComboBox'ını doldur
            FillComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMTEXT", "COMCODE");

            // Diğer ComboBox'ları temizle
            cmbIsMerkeziTipi.DataSource = null;
            cmbMalzemeTipi.DataSource = null;
            cmbRotaTipi.DataSource = null;
            cmbUrunAgaciTipi.DataSource = null;
            cmbOprNum.DataSource = null;


        }

        private void cmbFirmaKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirmaKodu.SelectedValue != null)
            {
                string selectedFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();

                // Malzeme Tipi ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEWCM001 WHERE COMCODE = @COMCODE", cmbIsMerkeziTipi,  "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEROT001 WHERE COMCODE = @COMCODE", cmbRotaTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEMAT001 WHERE COMCODE = @COMCODE", cmbMalzemeTipi,  "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEOPR001 WHERE COMCODE = @COMCODE", cmbOprNum, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);
                // Ağırlık Birimleri ComboBox'larını doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEBOM001 WHERE COMCODE = @COMCODE", cmbUrunAgaciTipi,  "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form üzerindeki değerleri al*********************************************************************************************************
            string selectedFirmaKodu = cmbFirmaKodu.SelectedValue?.ToString() ?? "";
            string selectedIsMerkeziTipi = cmbIsMerkeziTipi.SelectedValue?.ToString() ?? "";
            string selectedMalzemeTipi = cmbMalzemeTipi.SelectedValue?.ToString() ?? "";
            string selectedRotaTipi = cmbRotaTipi.SelectedValue?.ToString() ?? "";
            string selectedUrunAgaciTipi = cmbUrunAgaciTipi.SelectedValue?.ToString() ?? "";
            string selectedOprNum = cmbOprNum.SelectedValue?.ToString() ?? "";

            string query = @"
                INSERT INTO BSMSMEROTHEAD (
                    COMCODE, ROTDOCTYPE, ROTDOCNUM, ROTDOCFROM, ROTDOCUNTIL  
                   ,MATDOCTYPE ,MATDOCNUM ,QUANTITY, 
                   ISDELETED, ISPASSIVE, DRAWNUM) 
                VALUES (
                    @FirmaKodu, @RotaTipi, @RotaKodu, @GBaslangic, @GBitis, @MalzemeTipi, 
                    @MalzemeKodu, @BilesenMiktari, 
                    @Silindi, @PasifMi, @CizimNumarasi);

            
                INSERT INTO BSMSMEROTBOMCONTENT (
                    COMCODE ,ROTDOCTYPE ,ROTDOCNUM ,ROTDOCFROM ,ROTDOCUNTIL, MATDOCTYPE, MATDOCNUM, OPRNUM, BOMDOCTYPE, BOMDOCNUM, CONTENTNUM, COMPONENT,QUANTITY)
                VALUES (
                    @FirmaKodu, @RotaTipi, @RotaKodu, @GBaslangic, @GBitis, @MalzemeTipi, @MalzemeKodu, @OperasyonNumarasi, @UrunAgaciTipi, @UrunAgaciKodu, @IcerikNumarasi,@BilesenKodu, @BilesenMiktari);
            
                INSERT INTO BSMSMEROTOPRCONTENT(
                    COMCODE, ROTDOCTYPE, ROTDOCNUM, ROTDOCFROM, ROTDOCUNTIL, MATDOCTYPE, MATDOCNUM, OPRNUM, WCMDOCTYPE, WCMDOCNUM, OPRDOCTYPE, SETUPTIME, MACHINETIME, LABOURTIME)
                VALUES(
                    @FirmaKodu, @RotaTipi, @RotaKodu, @GBaslangic, @GBitis, @MalzemeTipi, @MalzemeKodu, @OperasyonNumarasi, @IsMerkeziTipi, @IsMerkeziKodu, @OperasyonKodu, @HazirlikSuresi, @MakineSuresi, @IscilikSuresi)";




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FirmaKodu", selectedFirmaKodu);
                        command.Parameters.AddWithValue("@IsMerkeziTipi", selectedIsMerkeziTipi);
                        command.Parameters.AddWithValue("@IsMerkeziKodu", is_merekezi_kodu_txt.Text);
                        command.Parameters.AddWithValue("@GBaslangic", DateTime.Now);
                        command.Parameters.AddWithValue("@GBitis", DateTime.Now.AddYears(1));
                        command.Parameters.AddWithValue("@MalzemeTipi", selectedMalzemeTipi);
                        command.Parameters.AddWithValue("@MalzemeKodu", malzeme_kodu_txt.Text);
                        command.Parameters.AddWithValue("@RotaTipi", selectedRotaTipi);
                        command.Parameters.AddWithValue("@RotaKodu", rota_kodu_txt.Text);
                        command.Parameters.AddWithValue("@OperasyonNumarasi",selectedOprNum );
                        command.Parameters.AddWithValue("@Silindi", chkSil.Checked);
                        command.Parameters.AddWithValue("@PasifMi", chkPasif.Checked);
                        command.Parameters.AddWithValue("@IcerikNumarasi", icerik_numarasi_txt.Text);
                        command.Parameters.AddWithValue("@BilesenMiktari", bilesen_miktar_txt.Text);
                        command.Parameters.AddWithValue("@UrunAgaciTipi", selectedUrunAgaciTipi);
                        command.Parameters.AddWithValue("@UrunAgaciKodu", urun_agaci_kodu_txt.Text);
                        command.Parameters.AddWithValue("@OperasyonKodu", operasyon_kodu_txt.Text);
                        command.Parameters.AddWithValue("@HazirlikSuresi", hazirlik_suresi_txt.Text);
                        command.Parameters.AddWithValue("@MakineSuresi", makine_suresi_txt.Text);
                        command.Parameters.AddWithValue("@IscilikSuresi", iscilik_suresi_txt.Text);
                        command.Parameters.AddWithValue("@BilesenKodu", bilesen_kodu_txt.Text);
                        command.Parameters.AddWithValue("@CizimNumarasi", cizim_numarasi_txt.Text);
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

        private void FillComboBox(string query, ComboBox comboBox, string displayMember, string valueMember, string parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                if (parameter != null)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@COMCODE", parameter);
                }

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
                comboBox.DataSource = dataTable;
            }
        }


        
    }
}
