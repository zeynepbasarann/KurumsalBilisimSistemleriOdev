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
    public partial class birim : Form
    {
        public birim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Butona tıklandığında tüm tablo verilerini getir
            LoadTable(dataGridView1, "SELECT * FROM BSMSMEGEN005", getColumnHeaders());
        }

        private void birim_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yalnızca sütun başlıklarını getir
            LoadTable(dataGridView1, "SELECT * FROM BSMSMEGEN005 WHERE 1=0", getColumnHeaders());
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
                { "UNITCODE", "Birim Kodu" },
                { "UNITTEXT", "Birim Adı" },
                { "ISMAINUNIT", "Ana Birim Mi" },// Yeni sütun
                { "MAINUNITCODE", "Ana Birim Kodu" } // Yeni sütun

            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dilEkle formunu aç
            birimEkle birimEkleForm = new birimEkle();
            birimEkleForm.ShowDialog();

            // Form kapandıktan sonra tabloyu yenile
            LoadTable(dataGridView1, "SELECT * FROM BSMSMEGEN005", getColumnHeaders());
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
                string birimKodu = selectedRow.Cells["UNITCODE"].Value.ToString();
                string birimAdi = selectedRow.Cells["UNITTEXT"].Value.ToString();
                bool AnaBirim = Convert.ToBoolean(selectedRow.Cells["ISMAINUNIT"].Value);
                string anaBirimKodu = selectedRow.Cells["MAINUNITCODE"].Value.ToString();

                // dilGuncelleme formunu oluştur ve bilgileri aktar
                birimGuncelleme birimGuncellemeForm = new birimGuncelleme();
                birimGuncellemeForm.SetBirimBilgileri(firmaKodu, birimKodu, birimAdi, AnaBirim, anaBirimKodu);

                // Formu modal olarak göster
                birimGuncellemeForm.ShowDialog();

                // Form kapandıktan sonra tabloyu yenile
                LoadTable(dataGridView1, "SELECT * FROM BSMSMEGEN005", getColumnHeaders());
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
                string birimKodu = selectedRow.Cells["UNITCODE"].Value.ToString();
                bool AnaBirim = Convert.ToBoolean(selectedRow.Cells["ISMAINUNIT"].Value);
                if (!AnaBirim)
                {
                    MessageBox.Show("Pasif bir operasyon tipi zaten silinemez.");
                    return;
                }
                // Kullanıcıya silme işlemi için onay sor
                DialogResult dialogResult = MessageBox.Show("Bu rota tipi kaydını silmek istediğinizden emin misiniz?",
                                                            "Silme Onayı",
                                                            MessageBoxButtons.YesNo);

                // Eğer kullanıcı "Evet" derse, kaydı sil
                if (dialogResult == DialogResult.Yes)
                {
                    // Veritabanına silme işlemi yapalım
                    string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";
                    string query = "DELETE FROM BSMSMEGEN005 WHERE COMCODE = @FirmaKodu AND UNITCODE = @birimKodu";

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
                                command.Parameters.AddWithValue("@birimKodu", birimKodu);

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

        private void birim_Load_1(object sender, EventArgs e)
        {

        }
    }
}
