namespace WinFormsApp1
{
    partial class sehirEkle
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
            sehir_adi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            sehir_kodu_txt = new TextBox();
            label2 = new Label();
            firma_kodu_label = new Label();
            label1 = new Label();
            cmbUlkeKodu = new ComboBox();
            SuspendLayout();
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(309, 115);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 45;
            // 
            // sehir_adi_txt
            // 
            sehir_adi_txt.Location = new Point(309, 206);
            sehir_adi_txt.Name = "sehir_adi_txt";
            sehir_adi_txt.Size = new Size(151, 27);
            sehir_adi_txt.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 210);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 43;
            label4.Text = "ŞEHİR ADI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(257, 26);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 42;
            label3.Text = "ŞEHİR EKLEME";
            // 
            // button1
            // 
            button1.Location = new Point(271, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 41;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sehir_kodu_txt
            // 
            sehir_kodu_txt.Location = new Point(309, 161);
            sehir_kodu_txt.Name = "sehir_kodu_txt";
            sehir_kodu_txt.Size = new Size(151, 27);
            sehir_kodu_txt.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 165);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 39;
            label2.Text = "ŞEHİR KODU";
            // 
            // firma_kodu_label
            // 
            firma_kodu_label.AutoSize = true;
            firma_kodu_label.Location = new Point(199, 120);
            firma_kodu_label.Name = "firma_kodu_label";
            firma_kodu_label.Size = new Size(96, 20);
            firma_kodu_label.TabIndex = 38;
            firma_kodu_label.Text = "FİRMA KODU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 255);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 46;
            label1.Text = "ÜLKE KODU";
            // 
            // cmbUlkeKodu
            // 
            cmbUlkeKodu.FormattingEnabled = true;
            cmbUlkeKodu.Location = new Point(309, 251);
            cmbUlkeKodu.Name = "cmbUlkeKodu";
            cmbUlkeKodu.Size = new Size(151, 28);
            cmbUlkeKodu.TabIndex = 47;
            // 
            // sehirEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(671, 451);
            Controls.Add(cmbUlkeKodu);
            Controls.Add(label1);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(sehir_adi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(sehir_kodu_txt);
            Controls.Add(label2);
            Controls.Add(firma_kodu_label);
            Name = "sehirEkle";
            Text = "sehirEkle";
            Load += sehirEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFirmaKodu;
        private TextBox sehir_adi_txt;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox sehir_kodu_txt;
        private Label label2;
        private Label firma_kodu_label;
        private Label label1;
        private ComboBox cmbUlkeKodu;
    }
}