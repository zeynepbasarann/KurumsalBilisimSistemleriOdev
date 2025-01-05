namespace WinFormsApp1
{
    partial class rota_yonetimi
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
            temel_miktar_txt = new TextBox();
            label11 = new Label();
            cizim_numarasi_txt = new TextBox();
            label10 = new Label();
            malzeme_kodu_txt = new TextBox();
            label5 = new Label();
            malzeme_tipi_txt = new TextBox();
            label6 = new Label();
            chkPasif = new CheckBox();
            chkSil = new CheckBox();
            dtpBitis = new DateTimePicker();
            dtpBas = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            rota_kodu_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            rota_tipi_txt = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // temel_miktar_txt
            // 
            temel_miktar_txt.Location = new Point(475, 145);
            temel_miktar_txt.Name = "temel_miktar_txt";
            temel_miktar_txt.Size = new Size(125, 27);
            temel_miktar_txt.TabIndex = 141;
            temel_miktar_txt.TextChanged += temel_miktar_txt_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(355, 152);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 140;
            label11.Text = "TEMEL MİKTAR";
            // 
            // cizim_numarasi_txt
            // 
            cizim_numarasi_txt.Location = new Point(185, 142);
            cizim_numarasi_txt.Name = "cizim_numarasi_txt";
            cizim_numarasi_txt.Size = new Size(125, 27);
            cizim_numarasi_txt.TabIndex = 139;
            cizim_numarasi_txt.TextChanged += cizim_numarasi_txt_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 146);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 138;
            label10.Text = "ÇİZİM NUMARASI";
            // 
            // malzeme_kodu_txt
            // 
            malzeme_kodu_txt.Location = new Point(475, 103);
            malzeme_kodu_txt.Name = "malzeme_kodu_txt";
            malzeme_kodu_txt.Size = new Size(125, 27);
            malzeme_kodu_txt.TabIndex = 137;
            malzeme_kodu_txt.TextChanged += malzeme_kodu_txt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 103);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 136;
            label5.Text = "MALZEME KODU";
            // 
            // malzeme_tipi_txt
            // 
            malzeme_tipi_txt.Location = new Point(185, 103);
            malzeme_tipi_txt.Name = "malzeme_tipi_txt";
            malzeme_tipi_txt.Size = new Size(125, 27);
            malzeme_tipi_txt.TabIndex = 135;
            malzeme_tipi_txt.TextChanged += malzeme_tipi_txt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 103);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 134;
            label6.Text = "MALZEME TİPİ";
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(647, 145);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 133;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            chkPasif.CheckedChanged += chkPasif_CheckedChanged;
            // 
            // chkSil
            // 
            chkSil.CheckAlign = ContentAlignment.MiddleRight;
            chkSil.Location = new Point(647, 93);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(126, 30);
            chkSil.TabIndex = 132;
            chkSil.Text = "SİLİNDİ Mİ?";
            chkSil.TextAlign = ContentAlignment.MiddleCenter;
            chkSil.TextImageRelation = TextImageRelation.TextAboveImage;
            chkSil.UseVisualStyleBackColor = true;
            chkSil.CheckedChanged += chkSil_CheckedChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Checked = false;
            dtpBitis.Location = new Point(1058, 102);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 131;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // dtpBas
            // 
            dtpBas.Checked = false;
            dtpBas.Location = new Point(1058, 47);
            dtpBas.Name = "dtpBas";
            dtpBas.Size = new Size(250, 27);
            dtpBas.TabIndex = 130;
            dtpBas.ValueChanged += dtpBas_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(930, 54);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 129;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(930, 100);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 128;
            label8.Text = "GEÇ. BİT. TARİHİ";
            // 
            // rota_kodu_txt
            // 
            rota_kodu_txt.Location = new Point(790, 47);
            rota_kodu_txt.Name = "rota_kodu_txt";
            rota_kodu_txt.Size = new Size(125, 27);
            rota_kodu_txt.TabIndex = 127;
            rota_kodu_txt.TextChanged += urun_agaci_kodu_txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 56);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 126;
            label4.Text = "ROTA KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(678, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 125;
            label3.Text = "ROTA YÖNETİMİ";
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
            dataGridView1.TabIndex = 124;
            // 
            // button4
            // 
            button4.Location = new Point(483, 193);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 122;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(355, 193);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 121;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(237, 193);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 120;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 193);
            button1.Name = "button1";
            button1.Size = new Size(198, 29);
            button1.TabIndex = 119;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTumunuGoster_Click;
            // 
            // rota_tipi_txt
            // 
            rota_tipi_txt.Location = new Point(475, 56);
            rota_tipi_txt.Name = "rota_tipi_txt";
            rota_tipi_txt.Size = new Size(125, 27);
            rota_tipi_txt.TabIndex = 118;
            rota_tipi_txt.TextChanged += urun_agaci_tipi_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 59);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 117;
            label2.Text = "ROTA TİPİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 116;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 62);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 115;
            label1.Text = "FİRMA KODU";
            // 
            // rota_yonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1341, 713);
            Controls.Add(temel_miktar_txt);
            Controls.Add(label11);
            Controls.Add(cizim_numarasi_txt);
            Controls.Add(label10);
            Controls.Add(malzeme_kodu_txt);
            Controls.Add(label5);
            Controls.Add(malzeme_tipi_txt);
            Controls.Add(label6);
            Controls.Add(chkPasif);
            Controls.Add(chkSil);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBas);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(rota_kodu_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rota_tipi_txt);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "rota_yonetimi";
            Text = "rota_yonetimi";
            Load += rotayonetimi_LOAD;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox temel_miktar_txt;
        private Label label11;
        private TextBox cizim_numarasi_txt;
        private Label label10;
        private TextBox malzeme_kodu_txt;
        private Label label5;
        private TextBox malzeme_tipi_txt;
        private Label label6;
        private CheckBox chkPasif;
        private CheckBox chkSil;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBas;
        private Label label9;
        private Label label8;
        private TextBox rota_kodu_txt;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox rota_tipi_txt;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}