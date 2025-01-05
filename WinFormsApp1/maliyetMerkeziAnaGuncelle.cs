using System;
using System.Collections;
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
    public partial class maliyetMerkeziAnaGuncelle : Form
    {
        public maliyetMerkeziAnaGuncelle()
        {
            InitializeComponent();
        }

        
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        public void SetMaliyetMerkeziBilgileri(string firmaKodu, string dilKodu, string maliyetMerkeziTipi, string anaMaliyetMerkeziTipi, string maliyetMekeziKodu, string anaMaliyetMerkeziKodu, DateTime GBasTarih, DateTime GBitisTarih, string maliyetMerkeziKisaAciklama, string maliyetMerkeziUzunAciklama, bool pasif, bool silindi)
        {
            cmbFirmaKodu.Text = firmaKodu;
            cmbDilKodu.Text = dilKodu;
            cmbMaliyetMerkezTipi.Text = maliyetMerkeziTipi;
            cmbAnaMaliyetMerkezTipi.Text = anaMaliyetMerkeziTipi;
            maliyetMerkezKodu_txt.Text = maliyetMekeziKodu;
            anaMaliyetMerkezKodu_txt.Text = anaMaliyetMerkeziKodu;
            dtpBasTarih.Value = GBasTarih;
            dtpBitTarih.Value = GBitisTarih;
            maliyetMerkeziKisaAciklama_txt.Text = maliyetMerkeziKisaAciklama;
            maliyetMerkeziUzunAciklama_txt.Text = maliyetMerkeziUzunAciklama;
            chkPasif.Checked = pasif;

            chkSil.Checked = silindi;

        }

        // Güncellenmiş verileri al

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncellenmiş verileri al
            string yeniFirmaKodu = cmbFirmaKodu.SelectedValue?.ToString();
            string yeniDilKodu = cmbDilKodu.SelectedValue?.ToString();
            string yeniMaliyetMerkeziTipi = cmbMaliyetMerkezTipi.SelectedValue?.ToString();
            string yeniAnaMaliyetMerkeziTipi = cmbAnaMaliyetMerkezTipi.SelectedValue?.ToString();
            string yeniMaliyetMerkeziKodu = maliyetMerkezKodu_txt.Text;
            string yeniAnaMaliyetMerkeziKodu = anaMaliyetMerkezKodu_txt.Text;
            DateTime yeniBaslangicTarihi = dtpBasTarih.Value;
            DateTime yeniBitisTarihi = dtpBitTarih.Value;
            string yeniKisaAciklama = maliyetMerkeziKisaAciklama_txt.Text;
            string yeniUzunAciklama = maliyetMerkeziUzunAciklama_txt.Text;
            bool yeniPasif = chkPasif.Checked;
            bool yeniSilindi = chkSil.Checked;

            // Alınan verileri işleme koy (örneğin, veritabanına güncelleme yapabilirsiniz)
            // Örnek olarak bir mesaj kutusunda gösterelim:
            MessageBox.Show($"Firma Kodu: {yeniFirmaKodu}\n" +
                    $"Dil Kodu: {yeniDilKodu}\n" +
                    $"Maliyet Merkezi Tipi: {yeniMaliyetMerkeziTipi}\n" +
                    $"Ana Maliyet Merkezi Tipi: {yeniAnaMaliyetMerkeziTipi}\n" +
                    $"Maliyet Merkezi Kodu: {yeniMaliyetMerkeziKodu}\n" +
                    $"Ana Maliyet Merkezi Kodu: {yeniAnaMaliyetMerkeziKodu}\n" +
                    $"Başlangıç Tarihi: {yeniBaslangicTarihi}\n" +
                    $"Bitiş Tarihi: {yeniBitisTarihi}\n" +
                    $"Kısa Açıklama: {yeniKisaAciklama}\n" +
                    $"Uzun Açıklama: {yeniUzunAciklama}\n" +
                    $"Pasif: {yeniPasif}\n" +
                    $"Silindi: {yeniSilindi}");

            // Eğer burada güncelleme işlemi yapılacaksa ilgili metot çağrılabilir, örneğin:
            // UpdateDatabase(firmaKodu, dilKodu, maliyetMerkeziTipi, ...);







            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = @"
    UPDATE BSMSMECCMTEXT SET CCMDOCTYPE = @MaliyetMerkeziTipi,CCMDOCFROM = @GBaslangic, CCMDOCUNTIL = @GBitis, LANCODE = @DilKodu, CCMLTEXT = @MaliyetMerkeziUzunAciklama, CCMSTEXT = @MaliyetMerkeziKisaAciklama WHERE COMCODE = @FirmaKodu AND CCMDOCNUM = @MaliyetMerkeziKodu
     UPDATE BSMSMECCMHEAD SET CCMDOCTYPE = @MaliyetMerkeziTipi,CCMDOCFROM = @GBaslangic, CCMDOCUNTIL = @GBitis,MAINCCMDOCTYPE = @AnaMaliyetMerkeziTipi, MAINCCMDOCNUM = @AnaMaliyetMerkeziKodu, ISDELETED =@Silindi, ISPASSIVE = @Pasif  WHERE COMCODE = @FirmaKodu AND CCMDOCNUM = @MaliyetMerkeziKodu
";

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
                        command.Parameters.AddWithValue("@FirmaKodu", yeniFirmaKodu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MaliyetMerkeziTipi", yeniMaliyetMerkeziTipi ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MaliyetMerkeziKodu", yeniMaliyetMerkeziKodu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@AnaMaliyetMerkeziTipi", yeniAnaMaliyetMerkeziTipi ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@AnaMaliyetMerkeziKodu", yeniAnaMaliyetMerkeziKodu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@GBaslangic", yeniBaslangicTarihi);
                        command.Parameters.AddWithValue("@GBitis", yeniBitisTarihi);
                        command.Parameters.AddWithValue("@DilKodu", yeniDilKodu ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MaliyetMerkeziUzunAciklama", yeniUzunAciklama ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MaliyetMerkeziKisaAciklama", yeniKisaAciklama ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Silindi", yeniSilindi);
                        command.Parameters.AddWithValue("@Pasif", yeniPasif);
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

        private void maliyetMerkeziAnaGuncelle_Load(object sender, EventArgs e)
        {
            PopulateComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMCODE", "COMTEXT");
            PopulateComboBox("SELECT LANCODE, LANTEXT FROM BSMSMEGEN002", cmbDilKodu, "LANCODE", "LANTEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMECCM001", cmbMaliyetMerkezTipi, "DOCTYPE", "DOCTYPETEXT");
            PopulateComboBox("SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMECCM001", cmbAnaMaliyetMerkezTipi, "DOCTYPE", "DOCTYPETEXT");
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

           
