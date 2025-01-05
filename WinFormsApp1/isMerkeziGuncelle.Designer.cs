namespace WinFormsApp1
{
    partial class isMerkeziGuncelle
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
            is_merkezi_aciklamasi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            is_merkezi_tipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbFirmaKodu = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 293);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 118;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // chkPasif
            // 
            chkPasif.CheckAlign = ContentAlignment.MiddleRight;
            chkPasif.Location = new Point(314, 244);
            chkPasif.Name = "chkPasif";
            chkPasif.Size = new Size(126, 30);
            chkPasif.TabIndex = 117;
            chkPasif.Text = "PASİF Mİ?";
            chkPasif.TextAlign = ContentAlignment.MiddleCenter;
            chkPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chkPasif.UseVisualStyleBackColor = true;
            // 
            // is_merkezi_aciklamasi
            // 
            is_merkezi_aciklamasi.Location = new Point(314, 194);
            is_merkezi_aciklamasi.Name = "is_merkezi_aciklamasi";
            is_merkezi_aciklamasi.Size = new Size(151, 27);
            is_merkezi_aciklamasi.TabIndex = 116;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 194);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 115;
            label4.Text = "İŞ MERKEZİ AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(278, 23);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 114;
            label3.Text = "İŞ MERKEZİ TİPİ GÜNCELLE";
            // 
            // is_merkezi_tipi_txt
            // 
            is_merkezi_tipi_txt.Location = new Point(314, 137);
            is_merkezi_tipi_txt.Name = "is_merkezi_tipi_txt";
            is_merkezi_tipi_txt.Size = new Size(151, 27);
            is_merkezi_tipi_txt.TabIndex = 113;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 137);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 112;
            label2.Text = "İŞ MERKEZİ TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 81);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 110;
            label1.Text = "FİRMA ";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(314, 78);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 119;
            // 
            // isMerkeziGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1207, 603);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(button1);
            Controls.Add(chkPasif);
            Controls.Add(is_merkezi_aciklamasi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(is_merkezi_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "isMerkeziGuncelle";
            Text = "isMerkeziGuncelle";
            Load += isMerkeziGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox chkPasif;
        private TextBox is_merkezi_aciklamasi;
        private Label label4;
        private Label label3;
        private TextBox is_merkezi_tipi_txt;
        private Label label2;
        private Label label1;
        private ComboBox cmbFirmaKodu;
    }
}