namespace WinFormsApp1
{
    partial class urunAgaciEkle
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
            cmbFirmaKodu.Location = new Point(335, 95);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 165;
            // 
            // button1
            // 
            button1.Location = new Point(216, 295);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 164;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(235, 237);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 163;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // urun_agaci_aciklamasi_txt
            // 
            urun_agaci_aciklamasi_txt.Location = new Point(335, 180);
            urun_agaci_aciklamasi_txt.Name = "urun_agaci_aciklamasi_txt";
            urun_agaci_aciklamasi_txt.Size = new Size(151, 27);
            urun_agaci_aciklamasi_txt.TabIndex = 162;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 189);
            label4.Name = "label4";
            label4.Size = new Size(184, 20);
            label4.TabIndex = 161;
            label4.Text = "ÜRÜN AĞACI AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(235, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 160;
            label3.Text = "ÜRÜN AĞACI EKLE";
            // 
            // urun_agaci_tipi_txt
            // 
            urun_agaci_tipi_txt.Location = new Point(335, 138);
            urun_agaci_tipi_txt.Name = "urun_agaci_tipi_txt";
            urun_agaci_tipi_txt.Size = new Size(151, 27);
            urun_agaci_tipi_txt.TabIndex = 159;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 142);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 158;
            label2.Text = "ÜRÜN AĞACI TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 95);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 157;
            label1.Text = "FİRMA ";
            // 
            // urunAgaciEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(648, 464);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(chkPasif);
            Controls.Add(urun_agaci_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(urun_agaci_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "urunAgaciEkle";
            Text = "urunAgaciEkle";
            Load += urunAgaciEkle_Load;
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