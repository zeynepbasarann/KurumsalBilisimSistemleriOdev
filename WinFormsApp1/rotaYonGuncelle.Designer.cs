namespace WinFormsApp1
{
    partial class rotaYonGuncelle
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
            cmbUrunAgaciTipi = new ComboBox();
            cmbFirmaKodu = new ComboBox();
            button1 = new Button();
            bilesen_miktar_txt = new TextBox();
            label22 = new Label();
            bilesen_kodu_txt = new TextBox();
            label21 = new Label();
            makine_suresi_txt = new TextBox();
            label19 = new Label();
            hazirlik_suresi_txt = new TextBox();
            label20 = new Label();
            icerik_numarasi_txt = new TextBox();
            label17 = new Label();
            iscilik_suresi_txt = new TextBox();
            label18 = new Label();
            operasyon_kodu_txt = new TextBox();
            label16 = new Label();
            cmbIsMerkeziTipi = new ComboBox();
            is_merekezi_kodu_txt = new TextBox();
            label14 = new Label();
            label15 = new Label();
            operasyon_numarasi_txt = new TextBox();
            label13 = new Label();
            cmbRotaTipi = new ComboBox();
            rota_kodu_txt = new TextBox();
            label7 = new Label();
            label12 = new Label();
            cmbMalzemeTipi = new ComboBox();
            temel_miktar_txt = new TextBox();
            label11 = new Label();
            cizim_numarasi_txt = new TextBox();
            label10 = new Label();
            malzeme_kodu_txt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            chkPasif = new CheckBox();
            chkSil = new CheckBox();
            dtpGBitis = new DateTimePicker();
            dtpGBas = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            urun_agaci_kodu_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbUrunAgaciTipi
            // 
            cmbUrunAgaciTipi.Enabled = false;
            cmbUrunAgaciTipi.FormattingEnabled = true;
            cmbUrunAgaciTipi.Location = new Point(523, 63);
            cmbUrunAgaciTipi.Name = "cmbUrunAgaciTipi";
            cmbUrunAgaciTipi.Size = new Size(151, 28);
            cmbUrunAgaciTipi.TabIndex = 237;
            cmbUrunAgaciTipi.DropDown += rotaYonGuncelle_Load;
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.Enabled = false;
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(182, 63);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 236;
            // 
            // button1
            // 
            button1.Location = new Point(492, 515);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 235;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // bilesen_miktar_txt
            // 
            bilesen_miktar_txt.Location = new Point(880, 160);
            bilesen_miktar_txt.Name = "bilesen_miktar_txt";
            bilesen_miktar_txt.Size = new Size(125, 27);
            bilesen_miktar_txt.TabIndex = 234;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(724, 163);
            label22.Name = "label22";
            label22.Size = new Size(128, 20);
            label22.TabIndex = 233;
            label22.Text = "BİLEŞEN  MİKTARI";
            // 
            // bilesen_kodu_txt
            // 
            bilesen_kodu_txt.Location = new Point(880, 114);
            bilesen_kodu_txt.Name = "bilesen_kodu_txt";
            bilesen_kodu_txt.Size = new Size(125, 27);
            bilesen_kodu_txt.TabIndex = 232;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(724, 117);
            label21.Name = "label21";
            label21.Size = new Size(112, 20);
            label21.TabIndex = 231;
            label21.Text = "BİLEŞEN  KODU";
            // 
            // makine_suresi_txt
            // 
            makine_suresi_txt.Location = new Point(523, 346);
            makine_suresi_txt.Name = "makine_suresi_txt";
            makine_suresi_txt.Size = new Size(151, 27);
            makine_suresi_txt.TabIndex = 230;
            // 
            // label19
            // 
            label19.Location = new Point(367, 359);
            label19.Name = "label19";
            label19.Size = new Size(162, 45);
            label19.TabIndex = 229;
            label19.Text = "OPERASYON MAKİNE SÜRESİ";
            // 
            // hazirlik_suresi_txt
            // 
            hazirlik_suresi_txt.Location = new Point(182, 355);
            hazirlik_suresi_txt.Name = "hazirlik_suresi_txt";
            hazirlik_suresi_txt.Size = new Size(151, 27);
            hazirlik_suresi_txt.TabIndex = 228;
            // 
            // label20
            // 
            label20.Location = new Point(13, 359);
            label20.Name = "label20";
            label20.Size = new Size(171, 46);
            label20.TabIndex = 227;
            label20.Text = "OPERASYON HAZIRLIK SÜRESİ";
            // 
            // icerik_numarasi_txt
            // 
            icerik_numarasi_txt.Enabled = false;
            icerik_numarasi_txt.Location = new Point(880, 206);
            icerik_numarasi_txt.Name = "icerik_numarasi_txt";
            icerik_numarasi_txt.Size = new Size(125, 27);
            icerik_numarasi_txt.TabIndex = 226;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(724, 209);
            label17.Name = "label17";
            label17.Size = new Size(131, 20);
            label17.TabIndex = 225;
            label17.Text = "İÇERİK NUMARASI";
            // 
            // iscilik_suresi_txt
            // 
            iscilik_suresi_txt.Location = new Point(880, 344);
            iscilik_suresi_txt.Name = "iscilik_suresi_txt";
            iscilik_suresi_txt.Size = new Size(125, 27);
            iscilik_suresi_txt.TabIndex = 224;
            // 
            // label18
            // 
            label18.Location = new Point(724, 347);
            label18.Name = "label18";
            label18.Size = new Size(184, 42);
            label18.TabIndex = 223;
            label18.Text = "OPERASYON İŞÇİLİK SÜRESİ";
            // 
            // operasyon_kodu_txt
            // 
            operasyon_kodu_txt.Location = new Point(523, 252);
            operasyon_kodu_txt.Name = "operasyon_kodu_txt";
            operasyon_kodu_txt.Size = new Size(151, 27);
            operasyon_kodu_txt.TabIndex = 222;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(367, 263);
            label16.Name = "label16";
            label16.Size = new Size(136, 20);
            label16.TabIndex = 221;
            label16.Text = "OPERASYON KODU";
            // 
            // cmbIsMerkeziTipi
            // 
            cmbIsMerkeziTipi.FormattingEnabled = true;
            cmbIsMerkeziTipi.Location = new Point(182, 306);
            cmbIsMerkeziTipi.Name = "cmbIsMerkeziTipi";
            cmbIsMerkeziTipi.Size = new Size(151, 28);
            cmbIsMerkeziTipi.TabIndex = 220;
            cmbIsMerkeziTipi.DropDown += rotaYonGuncelle_Load;
            // 
            // is_merekezi_kodu_txt
            // 
            is_merekezi_kodu_txt.Location = new Point(523, 299);
            is_merekezi_kodu_txt.Name = "is_merekezi_kodu_txt";
            is_merekezi_kodu_txt.Size = new Size(151, 27);
            is_merekezi_kodu_txt.TabIndex = 219;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(367, 311);
            label14.Name = "label14";
            label14.Size = new Size(129, 20);
            label14.TabIndex = 218;
            label14.Text = "İŞ MERKEZİ KODU";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 311);
            label15.Name = "label15";
            label15.Size = new Size(113, 20);
            label15.TabIndex = 217;
            label15.Text = "İŞ MERKEZİ TİPİ";
            // 
            // operasyon_numarasi_txt
            // 
            operasyon_numarasi_txt.Enabled = false;
            operasyon_numarasi_txt.Location = new Point(182, 258);
            operasyon_numarasi_txt.Name = "operasyon_numarasi_txt";
            operasyon_numarasi_txt.Size = new Size(151, 27);
            operasyon_numarasi_txt.TabIndex = 216;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 263);
            label13.Name = "label13";
            label13.Size = new Size(171, 20);
            label13.TabIndex = 215;
            label13.Text = "OPERASYON NUMARASI";
            // 
            // cmbRotaTipi
            // 
            cmbRotaTipi.Enabled = false;
            cmbRotaTipi.FormattingEnabled = true;
            cmbRotaTipi.Location = new Point(182, 209);
            cmbRotaTipi.Name = "cmbRotaTipi";
            cmbRotaTipi.Size = new Size(151, 28);
            cmbRotaTipi.TabIndex = 214;
            cmbRotaTipi.DropDown += rotaYonGuncelle_Load;
            // 
            // rota_kodu_txt
            // 
            rota_kodu_txt.Enabled = false;
            rota_kodu_txt.Location = new Point(523, 205);
            rota_kodu_txt.Name = "rota_kodu_txt";
            rota_kodu_txt.Size = new Size(151, 27);
            rota_kodu_txt.TabIndex = 213;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 215);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 212;
            label7.Text = "ROTA KODU";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 215);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 211;
            label12.Text = "ROTA TİPİ";
            // 
            // cmbMalzemeTipi
            // 
            cmbMalzemeTipi.Enabled = false;
            cmbMalzemeTipi.FormattingEnabled = true;
            cmbMalzemeTipi.Location = new Point(182, 112);
            cmbMalzemeTipi.Name = "cmbMalzemeTipi";
            cmbMalzemeTipi.Size = new Size(151, 28);
            cmbMalzemeTipi.TabIndex = 210;
            cmbMalzemeTipi.DropDown += rotaYonGuncelle_Load;
            // 
            // temel_miktar_txt
            // 
            temel_miktar_txt.Location = new Point(523, 158);
            temel_miktar_txt.Name = "temel_miktar_txt";
            temel_miktar_txt.Size = new Size(151, 27);
            temel_miktar_txt.TabIndex = 209;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(367, 167);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 208;
            label11.Text = "TEMEL MİKTAR";
            // 
            // cizim_numarasi_txt
            // 
            cizim_numarasi_txt.Location = new Point(182, 161);
            cizim_numarasi_txt.Name = "cizim_numarasi_txt";
            cizim_numarasi_txt.Size = new Size(151, 27);
            cizim_numarasi_txt.TabIndex = 207;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 167);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 206;
            label10.Text = "ÇİZİM NUMARASI";
            // 
            // malzeme_kodu_txt
            // 
            malzeme_kodu_txt.Enabled = false;
            malzeme_kodu_txt.Location = new Point(523, 111);
            malzeme_kodu_txt.Name = "malzeme_kodu_txt";
            malzeme_kodu_txt.Size = new Size(151, 27);
            malzeme_kodu_txt.TabIndex = 205;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 119);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 204;
            label5.Text = "MALZEME KODU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 119);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 203;
            label6.Text = "MALZEME TİPİ";
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(724, 418);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 202;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // chkSil
            // 
            chkSil.CheckAlign = ContentAlignment.MiddleRight;
            chkSil.Location = new Point(548, 418);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(126, 30);
            chkSil.TabIndex = 201;
            chkSil.Text = "SİLİNDİ Mİ?";
            chkSil.TextAlign = ContentAlignment.MiddleCenter;
            chkSil.TextImageRelation = TextImageRelation.TextAboveImage;
            chkSil.UseVisualStyleBackColor = true;
            // 
            // dtpGBitis
            // 
            dtpGBitis.Enabled = false;
            dtpGBitis.Location = new Point(880, 298);
            dtpGBitis.Name = "dtpGBitis";
            dtpGBitis.Size = new Size(125, 27);
            dtpGBitis.TabIndex = 200;
            // 
            // dtpGBas
            // 
            dtpGBas.Enabled = false;
            dtpGBas.Location = new Point(880, 252);
            dtpGBas.Name = "dtpGBas";
            dtpGBas.Size = new Size(125, 27);
            dtpGBas.TabIndex = 199;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(724, 255);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 198;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(724, 301);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 197;
            label8.Text = "GEÇ. BİT. TARİHİ";
            // 
            // urun_agaci_kodu_txt
            // 
            urun_agaci_kodu_txt.Enabled = false;
            urun_agaci_kodu_txt.Location = new Point(880, 68);
            urun_agaci_kodu_txt.Name = "urun_agaci_kodu_txt";
            urun_agaci_kodu_txt.Size = new Size(125, 27);
            urun_agaci_kodu_txt.TabIndex = 196;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(724, 71);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 195;
            label4.Text = "ÜRÜN AĞACI KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(466, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 194;
            label3.Text = "ROTA YÖNETİMİ GÜNCELLEME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 71);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 193;
            label2.Text = "ÜRÜN AĞACI TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 71);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 192;
            label1.Text = "FİRMA KODU";
            // 
            // rotaYonGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1322, 640);
            Controls.Add(cmbUrunAgaciTipi);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(bilesen_miktar_txt);
            Controls.Add(label22);
            Controls.Add(bilesen_kodu_txt);
            Controls.Add(label21);
            Controls.Add(makine_suresi_txt);
            Controls.Add(label19);
            Controls.Add(hazirlik_suresi_txt);
            Controls.Add(label20);
            Controls.Add(icerik_numarasi_txt);
            Controls.Add(label17);
            Controls.Add(iscilik_suresi_txt);
            Controls.Add(label18);
            Controls.Add(operasyon_kodu_txt);
            Controls.Add(label16);
            Controls.Add(cmbIsMerkeziTipi);
            Controls.Add(is_merekezi_kodu_txt);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(operasyon_numarasi_txt);
            Controls.Add(label13);
            Controls.Add(cmbRotaTipi);
            Controls.Add(rota_kodu_txt);
            Controls.Add(label7);
            Controls.Add(label12);
            Controls.Add(cmbMalzemeTipi);
            Controls.Add(temel_miktar_txt);
            Controls.Add(label11);
            Controls.Add(cizim_numarasi_txt);
            Controls.Add(label10);
            Controls.Add(malzeme_kodu_txt);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(chkPasif);
            Controls.Add(chkSil);
            Controls.Add(dtpGBitis);
            Controls.Add(dtpGBas);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(urun_agaci_kodu_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "rotaYonGuncelle";
            Text = "rotaYonGuncelle";
            Load += rotaYonGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUrunAgaciTipi;
        private ComboBox cmbFirmaKodu;
        private Button button1;
        private TextBox bilesen_miktar_txt;
        private Label label22;
        private TextBox bilesen_kodu_txt;
        private Label label21;
        private TextBox makine_suresi_txt;
        private Label label19;
        private TextBox hazirlik_suresi_txt;
        private Label label20;
        private TextBox icerik_numarasi_txt;
        private Label label17;
        private TextBox iscilik_suresi_txt;
        private Label label18;
        private TextBox operasyon_kodu_txt;
        private Label label16;
        private ComboBox cmbIsMerkeziTipi;
        private TextBox is_merekezi_kodu_txt;
        private Label label14;
        private Label label15;
        private TextBox operasyon_numarasi_txt;
        private Label label13;
        private ComboBox cmbRotaTipi;
        private TextBox rota_kodu_txt;
        private Label label7;
        private Label label12;
        private ComboBox cmbMalzemeTipi;
        private TextBox temel_miktar_txt;
        private Label label11;
        private TextBox cizim_numarasi_txt;
        private Label label10;
        private TextBox malzeme_kodu_txt;
        private Label label5;
        private Label label6;
        private CheckBox chkPasif;
        private CheckBox chkSil;
        private DateTimePicker dtpGBitis;
        private DateTimePicker dtpGBas;
        private Label label9;
        private Label label8;
        private TextBox urun_agaci_kodu_txt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}