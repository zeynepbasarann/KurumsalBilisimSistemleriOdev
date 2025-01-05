namespace WinFormsApp1
{
    partial class operasyonTipiEkle
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
            button2 = new Button();
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
            cmbFirmaKodu.Location = new Point(495, 75);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 120;
            // 
            // button2
            // 
            button2.Location = new Point(495, 264);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 119;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(495, 213);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 118;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // operasyon_tipi_aciklamasi_txt
            // 
            operasyon_tipi_aciklamasi_txt.Location = new Point(495, 161);
            operasyon_tipi_aciklamasi_txt.Name = "operasyon_tipi_aciklamasi_txt";
            operasyon_tipi_aciklamasi_txt.Size = new Size(151, 27);
            operasyon_tipi_aciklamasi_txt.TabIndex = 117;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 168);
            label4.Name = "label4";
            label4.Size = new Size(208, 20);
            label4.TabIndex = 116;
            label4.Text = "OPERASYON TİPİ AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(495, 28);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 115;
            label3.Text = "OPERASYON TİPİ EKLE";
            // 
            // operasyon_tipi_txt
            // 
            operasyon_tipi_txt.Location = new Point(495, 119);
            operasyon_tipi_txt.Name = "operasyon_tipi_txt";
            operasyon_tipi_txt.Size = new Size(151, 27);
            operasyon_tipi_txt.TabIndex = 114;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 122);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 113;
            label2.Text = "OPERASYON TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 78);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 112;
            label1.Text = "FİRMA ";
            // 
            // operasyonTipiEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 662);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button2);
            Controls.Add(chkPasif);
            Controls.Add(operasyon_tipi_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(operasyon_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "operasyonTipiEkle";
            Text = "operasyonTipiEkle";
            Load += operasyonTipiEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFirmaKodu;
        private Button button2;
        private CheckBox chkPasif;
        private TextBox operasyon_tipi_aciklamasi_txt;
        private Label label4;
        private Label label3;
        private TextBox operasyon_tipi_txt;
        private Label label2;
        private Label label1;
    }
}