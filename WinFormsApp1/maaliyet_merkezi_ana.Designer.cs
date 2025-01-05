namespace WinFormsApp1
{
    partial class maaliyet_merkezi_ana
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
            maliyetMerkezKodu_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            maliyetMerkezTipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            maliyetMerkeziKisaAciklama_txt = new TextBox();
            maliyetMerkeziUzunAciklama_txt = new TextBox();
            label7 = new Label();
            DilKodu_txt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dtpBasTarih = new DateTimePicker();
            dtpBitTarih = new DateTimePicker();
            chkSil = new CheckBox();
            chkPasif = new CheckBox();
            cmbFirmaKodu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // maliyetMerkezKodu_txt
            // 
            maliyetMerkezKodu_txt.Location = new Point(833, 47);
            maliyetMerkezKodu_txt.Name = "maliyetMerkezKodu_txt";
            maliyetMerkezKodu_txt.Size = new Size(125, 27);
            maliyetMerkezKodu_txt.TabIndex = 36;
            maliyetMerkezKodu_txt.TextChanged += maliyetMerkezKodu_txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 54);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 35;
            label4.Text = "MALİYET MERKEZ KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(633, 11);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 34;
            label3.Text = "MALİYET MERKEZİ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1383, 316);
            dataGridView1.TabIndex = 33;
            // 
            // button4
            // 
            button4.Location = new Point(518, 193);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 31;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(403, 193);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 30;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 193);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 193);
            button1.Name = "button1";
            button1.Size = new Size(255, 29);
            button1.TabIndex = 28;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maliyetMerkezTipi_txt
            // 
            maliyetMerkezTipi_txt.Location = new Point(475, 56);
            maliyetMerkezTipi_txt.Name = "maliyetMerkezTipi_txt";
            maliyetMerkezTipi_txt.Size = new Size(125, 27);
            maliyetMerkezTipi_txt.TabIndex = 27;
            maliyetMerkezTipi_txt.TextChanged += maliyetMerkezTipi_txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 58);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 26;
            label2.Text = "MALİYET MERKEZ TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 24;
            label1.Text = "FİRMA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 107);
            label5.Name = "label5";
            label5.Size = new Size(254, 20);
            label5.TabIndex = 37;
            label5.Text = "MALİYET MERKEZİ KISA AÇIKLAMASI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 142);
            label6.Name = "label6";
            label6.Size = new Size(263, 20);
            label6.TabIndex = 38;
            label6.Text = "MALİYET MERKEZİ UZUN AÇIKLAMASI";
            // 
            // maliyetMerkeziKisaAciklama_txt
            // 
            maliyetMerkeziKisaAciklama_txt.Location = new Point(344, 100);
            maliyetMerkeziKisaAciklama_txt.Name = "maliyetMerkeziKisaAciklama_txt";
            maliyetMerkeziKisaAciklama_txt.Size = new Size(256, 27);
            maliyetMerkeziKisaAciklama_txt.TabIndex = 39;
            // 
            // maliyetMerkeziUzunAciklama_txt
            // 
            maliyetMerkeziUzunAciklama_txt.Location = new Point(344, 139);
            maliyetMerkeziUzunAciklama_txt.Name = "maliyetMerkeziUzunAciklama_txt";
            maliyetMerkeziUzunAciklama_txt.Size = new Size(589, 27);
            maliyetMerkeziUzunAciklama_txt.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(730, 96);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 41;
            label7.Text = "DİL KODU";
            // 
            // DilKodu_txt
            // 
            DilKodu_txt.Location = new Point(833, 93);
            DilKodu_txt.Name = "DilKodu_txt";
            DilKodu_txt.Size = new Size(125, 27);
            DilKodu_txt.TabIndex = 42;
            DilKodu_txt.TextChanged += DilKodu_txt_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1001, 96);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 43;
            label8.Text = "GEÇ. BİT. TARİHİ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1001, 50);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 44;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // dtpBasTarih
            // 
            dtpBasTarih.Checked = false;
            dtpBasTarih.Location = new Point(1129, 43);
            dtpBasTarih.Name = "dtpBasTarih";
            dtpBasTarih.Size = new Size(250, 27);
            dtpBasTarih.TabIndex = 45;
            dtpBasTarih.ValueChanged += dtpBasTarih_ValueChanged;
            // 
            // dtpBitTarih
            // 
            dtpBitTarih.Checked = false;
            dtpBitTarih.Location = new Point(1129, 98);
            dtpBitTarih.Name = "dtpBitTarih";
            dtpBitTarih.Size = new Size(250, 27);
            dtpBitTarih.TabIndex = 46;
            dtpBitTarih.ValueChanged += dtpBitTarih_ValueChanged;
            // 
            // chkSil
            // 
            chkSil.CheckAlign = ContentAlignment.MiddleRight;
            chkSil.Location = new Point(1025, 141);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(126, 30);
            chkSil.TabIndex = 49;
            chkSil.Text = "SİLİNDİ Mİ?";
            chkSil.TextAlign = ContentAlignment.MiddleCenter;
            chkSil.TextImageRelation = TextImageRelation.TextAboveImage;
            chkSil.UseVisualStyleBackColor = true;
            chkSil.CheckedChanged += chkSil_CheckedChanged;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(1177, 141);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 50;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            chkPasif.CheckedChanged += chkPasif_CheckedChanged;
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(127, 54);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 51;
            // 
            // maaliyet_merkezi_ana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1390, 634);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(chkPasif);
            Controls.Add(chkSil);
            Controls.Add(dtpBitTarih);
            Controls.Add(dtpBasTarih);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(DilKodu_txt);
            Controls.Add(label7);
            Controls.Add(maliyetMerkeziUzunAciklama_txt);
            Controls.Add(maliyetMerkeziKisaAciklama_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(maliyetMerkezKodu_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maliyetMerkezTipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "maaliyet_merkezi_ana";
            Text = "maaliyet_merkezi_ana";
            Load += maaliyet_merkezi_ana_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox maliyetMerkezKodu_txt;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox maliyetMerkezTipi_txt;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox maliyetMerkeziKisaAciklama_txt;
        private TextBox maliyetMerkeziUzunAciklama_txt;
        private Label label7;
        private TextBox DilKodu_txt;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpBasTarih;
        private DateTimePicker dtpBitTarih;
        private CheckBox chkSil;
        private CheckBox chkPasif;
        private ComboBox cmbFirmaKodu;
    }
}