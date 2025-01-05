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
    public partial class operasyon_tipi : Form
    {
        public operasyon_tipi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona tıklandığında tüm tablo verilerini getir
            LoadTable(dataGridView1, "SELECT * FROM BSMSMEOPR001", getColumnHeaders());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // dilEkle formunu aç
            operasyonTipiEkle operasyonTipiEkleForm = new operasyonTipiEkle();
            operasyonTipiEkleForm.ShowDialog();

            // Form kapandıktan sonra tabloyu yenile
            LoadTable(dataGridView1, "SELECT * FROM BSMSMEOPR001", getColumnHeaders());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili satırın bilgilerini al
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Satırdaki hücreleri al (Firma Kodu, Dil Kodu, Dil Adı)
                string firmaKodu = selectedRow.Cells["COMCODE"].Value.ToString();
                string operasyonTipiKodu = selectedRow.Cells["DOCTYPE"].Value.ToString();
                string operasyonTipiAdi = selectedRow.Cells["DOCTYPETEXT"].Value.ToString();
                bool pasif = Convert.ToBoolean(selectedRow.Cells["ISPASSIVE"].Value);

                // dilGuncelleme formunu oluştur ve bilgileri aktar
                operasyonTipiGuncelleme operasyonTipiGuncellemeForm = new operasyonTipiGuncelleme();
                operasyonTipiGuncellemeForm.SetOperasyonTipiBilgileri(firmaKodu, operasyonTipiKodu, operasyonTipiAdi,pasif );

                // Formu modal olarak göster
                operasyonTipiGuncellemeForm.ShowDialog();

                // Form kapandıktan sonra tabloyu yenile
                LoadTable(dataGridView1, "SELECT * FROM BSMSMEROT001", getColumnHeaders());
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
            }
        }
        
        private void operasyon_tipi_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yalnızca sütun başlıklarını getir
            LoadTable(dataGridView1, "SELECT * FROM BSMSMEOPR001 WHERE 1=0", getColumnHeaders());
        }
        
        private void LoadTable(DataGridView gridView, string query, Dictionary<string, string> columnHeaders)
        {
            string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e bağlama
                    gridView.DataSource = dataTable;

                    // Sütun başlıklarını ayarlama
                    foreach (var column in columnHeaders)
                    {
                        if (gridView.Columns.Contains(column.Key))
                        {
                            gridView.Columns[column.Key].HeaderText = column.Value;
                        }
                    }

                    // CheckBoxColumn için ayar
                    if (gridView.Columns.Contains("ISPASSIVE"))
                    {
                        gridView.Columns["ISPASSIVE"].HeaderText = "Pasif Mi?";
                        gridView.Columns["ISPASSIVE"].ReadOnly = false; // Kullanıcı checkbox'ı işaretleyebilsin
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }
        
        private Dictionary<string, string> getColumnHeaders()
        {
            return new Dictionary<string, string>
    {
        { "COMCODE", "Firma Kodu" },
        { "DOCTYPETEXT", "Operasyon Tipi Adı" },
        { "DOCTYPE", "Operasyon Tipi Kodu" },
        { "ISPASSIVE", "Pasif Mi?" } // Yeni sütun
    };
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string firmaKodu = selectedRow.Cells["COMCODE"].Value?.ToString();
                string operasyonTipiKodu = selectedRow.Cells["DOCTYPE"].Value?.ToString();
                bool Pasif = Convert.ToBoolean(selectedRow.Cells["ISPASSIVE"].Value);

                if (!Pasif)
                {
                    MessageBox.Show("Pasif bir operasyon tipi zaten silinemez.");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                    "Bu operasyon tipi kaydını silmek istediğinizden emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
                    string query = "DELETE FROM BSMSMEOPR001 WHERE COMCODE = @FirmaKodu AND DOCTYPE = @OperasyonTipiKodu";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@FirmaKodu", firmaKodu);
                                command.Parameters.AddWithValue("@OperasyonTipiKodu", operasyonTipiKodu);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Operasyon Tipi kaydı başarıyla silindi.");
                                    dataGridView1.Rows.Remove(selectedRow);
                                }
                                else
                                {
                                    MessageBox.Show("Silme işlemi başarısız oldu. Kayıt bulunamadı.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Hata: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }


    }
}
