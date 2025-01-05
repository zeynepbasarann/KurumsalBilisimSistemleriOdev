using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class is_merkezi : Form
    {
        public is_merkezi()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
            string query = @"
                SELECT 
    H.COMCODE AS [Firma Kodu],
    H.WCMDOCTYPE AS [İş Merkezi Tipi],
    H.WCMDOCNUM AS [İş Merkezi Kodu],
    H.WCMDOCFROM AS [Geçerlilik Başlangıcı],
    H.WCMDOCUNTIL AS [Geçerlilik Bitişi],
    H.MAINWCMDOCTYPE AS [Ana İş Merkezi Tipi],
    H.MAINWCMDOCNUM AS [Ana İş Merkezi Kodu],
    H.CCMDOCTYPE AS [Maliyet Merkezi Tipi],
    H.CCMDOCNUM AS [Maliyet Merkezi Kodu],
    H.WORKTIME AS [Günlük Çalisma Suresi],
    H.ISDELETED AS [Silindi],
    H.ISPASSIVE AS [Pasif Mi?],
    T.LANCODE AS [Dil Kodu], 
    M.DOCTYPETEXT AS [İş Merkezi Tipi], 
    T.WCMSTEXT AS [Kısa Açıklama], 
    T.WCMLTEXT AS [Uzun Açıklama],
    O.OPRDOCTYPE AS [Operasyon Kodu]
FROM 
    BSMSMEWCMHEAD H
LEFT JOIN 
    BSMSMEWCM001 M ON H.COMCODE = M.COMCODE AND H.WCMDOCTYPE = M.DOCTYPE
LEFT JOIN 
    BSMSMEWCMTEXT T ON H.COMCODE = T.COMCODE AND H.WCMDOCTYPE = T.WCMDOCTYPE AND H.WCMDOCNUM = T.WCMDOCNUM 
LEFT JOIN BSMSMEWCMOPR O
    ON H.COMCODE = O.COMCODE AND H.WCMDOCTYPE = O.WCMDOCTYPE AND H.WCMDOCNUM = O.WCMDOCNUM";

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

            if (columns.Contains("FirmaKodu")) columns["FirmaKodu"].HeaderText = "Firma Kodu";
            if (columns.Contains("IsMerkeziTipi")) columns["IsMerkeziTipi"].HeaderText = "İş Merkezi Tipi";
            if (columns.Contains("IsMerkeziKodu")) columns["IsMerkeziKodu"].HeaderText = "İş Merkezi Kodu";
            if (columns.Contains("GecerlilikBaslangic")) columns["GecerlilikBaslangic"].HeaderText = "Geçerlilik Başlangıcı";
            if (columns.Contains("GecerlilikBitis")) columns["GecerlilikBitis"].HeaderText = "Geçerlilik Bitişi";
            if (columns.Contains("AnaIsMerkeziTipi")) columns["AnaIsMerkeziTipi"].HeaderText = "Ana İş Merkezi Tipi";
            if (columns.Contains("AnaIsMerkeziKodu")) columns["AnaIsMerkeziKodu"].HeaderText = "Ana İş Merkezi Kodu";
            if (columns.Contains("MaliyetMerkeziTipi")) columns["MaliyetMerkeziTipi"].HeaderText = "Maliyet Merkezi Tipi";
            if (columns.Contains("MaliyetMerkeziKodu")) columns["MaliyetMerkeziKodu"].HeaderText = "Maliyet Merkezi Tipi";
            if (columns.Contains("GunlukCalismaSuresi")) columns["GunlukCalismaSuresi"].HeaderText = "Günlük Çalisma Suresi";
            if (columns.Contains("Silindi")) columns["Silindi"].HeaderText = "Silindi";
            if (columns.Contains("PasifMi")) columns["PasifMi"].HeaderText = "Pasif Mi?";
            if (columns.Contains("DilKodu")) columns["DilKodu"].HeaderText = "Dil Kodu";
            if (columns.Contains("KisaAciklama")) columns["KisaAciklama"].HeaderText = "Kısa Açıklama";
            if (columns.Contains("UzunAciklama")) columns["UzunAciklama"].HeaderText = "Uzun Açıklama";
            if (columns.Contains("OperasyonKodu")) columns["OperasyonKodu"].HeaderText = "Operasyon Kodu";

        }


        // Optionally, make some columns read-only or set additional properties



        private void button2_Click(object sender, EventArgs e)
        {
            // dilEkle formunu aç
            isMerkeziAnaEkle isMerkeziAnaEkleForm = new isMerkeziAnaEkle();
            isMerkeziAnaEkleForm.ShowDialog();

            // Form kapandıktan sonra tabloyu yenile

        }
        private void isMerkezi_LOAD(object sender, EventArgs e)
        {
            // You can load an empty table structure or some default data on form load if necessary
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Add any additional functionality for this button, if needed
        //}
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
        { "COMCODE", "Firma Kodu" },
        { "WCMDOCTYPE", "İş Merkezi Tipi" },
        { "WCMDOCNUM", "İş Merkezi Kodu" },
        { "MAINWCMDOCTYPE", "Ana İş Merkezi Tipi" },
        { "MAINWCMDOCNUM", "Ana İş Merkezi Kodu" },
        { "LANCODE", "Dil Kodu" },
        { "WCMDOCFROM", "Geçerlilik Başlangıcı" },
        { "WCMDOCUNTIL", "Geçerlilik Bitişi" },
        { "DOCTYPETEXT", "İş Merkezi Tipi" },
        { "CCMDOCTYPE", "Maliyet Merkezi Tipi" },
        { "CCMDOCNUM", "Maliyet Merkezi Kodu" },
        { "WORKTIME", "Günlük Çalisma Suresi" },
        { "ISDELETED", "Silindi" },
        { "ISPASSIVE", "Pasif Mi?" },
        {"WCMSTEXT", "Kısa Açıklama" },
        {"WCMLTEXT", "Uzun Açıklama" },
        {"OPRDOCTYPE","Operasyon Numarası" },
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
                string firmaKodu = selectedRow.Cells["Firma Kodu"].Value.ToString();
                string isMerkeziTipi = selectedRow.Cells["İş Merkezi Tipi"].Value.ToString();
                string isMerkeziKodu = selectedRow.Cells["İş Merkezi Kodu"].Value.ToString();
                DateTime gecBaslangic = DateTime.Parse(selectedRow.Cells["Geçerlilik Başlangıcı"].Value.ToString());
                DateTime gecBitis = DateTime.Parse(selectedRow.Cells["Geçerlilik Bitişi"].Value.ToString());
                string dilKodu = selectedRow.Cells["Dil Kodu"].Value.ToString();
                string anaIsMerkeziTipi = selectedRow.Cells["Ana İş Merkezi Tipi"].Value.ToString();
                string kisaAciklama = selectedRow.Cells["Kısa Açıklama"].Value.ToString();
                string uzunAciklama = selectedRow.Cells["Uzun Açıklama"].Value.ToString();
                bool pasif = Convert.ToBoolean(selectedRow.Cells["Pasif Mi?"].Value);
                string anaIsMerkeziKodu = selectedRow.Cells["Ana İş Merkezi Kodu"]?.Value?.ToString() ?? "0";  // Varsayılan değer (0)
                string maliyetMerkeziTipi = selectedRow.Cells["Maliyet Merkezi Tipi"]?.Value?.ToString() ?? "kg";  // Varsayılan birim
                string maliyetMerkeziKodu = selectedRow.Cells["Maliyet Merkezi Kodu"]?.Value?.ToString() ?? "0";  // Varsayılan değer (0)
                decimal calismaSuresi = selectedRow.Cells["Günlük Çalisma Suresi"]?.Value is decimal ? (decimal)selectedRow.Cells["Günlük Çalisma Suresi"].Value : 0m;
                bool silindi = Convert.ToBoolean(selectedRow.Cells["Silindi"].Value);
                string operasyonKodu = selectedRow.Cells["Operasyon Kodu"]?.Value?.ToString() ?? "0";  // Varsayılan değer (0)
                //string netAgirlik =

                // dilGuncelleme formunu oluştur ve bilgileri aktar
                isMerkeziAnaGuncelle isMerkeziAnaGuncelleForm = new isMerkeziAnaGuncelle();
                isMerkeziAnaGuncelleForm.SetIsMerkeziBilgileri(firmaKodu, dilKodu, isMerkeziTipi, isMerkeziKodu, gecBaslangic, gecBitis, anaIsMerkeziTipi, kisaAciklama, uzunAciklama, pasif, anaIsMerkeziKodu, maliyetMerkeziTipi, maliyetMerkeziKodu, calismaSuresi, silindi, operasyonKodu);

                // Formu modal olarak göster
                isMerkeziAnaGuncelleForm.ShowDialog();

                // Form kapandıktan sonra tabloyu yenile
                LoadTable(dataGridView1, "SELECT * FROM BSMSMEWCMHEAD", getColumnHeaders());
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
                string isMerkeziKodu = selectedRow.Cells["İş Merkezi Kodu"].Value.ToString();

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
                                string deleteQueryHead = "DELETE FROM BSMSMEWCMHEAD WHERE WCMDOCNUM = @IsMerkeziKodu";
                                using (SqlCommand commandHead = new SqlCommand(deleteQueryHead, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandHead.Parameters.AddWithValue("@IsMerkeziKodu", isMerkeziKodu);
                                    commandHead.ExecuteNonQuery();
                                }

                                // Silme sorgusu (BSMSMEMATTEXT)
                                string deleteQueryText = "DELETE FROM BSMSMEWCMTEXT WHERE WCMDOCNUM = @IsMerkeziKodu";
                                using (SqlCommand commandText = new SqlCommand(deleteQueryText, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandText.Parameters.AddWithValue("@IsMerkeziKodu", isMerkeziKodu);
                                    commandText.ExecuteNonQuery();
                                }
                                // Silme sorgusu (BSMSMEMATTEXT)
                                string deleteQueryOpr = "DELETE FROM BSMSMEWCMOPR WHERE WCMDOCNUM = @IsMerkeziKodu";
                                using (SqlCommand commandText = new SqlCommand(deleteQueryOpr, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandText.Parameters.AddWithValue("@IsMerkeziKodu", isMerkeziKodu);
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
    H.COMCODE AS [Firma Kodu],
    H.WCMDOCTYPE AS [İş Merkezi Tipi],
    H.WCMDOCNUM AS [İş Merkezi Kodu],
    H.WCMDOCFROM AS [Geçerlilik Başlangıcı],
    H.WCMDOCUNTIL AS [Geçerlilik Bitişi],
    H.MAINWCMDOCTYPE AS [Ana İş Merkezi Tipi],
    H.MAINWCMDOCNUM AS [Ana İş Merkezi Kodu],
    H.CCMDOCTYPE AS [Maliyet Merkezi Tipi],
    H.CCMDOCNUM AS [Maliyet Merkezi Kodu],
    H.WORKTIME AS [Günlük Çalisma Suresi],
    H.ISDELETED AS [Silindi],
    H.ISPASSIVE AS [Pasif Mi?],
    T.LANCODE AS [Dil Kodu], 
    M.DOCTYPETEXT AS [İş Merkezi Tipi], 
    T.WCMSTEXT AS [Kısa Açıklama], 
    T.WCMLTEXT AS [Uzun Açıklama],
    O.OPRDOCTYPE AS [Operasyon Kodu]
FROM 
    BSMSMEWCMHEAD H
LEFT JOIN 
    BSMSMEWCM001 M ON H.COMCODE = M.COMCODE AND H.WCMDOCTYPE = M.DOCTYPE
LEFT JOIN 
    BSMSMEWCMTEXT T ON H.COMCODE = T.COMCODE AND H.WCMDOCTYPE = T.WCMDOCTYPE AND H.WCMDOCNUM = T.WCMDOCNUM 
LEFT JOIN BSMSMEWCMOPR O
    ON H.COMCODE = O.COMCODE AND H.WCMDOCTYPE = O.WCMDOCTYPE AND H.WCMDOCNUM = O.WCMDOCNUM
        WHERE 1=1";

            // TextBox'lara göre dinamik filtreler ekle
            if (!string.IsNullOrEmpty(is_merkezi_tipi_txt.Text))
            {
                query += " AND H.WCMDOCTYPE LIKE @IsMerkeziTipi";
            }
            if (!string.IsNullOrEmpty(is_merkezi_kodu_txt.Text))
            {
                query += " AND H.WCMDOCNUM LIKE @IsMerkeziKodu";
            }
            if (!string.IsNullOrEmpty(ana_is_merkezi_tipi.Text))
            {
                query += " AND H.MAINWCMDOCTYPE LIKE @AnaIsMerkeziTipi";
            }
            if (!string.IsNullOrEmpty(ana_is_merkezi_kodu_txt.Text))
            {
                query += " AND H.MAINWCMDOCNUM LIKE @AnaIsMerkeziKodu";
            }
            if (!string.IsNullOrEmpty(maliyet_merkezi_tipi_txt.Text))
            {
                query += " AND H.CCMDOCTYPE LIKE @MaliyetMerkeziTipi";
            }
            if (!string.IsNullOrEmpty(maliyet_merkezi_tipi_kodu.Text))
            {
                query += " AND H.CCMDOCNUM LIKE @MaliyetMerkeziKodu";
            }
            if (!string.IsNullOrEmpty(calisma_suresi.Text))
            {
                query += " AND H.WORKTIME LIKE @GunlukCalismaSuresi";
            }

            // DateTimePicker'a göre tarih filtresi ekle
            if (dtpBas.Checked)
            {
                query += " AND H.WCMDOCFROM LIKE @GecerlilikBaslangici";
            }
            if (dtpBitis.Checked)
            {
                query += " AND H.WCMDOCUNTIL LIKE @GecerlilikBitisi";
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
                        if (!string.IsNullOrEmpty(is_merkezi_tipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@IsMerkeziTipi", "%" + is_merkezi_tipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(is_merkezi_kodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@IsMerkeziKodu", "%" + is_merkezi_kodu_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(ana_is_merkezi_kodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@AnaIsMerkeziKodu", "%" + ana_is_merkezi_kodu_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(ana_is_merkezi_tipi.Text))
                        {
                            command.Parameters.AddWithValue("@AnaIsMerkeziTipi", "%" + ana_is_merkezi_tipi.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(maliyet_merkezi_tipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@MaliyetMerkeziTipi", "%" + maliyet_merkezi_tipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(maliyet_merkezi_tipi_kodu.Text))
                        {
                            command.Parameters.AddWithValue("@MaliyetMerkeziKodu", "%" + maliyet_merkezi_tipi_kodu.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(calisma_suresi.Text))
                        {
                            command.Parameters.AddWithValue("@GunlukCalismaSuresi", "%" + calisma_suresi.Text + "%");
                        }

                        // DateTimePicker parametrelerini ekle
                        if (dtpBas.Checked)
                        {
                            command.Parameters.AddWithValue("@GecerlilikBaslangici", "%" + dtpBas.Value.ToString("yyyy-MM-dd") + "%");

                        }
                        if (dtpBitis.Checked)
                        {
                            command.Parameters.AddWithValue("@GecerlilikBitisi", "%" + dtpBitis.Value.ToString("yyyy-MM-dd") + "%");

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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void is_merkezi_kodu_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void ana_is_merkezi_tipi_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void ana_is_merkezi_kodu_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void calisma_suresi_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void maliyet_merkezi_tipi_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void maliyet_merkezi_tipi_kodu_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void dtpBas_ValueChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
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
