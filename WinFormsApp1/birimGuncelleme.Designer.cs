namespace WinFormsApp1
{
    partial class birimGuncelleme
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
            birim_adi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            birim_kodu_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ana_birim_kodu_txt = new TextBox();
            label5 = new Label();
            chkAnaBirim = new CheckBox();
            SuspendLayout();
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(226, 64);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(201, 28);
            cmbFirmaKodu.TabIndex = 44;
            // 
            // birim_adi_txt
            // 
            birim_adi_txt.Location = new Point(226, 158);
            birim_adi_txt.Name = "birim_adi_txt";
            birim_adi_txt.Size = new Size(201, 27);
            birim_adi_txt.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 158);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 42;
            label4.Text = "BİRİM ADI";
            // 
            // label3
            // 
            label3.Location = new Point(261, 22);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 41;
            label3.Text = "BİRİM GÜNCELLE";
            // 
            // button1
            // 
            button1.Location = new Point(226, 292);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 40;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // birim_kodu_txt
            // 
            birim_kodu_txt.Location = new Point(226, 106);
            birim_kodu_txt.Name = "birim_kodu_txt";
            birim_kodu_txt.Size = new Size(201, 27);
            birim_kodu_txt.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 113);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 38;
            label2.Text = "BİRİM KODU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 71);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 37;
            label1.Text = "FİRMA KODU";
            // 
            // ana_birim_kodu_txt
            // 
            ana_birim_kodu_txt.Location = new Point(226, 197);
            ana_birim_kodu_txt.Name = "ana_birim_kodu_txt";
            ana_birim_kodu_txt.Size = new Size(201, 27);
            ana_birim_kodu_txt.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 200);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 46;
            label5.Text = "ANA BİRİM KODU";
            // 
            // chkAnaBirim
            // 
            chkAnaBirim.AutoSize = true;
            chkAnaBirim.Location = new Point(226, 243);
            chkAnaBirim.Name = "chkAnaBirim";
            chkAnaBirim.Size = new Size(126, 24);
            chkAnaBirim.TabIndex = 45;
            chkAnaBirim.Text = "ANA BİRİM Mİ";
            chkAnaBirim.UseVisualStyleBackColor = true;
            // 
            // birimGuncelleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 386);
            Controls.Add(ana_birim_kodu_txt);
            Controls.Add(label5);
            Controls.Add(chkAnaBirim);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(birim_adi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(birim_kodu_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "birimGuncelleme";
            Text = "birimGuncelleme";
            Load += birimGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFirmaKodu;
        private TextBox birim_adi_txt;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox birim_kodu_txt;
        private Label label2;
        private Label label1;
        private TextBox ana_birim_kodu_txt;
        private Label label5;
        private CheckBox chkAnaBirim;
    }
}