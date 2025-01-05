using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1
{
    public partial class isMerkeziAnaEkle : Form
    {
        public isMerkeziAnaEkle()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

        private void isMerkeziAnaEkle_Load(object sender, EventArgs e)
        {
            // Firma Kodu ComboBox'ını doldur
            FillComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMTEXT", "COMCODE");

            // Diğer ComboBox'ları temizle
            cmbIsMerkeziTipi.DataSource = null;
            cmbDilKodu.DataSource = null;
            cmbMaliyetMerkeziTipi.DataSource = null;
            
        }

        private void cmbFirmaKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirmaKodu.SelectedValue != null)
            {
                string selectedFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();

                // Malzeme Tipi ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEWCM001 WHERE COMCODE = @COMCODE", cmbIsMerkeziTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                // Dil Kodu ComboBox'ı doldur
                FillComboBox($"SELECT LANCODE, LANTEXT FROM BSMSMEGEN002 WHERE COMCODE = @COMCODE", cmbDilKodu, "LANTEXT", "LANCODE", selectedFirmaKodu);

                // Ağırlık Birimleri ComboBox'larını doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMECCM001 WHERE COMCODE = @COMCODE", cmbMaliyetMerkeziTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form üzerindeki değerleri al
            string selectedFirmaKodu = cmbFirmaKodu.SelectedValue?.ToString() ?? "";
            string selectedIsMerkeziTipi = cmbIsMerkeziTipi.SelectedValue?.ToString() ?? "";
            string selectedMaliyetMerkezi = cmbMaliyetMerkeziTipi.SelectedValue?.ToString() ?? "";
            string selectedDilKodu = cmbDilKodu.SelectedValue?.ToString() ?? "";
            

            string query = @"
                INSERT INTO BSMSMEWCMHEAD (
                    COMCODE, WCMDOCTYPE, WCMDOCNUM, WCMDOCFROM, WCMDOCUNTIL  
                   ,MAINWCMDOCTYPE ,MAINWCMDOCNUM ,CCMDOCTYPE ,CCMDOCNUM ,WORKTIME , 
                   ISDELETED, ISPASSIVE) 
                VALUES (
                    @FirmaKodu, @IsMerkeziTipi, @IsMerkeziKodu, @GBaslangic, @GBitis, @AnaIsMerkeziTipi, 
                    @AnaIsMerkeziKodu, @MaliyetMerkeziTipi, @MaliyetMerkeziKodu, @GunlukCalismaSuresi, 
                    @Silindi, @PasifMi);

            
                INSERT INTO BSMSMEWCMTEXT (
                    COMCODE ,WCMDOCTYPE ,WCMDOCNUM ,WCMDOCFROM ,WCMDOCUNTIL, LANCODE, WCMLTEXT, WCMSTEXT)
                VALUES (
                    @FirmaKodu, @IsMerkeziTipi, @IsMerkeziKodu, @GBaslangic, @GBitis, @DilKodu, @IsMerkeziUzunAciklama, @IsMerkeziKisaAciklama)
            
                INSERT INTO BSMSMEWCMOPR(
                    COMCODE, WCMDOCTYPE, WCMDOCNUM, WCMDOCFROM, WCMDOCUNTIL, OPRDOCTYPE)
                VALUES(
                    @FirmaKodu, @IsMerkeziTipi, @IsMerkeziKodu, @GBaslangic, @GBitis, @OperasyonKodu)";
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
                        command.Parameters.AddWithValue("@IsMerkeziKodu", is_merkezi_kodu_txt.Text);
                        command.Parameters.AddWithValue("@GBaslangic", DateTime.Now);
                        command.Parameters.AddWithValue("@GBitis", DateTime.Now.AddYears(1));
                        command.Parameters.AddWithValue("@AnaIsMerkeziTipi", ana_is_merkezi_tipi.Text);
                        command.Parameters.AddWithValue("@AnaIsMerkeziKodu", ana_is_merkezi_kodu.Text);
                        command.Parameters.AddWithValue("@MaliyetMerkeziTipi", selectedMaliyetMerkezi);
                        command.Parameters.AddWithValue("@MaliyetMerkeziKodu", maliyet_merkezi_kodu.Text);
                        command.Parameters.AddWithValue("@GunlukCalismaSuresi", calisma_suresi_txt.Text);
                        command.Parameters.AddWithValue("@Silindi", chkSil.Checked);
                        command.Parameters.AddWithValue("@PasifMi", chkPasif.Checked);
                        command.Parameters.AddWithValue("@DilKodu", selectedDilKodu);
                        command.Parameters.AddWithValue("@IsMerkeziUzunAciklama", uzun_aciklama_txt.Text);
                        command.Parameters.AddWithValue("@IsMerkeziKisaAciklama", kisa_aciklama_txt.Text);
                        command.Parameters.AddWithValue("@OperasyonKodu", operasyon_kodu_txt.Text);


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
