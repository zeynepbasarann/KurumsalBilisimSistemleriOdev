using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UrunAgaciAnaEkle : Form
    {
        public UrunAgaciAnaEkle()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        private void UrunAgaciAnaEkle_Load(object sender, EventArgs e)
        {
            // Firma Kodu ComboBox'ını doldur
            FillComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMTEXT", "COMCODE");

            // Diğer ComboBox'ları temizle
            cmbKalemUrunAgaciTipi.DataSource = null;
            cmbMalzemeTipi.DataSource = null;
            cmbUrunAgaciTipi.DataSource = null;

        }
        private void cmbFirmaKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirmaKodu.SelectedValue != null)
            {
                string selectedFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();

                // Malzeme Tipi ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEBOM001 WHERE COMCODE = @COMCODE", cmbKalemUrunAgaciTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                // Dil Kodu ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEMAT001 WHERE COMCODE = @COMCODE", cmbMalzemeTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                // Ağırlık Birimleri ComboBox'larını doldur
                FillComboBox($"SELECT DOCTYPETEXT, DOCTYPE FROM BSMSMEBOM001 WHERE COMCODE = @COMCODE", cmbUrunAgaciTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Form üzerindeki değerleri al
            string selectedFirmaKodu = cmbFirmaKodu.SelectedValue?.ToString() ?? "";
            string selectedUrunAgaciTipi = cmbUrunAgaciTipi.SelectedValue?.ToString() ?? "";
            string selectedMalzemeTipi = cmbMalzemeTipi.SelectedValue?.ToString() ?? "";
            string selectedKalemUrunAgaci = cmbKalemUrunAgaciTipi.SelectedValue?.ToString() ?? "";

            string query = @"
                INSERT INTO BSMSMEBOMHEAD (
                    COMCODE, BOMDOCTYPE, BOMDOCNUM, BOMDOCFROM, BOMDOCUNTIL, MATDOCTYPE, MATDOCNUM,QUANTITY, 
                     ISDELETED, ISPASSIVE, DRAWNUM) 
                VALUES (
                    @FirmaKodu, @UrunAgaciTipi, @UrunAgaciKodu, @GBaslangic, @GBitis, @MalzemeTipi, 
                    @MalzemeKodu,@TemelMiktar, @Silindi, @PasifMi, @CizimNumarasi);

            
                INSERT INTO BSMSMEBOMCONTENT (
                    COMCODE ,BOMDOCTYPE ,BOMDOCNUM ,BOMDOCFROM ,BOMDOCUNTIL, MATDOCTYPE, MATDOCNUM, CONTENTNUM, COMPONENT, COMPBOMDOCTYPE, COMPBOMDOCNUM, QUANTITY)
                VALUES (
                    @FirmaKodu, @UrunAgaciTipi, @UrunAgaciKodu, @GBaslangic, @GBitis, @MalzemeTipi, 
                    @MalzemeKodu, @IcerikNumarasi, @BilesenKodu, @KalemUrunAgaciTipi, @KalemUrunAgaciKodu, @BilesenMiktari)";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FirmaKodu", selectedFirmaKodu);
                        command.Parameters.AddWithValue("@UrunAgaciTipi", selectedUrunAgaciTipi);
                        command.Parameters.AddWithValue("@UrunAgaciKodu", urun_agaci_kodu_txt.Text);
                        command.Parameters.AddWithValue("@GBaslangic", DateTime.Now);
                        command.Parameters.AddWithValue("@GBitis", DateTime.Now.AddYears(1));
                        command.Parameters.AddWithValue("@MalzemeTipi", selectedMalzemeTipi);
                        command.Parameters.AddWithValue("@MalzemeKodu", malzeme_kodu_txt.Text);
                        command.Parameters.AddWithValue("@Silindi", chkSil.Checked);
                        command.Parameters.AddWithValue("@PasifMi", chkPasif.Checked);
                        command.Parameters.AddWithValue("@KalemUrunAgaciTipi", selectedKalemUrunAgaci);
                        command.Parameters.AddWithValue("@KalemUrunAgaciKodu", kalem_urun_agaci_kodu.Text);
                        command.Parameters.AddWithValue("@TemelMiktar", temel_miktar_txt.Text);
                        command.Parameters.AddWithValue("@BilesenMiktari", bilesen_miktar_txt.Text);
                        command.Parameters.AddWithValue("@CizimNumarasi", cizim_numarasi_txt.Text);
                        command.Parameters.AddWithValue("@IcerikNumarasi", icerik_numarasi_txt.Text);
                        command.Parameters.AddWithValue("@BilesenKodu", bileşen_kodu_txt.Text);



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
