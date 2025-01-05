namespace WinFormsApp1
{
    partial class birimEkle
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
            birim_adi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            birim_kodu_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbFirmaKodu = new ComboBox();
            chkAnaBirim = new CheckBox();
            ana_birim_kodu_txt = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // birim_adi_txt
            // 
            birim_adi_txt.Location = new Point(230, 113);
            birim_adi_txt.Name = "birim_adi_txt";
            birim_adi_txt.Size = new Size(251, 27);
            birim_adi_txt.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 116);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 34;
            label4.Text = "BİRİM ADI";
            // 
            // label3
            // 
            label3.Location = new Point(313, 19);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 33;
            label3.Text = "BİRİM EKLE";
            // 
            // button1
            // 
            button1.Location = new Point(230, 322);
            button1.Name = "button1";
            button1.Size = new Size(255, 29);
            button1.TabIndex = 28;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // birim_kodu_txt
            // 
            birim_kodu_txt.Location = new Point(230, 170);
            birim_kodu_txt.Name = "birim_kodu_txt";
            birim_kodu_txt.Size = new Size(255, 27);
            birim_kodu_txt.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 177);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 26;
            label2.Text = "BİRİM KODU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 64);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 24;
            label1.Text = "FİRMA KODU";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(230, 61);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(251, 28);
            cmbFirmaKodu.TabIndex = 36;
            // 
            // chkAnaBirim
            // 
            chkAnaBirim.AutoSize = true;
            chkAnaBirim.Location = new Point(230, 277);
            chkAnaBirim.Name = "chkAnaBirim";
            chkAnaBirim.Size = new Size(126, 24);
            chkAnaBirim.TabIndex = 37;
            chkAnaBirim.Text = "ANA BİRİM Mİ";
            chkAnaBirim.UseVisualStyleBackColor = true;
            // 
            // ana_birim_kodu_txt
            // 
            ana_birim_kodu_txt.Location = new Point(230, 231);
            ana_birim_kodu_txt.Name = "ana_birim_kodu_txt";
            ana_birim_kodu_txt.Size = new Size(255, 27);
            ana_birim_kodu_txt.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 231);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 38;
            label5.Text = "ANA BİRİM KODU";
            // 
            // birimEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(647, 388);
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
            Name = "birimEkle";
            Text = "birimEkle";
            Load += birimEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox birim_adi_txt;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox birim_kodu_txt;
        private Label label2;
        private Label label1;
        private ComboBox cmbFirmaKodu;
        private CheckBox chkAnaBirim;
        private TextBox ana_birim_kodu_txt;
        private Label label5;
    }
}