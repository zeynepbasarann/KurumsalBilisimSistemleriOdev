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
    public partial class maliyetMerkeziAnaEkle : Form
    {
        public maliyetMerkeziAnaEkle()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        private void maliyetMerkeziAnaEkle_Load(object sender, EventArgs e)
        {
            // Firma Kodu ComboBox'ını doldur
            FillComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMTEXT", "COMCODE");

            // Diğer ComboBox'ları temizle
            cmbMaliyetMerkezTipi.DataSource = null;
            cmbDilKodu.DataSource = null;
            cmbAnaMaliyetMerkezTipi.DataSource = null;
            
        }
        private void cmbFirmaKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirmaKodu.SelectedValue != null)
            {
                string selectedFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();

                // Malzeme Tipi ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMECCM001 WHERE COMCODE = @COMCODE", cmbMaliyetMerkezTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                // Dil Kodu ComboBox'ı doldur
                FillComboBox($"SELECT LANCODE, LANTEXT FROM BSMSMEGEN002 WHERE COMCODE = @COMCODE", cmbDilKodu, "LANTEXT", "LANCODE", selectedFirmaKodu);

                // Ağırlık Birimleri ComboBox'larını doldur
                FillComboBox($"SELECT DOCTYPETEXT, DOCTYPE FROM BSMSMECCM001 WHERE COMCODE = @COMCODE", cmbAnaMaliyetMerkezTipi , "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);
                  }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Form üzerindeki değerleri al
            string selectedFirmaKodu = cmbFirmaKodu.SelectedValue?.ToString() ?? "";
            string selectedAnaMaliyetMerkezTipi = cmbAnaMaliyetMerkezTipi.SelectedValue?.ToString() ?? "";
            string selectedMaliyetMerkezTipi = cmbMaliyetMerkezTipi.SelectedValue?.ToString() ?? "";      
            string selectedDilKodu = cmbDilKodu.SelectedValue?.ToString() ?? "";
            
            string query = @"
                INSERT INTO BSMSMECCMHEAD (
                    COMCODE, CCMDOCTYPE, CCMDOCNUM, CCMDOCFROM, CCMDOCUNTIL, MAINCCMDOCTYPE, MAINCCMDOCNUM, 
                     ISDELETED, ISPASSIVE) 
                VALUES (
                    @FirmaKodu, @MaliyetMerkeziTipi, @MaliyetMerkeziKodu, @GBaslangic, @GBitis, @AnaMaliyetMerkeziTipi, 
                    @AnaMaliyetMerkeziKodu, @Silindi, @PasifMi);

            
                INSERT INTO BSMSMECCMTEXT (
                    COMCODE ,CCMDOCTYPE ,CCMDOCNUM ,CCMDOCFROM ,CCMDOCUNTIL, LANCODE, CCMSTEXT, CCMLTEXT)
                VALUES (
                    @FirmaKodu, @MaliyetMerkeziTipi, @MaliyetMerkeziKodu, @GBaslangic, @GBitis, @DilKodu, @CCMKisaAciklama, @CCMUzunAciklama)";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FirmaKodu", selectedFirmaKodu);
                        command.Parameters.AddWithValue("@AnaMaliyetMerkeziTipi", selectedAnaMaliyetMerkezTipi);
                        command.Parameters.AddWithValue("@AnaMaliyetMerkeziKodu", anaMaliyetMerkezKodu_txt.Text);
                        command.Parameters.AddWithValue("@GBaslangic", DateTime.Now);
                        command.Parameters.AddWithValue("@GBitis", DateTime.Now.AddYears(1));
                       
                       
                        
                        command.Parameters.AddWithValue("@MaliyetMerkeziTipi", selectedMaliyetMerkezTipi);
                        command.Parameters.AddWithValue("@MaliyetMerkeziKodu", maliyetMerkezKodu_txt.Text);
                        
                        command.Parameters.AddWithValue("@Silindi", chkSil.Checked);
                        command.Parameters.AddWithValue("@PasifMi", chkPasif.Checked);



                        command.Parameters.AddWithValue("@DilKodu", selectedDilKodu);
                        command.Parameters.AddWithValue("@CCMKisaAciklama", maliyetMerkeziKisaAciklama_txt.Text);
                        command.Parameters.AddWithValue("@CCMUzunAciklama", maliyetMerkeziUzunAciklama_txt.Text);



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
