using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class malzeme_kartlari : Form
    {
        public malzeme_kartlari()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {

            string query = @"
                SELECT 
    H.COMCODE AS [Firma Kodu],
    H.MATDOCTYPE AS [Malzeme Tipi],
    H.MATDOCNUM AS [Malzeme Kodu],
    H.MATDOCFROM AS [Geçerlilik Başlangıcı],
    H.MATDOCUNTIL AS [Geçerlilik Bitişi],
    H.SUPPLYTYPE AS [Tedarik Tipi],
    H.STUNIT AS [Malzeme Stok Birimi],
    H.NETWEIGHT AS [Net Ağırlık],
    H.NWUNIT AS [Net Ağırlık Birimi],
    H.BRUTWEIGHT AS [Brüt Ağırlık],
    H.BWUNIT AS [Brüt Ağırlık Birimi],
    H.ISBOM AS [Ürün Ağacı Var Mı?],
    H.BOMDOCTYPE AS [Ürün Ağacı Tipi],
    H.BOMDOCNUM AS [Ürün Ağacı Kodu],
    H.ISROUTE AS [Rota Var Mı?],
    H.ROTDOCTYPE AS [Rota Tipi],
    H.ROTDOCNUM AS [Rota Numarası],
    H.ISDELETED AS [Silindi],
    H.ISPASSIVE AS [Pasif Mi?],
    T.LANCODE AS [Dil Kodu], 
    M.DOCTYPETEXT AS [Tedarik Tipi], 
    T.MATSTEXT AS [Kısa Açıklama], 
    T.MATLTEXT AS [Uzun Açıklama]
FROM 
    BSMSMEMATHEAD H
LEFT JOIN 
    BSMSMEMAT001 M ON H.COMCODE = M.COMCODE AND H.MATDOCTYPE = M.DOCTYPE
LEFT JOIN 
    BSMSMEMATTEXT T ON H.COMCODE = T.COMCODE AND H.MATDOCTYPE = T.MATDOCTYPE AND H.MATDOCNUM = T.MATDOCNUM ";

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
            if (columns.Contains("MalzemeTipi")) columns["MalzemeTipi"].HeaderText = "Malzeme Tipi";
            if (columns.Contains("MalzemeKodu")) columns["MalzemeKodu"].HeaderText = "Malzeme Kodu";
            if (columns.Contains("GecerlilikBaslangic")) columns["GecerlilikBaslangic"].HeaderText = "Geçerlilik Başlangıcı";
            if (columns.Contains("GecerlilikBitis")) columns["GecerlilikBitis"].HeaderText = "Geçerlilik Bitişi";
            if (columns.Contains("TedarikTipi")) columns["TedarikTipi"].HeaderText = "Tedarik Tipi";
            if (columns.Contains("MalzemeStokBirimi")) columns["MalzemeStokBirimi"].HeaderText = "Malzeme Stok Birimi";
            if (columns.Contains("NetAgirlik")) columns["NetAgirlik"].HeaderText = "Net Ağırlık";
            if (columns.Contains("NetAgirlikBirimi")) columns["NetAgirlikBirimi"].HeaderText = "Net Ağırlık Birimi";
            if (columns.Contains("BrutAgirlik")) columns["BrutAgirlik"].HeaderText = "Brüt Ağırlık";
            if (columns.Contains("BrutAgirlikBirimi")) columns["BrutAgirlikBirimi"].HeaderText = "Brüt Ağırlık Birimi";
            if (columns.Contains("UrunAgaciVarMi")) columns["UrunAgaciVarMi"].HeaderText = "Ürün Ağacı Var Mı?";
            if (columns.Contains("UrunAgaciTipi")) columns["UrunAgaciTipi"].HeaderText = "Ürün Ağacı Tipi";
            if (columns.Contains("UrunAgaciKodu")) columns["UrunAgaciKodu"].HeaderText = "Ürün Ağacı Kodu";
            if (columns.Contains("RotaVarMi")) columns["RotaVarMi"].HeaderText = "Rota Var Mı?";
            if (columns.Contains("RotaTipi")) columns["RotaTipi"].HeaderText = "Rota Tipi";
            if (columns.Contains("RotaNumarasi")) columns["RotaNumarasi"].HeaderText = "Rota Numarası";
            if (columns.Contains("Silindi")) columns["Silindi"].HeaderText = "Silindi";
            if (columns.Contains("PasifMi")) columns["PasifMi"].HeaderText = "Pasif Mi?";
            if (columns.Contains("DilKodu")) columns["DilKodu"].HeaderText = "Dil Kodu";
            if (columns.Contains("KisaAciklama")) columns["KisaAciklama"].HeaderText = "Kısa Açıklama";
            if (columns.Contains("UzunAciklama")) columns["UzunAciklama"].HeaderText = "Uzun Açıklama";
        }


        // Optionally, make some columns read-only or set additional properties



        private void button2_Click(object sender, EventArgs e)
        {
            // dilEkle formunu aç
            malzemeKartiEkle malzemeKartiEkleForm = new malzemeKartiEkle();
            malzemeKartiEkleForm.ShowDialog();

            // Form kapandıktan sonra tabloyu yenile

        }
        private void malzeme_kartlari_Load(object sender, EventArgs e)
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
        { "COMCODE", "Firma Kodu" },
        { "MATDOCTYPE", "Malzeme Tipi" },
        { "MATDOCNUM", "Malzeme Kodu" },
        { "LANCODE", "Dil Kodu" },
        { "MATDOCFROM", "Geçerlilik Başlangıcı" },
        { "MATDOCUNTIL", "Geçerlilik Bitişi" },
        { "DOCTYPETEXT", "Tedarik Tipi" },
        { "STUNIT", "Malzeme Stok Birimi" },
        { "NETWEIGHT", "Net Ağırlık" },
        { "NWUNIT", "Net Ağırlık Birimi" },
        { "BRUTWEIGHT", "Brüt Ağırlık" },
        { "BWUNIT", "Brüt Ağırlık Birimi" },
        { "ISBOM", "Ürün Ağacı Var Mı?" },
        { "BOMDOCTYPE", "Ürün Ağacı Tipi" },
        { "BOMDOCNUM", "Ürün Ağacı Numarası" },
        { "ISROUTE", "Rota Var Mı?" },
        { "ROTDOCTYPE", "Rota Tipi" },
        { "ROTDOCNUM", "Rota Numarası" },
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
                string firmaKodu = selectedRow.Cells["Firma Kodu"].Value.ToString();
                string malzemeTipi = selectedRow.Cells["Malzeme Tipi"].Value.ToString();
                string malzemeNumarasi = selectedRow.Cells["Malzeme Kodu"].Value.ToString();
                DateTime gecBaslangic = DateTime.Parse(selectedRow.Cells["Geçerlilik Başlangıcı"].Value.ToString());
                DateTime gecBitis = DateTime.Parse(selectedRow.Cells["Geçerlilik Bitişi"].Value.ToString());
                string dilKodu = selectedRow.Cells["Dil Kodu"].Value.ToString();
                string tedarikTipi = selectedRow.Cells["Tedarik Tipi"].Value.ToString();
                string kisaAciklama = selectedRow.Cells["Kısa Açıklama"].Value.ToString();
                string uzunAciklama = selectedRow.Cells["Uzun Açıklama"].Value.ToString();
                bool pasif = Convert.ToBoolean(selectedRow.Cells["Pasif Mi?"].Value);
                decimal netAgirlik = selectedRow.Cells["Net Ağırlık"]?.Value is decimal ? (decimal)selectedRow.Cells["Net Ağırlık"].Value : 0m;
                string netAgirlikBirimi = selectedRow.Cells["Net Ağırlık Birimi"]?.Value?.ToString() ?? "kg";  // Varsayılan birim
                decimal brutAgirlik = selectedRow.Cells["Brüt Ağırlık"]?.Value is decimal ? (decimal)selectedRow.Cells["Brüt Ağırlık"].Value : 0m;
                string brutAgirlikBirimi = selectedRow.Cells["Brüt Ağırlık Birimi"]?.Value?.ToString() ?? "kg";  // Varsayılan birim
                bool urunAgaciVarMi = selectedRow.Cells["Ürün Ağacı Var Mı?"]?.Value != null && Convert.ToBoolean(selectedRow.Cells["Ürün Ağacı Var Mı?"].Value);  // Varsayılan değer (false)
                bool rotaVarMi = selectedRow.Cells["Rota Var Mı?"]?.Value != null && Convert.ToBoolean(selectedRow.Cells["Rota Var Mı?"].Value);  // Varsayılan değer (false)
                string malStokBrimi = selectedRow.Cells["Malzeme Stok Birimi"].Value.ToString();
                string urunAgaciTipi = selectedRow.Cells["Ürün Ağacı Tipi"].Value.ToString();
                string urunAgaciNum = selectedRow.Cells["Ürün Ağacı Kodu"].Value.ToString();
                string rotaTipi = selectedRow.Cells["Rota Tipi"].Value.ToString();
                string rotaTipiNum = selectedRow.Cells["Rota Numarası"].Value.ToString();
                bool silindi = Convert.ToBoolean(selectedRow.Cells["Silindi"].Value);

                //string netAgirlik =

                // dilGuncelleme formunu oluştur ve bilgileri aktar
                malzemeKartiGuncelle malzemeKartiGuncelleForm = new malzemeKartiGuncelle();
                malzemeKartiGuncelleForm.SetMalzemeBilgileri(firmaKodu, dilKodu, malzemeNumarasi, malzemeTipi, gecBaslangic, gecBitis, tedarikTipi, kisaAciklama, uzunAciklama, pasif, netAgirlik, netAgirlikBirimi, brutAgirlikBirimi, brutAgirlik, urunAgaciVarMi, rotaVarMi, malStokBrimi, urunAgaciTipi, urunAgaciNum, rotaTipi, rotaTipiNum, silindi);

                // Formu modal olarak göster
                malzemeKartiGuncelleForm.ShowDialog();

                // Form kapandıktan sonra tabloyu yenile
                LoadTable(dataGridView1, "SELECT * FROM BSMSMEMATHEAD", getColumnHeaders());
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
                string malzemeKodu = selectedRow.Cells["Malzeme Kodu"].Value.ToString();

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
                                string deleteQueryHead = "DELETE FROM BSMSMEMATHEAD WHERE MATDOCNUM = @MalzemeKodu";
                                using (SqlCommand commandHead = new SqlCommand(deleteQueryHead, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandHead.Parameters.AddWithValue("@MalzemeKodu", malzemeKodu);
                                    commandHead.ExecuteNonQuery();
                                }

                                // Silme sorgusu (BSMSMEMATTEXT)
                                string deleteQueryText = "DELETE FROM BSMSMEMATTEXT WHERE MATDOCNUM = @MalzemeKodu";
                                using (SqlCommand commandText = new SqlCommand(deleteQueryText, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandText.Parameters.AddWithValue("@MalzemeKodu", malzemeKodu);
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
            H.MATDOCTYPE AS [Malzeme Tipi],
            H.MATDOCNUM AS [Malzeme Kodu],
            H.MATDOCFROM AS [Geçerlilik Başlangıcı],
            H.MATDOCUNTIL AS [Geçerlilik Bitisi],
            H.SUPPLYTYPE AS [Tedarik Tipi],
            H.STUNIT AS [Malzeme Stok Birimi],
            H.NETWEIGHT AS [Net Ağırlık],
            H.NWUNIT AS [Net Ağırlık Birimi],
            H.BRUTWEIGHT AS [Brüt Ağırlık],
            H.BWUNIT AS [Brüt Ağırlık Birimi],
            H.ISBOM AS [Ürün Ağacı Var Mı?],
            H.BOMDOCTYPE AS [Ürün Ağacı Tipi],
            H.BOMDOCNUM AS [Ürün Ağacı Kodu],
            H.ISROUTE AS [Rota Var Mı?],
            H.ROTDOCTYPE AS [Rota Tipi],
            H.ROTDOCNUM AS [Rota Numarası],
            H.ISDELETED AS [Silindi],
            H.ISPASSIVE AS [Pasif Mi?],
            T.LANCODE AS [Dil Kodu], 
            M.DOCTYPETEXT AS [Tedarik Tipi], 
            T.MATSTEXT AS [Kısa Açıklama], 
            T.MATLTEXT AS [Uzun Açıklama]
        FROM 
            BSMSMEMATHEAD H
        LEFT JOIN 
            BSMSMEMAT001 M ON H.COMCODE = M.COMCODE AND H.MATDOCTYPE = M.DOCTYPE
        LEFT JOIN 
            BSMSMEMATTEXT T ON H.COMCODE = T.COMCODE AND H.MATDOCTYPE = T.MATDOCTYPE AND H.MATDOCNUM = T.MATDOCNUM
        WHERE 1=1";

            // TextBox'lara göre dinamik filtreler ekle
            if (!string.IsNullOrEmpty(malzeme_karti_txt.Text))
            {
                query += " AND H.MATDOCNUM LIKE @MalzemeKodu";
            }
            if (!string.IsNullOrEmpty(malzeme_tipi_txt.Text))
            {
                query += " AND H.MATDOCTYPE LIKE @MalzemeTipi";
            }
            if (!string.IsNullOrEmpty(tedarik_tipi_txt.Text))
            {
                query += " AND H.SUPPLYTYPE LIKE @TedarikTipi";
            }
            if (!string.IsNullOrEmpty(dil_kodu_txt.Text))
            {
                query += " AND T.LANCODE LIKE @DilKodu";
            }

            // DateTimePicker'a göre tarih filtresi ekle
            if (dtpBas.Checked)
            {
                query += " AND H.MATDOCFROM LIKE @GecerlilikBaslangici";
            }
            if (dtpBitis.Checked)
            {
                query += " AND H.MATDOCUNTIL LIKE @GecerlilikBitisi";
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
                        if (!string.IsNullOrEmpty(malzeme_karti_txt.Text))
                        {
                            command.Parameters.AddWithValue("@MalzemeKodu", "%" + malzeme_karti_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(malzeme_tipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@MalzemeTipi", "%" + malzeme_tipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(tedarik_tipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@TedarikTipi", "%" + tedarik_tipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(dil_kodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@DilKodu", "%" + dil_kodu_txt.Text + "%");
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




        // TextBox'daki değişiklikleri yakalamak için:


        private void malzeme_karti_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void malzeme_tipi_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void tedarik_tipi_txt_TextChanged(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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
