using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using System.Data;

namespace WinFormsApp1
{
    public partial class ana_ekran : Form
    {
        public ana_ekran()
        {
            InitializeComponent();

        }







        private void firma_Click(object sender, EventArgs e)
        {
            firma firma = new firma();
            OpenFormInPanel(firma);
        }

        private void operasyonlar_Click(object sender, EventArgs e)
        {
            operasyonlar operasyonlar = new operasyonlar();
            OpenFormInPanel(operasyonlar);
        }
        private void rota_yonetimi_Click(object sender, EventArgs e)
        {
            rota_yonetimi rota_yonetimi = new rota_yonetimi();
            OpenFormInPanel(rota_yonetimi);
        }
        private void urun_agaci_ana_Click(object sender, EventArgs e)
        {
            urun_agaci_ana urun_agaci_ana = new urun_agaci_ana();
            OpenFormInPanel(urun_agaci_ana);
        }
        private void birim_Click(object sender, EventArgs e)
        {
            birim birim = new birim();
            OpenFormInPanel(birim);
        }
        private void dil_Click(object sender, EventArgs e)
        {
            dil dil = new dil();
            OpenFormInPanel(dil);
        }
        private void sehir_Click(object sender, EventArgs e)
        {
            sehir sehir = new sehir();
            OpenFormInPanel(sehir);
        }
        private void ulke_Click(object sender, EventArgs e)
        {
            ulke ulke = new ulke();
            OpenFormInPanel(ulke);
        }
        private void rota_tipi_Click(object sender, EventArgs e)
        {
            rota_tipi rota_tipi = new rota_tipi();
            OpenFormInPanel(rota_tipi);
        }
        private void operasyon_tipi_Click(object sender, EventArgs e)
        {
            operasyon_tipi operasyon_tipi = new operasyon_tipi();
            OpenFormInPanel(operasyon_tipi);
        }
        private void malzeme_tipi_Click(object sender, EventArgs e)
        {
            malzeme_tipi malzeme_tipi = new malzeme_tipi();
            OpenFormInPanel(malzeme_tipi);
        }
        private void maaliyet_merkezi_Click(object sender, EventArgs e)
        {
            maliyet_merkezi maaliyet_merkezi = new maliyet_merkezi();
            OpenFormInPanel(maaliyet_merkezi);
        }
        private void urun_agaci_Click(object sender, EventArgs e)
        {
            urun_agaci urun_agaci = new urun_agaci();
            OpenFormInPanel(urun_agaci);
        }

        private void is_merkezi_tipi_Click(object sender, EventArgs e)
        {

            is_merkezi_tipi is_merkezi_tipi = new is_merkezi_tipi();
            OpenFormInPanel(is_merkezi_tipi);
        }



        private void is_merkezi_Click(object sender, EventArgs e)
        {
            is_merkezi is_merkezi = new is_merkezi();
            OpenFormInPanel(is_merkezi);
        }

        private void maaliyet_merkezi_ana_Click(object sender, EventArgs e)
        {
            maaliyet_merkezi_ana maaliyet_merkezi_ana = new maaliyet_merkezi_ana();
            OpenFormInPanel(maaliyet_merkezi_ana);
        }

        private void malzeme_kartlari_Click(object sender, EventArgs e)
        {
            malzeme_kartlari malzeme_kartlari = new malzeme_kartlari();
            OpenFormInPanel(malzeme_kartlari);
        }


        private void OpenFormInPanel(Form form)
        {
            // Paneli temizle
            panel1.Controls.Clear();

            // Ana formdaki diðer bileþenleri gizle
            foreach (Control control in this.Controls)
            {
                if (control != panel1)
                {
                    control.Visible = false;
                }
            }

            // Form özelliklerini ayarla
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            form.Dock = DockStyle.Fill;

            // Form kapandýðýnda paneli temizle ve ana ekraný geri getir
            form.FormClosed += (s, e) =>
            {
                panel1.Controls.Clear();
                RestoreMainScreen();
            };

            // Formu panele ekle ve göster
            panel1.Controls.Add(form);
            form.Show();
        }

        private void RestoreMainScreen()
        {
            // Ana ekrandaki bileþenleri yeniden görünür yap
            foreach (Control control in this.Controls)
            {
                if (control != panel1)
                {
                    control.Visible = true;
                }
            }
            //malzeme_kartlari.Visible = true;
            //operasyonlar.Visible = true;
        }

        private void ana_ekran_Load(object sender, EventArgs e)
        {

        }
    }
}


