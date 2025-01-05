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
    public partial class maliyet_merkezi : Form
    {
        public maliyet_merkezi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona tıklandığında tüm tablo verilerini getir
            LoadTable(dataGridView1, "SELECT * FROM BSMSMECCM001", getColumnHeaders());
        }

        private void maliyet_merkezi_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yalnızca sütun başlıklarını getir
            LoadTable(dataGridView1, "SELECT * FROM BSMSMECCM001 WHERE 1=0", getColumnHeaders());
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
                { "DOCTYPETEXT", "Maliyet Merkezi Adı" },
                { "DOCTYPE", "Maliyet Merkezi Kodu" },
                { "ISPASSIVE", "Pasif Mi?" } // Yeni sütun

            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dilEkle formunu aç
            maliyetMerkeziEkle maliyetMerkeziEkleForm = new maliyetMerkeziEkle();
            maliyetMerkeziEkleForm.ShowDialog();

            // Form kapandıktan sonra tabloyu yenile
            LoadTable(dataGridView1, "SELECT * FROM BSMSMECCM001", getColumnHeaders());
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
                string maliyetMerkeziKodu = selectedRow.Cells["DOCTYPE"].Value.ToString();
                string maliyetMerkeziAdi = selectedRow.Cells["DOCTYPETEXT"].Value.ToString();
                bool Pasif = Convert.ToBoolean(selectedRow.Cells["ISPASSIVE"].Value);

                // dilGuncelleme formunu oluştur ve bilgileri aktar
                maliyetMerkeziGuncelleme maliyetMerkeziGuncellemeForm = new maliyetMerkeziGuncelleme();
                maliyetMerkeziGuncellemeForm.SetMaliyetMerkeziBilgileri(firmaKodu, maliyetMerkeziKodu, maliyetMerkeziAdi, Pasif);

                // Formu modal olarak göster
                maliyetMerkeziGuncellemeForm.ShowDialog();

                // Form kapandıktan sonra tabloyu yenile
                LoadTable(dataGridView1, "SELECT * FROM BSMSMECCM001", getColumnHeaders());
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili satır varsa
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Satırdaki hücreleri al (Firma Kodu ve Dil Kodu)
                string firmaKodu = selectedRow.Cells["COMCODE"].Value.ToString();
                string maliyetMerkeziKodu = selectedRow.Cells["DOCTYPE"].Value.ToString();
                bool Pasif = Convert.ToBoolean(selectedRow.Cells["ISPASSIVE"].Value);
                if (!Pasif)
                {
                    MessageBox.Show("Pasif bir operasyon tipi zaten silinemez.");
                    return;
                }
                // Kullanıcıya silme işlemi için onay sor
                DialogResult dialogResult = MessageBox.Show("Bu malzeme tipi kaydını silmek istediğinizden emin misiniz?",
                                                            "Silme Onayı",
                                                            MessageBoxButtons.YesNo);

                // Eğer kullanıcı "Evet" derse, kaydı sil
                if (dialogResult == DialogResult.Yes)
                {
                    // Veritabanına silme işlemi yapalım
                    string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
                    string query = "DELETE FROM BSMSMECCM001 WHERE COMCODE = @FirmaKodu AND DOCTYPE = @MaliyetMerkeziKodu";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // SQL komutunu oluştur
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Parametreleri ekle
                                command.Parameters.AddWithValue("@FirmaKodu", firmaKodu);
                                command.Parameters.AddWithValue("@MaliyetMerkeziKodu", maliyetMerkeziKodu);

                                // Veritabanından kaydı sil
                                int rowsAffected = command.ExecuteNonQuery();

                                // Silme başarılıysa kullanıcıyı bilgilendir
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Rota Tipi kaydı başarıyla silindi.");

                                    // DataGridView'dan seçili satırı anında sil
                                    dataGridView1.Rows.Remove(selectedRow);
                                }
                                else
                                {
                                    MessageBox.Show("Silme işlemi başarısız oldu.");
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
