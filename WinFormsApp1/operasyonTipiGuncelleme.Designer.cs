namespace WinFormsApp1
{
    partial class operasyonTipiGuncelleme
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
            operasyon_tipi_aciklamasi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            operasyon_tipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(525, 69);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 128;
            // 
            // button1
            // 
            button1.Location = new Point(465, 265);
            button1.Name = "button1";
            button1.Size = new Size(211, 29);
            button1.TabIndex = 127;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(550, 212);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 126;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // operasyon_tipi_aciklamasi_txt
            // 
            operasyon_tipi_aciklamasi_txt.Location = new Point(525, 168);
            operasyon_tipi_aciklamasi_txt.Name = "operasyon_tipi_aciklamasi_txt";
            operasyon_tipi_aciklamasi_txt.Size = new Size(155, 27);
            operasyon_tipi_aciklamasi_txt.TabIndex = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 171);
            label4.Name = "label4";
            label4.Size = new Size(208, 20);
            label4.TabIndex = 124;
            label4.Text = "OPERASYON TİPİ AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(495, 27);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 123;
            label3.Text = "OPERASYON TİPİ GÜNCELLE";
            // 
            // operasyon_tipi_txt
            // 
            operasyon_tipi_txt.Location = new Point(525, 114);
            operasyon_tipi_txt.Name = "operasyon_tipi_txt";
            operasyon_tipi_txt.Size = new Size(151, 27);
            operasyon_tipi_txt.TabIndex = 122;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 121);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 121;
            label2.Text = "OPERASYON TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 77);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 120;
            label1.Text = "FİRMA ";
            // 
            // operasyonTipiGuncelleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1181, 670);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(chkPasif);
            Controls.Add(operasyon_tipi_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(operasyon_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "operasyonTipiGuncelleme";
            Text = "operasyonTipiGuncelleme";
            Load += operasyonTipiGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFirmaKodu;
        private Button button1;
        private CheckBox chkPasif;
        private TextBox operasyon_tipi_aciklamasi_txt;
        private Label label4;
        private Label label3;
        private TextBox operasyon_tipi_txt;
        private Label label2;
        private Label label1;
    }
}