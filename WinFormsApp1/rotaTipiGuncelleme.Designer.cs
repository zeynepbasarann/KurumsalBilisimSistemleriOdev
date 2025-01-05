namespace WinFormsApp1
{
    partial class rotaTipiGuncelleme
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
            button1 = new Button();
            chkPasif = new CheckBox();
            rota_aciklamasi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            rota_tipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbFirmaKodu = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(388, 287);
            button1.Name = "button1";
            button1.Size = new Size(211, 29);
            button1.TabIndex = 118;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(473, 238);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 117;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // rota_aciklamasi_txt
            // 
            rota_aciklamasi_txt.Location = new Point(448, 186);
            rota_aciklamasi_txt.Name = "rota_aciklamasi_txt";
            rota_aciklamasi_txt.Size = new Size(151, 27);
            rota_aciklamasi_txt.TabIndex = 116;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 193);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 115;
            label4.Text = "ROTA AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(435, 20);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 114;
            label3.Text = "ROTA TİPİ GÜNCELLE";
            // 
            // rota_tipi_txt
            // 
            rota_tipi_txt.Location = new Point(448, 125);
            rota_tipi_txt.Name = "rota_tipi_txt";
            rota_tipi_txt.Size = new Size(151, 27);
            rota_tipi_txt.TabIndex = 113;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 132);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 112;
            label2.Text = "ROTA TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 74);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 110;
            label1.Text = "FİRMA ";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(448, 76);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 119;
            cmbFirmaKodu.SelectedIndexChanged += rotaTipiGuncelleme_Load;
            // 
            // rotaTipiGuncelleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1169, 728);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(chkPasif);
            Controls.Add(rota_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rota_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "rotaTipiGuncelleme";
            Text = "rotaTipiGuncelleme";
            Load += rotaTipiGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox chkPasif;
        private TextBox rota_aciklamasi_txt;
        private Label label4;
        private Label label3;
        private TextBox rota_tipi_txt;
        private Label label2;
        private Label label1;
        private ComboBox cmbFirmaKodu;
    }
}