namespace WinFormsApp1
{
    partial class malzemeTipiEkle
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
            malzeme_aciklamasi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            malzeme_tipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbFirmaKodu = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(401, 284);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 146;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(415, 217);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 145;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // malzeme_aciklamasi_txt
            // 
            malzeme_aciklamasi_txt.Location = new Point(415, 172);
            malzeme_aciklamasi_txt.Name = "malzeme_aciklamasi_txt";
            malzeme_aciklamasi_txt.Size = new Size(151, 27);
            malzeme_aciklamasi_txt.TabIndex = 144;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 179);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 143;
            label4.Text = "MALZEME AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(415, 24);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 142;
            label3.Text = "MALZEME TİPİ EKLE";
            // 
            // malzeme_tipi_txt
            // 
            malzeme_tipi_txt.Location = new Point(415, 118);
            malzeme_tipi_txt.Name = "malzeme_tipi_txt";
            malzeme_tipi_txt.Size = new Size(151, 27);
            malzeme_tipi_txt.TabIndex = 141;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 125);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 140;
            label2.Text = "MALZEME  TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 68);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 138;
            label1.Text = "FİRMA ";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(415, 66);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 147;
            // 
            // malzemeTipiEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1196, 635);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(chkPasif);
            Controls.Add(malzeme_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(malzeme_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "malzemeTipiEkle";
            Text = "malzemeTipiEkle";
            Load += malzemeTipiEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox chkPasif;
        private TextBox malzeme_aciklamasi_txt;
        private Label label4;
        private Label label3;
        private TextBox malzeme_tipi_txt;
        private Label label2;
        private Label label1;
        private ComboBox cmbFirmaKodu;
    }
}