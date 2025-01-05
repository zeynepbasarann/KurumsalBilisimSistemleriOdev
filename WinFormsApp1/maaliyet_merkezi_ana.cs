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
    public partial class maaliyet_merkezi_ana : Form
    {
        public maaliyet_merkezi_ana()
        {
            InitializeComponent();
        }

        private void maaliyet_merkezi_ana_Load(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        private void button1_Click(object sender, EventArgs e)
        {


            string query = @"
                SELECT 
    H.COMCODE AS [FirmaKodu],
    H.CCMDOCTYPE AS [Maliyet Merkezi Tipi],
    H.CCMDOCNUM AS [Maliyet Merkezi Kodu],
    H.CCMDOCFROM AS [Geçerlilik Başlangıcı],
    H.CCMDOCUNTIL AS [Geçerlilik Bitişi],
    H.MAINCCMDOCTYPE AS [Ana Maliyet Merkezi Tipi],
    H.MAINCCMDOCNUM AS [Ana Maliyet Merkezi Kodu],
    H.ISDELETED AS [Silindi],
    H.ISPASSIVE AS [Pasif Mi?],
    T.LANCODE AS [Dil Kodu],
    T.CCMSTEXT AS [Kısa Açıklama],
    T.CCMLTEXT AS [Uzun Açıklama]   
FROM 
    BSMSMECCMHEAD H
LEFT JOIN 
    BSMSMECCMTEXT T 
    ON H.COMCODE = T.COMCODE 
    AND H.CCMDOCTYPE = T.CCMDOCTYPE 
    AND H.CCMDOCNUM = T.CCMDOCNUM 
    AND H.CCMDOCFROM = T.CCMDOCFROM 
    AND H.CCMDOCUNTIL = T.CCMDOCUNTIL; ";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind data to DataGridView
            dataGridView1.DataSource = dataTable;


            // Optionally, you can set column headers
            SetColumnHeaders();

        }


        private void SetColumnHeaders()
        {

            var columns = dataGridView1.Columns;

            if (columns.Contains("FirmaKodu")) columns["FirmaKodu"].HeaderText = "FirmaKodu";
            if (columns.Contains("MaliyetMerkeziTipi")) columns["MaliyetMerkeziTipi"].HeaderText = "Maliyet Merkezi Tipi";
            if (columns.Contains("MaliyetMerkeziKodu")) columns["MaliyetMerkeziKodu"].HeaderText = "Maliyet Merkezi Kodu";
            if (columns.Contains("GecerlilikBaslangic")) columns["GecerlilikBaslangic"].HeaderText = "Geçerlilik Başlangıcı";
            if (columns.Contains("GecerlilikBitis")) columns["GecerlilikBitis"].HeaderText = "Geçerlilik Bitişi";
            if (columns.Contains("AnaMaliyetMerkeziTipi")) columns["AnaMaliyetMerkeziTipi"].HeaderText = "Ana Maliyet Merkezi Tipi";
            if (columns.Contains("AnaMaliyetMerkeziKodu")) columns["AnaMaliyetMerkeziKodu"].HeaderText = "Ana Maliyet Merkezi Kodu";
            if (columns.Contains("Silindi")) columns["Silindi"].HeaderText = "Silindi";
            if (columns.Contains("PasifMi")) columns["PasifMi"].HeaderText = "Pasif Mi?";
            if (columns.Contains("DilKodu")) columns["DilKodu"].HeaderText = "Dil Kodu";
            if (columns.Contains("KisaAciklama")) columns["KisaAciklama"].HeaderText = "Kısa Açıklama";
            if (columns.Contains("UzunAciklama")) columns["UzunAciklama"].HeaderText = "Uzun Açıklama";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maliyetMerkeziAnaEkle maliyetMerkeziAnaEkleForm = new maliyetMerkeziAnaEkle();
            maliyetMerkeziAnaEkleForm.ShowDialog();
        }

        private void LoadTable(DataGridView gridView, string query, Dictionary<string, string> columnHeaders = null)
        {
            try
            {
                string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e bağlama
                    gridView.DataSource = dataTable;

                    // Sütun başlıklarını ayarlama
                    if (columnHeaders != null)
                    {
                        foreach (var header in columnHeaders)
                        {
                            if (gridView.Columns.Contains(header.Key))
                            {
                                gridView.Columns[header.Key].HeaderText = header.Value;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veri Yükleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string, string> getColumnHeaders()
        {
            return new Dictionary<string, string>
    {
        { "COMCODE", "FirmaKodu" },
        { "CCMDOCTYPE", "Maliyet Merkezi Tipi" },
        { "CCMDOCNUM", "Maliyet Merkezi Kodu" },
        { "LANCODE", "Dil Kodu" },
        { "CCMDOCFROM", "Geçerlilik Başlangıcı" },
        { "CCMDOCUNTIL", "Geçerlilik Bitişi" },
        { "MAINCCMDOCTYPE", "Ana Maliyet Merkezi Tipi" },
        { "MAINCCMDOCNUM", "Ana Maliyet Merkezi Kodu" },
        { "ISDELETED", "Silindi" },
        { "ISPASSIVE", "Pasif Mi?" },
        {"MATSTEXT", "Kısa Açıklama" },
        {"MATLTEXT", "Uzun Açıklama" },
    };
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili satırın bilgilerini al
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Satırdaki hücreleri al (Firma Kodu, Dil Kodu, Dil Adı)
                string firmaKodu = selectedRow.Cells["FirmaKodu"].Value.ToString();
                string maliyetMerkeziTipi = selectedRow.Cells["Maliyet Merkezi Tipi"].Value.ToString();
                string maliyetMerkeziKodu = selectedRow.Cells["Maliyet Merkezi Kodu"].Value.ToString();
                DateTime GBasTarih = DateTime.Parse(selectedRow.Cells["Geçerlilik Başlangıcı"].Value.ToString());
                DateTime GBitisTarih = DateTime.Parse(selectedRow.Cells["Geçerlilik Bitişi"].Value.ToString());
                string dilKodu = selectedRow.Cells["Dil Kodu"].Value.ToString();
                string anaMaliyetMerkeziTipi = selectedRow.Cells["Ana Maliyet Merkezi Tipi"].Value.ToString();
                string maliyetMerkeziKisaAciklama = selectedRow.Cells["Kısa Açıklama"].Value.ToString();
                string maliyetMerkeziUzunAciklama = selectedRow.Cells["Uzun Açıklama"].Value.ToString();
                bool pasif = Convert.ToBoolean(selectedRow.Cells["Pasif Mi?"].Value);
                string anaMaliyetMerkeziKodu = selectedRow.Cells["Ana Maliyet Merkezi Kodu"].Value.ToString();  // Varsayılan değer (0)

                bool silindi = Convert.ToBoolean(selectedRow.Cells["Silindi"].Value);



                // dilGuncelleme formunu oluştur ve bilgileri aktar
                maliyetMerkeziAnaGuncelle maliyetMerkeziAnaGuncelleForm = new maliyetMerkeziAnaGuncelle();
                maliyetMerkeziAnaGuncelleForm.SetMaliyetMerkeziBilgileri(firmaKodu, dilKodu, maliyetMerkeziTipi, anaMaliyetMerkeziTipi, maliyetMerkeziKodu, anaMaliyetMerkeziKodu, GBasTarih, GBitisTarih, maliyetMerkeziKisaAciklama, maliyetMerkeziUzunAciklama, pasif, silindi);
                {
                    // Formu modal olarak göster
                    maliyetMerkeziAnaGuncelleForm.ShowDialog();

                    // Form kapandıktan sonra tabloyu yenile
                    LoadTable(dataGridView1, "SELECT * FROM BSMSMECCMHEAD", getColumnHeaders());
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Malzeme Kodu birincil anahtar olarak kullanılıyor
                string maliyetMerkeziKodu = selectedRow.Cells["Maliyet Merkezi Kodu"].Value.ToString();

                // Silme işlemi için onay al
                DialogResult result = MessageBox.Show(
                    "Bu kaydı silmek istediğinizden emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Veritabanı bağlantısı
                    string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Transaction başlat
                            SqlTransaction transaction = connection.BeginTransaction();

                            try
                            {
                                // Silme sorgusu (BSMSMEMATHEAD)
                                string deleteQueryHead = "DELETE FROM BSMSMECCMHEAD WHERE CCMDOCNUM = @MaliyetMerkeziKodu";
                                using (SqlCommand commandHead = new SqlCommand(deleteQueryHead, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandHead.Parameters.AddWithValue("@MaliyetMerkeziKodu", maliyetMerkeziKodu);
                                    commandHead.ExecuteNonQuery();
                                }

                                // Silme sorgusu (BSMSMEMATTEXT)
                                string deleteQueryText = "DELETE FROM BSMSMECCMTEXT WHERE CCMDOCNUM = @MaliyetMerkeziKodu";
                                using (SqlCommand commandText = new SqlCommand(deleteQueryText, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandText.Parameters.AddWithValue("@MaliyetMerkeziKodu", maliyetMerkeziKodu);
                                    commandText.ExecuteNonQuery();
                                }

                                // Commit işlemi
                                transaction.Commit();

                                MessageBox.Show("Kayıtlar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // DataGridView'i yenile
                                button1.PerformClick();
                            }
                            catch (Exception ex)
                            {
                                // Rollback işlemi
                                transaction.Rollback();
                                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AramaYap()
        {
            // SQL sorgusunu oluştur
            string query = @"
        SELECT 
    H.COMCODE AS [FirmaKodu],
    H.CCMDOCTYPE AS [Maliyet Merkezi Tipi],
    H.CCMDOCNUM AS [Maliyet Merkezi Kodu],
    H.CCMDOCFROM AS [Geçerlilik Başlangıcı],
    H.CCMDOCUNTIL AS [Geçerlilik Bitişi],
    H.MAINCCMDOCTYPE AS [Ana Maliyet Merkezi Tipi],
    H.MAINCCMDOCNUM AS [Ana Maliyet Merkezi Kodu],
    H.ISDELETED AS [Silindi],
    H.ISPASSIVE AS [Pasif Mi?],
    T.LANCODE AS [Dil Kodu],
    T.CCMSTEXT AS [Kısa Açıklama],
    T.CCMLTEXT AS [Uzun Açıklama]   
FROM 
    BSMSMECCMHEAD H
LEFT JOIN 
    BSMSMECCMTEXT T 
    ON H.COMCODE = T.COMCODE 
    AND H.CCMDOCTYPE = T.CCMDOCTYPE 
    AND H.CCMDOCNUM = T.CCMDOCNUM 
    AND H.CCMDOCFROM = T.CCMDOCFROM 
    AND H.CCMDOCUNTIL = T.CCMDOCUNTIL
        WHERE 1=1";

            // TextBox'lara göre dinamik filtreler ekle
            if (!string.IsNullOrEmpty(maliyetMerkezTipi_txt.Text))
            {
                query += " AND H.CCMDOCTYPE LIKE @MaliyetMerkeziTipi";
            }
            if (!string.IsNullOrEmpty(maliyetMerkezKodu_txt.Text))
            {
                query += " AND H.CCMDOCNUM LIKE @MaliyetMerkeziKodu";
            }
            if (!string.IsNullOrEmpty(DilKodu_txt.Text))
            {
                query += " AND T.LANCODE LIKE @DilKodu";
            }


            // DateTimePicker'a göre tarih filtresi ekle
            if (dtpBasTarih.Checked)
            {
                query += " AND H.CCMDOCFROM LIKE @GecerlilikBaslangici";
            }
            if (dtpBitTarih.Checked)
            {
                query += " AND H.CCMDOCUNTIL LIKE @GecerlilikBitisi";
            }
            if (chkPasif.Checked)
            {
                query += " AND H.ISPASSIVE LIKE @PasifMi";
            }
            if (chkSil.Checked)
            {
                query += " AND H.ISDELETED LIKE @Silindi";
            }
            // Veritabanı bağlantısını kullanarak sorguyu çalıştır
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SqlCommand ile parametreleri ekleyerek güvenli bir sorgu oluştur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // TextBox parametrelerini ekle
                        if (!string.IsNullOrEmpty(maliyetMerkezTipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@MaliyetMerkeziTipi", "%" + maliyetMerkezTipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(maliyetMerkezKodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@MaliyetMerkeziKodu", "%" + maliyetMerkezKodu_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(DilKodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@DilKodu", "%" + DilKodu_txt.Text + "%");
                        }


                        // DateTimePicker parametrelerini ekle
                        if (dtpBasTarih.Checked)
                        {
                            command.Parameters.AddWithValue("@GecerlilikBaslangici", "%" + dtpBasTarih.Value.ToString("yyyy-MM-dd") + "%");

                        }
                        if (dtpBitTarih.Checked)
                        {
                            command.Parameters.AddWithValue("@GecerlilikBitisi", "%" + dtpBitTarih.Value.ToString("yyyy-MM-dd") + "%");

                        }
                        if (chkSil.Checked)
                        {
                            command.Parameters.AddWithValue("@Silindi", "%" + chkSil.Text + "%");

                        }
                        if (chkPasif.Checked)
                        {
                            command.Parameters.AddWithValue("@PasifMi", "%" + chkPasif.Text + "%");

                        }
                        // DataTable ile verileri al
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // DataGridView'e sonucu aktar
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void maliyetMerkezTipi_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void maliyetMerkezKodu_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void DilKodu_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void dtpBasTarih_ValueChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void dtpBitTarih_ValueChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void chkSil_CheckedChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void chkPasif_CheckedChanged(object sender, EventArgs e)
        {
            AramaYap();
        }
    }
}
    
