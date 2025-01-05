namespace WinFormsApp1
{
    partial class ulkeEkle
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
            ulke_adi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            ulke_kodu_txt = new TextBox();
            label2 = new Label();
            firma_kodu_label = new Label();
            SuspendLayout();
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(233, 95);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 45;
            // 
            // ulke_adi_txt
            // 
            ulke_adi_txt.Location = new Point(233, 220);
            ulke_adi_txt.Name = "ulke_adi_txt";
            ulke_adi_txt.Size = new Size(151, 27);
            ulke_adi_txt.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 216);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 43;
            label4.Text = "ÜLKE ADI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(186, 34);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 42;
            label3.Text = "ÜLKE EKLEME";
            // 
            // button1
            // 
            button1.Location = new Point(186, 293);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 41;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ulke_kodu_txt
            // 
            ulke_kodu_txt.Location = new Point(233, 158);
            ulke_kodu_txt.Name = "ulke_kodu_txt";
            ulke_kodu_txt.Size = new Size(151, 27);
            ulke_kodu_txt.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 157);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 39;
            label2.Text = "ÜLKE KODU";
            // 
            // firma_kodu_label
            // 
            firma_kodu_label.AutoSize = true;
            firma_kodu_label.Location = new Point(121, 98);
            firma_kodu_label.Name = "firma_kodu_label";
            firma_kodu_label.Size = new Size(96, 20);
            firma_kodu_label.TabIndex = 38;
            firma_kodu_label.Text = "FİRMA KODU";
            // 
            // ulkeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(531, 437);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(ulke_adi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(ulke_kodu_txt);
            Controls.Add(label2);
            Controls.Add(firma_kodu_label);
            Name = "ulkeEkle";
            Text = "ulkeEkle";
            Load += ulkeEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFirmaKodu;
        private TextBox ulke_adi_txt;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox ulke_kodu_txt;
        private Label label2;
        private Label firma_kodu_label;
    }
}