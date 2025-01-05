namespace WinFormsApp1
{
    partial class maliyetMerkeziAnaGuncelle
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
            cmbAnaMaliyetMerkezTipi = new ComboBox();
            cmbDilKodu = new ComboBox();
            cmbMaliyetMerkezTipi = new ComboBox();
            anaMaliyetMerkezKodu_txt = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cmbFirmaKodu = new ComboBox();
            chkPasif = new CheckBox();
            chkSil = new CheckBox();
            dtpBitTarih = new DateTimePicker();
            dtpBasTarih = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            maliyetMerkeziUzunAciklama_txt = new TextBox();
            maliyetMerkeziKisaAciklama_txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            maliyetMerkezKodu_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbAnaMaliyetMerkezTipi
            // 
            cmbAnaMaliyetMerkezTipi.FormattingEnabled = true;
            cmbAnaMaliyetMerkezTipi.Location = new Point(234, 119);
            cmbAnaMaliyetMerkezTipi.Name = "cmbAnaMaliyetMerkezTipi";
            cmbAnaMaliyetMerkezTipi.Size = new Size(151, 28);
            cmbAnaMaliyetMerkezTipi.TabIndex = 106;
            cmbAnaMaliyetMerkezTipi.DropDown += maliyetMerkeziAnaGuncelle_Load;
            // 
            // cmbDilKodu
            // 
            cmbDilKodu.Enabled = false;
            cmbDilKodu.FormattingEnabled = true;
            cmbDilKodu.Location = new Point(807, 165);
            cmbDilKodu.Name = "cmbDilKodu";
            cmbDilKodu.Size = new Size(151, 28);
            cmbDilKodu.TabIndex = 105;
            cmbDilKodu.DropDown += maliyetMerkeziAnaGuncelle_Load;
            // 
            // cmbMaliyetMerkezTipi
            // 
            cmbMaliyetMerkezTipi.Enabled = false;
            cmbMaliyetMerkezTipi.FormattingEnabled = true;
            cmbMaliyetMerkezTipi.Location = new Point(476, 66);
            cmbMaliyetMerkezTipi.Name = "cmbMaliyetMerkezTipi";
            cmbMaliyetMerkezTipi.Size = new Size(151, 28);
            cmbMaliyetMerkezTipi.TabIndex = 104;
            cmbMaliyetMerkezTipi.DropDown += maliyetMerkeziAnaGuncelle_Load;
            // 
            // anaMaliyetMerkezKodu_txt
            // 
            anaMaliyetMerkezKodu_txt.Location = new Point(833, 110);
            anaMaliyetMerkezKodu_txt.Name = "anaMaliyetMerkezKodu_txt";
            anaMaliyetMerkezKodu_txt.Size = new Size(125, 27);
            anaMaliyetMerkezKodu_txt.TabIndex = 103;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(608, 113);
            label10.Name = "label10";
            label10.Size = new Size(206, 20);
            label10.TabIndex = 102;
            label10.Text = "ANA MALİYET MERKEZ KODU";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 117);
            label11.Name = "label11";
            label11.Size = new Size(190, 20);
            label11.TabIndex = 101;
            label11.Text = "ANA MALİYET MERKEZ TİPİ";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.Enabled = false;
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(135, 68);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 100;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(1165, 155);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 99;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // chkSil
            // 
            chkSil.CheckAlign = ContentAlignment.MiddleRight;
            chkSil.Location = new Point(997, 155);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(126, 30);
            chkSil.TabIndex = 98;
            chkSil.Text = "SİLİNDİ Mİ?";
            chkSil.TextAlign = ContentAlignment.MiddleCenter;
            chkSil.TextImageRelation = TextImageRelation.TextAboveImage;
            chkSil.UseVisualStyleBackColor = true;
            // 
            // dtpBitTarih
            // 
            dtpBitTarih.Enabled = false;
            dtpBitTarih.Location = new Point(1129, 110);
            dtpBitTarih.Name = "dtpBitTarih";
            dtpBitTarih.Size = new Size(250, 27);
            dtpBitTarih.TabIndex = 97;
            // 
            // dtpBasTarih
            // 
            dtpBasTarih.Enabled = false;
            dtpBasTarih.Location = new Point(1129, 55);
            dtpBasTarih.Name = "dtpBasTarih";
            dtpBasTarih.Size = new Size(250, 27);
            dtpBasTarih.TabIndex = 96;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1001, 62);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 95;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1001, 108);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 94;
            label8.Text = "GEÇ. BİT. TARİHİ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 165);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 93;
            label7.Text = "DİL KODU";
            // 
            // maliyetMerkeziUzunAciklama_txt
            // 
            maliyetMerkeziUzunAciklama_txt.Location = new Point(344, 204);
            maliyetMerkeziUzunAciklama_txt.Name = "maliyetMerkeziUzunAciklama_txt";
            maliyetMerkeziUzunAciklama_txt.Size = new Size(614, 27);
            maliyetMerkeziUzunAciklama_txt.TabIndex = 92;
            // 
            // maliyetMerkeziKisaAciklama_txt
            // 
            maliyetMerkeziKisaAciklama_txt.Location = new Point(344, 165);
            maliyetMerkeziKisaAciklama_txt.Name = "maliyetMerkeziKisaAciklama_txt";
            maliyetMerkeziKisaAciklama_txt.Size = new Size(256, 27);
            maliyetMerkeziKisaAciklama_txt.TabIndex = 91;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 204);
            label6.Name = "label6";
            label6.Size = new Size(273, 20);
            label6.TabIndex = 90;
            label6.Text = "MAALİYET MERKEZİ UZUN AÇIKLAMASI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 165);
            label5.Name = "label5";
            label5.Size = new Size(264, 20);
            label5.TabIndex = 89;
            label5.Text = "MAALİYET MERKEZİ KISA AÇIKLAMASI";
            // 
            // maliyetMerkezKodu_txt
            // 
            maliyetMerkezKodu_txt.Enabled = false;
            maliyetMerkezKodu_txt.Location = new Point(833, 59);
            maliyetMerkezKodu_txt.Name = "maliyetMerkezKodu_txt";
            maliyetMerkezKodu_txt.Size = new Size(125, 27);
            maliyetMerkezKodu_txt.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 66);
            label4.Name = "label4";
            label4.Size = new Size(181, 20);
            label4.TabIndex = 87;
            label4.Text = "MAALİYET MERKEZ KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(608, 13);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 86;
            label3.Text = "MALİYET MERKEZİ GÜNCELLE";
            // 
            // button1
            // 
            button1.Location = new Point(633, 259);
            button1.Name = "button1";
            button1.Size = new Size(255, 29);
            button1.TabIndex = 85;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 70);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 84;
            label2.Text = "MAALİYET MERKEZ TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 71);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 83;
            label1.Text = "FİRMA";
            // 
            // maliyetMerkeziAnaGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1303, 589);
            Controls.Add(cmbAnaMaliyetMerkezTipi);
            Controls.Add(cmbDilKodu);
            Controls.Add(cmbMaliyetMerkezTipi);
            Controls.Add(anaMaliyetMerkezKodu_txt);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(chkPasif);
            Controls.Add(chkSil);
            Controls.Add(dtpBitTarih);
            Controls.Add(dtpBasTarih);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(maliyetMerkeziUzunAciklama_txt);
            Controls.Add(maliyetMerkeziKisaAciklama_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(maliyetMerkezKodu_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Enabled = false;
            Name = "maliyetMerkeziAnaGuncelle";
            Text = "maliyetMerkeziAnaGuncelle";
            Load += maliyetMerkeziAnaGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAnaMaliyetMerkezTipi;
        private ComboBox cmbDilKodu;
        private ComboBox cmbMaliyetMerkezTipi;
        private TextBox anaMaliyetMerkezKodu_txt;
        private Label label10;
        private Label label11;
        private ComboBox cmbFirmaKodu;
        private CheckBox chkPasif;
        private CheckBox chkSil;
        private DateTimePicker dtpBitTarih;
        private DateTimePicker dtpBasTarih;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox maliyetMerkeziUzunAciklama_txt;
        private TextBox maliyetMerkeziKisaAciklama_txt;
        private Label label6;
        private Label label5;
        private TextBox maliyetMerkezKodu_txt;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}