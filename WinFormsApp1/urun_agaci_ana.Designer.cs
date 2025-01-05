namespace WinFormsApp1
{
    partial class urun_agaci_ana
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
            urun_agaci_kodu_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            urun_agaci_tipi_txt = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // temel_miktar_txt
            // 
            temel_miktar_txt.Location = new Point(448, 146);
            temel_miktar_txt.Name = "temel_miktar_txt";
            temel_miktar_txt.Size = new Size(94, 27);
            temel_miktar_txt.TabIndex = 114;
            temel_miktar_txt.TextChanged += temel_miktar_txt_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(306, 145);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 113;
            label11.Text = "TEMEL MİKTAR";
            // 
            // cizim_numarasi_txt
            // 
            cizim_numarasi_txt.Location = new Point(158, 145);
            cizim_numarasi_txt.Name = "cizim_numarasi_txt";
            cizim_numarasi_txt.Size = new Size(125, 27);
            cizim_numarasi_txt.TabIndex = 110;
            cizim_numarasi_txt.TextChanged += cizim_numarasi_txt_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 150);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 109;
            label10.Text = "ÇİZİM NUMARASI";
            // 
            // malzeme_kodu_txt
            // 
            malzeme_kodu_txt.Location = new Point(448, 100);
            malzeme_kodu_txt.Name = "malzeme_kodu_txt";
            malzeme_kodu_txt.Size = new Size(94, 27);
            malzeme_kodu_txt.TabIndex = 108;
            malzeme_kodu_txt.TextChanged += malzeme_kodu_txt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 101);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 107;
            label5.Text = "MALZEME KODU";
            // 
            // malzeme_tipi_txt
            // 
            malzeme_tipi_txt.Location = new Point(158, 103);
            malzeme_tipi_txt.Name = "malzeme_tipi_txt";
            malzeme_tipi_txt.Size = new Size(125, 27);
            malzeme_tipi_txt.TabIndex = 106;
            malzeme_tipi_txt.TextChanged += malzeme_tipi_txt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 107);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 105;
            label6.Text = "MALZEME TİPİ";
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(931, 135);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 104;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            chkPasif.CheckedChanged += chkPasif_CheckedChanged;
            // 
            // chkSil
            // 
            chkSil.CheckAlign = ContentAlignment.MiddleRight;
            chkSil.Location = new Point(931, 64);
            chkSil.Name = "chkSil";
            chkSil.Size = new Size(126, 30);
            chkSil.TabIndex = 103;
            chkSil.Text = "SİLİNDİ Mİ?";
            chkSil.TextAlign = ContentAlignment.MiddleCenter;
            chkSil.TextImageRelation = TextImageRelation.TextAboveImage;
            chkSil.UseVisualStyleBackColor = true;
            chkSil.CheckedChanged += chkSil_CheckedChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Checked = false;
            dtpBitis.Location = new Point(725, 153);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(159, 27);
            dtpBitis.TabIndex = 102;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // dtpBas
            // 
            dtpBas.Checked = false;
            dtpBas.Location = new Point(725, 104);
            dtpBas.Name = "dtpBas";
            dtpBas.Size = new Size(159, 27);
            dtpBas.TabIndex = 101;
            dtpBas.ValueChanged += dtpBas_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(568, 107);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 100;
            label9.Text = "GEÇ. BAŞ. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(568, 153);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 99;
            label8.Text = "GEÇ. BİT. TARİHİ";
            // 
            // urun_agaci_kodu_txt
            // 
            urun_agaci_kodu_txt.Location = new Point(725, 55);
            urun_agaci_kodu_txt.Name = "urun_agaci_kodu_txt";
            urun_agaci_kodu_txt.Size = new Size(159, 27);
            urun_agaci_kodu_txt.TabIndex = 98;
            urun_agaci_kodu_txt.TextChanged += urun_agaci_kodu_txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 61);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 97;
            label4.Text = "ÜRÜN AĞACI KODU";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(568, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 96;
            label3.Text = "ÜRÜN AĞACI ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-6, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 95;
            // 
            // button4
            // 
            button4.Location = new Point(471, 198);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 93;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(343, 198);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 92;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 198);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 91;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(9, 198);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 90;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // urun_agaci_tipi_txt
            // 
            urun_agaci_tipi_txt.Location = new Point(448, 54);
            urun_agaci_tipi_txt.Name = "urun_agaci_tipi_txt";
            urun_agaci_tipi_txt.Size = new Size(94, 27);
            urun_agaci_tipi_txt.TabIndex = 89;
            urun_agaci_tipi_txt.TextChanged += urun_agaci_tipi_txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 57);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 88;
            label2.Text = "ÜRÜN AĞACI TİPİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 64);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 86;
            label1.Text = "FİRMA KODU";
            // 
            // urun_agaci_ana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1370, 694);
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
            Controls.Add(urun_agaci_kodu_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(urun_agaci_tipi_txt);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "urun_agaci_ana";
            Text = "urun_agaci_ana";
            Load += urun_agaci_ana_Load;
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
        private TextBox urun_agaci_kodu_txt;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox urun_agaci_tipi_txt;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}