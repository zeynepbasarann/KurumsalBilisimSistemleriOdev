namespace WinFormsApp1
{
    partial class urunAgaciGuncelleme
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
            cmbFirmaKodu = new ComboBox();
            button1 = new Button();
            chkPasif = new CheckBox();
            urun_agaci_aciklamasi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            urun_agaci_tipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(349, 111);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 174;
            // 
            // button1
            // 
            button1.Location = new Point(258, 355);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 173;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(278, 288);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 172;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // urun_agaci_aciklamasi_txt
            // 
            urun_agaci_aciklamasi_txt.Location = new Point(349, 216);
            urun_agaci_aciklamasi_txt.Name = "urun_agaci_aciklamasi_txt";
            urun_agaci_aciklamasi_txt.Size = new Size(151, 27);
            urun_agaci_aciklamasi_txt.TabIndex = 171;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 225);
            label4.Name = "label4";
            label4.Size = new Size(184, 20);
            label4.TabIndex = 170;
            label4.Text = "ÜRÜN AĞACI AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(242, 33);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 169;
            label3.Text = "ÜRÜN AĞACI GÜNCELLE";
            // 
            // urun_agaci_tipi_txt
            // 
            urun_agaci_tipi_txt.Location = new Point(349, 164);
            urun_agaci_tipi_txt.Name = "urun_agaci_tipi_txt";
            urun_agaci_tipi_txt.Size = new Size(151, 27);
            urun_agaci_tipi_txt.TabIndex = 168;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 168);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 167;
            label2.Text = "ÜRÜN AĞACI TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 111);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 166;
            label1.Text = "FİRMA ";
            // 
            // urunAgaciGuncelleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(685, 480);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(chkPasif);
            Controls.Add(urun_agaci_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(urun_agaci_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "urunAgaciGuncelleme";
            Text = "urunAgaciGuncelleme";
            Load += urunAgaciGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFirmaKodu;
        private Button button1;
        private CheckBox chkPasif;
        private TextBox urun_agaci_aciklamasi_txt;
        private Label label4;
        private Label label3;
        private TextBox urun_agaci_tipi_txt;
        private Label label2;
        private Label label1;
    }
}