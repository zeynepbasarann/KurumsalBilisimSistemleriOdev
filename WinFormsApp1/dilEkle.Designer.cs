namespace WinFormsApp1
{
    partial class dilEkle
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
            dil_adi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            dil_kodu_txt = new TextBox();
            label2 = new Label();
            firma_kodu_label = new Label();
            cmbFirmaKodu = new ComboBox();
            SuspendLayout();
            // 
            // dil_adi_txt
            // 
            dil_adi_txt.Location = new Point(221, 169);
            dil_adi_txt.Name = "dil_adi_txt";
            dil_adi_txt.Size = new Size(251, 27);
            dil_adi_txt.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 172);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 35;
            label4.Text = "DİL ADI";
            // 
            // label3
            // 
            label3.Location = new Point(285, 28);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 34;
            label3.Text = "DİL EKLEME";
            // 
            // button1
            // 
            button1.Location = new Point(221, 223);
            button1.Name = "button1";
            button1.Size = new Size(251, 29);
            button1.TabIndex = 28;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dil_kodu_txt
            // 
            dil_kodu_txt.Location = new Point(221, 115);
            dil_kodu_txt.Name = "dil_kodu_txt";
            dil_kodu_txt.Size = new Size(251, 27);
            dil_kodu_txt.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 122);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 26;
            label2.Text = "DİL KODU";
            // 
            // firma_kodu_label
            // 
            firma_kodu_label.AutoSize = true;
            firma_kodu_label.Location = new Point(110, 75);
            firma_kodu_label.Name = "firma_kodu_label";
            firma_kodu_label.Size = new Size(96, 20);
            firma_kodu_label.TabIndex = 24;
            firma_kodu_label.Text = "FİRMA KODU";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(221, 70);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(251, 28);
            cmbFirmaKodu.TabIndex = 37;
            // 
            // dilEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(626, 414);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(dil_adi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dil_kodu_txt);
            Controls.Add(label2);
            Controls.Add(firma_kodu_label);
            Name = "dilEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dilEkle";
            Load += dilEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dil_adi_txt;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox dil_kodu_txt;
        private Label label2;
        private Label firma_kodu_label;
        private ComboBox cmbFirmaKodu;
    }
}