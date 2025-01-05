namespace WinFormsApp1
{
    partial class malzemeKartiEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dtpBitisTarih = new DateTimePicker();
            dtpBaşTarih = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            tedarik_tipi_txt = new TextBox();
            label4 = new Label();
            malzeme_uzun_acik_txt = new TextBox();
            malzeme_kısa_acik_txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            malzeme_karti_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            cmbFirmaKodu = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            chkIsBom = new CheckBox();
            chkRota = new CheckBox();
            chkSil = new CheckBox();
            chkPasif = new CheckBox();
            cmbMalzemeTipi = new ComboBox();
            cmbMalzemeStokBirimi = new ComboBox();
            cmbDilKodu = new ComboBox();
            cmbBrutAgirlikBirimi = new ComboBox();
            cmbNetAgirlikBirimi = new ComboBox();
            cmbRotaTipi = new ComboBox();
            rota_numarasi_txt = new TextBox();
            urun_agaci_kodu_txt = new TextBox();
            net_agirlik_txt = new TextBox();
            brut_agirlik_txt = new TextBox();
            cmbUrunAgaci = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(555, 436);
            button1.Name = "button1";
            button1.Size = new Size(219, 29);
            button1.TabIndex = 104;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpBitisTarih
            // 
            dtpBitisTarih.Location = new Point(877, 140);
            dtpBitisTarih.Name = "dtpBitisTarih";
            dtpBitisTarih.Size = new Size(250, 27);
            dtpBitisTarih.TabIndex = 103;
            // 
            // dtpBaşTarih
            // 
            dtpBaşTarih.Location = new Point(877, 85);
            dtpBaşTarih.Name = "dtpBaşTarih";
            dtpBaşTarih.Size = new Size(250, 27);
            dtpBaşTarih.TabIndex = 102;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(749, 92);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 101;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(749, 138);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 100;
            label10.Text = "GEÇ. BİT. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(522, 90);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 98;
            label8.Text = "DİL KODU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(749, 45);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 96;
            label7.Text = "MALZEME TİPİ";
            // 
            // tedarik_tipi_txt
            // 
            tedarik_tipi_txt.Location = new Point(603, 366);
            tedarik_tipi_txt.Name = "tedarik_tipi_txt";
            tedarik_tipi_txt.Size = new Size(154, 27);
            tedarik_tipi_txt.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 373);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 94;
            label4.Text = "TEDARİK TİPİ";
            // 
            // malzeme_uzun_acik_txt
            // 
            malzeme_uzun_acik_txt.Location = new Point(250, 121);
            malzeme_uzun_acik_txt.Name = "malzeme_uzun_acik_txt";
            malzeme_uzun_acik_txt.Size = new Size(478, 27);
            malzeme_uzun_acik_txt.TabIndex = 93;
            // 
            // malzeme_kısa_acik_txt
            // 
            malzeme_kısa_acik_txt.Location = new Point(250, 83);
            malzeme_kısa_acik_txt.Name = "malzeme_kısa_acik_txt";
            malzeme_kısa_acik_txt.Size = new Size(195, 27);
            malzeme_kısa_acik_txt.TabIndex = 92;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 122);
            label6.Name = "label6";
            label6.Size = new Size(209, 20);
            label6.TabIndex = 91;
            label6.Text = "MALZEME UZUN AÇIKLAMASI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 87);
            label5.Name = "label5";
            label5.Size = new Size(200, 20);
            label5.TabIndex = 90;
            label5.Text = "MALZEME KISA AÇIKLAMASI";
            // 
            // malzeme_karti_txt
            // 
            malzeme_karti_txt.Location = new Point(603, 44);
            malzeme_karti_txt.Name = "malzeme_karti_txt";
            malzeme_karti_txt.Size = new Size(125, 27);
            malzeme_karti_txt.TabIndex = 89;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 45);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 88;
            label2.Text = "MALZEME KODU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 86;
            label1.Text = "FİRMA KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(555, 6);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 85;
            label3.Text = "MALZEME KARTI OLUŞTUR";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(250, 44);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(195, 28);
            cmbFirmaKodu.TabIndex = 105;
            cmbFirmaKodu.SelectedIndexChanged += cmbFirmaKodu_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 167);
            label11.Name = "label11";
            label11.Size = new Size(163, 20);
            label11.TabIndex = 106;
            label11.Text = "MALZEME STOK BİRİMİ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 217);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 107;
            label12.Text = "NET AĞIRLIK";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 268);
            label13.Name = "label13";
            label13.Size = new Size(140, 20);
            label13.TabIndex = 108;
            label13.Text = "NET AĞIRLIK BİRİMİ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(495, 224);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 109;
            label14.Text = "BRÜT AĞIRLIK";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(451, 170);
            label15.Name = "label15";
            label15.Size = new Size(149, 20);
            label15.TabIndex = 110;
            label15.Text = "BRÜT AĞIRLIK BİRİMİ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(464, 268);
            label16.Name = "label16";
            label16.Size = new Size(124, 20);
            label16.TabIndex = 111;
            label16.Text = "ÜRÜN AĞACI TİPİ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(448, 317);
            label17.Name = "label17";
            label17.Size = new Size(140, 20);
            label17.TabIndex = 112;
            label17.Text = "ÜRÜN AĞACI KODU";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 318);
            label18.Name = "label18";
            label18.Size = new Size(73, 20);
            label18.TabIndex = 113;
            label18.Text = "ROTA TİPİ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 373);
            label19.Name = "label19";
            label19.Size = new Size(124, 20);
            label19.TabIndex = 114;
            label19.Text = "ROTA NUMARASI";
            // 
            // chkIsBom
            // 
            chkIsBom.AutoSize = true;
            chkIsBom.Location = new Point(877, 195);
            chkIsBom.Name = "chkIsBom";
            chkIsBom.Size = new Size(170, 24);
            chkIsBom.TabIndex = 115;
            chkIsBom.Text = "ÜRÜN AĞACI VAR MI";
            chkIsBom.UseVisualStyleBackColor = true;
            chkIsBom.CheckedChanged += chkIsBom_CheckedChanged;
            // 
            // chkRota
            // 
            chkRota.AutoSize = true;
            chkRota.Location = new Point(877, 232);
            chkRota.Name = "chkRota";
            chkRota.Size = new Size(119, 24);
            chkRota.TabIndex = 116;
            chkRota.Text = "ROTA VAR MI";
            chkRota.UseVisualStyleBackColor = true;
            chkRota.CheckedChanged += chkRota_CheckedChanged;
            // 
            // chkSil
            // 
            chkSil.AutoSize = true;
            chkSil.Location = new Point(877, 282);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(80, 24);
            chkSil.TabIndex = 117;
            chkSil.Text = "SİLİNDİ";
            chkSil.UseVisualStyleBackColor = true;
            // 
            // chkPasif
            // 
            chkPasif.AutoSize = true;
            chkPasif.Location = new Point(877, 326);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(88, 24);
            chkPasif.TabIndex = 118;
            chkPasif.Text = "PASİF Mİ";
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // cmbMalzemeTipi
            // 
            cmbMalzemeTipi.FormattingEnabled = true;
            cmbMalzemeTipi.Location = new Point(877, 43);
            cmbMalzemeTipi.Name = "cmbMalzemeTipi";
            cmbMalzemeTipi.Size = new Size(252, 28);
            cmbMalzemeTipi.TabIndex = 119;
            // 
            // cmbMalzemeStokBirimi
            // 
            cmbMalzemeStokBirimi.FormattingEnabled = true;
            cmbMalzemeStokBirimi.Location = new Point(250, 167);
            cmbMalzemeStokBirimi.Name = "cmbMalzemeStokBirimi";
            cmbMalzemeStokBirimi.Size = new Size(151, 28);
            cmbMalzemeStokBirimi.TabIndex = 120;
            // 
            // cmbDilKodu
            // 
            cmbDilKodu.FormattingEnabled = true;
            cmbDilKodu.Location = new Point(603, 84);
            cmbDilKodu.Name = "cmbDilKodu";
            cmbDilKodu.Size = new Size(125, 28);
            cmbDilKodu.TabIndex = 121;
            // 
            // cmbBrutAgirlikBirimi
            // 
            cmbBrutAgirlikBirimi.FormattingEnabled = true;
            cmbBrutAgirlikBirimi.Location = new Point(606, 167);
            cmbBrutAgirlikBirimi.Name = "cmbBrutAgirlikBirimi";
            cmbBrutAgirlikBirimi.Size = new Size(151, 28);
            cmbBrutAgirlikBirimi.TabIndex = 122;
            // 
            // cmbNetAgirlikBirimi
            // 
            cmbNetAgirlikBirimi.FormattingEnabled = true;
            cmbNetAgirlikBirimi.Location = new Point(250, 260);
            cmbNetAgirlikBirimi.Name = "cmbNetAgirlikBirimi";
            cmbNetAgirlikBirimi.Size = new Size(151, 28);
            cmbNetAgirlikBirimi.TabIndex = 123;
            // 
            // cmbRotaTipi
            // 
            cmbRotaTipi.Enabled = false;
            cmbRotaTipi.FormattingEnabled = true;
            cmbRotaTipi.Location = new Point(250, 317);
            cmbRotaTipi.Name = "cmbRotaTipi";
            cmbRotaTipi.Size = new Size(151, 28);
            cmbRotaTipi.TabIndex = 124;
            // 
            // rota_numarasi_txt
            // 
            rota_numarasi_txt.Enabled = false;
            rota_numarasi_txt.Location = new Point(250, 366);
            rota_numarasi_txt.Name = "rota_numarasi_txt";
            rota_numarasi_txt.Size = new Size(151, 27);
            rota_numarasi_txt.TabIndex = 126;
            // 
            // urun_agaci_kodu_txt
            // 
            urun_agaci_kodu_txt.Enabled = false;
            urun_agaci_kodu_txt.Location = new Point(606, 317);
            urun_agaci_kodu_txt.Name = "urun_agaci_kodu_txt";
            urun_agaci_kodu_txt.Size = new Size(151, 27);
            urun_agaci_kodu_txt.TabIndex = 127;
            // 
            // net_agirlik_txt
            // 
            net_agirlik_txt.Location = new Point(250, 217);
            net_agirlik_txt.Name = "net_agirlik_txt";
            net_agirlik_txt.Size = new Size(151, 27);
            net_agirlik_txt.TabIndex = 128;
            // 
            // brut_agirlik_txt
            // 
            brut_agirlik_txt.Location = new Point(603, 220);
            brut_agirlik_txt.Name = "brut_agirlik_txt";
            brut_agirlik_txt.Size = new Size(154, 27);
            brut_agirlik_txt.TabIndex = 129;
            // 
            // cmbUrunAgaci
            // 
            cmbUrunAgaci.Enabled = false;
            cmbUrunAgaci.FormattingEnabled = true;
            cmbUrunAgaci.Location = new Point(606, 268);
            cmbUrunAgaci.Name = "cmbUrunAgaci";
            cmbUrunAgaci.Size = new Size(151, 28);
            cmbUrunAgaci.TabIndex = 130;
            // 
            // malzemeKartiEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1265, 661);
            Controls.Add(cmbUrunAgaci);
            Controls.Add(brut_agirlik_txt);
            Controls.Add(net_agirlik_txt);
            Controls.Add(urun_agaci_kodu_txt);
            Controls.Add(rota_numarasi_txt);
            Controls.Add(cmbRotaTipi);
            Controls.Add(cmbNetAgirlikBirimi);
            Controls.Add(cmbBrutAgirlikBirimi);
            Controls.Add(cmbDilKodu);
            Controls.Add(cmbMalzemeStokBirimi);
            Controls.Add(cmbMalzemeTipi);
            Controls.Add(chkPasif);
            Controls.Add(chkSil);
            Controls.Add(chkRota);
            Controls.Add(chkIsBom);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(dtpBitisTarih);
            Controls.Add(dtpBaşTarih);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tedarik_tipi_txt);
            Controls.Add(label4);
            Controls.Add(malzeme_uzun_acik_txt);
            Controls.Add(malzeme_kısa_acik_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(malzeme_karti_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "malzemeKartiEkle";
            Text = "malzemeKartiEkle";
            Load += malzemeKartiEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtpBitisTarih;
        private DateTimePicker dtpBaşTarih;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private TextBox tedarik_tipi_txt;
        private Label label4;
        private TextBox malzeme_uzun_acik_txt;
        private TextBox malzeme_kısa_acik_txt;
        private Label label6;
        private Label label5;
        private TextBox malzeme_karti_txt;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cmbFirmaKodu;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private CheckBox chkIsBom;
        private CheckBox chkRota;
        private CheckBox chkSil;
        private CheckBox chkPasif;
        private ComboBox cmbMalzemeTipi;
        private ComboBox cmbMalzemeStokBirimi;
        private ComboBox cmbDilKodu;
        private ComboBox cmbBrutAgirlikBirimi;
        private ComboBox cmbNetAgirlikBirimi;
        private ComboBox cmbRotaTipi;
        private TextBox rota_numarasi_txt;
        private TextBox urun_agaci_kodu_txt;
        private TextBox net_agirlik_txt;
        private TextBox brut_agirlik_txt;
        private ComboBox cmbUrunAgaci;
    }
}