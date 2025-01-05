namespace WinFormsApp1
{
    partial class birim
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
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            birim_kodu_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            birim_adi_txt = new TextBox();
            label4 = new Label();
            cmbFirmaKodu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(374, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 21;
            label3.Text = "BİRİM KONTROL TABLOSU";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(969, 405);
            dataGridView1.TabIndex = 20;
            // 
            // button4
            // 
            button4.Location = new Point(469, 96);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(341, 96);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 96);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 96);
            button1.Name = "button1";
            button1.Size = new Size(191, 29);
            button1.TabIndex = 15;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // birim_kodu_txt
            // 
            birim_kodu_txt.Location = new Point(432, 51);
            birim_kodu_txt.Name = "birim_kodu_txt";
            birim_kodu_txt.Size = new Size(155, 27);
            birim_kodu_txt.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 56);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 13;
            label2.Text = "BİRİM KODU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 56);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 11;
            label1.Text = "FİRMA KODU";
            // 
            // birim_adi_txt
            // 
            birim_adi_txt.Location = new Point(703, 52);
            birim_adi_txt.Name = "birim_adi_txt";
            birim_adi_txt.Size = new Size(169, 27);
            birim_adi_txt.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 55);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 22;
            label4.Text = "BİRİM ADI";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(116, 53);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 24;
            // 
            // birim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(971, 541);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(birim_adi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(birim_kodu_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "birim";
            Text = "birim";
            Load += birim_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox birim_kodu_txt;
        private Label label2;
        private Label label1;
        private TextBox birim_adi_txt;
        private Label label4;
        private ComboBox cmbFirmaKodu;
    }
}