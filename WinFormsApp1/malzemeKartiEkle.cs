using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class malzemeKartiEkle : Form
    {
        public malzemeKartiEkle()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ZEYBASARAN;Initial Catalog=SMEDEMO;Integrated Security=True;";

        private void malzemeKartiEkle_Load(object sender, EventArgs e)
        {
            // Firma Kodu ComboBox'ını doldur
            FillComboBox("SELECT COMCODE, COMTEXT FROM BSMSMEGEN001", cmbFirmaKodu, "COMTEXT", "COMCODE");

            // Diğer ComboBox'ları temizle
            cmbMalzemeTipi.DataSource = null;
            cmbDilKodu.DataSource = null;
            cmbNetAgirlikBirimi.DataSource = null;
            cmbBrutAgirlikBirimi.DataSource = null;
            cmbMalzemeStokBirimi.DataSource = null;
            cmbRotaTipi.DataSource = null;
            cmbUrunAgaci.DataSource = null;
        }

        private void cmbFirmaKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirmaKodu.SelectedValue != null)
            {
                string selectedFirmaKodu = cmbFirmaKodu.SelectedValue.ToString();

                // Malzeme Tipi ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE, DOCTYPETEXT FROM BSMSMEMAT001 WHERE COMCODE = @COMCODE", cmbMalzemeTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                // Dil Kodu ComboBox'ı doldur
                FillComboBox($"SELECT LANCODE, LANTEXT FROM BSMSMEGEN002 WHERE COMCODE = @COMCODE", cmbDilKodu, "LANTEXT", "LANCODE", selectedFirmaKodu);

                // Ağırlık Birimleri ComboBox'larını doldur
                FillComboBox($"SELECT UNITCODE, UNITTEXT FROM BSMSMEGEN005 WHERE COMCODE = @COMCODE", cmbNetAgirlikBirimi, "UNITTEXT", "UNITCODE", selectedFirmaKodu);
                FillComboBox($"SELECT UNITCODE, UNITTEXT FROM BSMSMEGEN005 WHERE COMCODE = @COMCODE", cmbBrutAgirlikBirimi, "UNITTEXT", "UNITCODE", selectedFirmaKodu);
                FillComboBox($"SELECT UNITCODE, UNITTEXT FROM BSMSMEGEN005 WHERE COMCODE = @COMCODE", cmbMalzemeStokBirimi, "UNITTEXT", "UNITCODE", selectedFirmaKodu);

                // Rota Tipi ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE,DOCTYPETEXT FROM BSMSMEROT001 WHERE COMCODE = @COMCODE", cmbRotaTipi, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);

                // Ürün Ağacı ComboBox'ı doldur
                FillComboBox($"SELECT DOCTYPE,DOCTYPETEXT  FROM BSMSMEBOM001 WHERE COMCODE = @COMCODE", cmbUrunAgaci, "DOCTYPETEXT", "DOCTYPE", selectedFirmaKodu);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form üzerindeki değerleri al
            string selectedFirmaKodu = cmbFirmaKodu.SelectedValue?.ToString() ?? "";
            string selectedMalzemeTipi = cmbMalzemeTipi.SelectedValue?.ToString() ?? "";
            string selectedUrunAgaci = cmbUrunAgaci.SelectedValue?.ToString() ?? "";
            string selectedNetAgirlikBirimi = cmbNetAgirlikBirimi.SelectedValue?.ToString() ?? "";
            string selectedBrutAgirlikBirimi = cmbBrutAgirlikBirimi.SelectedValue?.ToString() ?? "";
            string selectedMalzemeStokBirimi = cmbMalzemeStokBirimi.SelectedValue?.ToString() ?? "";
            string selectedDilKodu = cmbDilKodu.SelectedValue?.ToString() ?? "";
            string selectedRotaTipi = cmbRotaTipi.SelectedValue?.ToString() ?? "";

            string query = @"
                INSERT INTO BSMSMEMATHEAD (
                    COMCODE, MATDOCTYPE, MATDOCNUM, MATDOCFROM, MATDOCUNTIL, SUPPLYTYPE, STUNIT, 
                    NETWEIGHT, NWUNIT, BRUTWEIGHT, BWUNIT, ISBOM, BOMDOCTYPE, 
                    BOMDOCNUM, ISROUTE, ROTDOCTYPE, ROTDOCNUM, ISDELETED, ISPASSIVE) 
                VALUES (
                    @FirmaKodu, @MalzemeTipi, @MalzemeKodu, @GBaslangic, @GBitis, @TedarikTipi, 
                    @MalzemeStokBirimi, @NetAgirlik, @NetAgirlikBirimi, @BrutAgirlik, 
                    @BrutAgirlikBirimi, @UrunAgaciVarMi, @UrunAgaci, @UrunAgaciKodu, @RotaVarMi, 
                    @RotaTipi, @RotaNumarasi, @Silindi, @PasifMi);

            
                INSERT INTO BSMSMEMATTEXT (
                    COMCODE ,MATDOCTYPE ,MATDOCNUM ,MATDOCFROM ,MATDOCUNTIL, LANCODE, MATLTEXT, MATSTEXT)
                VALUES (
                    @FirmaKodu, @MalzemeTipi, @MalzemeKodu, @GBaslangic, @GBitis, @DilKodu, @MalzemeUzunAciklama, @MalzemeKisaAciklama)";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FirmaKodu", selectedFirmaKodu);
                        command.Parameters.AddWithValue("@MalzemeTipi", selectedMalzemeTipi);
                        command.Parameters.AddWithValue("@MalzemeKodu", malzeme_karti_txt.Text);
                        command.Parameters.AddWithValue("@GBaslangic", DateTime.Now);
                        command.Parameters.AddWithValue("@GBitis", DateTime.Now.AddYears(1));
                        command.Parameters.AddWithValue("@TedarikTipi", tedarik_tipi_txt.Text);
                        command.Parameters.AddWithValue("@MalzemeStokBirimi", selectedMalzemeStokBirimi);
                        command.Parameters.AddWithValue("@NetAgirlik", net_agirlik_txt.Text);
                        command.Parameters.AddWithValue("@NetAgirlikBirimi", selectedNetAgirlikBirimi);
                        command.Parameters.AddWithValue("@BrutAgirlik", brut_agirlik_txt.Text);
                        command.Parameters.AddWithValue("@BrutAgirlikBirimi", selectedBrutAgirlikBirimi);
                        command.Parameters.AddWithValue("@UrunAgaciVarMi", chkIsBom.Checked);
                        command.Parameters.AddWithValue("@UrunAgaci", selectedUrunAgaci);
                        command.Parameters.AddWithValue("@UrunAgaciKodu", urun_agaci_kodu_txt.Text);
                        command.Parameters.AddWithValue("@RotaVarMi", chkRota.Checked);
                        command.Parameters.AddWithValue("@RotaTipi", selectedRotaTipi);

                        command.Parameters.AddWithValue("@RotaNumarasi", rota_numarasi_txt.Text);
                        command.Parameters.AddWithValue("@Silindi", chkSil.Checked);
                        command.Parameters.AddWithValue("@PasifMi", chkPasif.Checked);



                        command.Parameters.AddWithValue("@DilKodu", selectedDilKodu);
                        command.Parameters.AddWithValue("@MalzemeUzunAciklama", malzeme_uzun_acik_txt.Text);
                        command.Parameters.AddWithValue("@MalzemeKisaAciklama", malzeme_kısa_acik_txt.Text);



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

        private void chkRota_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRota.Checked)
            {
                cmbRotaTipi.Enabled = true;
                rota_numarasi_txt.Enabled = true;
            }
            else
            {
                cmbRotaTipi.Enabled = false;
                rota_numarasi_txt.Enabled = false;
            }
        }

        private void chkIsBom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsBom.Checked)
            {
                cmbUrunAgaci.Enabled = true;
                urun_agaci_kodu_txt.Enabled = true;
            }
            else
            {
                cmbUrunAgaci.Enabled = false;
                urun_agaci_kodu_txt.Enabled = false;
            }
            }
    }
}
