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
    public partial class urun_agaci_ana : Form
    {
        public urun_agaci_ana()
        {
            InitializeComponent();
        }

        private void urun_agaci_ana_Load(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
        private void button1_Click(object sender, EventArgs e)
        {

            string query = @"
        SELECT 
            H.COMCODE AS [FirmaKodu],
            H.BOMDOCTYPE AS [UrunAgaciTipi],
            H.BOMDOCNUM AS [UrunAgaciKodu],
            H.BOMDOCFROM AS [GecerlilikBaslangic],
            H.BOMDOCUNTIL AS [GecerlilikBitis],
            H.MATDOCTYPE AS [MalzemeTipi],
            H.MATDOCNUM AS [MalzemeKodu],
            H.QUANTITY AS [TemelMiktar],
            H.ISDELETED AS [Silindi],
            H.ISPASSIVE AS [PasifMi],
            H.DRAWNUM AS [CizimNumarasi],
            
            
            C.CONTENTNUM AS [IcerikNumarasi],
            C.COMPONENT AS [BilesenKodu],
            C.COMPBOMDOCTYPE AS [KalemUrunAgaciTipi],
            C.COMPBOMDOCNUM AS [KalemUrunAgaciKodu],
            C.QUANTITY AS [BilesenMiktari]
        FROM 
            BSMSMEBOMHEAD H
        LEFT JOIN 
            BSMSMEBOMCONTENT C
            ON H.COMCODE = C.COMCODE 
            AND H.BOMDOCTYPE = C.BOMDOCTYPE 
            AND H.BOMDOCNUM = C.BOMDOCNUM 
            AND H.BOMDOCFROM = C.BOMDOCFROM 
            AND H.BOMDOCUNTIL = C.BOMDOCUNTIL;";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // DataGridView'e veriyi bağla
            dataGridView1.DataSource = dataTable;

            // Başlıkları ayarlamak için fonksiyonu çağır
            SetColumnHeaders();
        }

        private void SetColumnHeaders()
        {
            var columns = dataGridView1.Columns;

            // Kolonları kontrol et ve başlıkları ayarla
            if (columns.Contains("FirmaKodu")) columns["FirmaKodu"].HeaderText = "Firma Kodu";
            if (columns.Contains("UrunAgaciTipi")) columns["UrunAgaciTipi"].HeaderText = "Ürün Ağacı Tipi";
            if (columns.Contains("UrunAgaciKodu")) columns["UrunAgaciKodu"].HeaderText = "Ürün Ağacı Kodu";
            if (columns.Contains("GecerlilikBaslangic")) columns["GecerlilikBaslangic"].HeaderText = "Geçerlilik Başlangıcı";
            if (columns.Contains("GecerlilikBitis")) columns["GecerlilikBitis"].HeaderText = "Geçerlilik Bitişi";
            if (columns.Contains("MalzemeTipi")) columns["MalzemeTipi"].HeaderText = "Malzeme Tipi";
            if (columns.Contains("MalzemeKodu")) columns["MalzemeKodu"].HeaderText = "Malzeme Kodu";
            if (columns.Contains("TemelMiktar")) columns["TemelMiktar"].HeaderText = "Temel Miktar";
            if (columns.Contains("Silindi")) columns["Silindi"].HeaderText = "Silindi?";
            if (columns.Contains("PasifMi")) columns["PasifMi"].HeaderText = "Pasif Mi?";
            if (columns.Contains("CizimNumarasi")) columns["CizimNumarasi"].HeaderText = "Çizim Numarası";

            // BSMGR0BOMCONTENT için başlıklar

            if (columns.Contains("IcerikNumarasi")) columns["IcerikNumarasi"].HeaderText = "İçerik Numarası";
            if (columns.Contains("BilesenKodu")) columns["BilesenKodu"].HeaderText = "Bileşen Kodu";
            if (columns.Contains("KalemUrunAgaciTipi")) columns["KalemUrunAgaciTipi"].HeaderText = "Kalem Ürün Ağacı Tipi";
            if (columns.Contains("KalemUrunAgaciKodu")) columns["KalemUrunAgaciKodu"].HeaderText = "Kalem Ürün Ağacı Kodu";
            if (columns.Contains("BilesenMiktari")) columns["BilesenMiktari"].HeaderText = "Bileşen Miktarı";
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
            {
                return new Dictionary<string, string>
                {
    { "COMCODE", "Firma Kodu" },
    { "BOMDOCTYPE", "Ürün Ağacı Tipi" },
    { "BOMDOCNUM", "Ürün Ağacı Kodu" },
    { "BOMDOCFROM", "Geçerlilik Başlangıcı" },
    { "BOMDOCUNTIL", "Geçerlilik Bitişi" },
    { "MATDOCTYPE", "Malzeme Tipi" },
    { "MATDOCNUM", "Malzeme Kodu" },
    { "QUANTITY", "Temel Miktar" },
    { "ISDELETED", "Silindi?" },
    { "ISPASSIVE", "Pasif Mi?" },
    { "DRAWNUM", "Çizim Numarası" },
    { "CONTENTNUM", "İçerik Numarası" },
    { "COMPONENT", "Bileşen Kodu" },
    { "COMPBOMDOCTYPE", "Kalem Ürün Ağacı Tipi" },
    { "COMPBOMDOCNUM", "Kalem Ürün Ağacı Kodu" },
    { "BILESENDERS", "Bileşen Miktarı" }

};
            };
        }


        private void button2_Click(object sender, EventArgs e)
        {
            UrunAgaciAnaEkle UrunAgaciAnaEkleForm = new UrunAgaciAnaEkle();
            UrunAgaciAnaEkleForm.ShowDialog();
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
                string firmaKodu = selectedRow.Cells["FirmaKodu"].Value.ToString();
                DateTime GBaslangic = DateTime.Parse(selectedRow.Cells["GecerlilikBaslangic"].Value.ToString());
                DateTime GBitis = DateTime.Parse(selectedRow.Cells["GecerlilikBitis"].Value.ToString());
                string malzemeTipi = selectedRow.Cells["MalzemeTipi"].Value.ToString();
                string malzemeKodu = selectedRow.Cells["MalzemeKodu"].Value.ToString();
                bool pasif = Convert.ToBoolean(selectedRow.Cells["PasifMi"].Value);
                string icerikNumarasi = selectedRow.Cells["IcerikNumarasi"]?.Value?.ToString() ?? string.Empty;
                decimal bilesenMiktari = selectedRow.Cells["BilesenMiktari"]?.Value is decimal ? (decimal)selectedRow.Cells["BilesenMiktari"].Value : 0m;
                string urunAgaciTipi = selectedRow.Cells["UrunAgaciTipi"]?.Value?.ToString() ?? string.Empty;
                string urunAgaciKodu = selectedRow.Cells["UrunAgaciKodu"]?.Value?.ToString() ?? string.Empty;
                string bilesenKodu = selectedRow.Cells["BilesenKodu"]?.Value?.ToString() ?? string.Empty;
                string cizimNumarasi = selectedRow.Cells["CizimNumarasi"]?.Value?.ToString() ?? string.Empty;
                decimal temelMiktar = selectedRow.Cells["TemelMiktar"]?.Value is decimal ? (decimal)selectedRow.Cells["TemelMiktar"].Value : 0m;
                string kalemUrunAgaciTipi = selectedRow.Cells["KalemUrunAgaciTipi"]?.Value?.ToString() ?? string.Empty;
                string kalemUrunAgaciKodu = selectedRow.Cells["KalemUrunAgaciKodu"]?.Value?.ToString() ?? string.Empty;
                bool silindi = Convert.ToBoolean(selectedRow.Cells["Silindi"].Value);

                //string netAgirlik =

                // dilGuncelleme formunu oluştur ve bilgileri aktar
                UrunAgaciAnaGuncelle UrunAgaciAnaGuncelleForm = new UrunAgaciAnaGuncelle();
                UrunAgaciAnaGuncelleForm.SetUrunAgaciAnaBilgileri(firmaKodu,
             GBaslangic, GBitis,
             malzemeTipi, malzemeKodu, pasif,
             icerikNumarasi, bilesenMiktari, urunAgaciTipi, urunAgaciKodu,
             bilesenKodu,
             cizimNumarasi, silindi, temelMiktar, kalemUrunAgaciKodu, kalemUrunAgaciTipi);
                UrunAgaciAnaGuncelleForm.ShowDialog();

                // Form kapandıktan sonra tabloyu yenile
                LoadTable(dataGridView1, "SELECT * FROM BSMSMEBOMHEAD", getColumnHeaders());
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
                string urunAgaciKodu = selectedRow.Cells["UrunAgaciKodu"].Value.ToString();

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
                                string deleteQueryHead = "DELETE FROM BSMSMEBOMHEAD WHERE BOMDOCNUM = @UrunAgaciKodu";
                                using (SqlCommand commandHead = new SqlCommand(deleteQueryHead, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandHead.Parameters.AddWithValue("@UrunAgaciKodu", urunAgaciKodu);
                                    commandHead.ExecuteNonQuery();
                                }

                                // Silme sorgusu (BSMSMEMATTEXT)
                                string deleteQueryBOM = "DELETE FROM BSMSMEBOMCONTENT WHERE BOMDOCNUM = @UrunAgaciKodu";
                                using (SqlCommand commandText = new SqlCommand(deleteQueryBOM, connection, transaction))
                                {
                                    // Parametreyi ekle
                                    commandText.Parameters.AddWithValue("@UrunAgaciKodu", urunAgaciKodu);
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
            H.BOMDOCTYPE AS [UrunAgaciTipi],
            H.BOMDOCNUM AS [UrunAgaciKodu],
            H.BOMDOCFROM AS [GecerlilikBaslangic],
            H.BOMDOCUNTIL AS [GecerlilikBitis],
            H.MATDOCTYPE AS [MalzemeTipi],
            H.MATDOCNUM AS [MalzemeKodu],
            H.QUANTITY AS [TemelMiktar],
            H.ISDELETED AS [Silindi],
            H.ISPASSIVE AS [PasifMi],
            H.DRAWNUM AS [CizimNumarasi],
            
            
            C.CONTENTNUM AS [IcerikNumarasi],
            C.COMPONENT AS [BilesenKodu],
            C.COMPBOMDOCTYPE AS [KalemUrunAgaciTipi],
            C.COMPBOMDOCNUM AS [KalemUrunAgaciKodu],
            C.QUANTITY AS [BilesenMiktari]
        FROM 
            BSMSMEBOMHEAD H
        LEFT JOIN 
            BSMSMEBOMCONTENT C
            ON H.COMCODE = C.COMCODE 
            AND H.BOMDOCTYPE = C.BOMDOCTYPE 
            AND H.BOMDOCNUM = C.BOMDOCNUM 
            AND H.BOMDOCFROM = C.BOMDOCFROM 
            AND H.BOMDOCUNTIL = C.BOMDOCUNTIL
        WHERE 1=1";

            // TextBox'lara göre dinamik filtreler ekle
            if (!string.IsNullOrEmpty(urun_agaci_tipi_txt.Text))
            {
                query += " AND H.BOMDOCTYPE LIKE @UrunAgaciTipi";
            }
            if (!string.IsNullOrEmpty(urun_agaci_kodu_txt.Text))
            {
                query += " AND H.BOMDOCNUM LIKE @UrunAgaciKodu";
            }
            if (!string.IsNullOrEmpty(malzeme_tipi_txt.Text))
            {
                query += " AND H.MATDOCTYPE LIKE @MalzemeTipi";
            }
            if (!string.IsNullOrEmpty(malzeme_kodu_txt.Text))
            {
                query += " AND H.MATDOCNUM LIKE @MalzemeKodu";
            }
            if (!string.IsNullOrEmpty(cizim_numarasi_txt.Text))
            {
                query += " AND H.DRAWNUM LIKE @CizimNumarasi";
            }
            if (!string.IsNullOrEmpty(temel_miktar_txt.Text))
            {
                query += " AND H.QUANTITY LIKE @TemelMiktar";
            }

            // DateTimePicker'a göre tarih filtresi ekle
            if (dtpBas.Checked)
            {
                query += " AND H.ROTDOCFROM LIKE @GecerlilikBaslangici";
            }
            if (dtpBitis.Checked)
            {
                query += " AND H.ROTDOCUNTIL LIKE @GecerlilikBitisi";
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
                        if (!string.IsNullOrEmpty(urun_agaci_tipi_txt.Text))
                        {
                            command.Parameters.AddWithValue("@UrunAgaciTipi", "%" + urun_agaci_tipi_txt.Text + "%");
                        }
                        if (!string.IsNullOrEmpty(urun_agaci_kodu_txt.Text))
                        {
                            command.Parameters.AddWithValue("@UrunAgaciKodu", "%" + urun_agaci_kodu_txt.Text + "%");
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

        private void urun_agaci_tipi_txt_TextChanged(object sender, EventArgs e)
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
