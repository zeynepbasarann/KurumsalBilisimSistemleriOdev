using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class rota_yonetimi : Form
    {
        public rota_yonetimi()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {

            string query = @"
        SELECT 
    RH.COMCODE AS [Firma Kodu],
    RH.ROTDOCTYPE AS [Rota Tipi],
    RH.ROTDOCNUM AS [Rota Kodu],
    RH.ROTDOCFROM AS [Geçerlilik Başlangıcı],
    RH.ROTDOCUNTIL AS [Geçerlilik Bitişi],
    RH.MATDOCTYPE AS [Malzeme Tipi],
    RH.MATDOCNUM AS [Malzeme Kodu],
    RH.QUANTITY AS [Temel Miktar],
    RH.ISDELETED AS [Silindi],
    RH.ISPASSIVE AS [Pasif Mi?],
    RH.DRAWNUM AS [Çizim Numarası],
    ROC.OPRNUM AS [Operasyon Numarası],
    ROC.WCMDOCTYPE AS [İş Merkezi Tipi],
    ROC.WCMDOCNUM AS [İş Merkezi Kodu],
    ROC.OPRDOCTYPE AS [Operasyon Kodu],
    ROC.SETUPTIME AS [Hazırlık Süresi],
    ROC.MACHINETIME AS [Makine Süresi],
    ROC.LABOURTIME AS [İşçilik Süresi],
    RBC.BOMDOCTYPE AS [Ürün Ağacı Tipi],
    RBC.BOMDOCNUM AS [Ürün Ağacı Kodu],
    RBC.CONTENTNUM AS [İçerik Numarası],
    RBC.COMPONENT AS [Bileşen Kodu],
    RBC.QUANTITY AS [Bileşen Miktarı]
FROM 
    BSMSMEROTHEAD RH
LEFT JOIN BSMSMEROTOPRCONTENT ROC 
    ON RH.COMCODE = ROC.COMCODE 
    AND RH.ROTDOCTYPE = ROC.ROTDOCTYPE 
    AND RH.ROTDOCNUM = ROC.ROTDOCNUM
    AND RH.ROTDOCFROM = ROC.ROTDOCFROM
LEFT JOIN BSMSMEROTBOMCONTENT RBC 
    ON RH.COMCODE = RBC.COMCODE 
    AND RH.ROTDOCTYPE = RBC.ROTDOCTYPE 
    AND RH.ROTDOCNUM = RBC.ROTDOCNUM
    AND RH.ROTDOCFROM = RBC.ROTDOCFROM;

    ";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // DataGridView'e veri bağlama
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;

            // Sütun başlıklarını ayarla
            SetColumnHeaders(dataGridView1);
        }

        private void SetColumnHeaders(DataGridView dataGridView)
        {
            dataGridView.Columns["Firma Kodu"].HeaderText = "Firma Kodu";
            dataGridView.Columns["Rota Tipi"].HeaderText = "Rota Tipi";
            dataGridView.Columns["Rota Kodu"].HeaderText = "Rota Kodu";
            dataGridView.Columns["Geçerlilik Başlangıcı"].HeaderText = "Geçerlilik Başlangıcı";
            dataGridView.Columns["Geçerlilik Bitişi"].HeaderText = "Geçerlilik Bitişi";
            dataGridView.Columns["Malzeme Tipi"].HeaderText = "Malzeme Tipi";
            dataGridView.Columns["Malzeme Kodu"].HeaderText = "Malzeme Kodu";
            dataGridView.Columns["Temel Miktar"].HeaderText = "Temel Miktar";
            dataGridView.Columns["Silindi"].HeaderText = "Silindi?";
            dataGridView.Columns["Pasif Mi?"].HeaderText = "Pasif Mi?";
            dataGridView.Columns["Çizim Numarası"].HeaderText = "Çizim Numarası";
            dataGridView.Columns["Operasyon Numarası"].HeaderText = "Operasyon Numarası";
            dataGridView.Columns["İş Merkezi Tipi"].HeaderText = "İş Merkezi Tipi";
            dataGridView.Columns["İş Merkezi Kodu"].HeaderText = "İş Merkezi Kodu";
            dataGridView.Columns["Operasyon Kodu"].HeaderText = "Operasyon Kodu";
            dataGridView.Columns["Hazırlık Süresi"].HeaderText = "Hazırlık Süresi";
            dataGridView.Columns["Makine Süresi"].HeaderText = "Makine Süresi";
            dataGridView.Columns["İşçilik Süresi"].HeaderText = "İşçilik Süresi";
            dataGridView.Columns["Ürün Ağacı Tipi"].HeaderText = "Ürün Ağacı Tipi";
            dataGridView.Columns["Ürün Ağacı Kodu"].HeaderText = "Ürün Ağacı Kodu";
            dataGridView.Columns["İçerik Numarası"].HeaderText = "İçerik Numarası";
            dataGridView.Columns["Bileşen Kodu"].HeaderText = "Bileşen Kodu";
            dataGridView.Columns["Bileşen Miktarı"].HeaderText = "Bileşen Miktarı";
        }


        // Optionally, make some columns read-only or set additional properties



        private void button2_Click(object sender, EventArgs e)
        {
            // dilEkle formunu aç
            rotaYonEkle rotaYonEkleForm = new rotaYonEkle();
            rotaYonEkleForm.ShowDialog();

            // Form kapandıktan sonra tabloyu yenile

        }
        private void rotayonetimi_LOAD(object sender, EventArgs e)
        {
            // You can load an empty table structure or some default data on form load if necessary
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add any additional functionality for this button, if needed
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
        { "Firma Kodu", "Firma Kodu" },
        { "Rota Tipi", "Rota Tipi" },
        { "Rota Kodu", "Rota Kodu" },
        { "Geçerlilik Başlangıcı", "Geçerlilik Başlangıcı" },
        { "Geçerlilik Bitişi", "Geçerlilik Bitişi" },
        { "Malzeme Tipi", "Malzeme Tipi" },
        { "Malzeme Kodu", "Malzeme Kodu" },
        { "Temel Miktar", "Temel Miktar" },
        { "Silindi", "Silindi?" },
        { "Pasif Mi?", "Pasif Mi?" },
        { "Çizim Numarası", "Çizim Numarası" },
        { "Operasyon Numarası", "Operasyon Numarası" },
        { "İş Merkezi Tipi", "İş Merkezi Tipi" },
        { "İş Merkezi Kodu", "İş Merkezi Kodu" },
        { "Operasyon Kodu", "Operasyon Kodu" },
        { "Hazırlık Süresi", "Hazırlık Süresi" },
        { "Makine Süresi", "Makine Süresi" },
        { "İşçilik Süresi", "İşçilik Süresi" },
        { "Ürün Ağacı Tipi", "Ürün Ağacı Tipi" },
        { "Ürün Ağacı Kodu", "Ürün Ağacı Kodu" },
        { "İçerik Numarası", "İçerik Numarası" },
        { "Bileşen Kodu", "Bileşen Kodu" },
        { "Bileşen Miktarı", "Bileşen Miktarı" }
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
                // Seçilen satırdaki verileri al
                string firmaKodu = selectedRow.Cells["Firma Kodu"].Value.ToString();
                string isMerkeziTipi = selectedRow.Cells["İş Merkezi Tipi"].Value.ToString();
                string isMerkeziKodu = selectedRow.Cells["İş Merkezi Kodu"].Value.ToString();
                DateTime GBaslangic = DateTime.Parse(selectedRow.Cells["Geçerlilik Başlangıcı"].Value.ToString());
                DateTime GBitis = DateTime.Parse(selectedRow.Cells["Geçerlilik Bitişi"].Value.ToString());
                string malzemeTipi = selectedRow.Cells["Malzeme Tipi"].Value.ToString();
                string malzemeKodu = selectedRow.Cells["Malzeme Kodu"].Value.ToString();
                string rotaTipi = selectedRow.Cells["Rota Tipi"].Value.ToString();
                bool pasif = Convert.ToBoolean(selectedRow.Cells["Pasif Mi?"].Value);
                string rotaKodu = selectedRow.Cells["Rota Kodu"]?.Value?.ToString() ?? string.Empty; // Varsayılan değer boş string
                string operasyonNumarasi = selectedRow.Cells["Operasyon Numarası"]?.Value?.ToString() ?? string.Empty;
                string icerikNumarasi = selectedRow.Cells["İçerik Numarası"]?.Value?.ToString() ?? string.Empty;
                decimal bilesenMiktari = selectedRow.Cells["Bileşen Miktarı"]?.Value is decimal ? (decimal)selectedRow.Cells["Bileşen Miktarı"].Value : 0m;
                string urunAgaciTipi = selectedRow.Cells["Ürün Ağacı Tipi"]?.Value?.ToString() ?? string.Empty;
                string urunAgaciKodu = selectedRow.Cells["Ürün Ağacı Kodu"]?.Value?.ToString() ?? string.Empty;
                string operasyonKodu = selectedRow.Cells["Operasyon Kodu"]?.Value?.ToString() ?? string.Empty;
                decimal hazirlikSuresi = selectedRow.Cells["Hazırlık Süresi"]?.Value is decimal ? (decimal)selectedRow.Cells["Hazırlık Süresi"].Value : 0m;
                decimal makineSuresi = selectedRow.Cells["Makine Süresi"]?.Value is decimal ? (decimal)selectedRow.Cells["Makine Süresi"].Value : 0m;
                decimal iscilikSuresi = selectedRow.Cells["İşçilik Süresi"]?.Value is decimal ? (decimal)selectedRow.Cells["İşçilik Süresi"].Value : 0m;
                string bilesenKodu = selectedRow.Cells["Bileşen Kodu"]?.Value?.ToString() ?? string.Empty;
                string cizimNumarasi = selectedRow.Cells["Çizim Numarası"]?.Value?.ToString() ?? string.Empty;
                decimal temelMiktar = selectedRow.Cells["Temel Miktar"]?.Value is decimal ? (decimal)selectedRow.Cells["Temel Miktar"].Value : 0m;

                bool silindi = Convert.ToBoolean(selectedRow.Cells["Silindi"].Value);

                //string netAgirlik =

                // dilGuncelleme formunu oluştur ve bilgileri aktar
                rotaYonGuncelle rotaYonGuncelleForm = new rotaYonGuncelle();
                rotaYonGuncelleForm.SetRotaYonetimiBilgileri(firmaKodu, isMerkeziTipi, isMerkeziKodu, GBaslangic, GBitis, malzemeTipi, malzemeKodu, rotaTipi, pasif, rotaKodu, operasyonNumarasi, icerikNumarasi, bilesenMiktari, urunAgaciTipi, urunAgaciKodu, operasyonKodu, hazirlikSuresi, makineSuresi, iscilikSuresi, bilesenKodu, cizimNumarasi, silindi, temelMiktar);
                // Formu modal olarak göster
                rotaYonGuncelleForm.ShowDialog();

                // Form kapandıktan sonra tabloyu yenile
                LoadTable(dataGridView1, "SELECT * FROM BSMSMEROTHEAD", getColumnHeaders());
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
                string rotaKodu = selectedRow.Cells["Rota Kodu"].Value.ToString();

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
                                string deleteQueryHead = "DELETE FROM BSMSMEROTHEAD WHERE ROTDOCNUM = @RotaKodu";
                                using (SqlCommand commandHead = new SqlCommand(deleteQueryHead, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandHead.Parameters.AddWithValue("@RotaKodu", rotaKodu);
                                    commandHead.ExecuteNonQuery();
                                }

                                // Silme sorgusu (BSMSMEMATTEXT)
                                string deleteQueryBOM = "DELETE FROM BSMSMEROTBOMCONTENT WHERE ROTDOCNUM = @RotaKodu";
                                using (SqlCommand commandText = new SqlCommand(deleteQueryBOM, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandText.Parameters.AddWithValue("@RotaKodu", rotaKodu);
                                    commandText.ExecuteNonQuery();
                                }
                                string deleteQueryOpr = "DELETE FROM BSMSMEROTOPRCONTENT WHERE ROTDOCNUM = @RotaKodu";
                                using (SqlCommand commandText = new SqlCommand(deleteQueryOpr, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandText.Parameters.AddWithValue("@RotaKodu", rotaKodu);
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
    RH.COMCODE AS [Firma Kodu],
    RH.ROTDOCTYPE AS [Rota Tipi],
    RH.ROTDOCNUM AS [Rota Kodu],
    RH.ROTDOCFROM AS [Geçerlilik Başlangıcı],
    RH.ROTDOCUNTIL AS [Geçerlilik Bitişi],
    RH.MATDOCTYPE AS [Malzeme Tipi],
    RH.MATDOCNUM AS [Malzeme Kodu],
    RH.QUANTITY AS [Temel Miktar],
    RH.ISDELETED AS [Silindi],
    RH.ISPASSIVE AS [Pasif Mi?],
    RH.DRAWNUM AS [Çizim Numarası],
    ROC.OPRNUM AS [Operasyon Numarası],
    ROC.WCMDOCTYPE AS [İş Merkezi Tipi],
    ROC.WCMDOCNUM AS [İş Merkezi Kodu],
    ROC.OPRDOCTYPE AS [Operasyon Kodu],
    ROC.SETUPTIME AS [Hazırlık Süresi],
    ROC.MACHINETIME AS [Makine Süresi],
    ROC.LABOURTIME AS [İşçilik Süresi],
    RBC.BOMDOCTYPE AS [Ürün Ağacı Tipi],
    RBC.BOMDOCNUM AS [Ürün Ağacı Kodu],
    RBC.CONTENTNUM AS [İçerik Numarası],
    RBC.COMPONENT AS [Bileşen Kodu],
    RBC.QUANTITY AS [Bileşen Miktarı]
FROM 
    BSMSMEROTHEAD RH
LEFT JOIN BSMSMEROTOPRCONTENT ROC 
    ON RH.COMCODE = ROC.COMCODE 
    AND RH.ROTDOCTYPE = ROC.ROTDOCTYPE 
    AND RH.ROTDOCNUM = ROC.ROTDOCNUM
    AND RH.ROTDOCFROM = ROC.ROTDOCFROM
LEFT JOIN BSMSMEROTBOMCONTENT RBC 
    ON RH.COMCODE = RBC.COMCODE 
    AND RH.ROTDOCTYPE = RBC.ROTDOCTYPE 
    AND RH.ROTDOCNUM = RBC.ROTDOCNUM
    AND RH.ROTDOCFROM = RBC.ROTDOCFROM
        WHERE 1=1";

            // TextBox'lara göre dinamik filtreler ekle
            if (!string.IsNullOrEmpty(rota_tipi_txt.Text))
            {
                query += " AND RH.ROTDOCTYPE LIKE @RotaTipi";
            }
            if (!string.IsNullOrEmpty(rota_kodu_txt.Text))
            {
                query += " AND RH.ROTDOCNUM LIKE @RotaKodu";
            }
            if (!string.IsNullOrEmpty(malzeme_tipi_txt.Text))
            {
                query += " AND RH.MATDOCTYPE LIKE @MalzemeTipi";
            }
            if (!string.IsNullOrEmpty(malzeme_kodu_txt.Text))
            {
                query += " AND RH.MATDOCNUM LIKE @MalzemeKodu";
            }
            if (!string.IsNullOrEmpty(cizim_numarasi_txt.Text))
            {
                query += " AND RH.DRAWNUM LIKE @CizimNumarasi";
            }
            if (!string.IsNullOrEmpty(temel_miktar_txt.Text))
            {
                query += " AND RH.QUANTITY LIKE @TemelMiktar";
            }

            // DateTimePicker'a göre tarih filtresi ekle
            if (dtpBas.Checked)
            {
                query += " AND RH.ROTDOCFROM LIKE @GecerlilikBaslangici";
            }
            if (dtpBitis.Checked)
            {
                query += " AND RH.ROTDOCUNTIL LIKE @GecerlilikBitisi";
            }
            if (chkPasif.Checked)
            {
                query += " AND RH.ISPASSIVE LIKE @PasifMi";
            }
            if (chkSil.Checked)
            {
                query += " AND RH.ISDELETED LIKE @Silindi";
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
                        if (!string.IsNullOrEmpty(rota_tipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@RotaTipi", "%" + rota_tipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(rota_kodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@RotaKodu", "%" + rota_kodu_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(malzeme_tipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@MalzemeTipi", "%" + malzeme_tipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(malzeme_kodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@MalzemeKodu", "%" + malzeme_kodu_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(cizim_numarasi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@CizimNumarasi", "%" + cizim_numarasi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(temel_miktar_txt.Text))
                        {
                            command.Parameters.AddWithValue("@TemelMiktar", "%" + temel_miktar_txt.Text + "%");
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

        private void urun_agaci_tipi_TextChanged(object sender, EventArgs e)
        {
            AramaYap();

        }

        private void urun_agaci_kodu_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void malzeme_tipi_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void malzeme_kodu_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void cizim_numarasi_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void temel_miktar_txt_TextChanged(object sender, EventArgs e)
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

        private void dtpBas_ValueChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            AramaYap();
        }
    }
}
