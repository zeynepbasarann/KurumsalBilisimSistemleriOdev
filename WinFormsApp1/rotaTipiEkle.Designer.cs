namespace WinFormsApp1
{
    partial class rotaTipiEkle
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
            button2 = new Button();
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
            // button2
            // 
            button2.Location = new Point(526, 272);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 106;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(494, 223);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 104;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // rota_aciklamasi_txt
            // 
            rota_aciklamasi_txt.Location = new Point(479, 180);
            rota_aciklamasi_txt.Name = "rota_aciklamasi_txt";
            rota_aciklamasi_txt.Size = new Size(151, 27);
            rota_aciklamasi_txt.TabIndex = 103;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 180);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 102;
            label4.Text = "ROTA AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(479, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 101;
            label3.Text = "ROTA TİPİ EKLE";
            // 
            // rota_tipi_txt
            // 
            rota_tipi_txt.Location = new Point(479, 129);
            rota_tipi_txt.Name = "rota_tipi_txt";
            rota_tipi_txt.Size = new Size(151, 27);
            rota_tipi_txt.TabIndex = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 129);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 99;
            label2.Text = "ROTA TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 76);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 97;
            label1.Text = "FİRMA ";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(479, 73);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 111;
            // 
            // rotaTipiEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1175, 703);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button2);
            Controls.Add(chkPasif);
            Controls.Add(rota_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rota_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "rotaTipiEkle";
            Text = "rotaTipiEkle";
            Load += rotaTipiEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
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