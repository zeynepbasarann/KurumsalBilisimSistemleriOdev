namespace WinFormsApp1
{
    partial class dilGuncelleme
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
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            firma_kodu_label = new Label();
            dil_adi_txt = new TextBox();
            dil_kodu_txt = new TextBox();
            SuspendLayout();
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(211, 64);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(275, 28);
            cmbFirmaKodu.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 172);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 43;
            label4.Text = "DİL ADI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(285, 22);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 42;
            label3.Text = "DİL GÜNCELLE";
            // 
            // button1
            // 
            button1.Location = new Point(211, 229);
            button1.Name = "button1";
            button1.Size = new Size(275, 29);
            button1.TabIndex = 41;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 118);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 39;
            label2.Text = "DİL KODU";
            // 
            // firma_kodu_label
            // 
            firma_kodu_label.AutoSize = true;
            firma_kodu_label.Location = new Point(100, 69);
            firma_kodu_label.Name = "firma_kodu_label";
            firma_kodu_label.Size = new Size(96, 20);
            firma_kodu_label.TabIndex = 38;
            firma_kodu_label.Text = "FİRMA KODU";
            // 
            // dil_adi_txt
            // 
            dil_adi_txt.Location = new Point(211, 169);
            dil_adi_txt.Name = "dil_adi_txt";
            dil_adi_txt.Size = new Size(275, 27);
            dil_adi_txt.TabIndex = 44;
            // 
            // dil_kodu_txt
            // 
            dil_kodu_txt.Location = new Point(211, 115);
            dil_kodu_txt.Name = "dil_kodu_txt";
            dil_kodu_txt.Size = new Size(275, 27);
            dil_kodu_txt.TabIndex = 40;
            // 
            // dilGuncelleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1136, 672);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(dil_adi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dil_kodu_txt);
            Controls.Add(label2);
            Controls.Add(firma_kodu_label);
            Name = "dilGuncelleme";
            Text = "dilGuncelleme";
            Load += dilGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFirmaKodu;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label firma_kodu_label;
        private TextBox dil_adi_txt;
        private TextBox dil_kodu_txt;
    }
}