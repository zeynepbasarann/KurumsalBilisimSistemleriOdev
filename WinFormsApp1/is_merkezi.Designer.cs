namespace WinFormsApp1
{
    partial class is_merkezi
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
            chkPasif = new CheckBox();
            chkSil = new CheckBox();
            dtpBitis = new DateTimePicker();
            dtpBas = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            is_merkezi_kodu_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            is_merkezi_tipi_txt = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ana_is_merkezi_kodu_txt = new TextBox();
            label5 = new Label();
            ana_is_merkezi_tipi = new TextBox();
            label6 = new Label();
            maliyet_merkezi_tipi_kodu = new TextBox();
            label7 = new Label();
            maliyet_merkezi_tipi_txt = new TextBox();
            label10 = new Label();
            label11 = new Label();
            calisma_suresi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(876, 164);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 75;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            chkPasif.CheckedChanged += chkPasif_CheckedChanged;
            // 
            // chkSil
            // 
            chkSil.CheckAlign = ContentAlignment.MiddleRight;
            chkSil.Location = new Point(706, 164);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(126, 30);
            chkSil.TabIndex = 74;
            chkSil.Text = "SİLİNDİ Mİ?";
            chkSil.TextAlign = ContentAlignment.MiddleCenter;
            chkSil.TextImageRelation = TextImageRelation.TextAboveImage;
            chkSil.UseVisualStyleBackColor = true;
            chkSil.CheckedChanged += chkSil_CheckedChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Checked = false;
            dtpBitis.Location = new Point(1123, 112);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 73;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // dtpBas
            // 
            dtpBas.Checked = false;
            dtpBas.Location = new Point(1123, 57);
            dtpBas.Name = "dtpBas";
            dtpBas.Size = new Size(250, 27);
            dtpBas.TabIndex = 72;
            dtpBas.ValueChanged += dtpBas_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(995, 64);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 71;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(995, 110);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 70;
            label8.Text = "GEÇ. BİT. TARİHİ";
            // 
            // is_merkezi_kodu_txt
            // 
            is_merkezi_kodu_txt.Location = new Point(850, 56);
            is_merkezi_kodu_txt.Name = "is_merkezi_kodu_txt";
            is_merkezi_kodu_txt.Size = new Size(125, 27);
            is_merkezi_kodu_txt.TabIndex = 63;
            is_merkezi_kodu_txt.TextChanged += is_merkezi_kodu_txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(706, 63);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 62;
            label4.Text = "İŞ MERKEZİ KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(664, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 61;
            label3.Text = "İŞ MERKEZİ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 60;
            // 
            // button4
            // 
            button4.Location = new Point(475, 193);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 58;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(362, 193);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 57;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 193);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 56;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 193);
            button1.Name = "button1";
            button1.Size = new Size(206, 29);
            button1.TabIndex = 55;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTumunuGoster_Click;
            // 
            // is_merkezi_tipi_txt
            // 
            is_merkezi_tipi_txt.Location = new Point(507, 57);
            is_merkezi_tipi_txt.Name = "is_merkezi_tipi_txt";
            is_merkezi_tipi_txt.Size = new Size(125, 27);
            is_merkezi_tipi_txt.TabIndex = 54;
            is_merkezi_tipi_txt.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 59);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 53;
            label2.Text = "İŞ MERKEZİ TİPİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 51;
            label1.Text = "FİRMA KODU";
            // 
            // ana_is_merkezi_kodu_txt
            // 
            ana_is_merkezi_kodu_txt.Location = new Point(507, 100);
            ana_is_merkezi_kodu_txt.Name = "ana_is_merkezi_kodu_txt";
            ana_is_merkezi_kodu_txt.Size = new Size(125, 27);
            ana_is_merkezi_kodu_txt.TabIndex = 79;
            ana_is_merkezi_kodu_txt.TextChanged += ana_is_merkezi_kodu_txt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 96);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 78;
            label5.Text = "ANA İŞ MERKEZİ KODU";
            // 
            // ana_is_merkezi_tipi
            // 
            ana_is_merkezi_tipi.Location = new Point(175, 100);
            ana_is_merkezi_tipi.Name = "ana_is_merkezi_tipi";
            ana_is_merkezi_tipi.Size = new Size(125, 27);
            ana_is_merkezi_tipi.TabIndex = 77;
            ana_is_merkezi_tipi.TextChanged += ana_is_merkezi_tipi_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 96);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 76;
            label6.Text = "ANA İŞ MERKEZİ TİPİ";
            // 
            // maliyet_merkezi_tipi_kodu
            // 
            maliyet_merkezi_tipi_kodu.Location = new Point(507, 144);
            maliyet_merkezi_tipi_kodu.Name = "maliyet_merkezi_tipi_kodu";
            maliyet_merkezi_tipi_kodu.Size = new Size(125, 27);
            maliyet_merkezi_tipi_kodu.TabIndex = 83;
            maliyet_merkezi_tipi_kodu.TextChanged += maliyet_merkezi_tipi_kodu_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 142);
            label7.Name = "label7";
            label7.Size = new Size(175, 20);
            label7.TabIndex = 82;
            label7.Text = "MALİYET MERKEZİ KODU";
            // 
            // maliyet_merkezi_tipi_txt
            // 
            maliyet_merkezi_tipi_txt.Location = new Point(175, 142);
            maliyet_merkezi_tipi_txt.Name = "maliyet_merkezi_tipi_txt";
            maliyet_merkezi_tipi_txt.Size = new Size(125, 27);
            maliyet_merkezi_tipi_txt.TabIndex = 81;
            maliyet_merkezi_tipi_txt.TextChanged += maliyet_merkezi_tipi_txt_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 139);
            label10.Name = "label10";
            label10.Size = new Size(159, 20);
            label10.TabIndex = 80;
            label10.Text = "MALİYET MERKEZİ TİPİ";
            // 
            // label11
            // 
            label11.Location = new Point(701, 103);
            label11.Name = "label11";
            label11.Size = new Size(134, 43);
            label11.TabIndex = 84;
            label11.Text = "GÜNLÜK ÇALIŞMA SÜRESİ (SAAT)";
            // 
            // calisma_suresi
            // 
            calisma_suresi.Location = new Point(850, 103);
            calisma_suresi.Name = "calisma_suresi";
            calisma_suresi.Size = new Size(125, 27);
            calisma_suresi.TabIndex = 85;
            calisma_suresi.TextChanged += calisma_suresi_TextChanged;
            // 
            // is_merkezi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1390, 711);
            Controls.Add(calisma_suresi);
            Controls.Add(label11);
            Controls.Add(maliyet_merkezi_tipi_kodu);
            Controls.Add(label7);
            Controls.Add(maliyet_merkezi_tipi_txt);
            Controls.Add(label10);
            Controls.Add(ana_is_merkezi_kodu_txt);
            Controls.Add(label5);
            Controls.Add(ana_is_merkezi_tipi);
            Controls.Add(label6);
            Controls.Add(chkPasif);
            Controls.Add(chkSil);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBas);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(is_merkezi_kodu_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(is_merkezi_tipi_txt);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "is_merkezi";
            Text = "is_merkezi";
            Load += isMerkezi_LOAD;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPasif;
        private CheckBox chkSil;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBas;
        private Label label9;
        private Label label8;
        private TextBox is_merkezi_kodu_txt;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox is_merkezi_tipi_txt;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox ana_is_merkezi_kodu_txt;
        private Label label5;
        private TextBox ana_is_merkezi_tipi;
        private Label label6;
        private TextBox maliyet_merkezi_tipi_kodu;
        private Label label7;
        private TextBox maliyet_merkezi_tipi_txt;
        private Label label10;
        private Label label11;
        private TextBox calisma_suresi;
    }
}