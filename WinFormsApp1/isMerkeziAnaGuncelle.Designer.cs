namespace WinFormsApp1
{
    partial class isMerkeziAnaGuncelle
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
            cmbMaliyetMerkeziTipi = new ComboBox();
            cmbDilKodu = new ComboBox();
            cmbIsMerkeziTipi = new ComboBox();
            cmbFirmaKodu = new ComboBox();
            button1 = new Button();
            uzun_aciklama_txt = new TextBox();
            label13 = new Label();
            kisa_aciklama_txt = new TextBox();
            label14 = new Label();
            label12 = new Label();
            calisma_suresi_txt = new TextBox();
            label11 = new Label();
            maliyet_merkezi_kodu = new TextBox();
            label7 = new Label();
            label10 = new Label();
            ana_is_merkezi_kodu = new TextBox();
            label5 = new Label();
            ana_is_merkezi_tipi = new TextBox();
            label6 = new Label();
            chkPasif = new CheckBox();
            chkSil = new CheckBox();
            dtpGBitis = new DateTimePicker();
            dtpGBas = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            is_merkezi_kodu_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            operasyon_kodu_txt = new TextBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // cmbMaliyetMerkeziTipi
            // 
            cmbMaliyetMerkeziTipi.FormattingEnabled = true;
            cmbMaliyetMerkeziTipi.Location = new Point(175, 156);
            cmbMaliyetMerkeziTipi.Name = "cmbMaliyetMerkeziTipi";
            cmbMaliyetMerkeziTipi.Size = new Size(151, 28);
            cmbMaliyetMerkeziTipi.TabIndex = 149;
            cmbMaliyetMerkeziTipi.DropDown += isMerkeziAnaGuncelle_Load;
            // 
            // cmbDilKodu
            // 
            cmbDilKodu.Enabled = false;
            cmbDilKodu.FormattingEnabled = true;
            cmbDilKodu.Location = new Point(853, 159);
            cmbDilKodu.Name = "cmbDilKodu";
            cmbDilKodu.Size = new Size(122, 28);
            cmbDilKodu.TabIndex = 148;
            cmbDilKodu.DropDown += isMerkeziAnaGuncelle_Load;
            // 
            // cmbIsMerkeziTipi
            // 
            cmbIsMerkeziTipi.Enabled = false;
            cmbIsMerkeziTipi.FormattingEnabled = true;
            cmbIsMerkeziTipi.Location = new Point(533, 67);
            cmbIsMerkeziTipi.Name = "cmbIsMerkeziTipi";
            cmbIsMerkeziTipi.Size = new Size(151, 28);
            cmbIsMerkeziTipi.TabIndex = 147;
            cmbIsMerkeziTipi.DropDown += isMerkeziAnaGuncelle_Load;
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.Enabled = false;
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(175, 64);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 146;
            // 
            // button1
            // 
            button1.Location = new Point(590, 296);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 145;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // uzun_aciklama_txt
            // 
            uzun_aciklama_txt.Location = new Point(175, 243);
            uzun_aciklama_txt.Name = "uzun_aciklama_txt";
            uzun_aciklama_txt.Size = new Size(509, 27);
            uzun_aciklama_txt.TabIndex = 144;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 250);
            label13.Name = "label13";
            label13.Size = new Size(125, 20);
            label13.TabIndex = 143;
            label13.Text = "UZUN AÇIKLAMA";
            // 
            // kisa_aciklama_txt
            // 
            kisa_aciklama_txt.Location = new Point(175, 204);
            kisa_aciklama_txt.Name = "kisa_aciklama_txt";
            kisa_aciklama_txt.Size = new Size(509, 27);
            kisa_aciklama_txt.TabIndex = 142;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(53, 211);
            label14.Name = "label14";
            label14.Size = new Size(116, 20);
            label14.TabIndex = 141;
            label14.Text = "KISA AÇIKLAMA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(757, 167);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 140;
            label12.Text = "DİL KODU";
            // 
            // calisma_suresi_txt
            // 
            calisma_suresi_txt.Location = new Point(853, 113);
            calisma_suresi_txt.Name = "calisma_suresi_txt";
            calisma_suresi_txt.Size = new Size(122, 27);
            calisma_suresi_txt.TabIndex = 139;
            // 
            // label11
            // 
            label11.Location = new Point(703, 109);
            label11.Name = "label11";
            label11.Size = new Size(144, 42);
            label11.TabIndex = 138;
            label11.Text = "GÜNLÜK ÇALIŞMA SÜRESİ (SAAT)";
            // 
            // maliyet_merkezi_kodu
            // 
            maliyet_merkezi_kodu.Location = new Point(533, 159);
            maliyet_merkezi_kodu.Name = "maliyet_merkezi_kodu";
            maliyet_merkezi_kodu.Size = new Size(153, 27);
            maliyet_merkezi_kodu.TabIndex = 137;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 161);
            label7.Name = "label7";
            label7.Size = new Size(185, 20);
            label7.TabIndex = 136;
            label7.Text = "MAALİYET MERKEZİ KODU";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 159);
            label10.Name = "label10";
            label10.Size = new Size(159, 20);
            label10.TabIndex = 135;
            label10.Text = "MALİYET MERKEZİ TİPİ";
            // 
            // ana_is_merkezi_kodu
            // 
            ana_is_merkezi_kodu.Location = new Point(533, 113);
            ana_is_merkezi_kodu.Name = "ana_is_merkezi_kodu";
            ana_is_merkezi_kodu.Size = new Size(151, 27);
            ana_is_merkezi_kodu.TabIndex = 134;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 116);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 133;
            label5.Text = "ANA İŞ MERKEZİ KODU";
            // 
            // ana_is_merkezi_tipi
            // 
            ana_is_merkezi_tipi.Location = new Point(175, 113);
            ana_is_merkezi_tipi.Name = "ana_is_merkezi_tipi";
            ana_is_merkezi_tipi.Size = new Size(151, 27);
            ana_is_merkezi_tipi.TabIndex = 132;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 116);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 131;
            label6.Text = "ANA İŞ MERKEZİ TİPİ";
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(1149, 163);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 130;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // chkSil
            // 
            chkSil.CheckAlign = ContentAlignment.MiddleRight;
            chkSil.Location = new Point(1007, 167);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(126, 30);
            chkSil.TabIndex = 129;
            chkSil.Text = "SİLİNDİ Mİ?";
            chkSil.TextAlign = ContentAlignment.MiddleCenter;
            chkSil.TextImageRelation = TextImageRelation.TextAboveImage;
            chkSil.UseVisualStyleBackColor = true;
            // 
            // dtpGBitis
            // 
            dtpGBitis.Enabled = false;
            dtpGBitis.Location = new Point(1122, 123);
            dtpGBitis.Name = "dtpGBitis";
            dtpGBitis.Size = new Size(250, 27);
            dtpGBitis.TabIndex = 128;
            // 
            // dtpGBas
            // 
            dtpGBas.Enabled = false;
            dtpGBas.Location = new Point(1122, 68);
            dtpGBas.Name = "dtpGBas";
            dtpGBas.Size = new Size(250, 27);
            dtpGBas.TabIndex = 127;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(994, 75);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 126;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(994, 121);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 125;
            label8.Text = "GEÇ. BİT. TARİHİ";
            // 
            // is_merkezi_kodu_txt
            // 
            is_merkezi_kodu_txt.Enabled = false;
            is_merkezi_kodu_txt.Location = new Point(850, 70);
            is_merkezi_kodu_txt.Name = "is_merkezi_kodu_txt";
            is_merkezi_kodu_txt.Size = new Size(125, 27);
            is_merkezi_kodu_txt.TabIndex = 124;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(703, 77);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 123;
            label4.Text = "İŞ MERKEZİ KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(633, 14);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 122;
            label3.Text = "İŞ MERKEZİ GÜNCELLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 72);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 121;
            label2.Text = "İŞ MERKEZİ TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 70);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 120;
            label1.Text = "FİRMA KODU";
            // 
            // operasyon_kodu_txt
            // 
            operasyon_kodu_txt.Enabled = false;
            operasyon_kodu_txt.Location = new Point(850, 200);
            operasyon_kodu_txt.Name = "operasyon_kodu_txt";
            operasyon_kodu_txt.Size = new Size(125, 27);
            operasyon_kodu_txt.TabIndex = 151;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(696, 207);
            label15.Name = "label15";
            label15.Size = new Size(136, 20);
            label15.TabIndex = 150;
            label15.Text = "OPERASYON KODU";
            // 
            // isMerkeziAnaGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1495, 722);
            Controls.Add(operasyon_kodu_txt);
            Controls.Add(label15);
            Controls.Add(cmbMaliyetMerkeziTipi);
            Controls.Add(cmbDilKodu);
            Controls.Add(cmbIsMerkeziTipi);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(uzun_aciklama_txt);
            Controls.Add(label13);
            Controls.Add(kisa_aciklama_txt);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(calisma_suresi_txt);
            Controls.Add(label11);
            Controls.Add(maliyet_merkezi_kodu);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(ana_is_merkezi_kodu);
            Controls.Add(label5);
            Controls.Add(ana_is_merkezi_tipi);
            Controls.Add(label6);
            Controls.Add(chkPasif);
            Controls.Add(chkSil);
            Controls.Add(dtpGBitis);
            Controls.Add(dtpGBas);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(is_merkezi_kodu_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "isMerkeziAnaGuncelle";
            Text = "isMerkeziAnaGuncelle";
            Load += isMerkeziAnaGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaliyetMerkeziTipi;
        private ComboBox cmbDilKodu;
        private ComboBox cmbIsMerkeziTipi;
        private ComboBox cmbFirmaKodu;
        private Button button1;
        private TextBox uzun_aciklama_txt;
        private Label label13;
        private TextBox kisa_aciklama_txt;
        private Label label14;
        private Label label12;
        private TextBox calisma_suresi_txt;
        private Label label11;
        private TextBox maliyet_merkezi_kodu;
        private Label label7;
        private Label label10;
        private TextBox ana_is_merkezi_kodu;
        private Label label5;
        private TextBox ana_is_merkezi_tipi;
        private Label label6;
        private CheckBox chkPasif;
        private CheckBox chkSil;
        private DateTimePicker dtpGBitis;
        private DateTimePicker dtpGBas;
        private Label label9;
        private Label label8;
        private TextBox is_merkezi_kodu_txt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox operasyon_kodu_txt;
        private Label label15;
    }
}