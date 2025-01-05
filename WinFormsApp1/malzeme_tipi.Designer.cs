namespace WinFormsApp1
{
    partial class malzeme_tipi
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
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            checkBox2 = new CheckBox();
            malzeme_aciklama_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            malzeme_tipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbFirmaKodu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 138;
            // 
            // button4
            // 
            button4.Location = new Point(438, 120);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 136;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(310, 120);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 135;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(192, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 134;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 120);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 133;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(1012, 54);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 30);
            checkBox2.TabIndex = 132;
            checkBox2.Text = "PASİF Mİ?";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // malzeme_aciklama_txt
            // 
            malzeme_aciklama_txt.Location = new Point(823, 56);
            malzeme_aciklama_txt.Name = "malzeme_aciklama_txt";
            malzeme_aciklama_txt.Size = new Size(125, 27);
            malzeme_aciklama_txt.TabIndex = 131;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 56);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 130;
            label4.Text = "MALZEME AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(620, 12);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 129;
            label3.Text = "MALZEME TİPİ";
            // 
            // malzeme_tipi_txt
            // 
            malzeme_tipi_txt.Location = new Point(475, 56);
            malzeme_tipi_txt.Name = "malzeme_tipi_txt";
            malzeme_tipi_txt.Size = new Size(125, 27);
            malzeme_tipi_txt.TabIndex = 128;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 64);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 127;
            label2.Text = "MALZEME  TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 125;
            label1.Text = "FİRMA ";
            // 
            // cmbFirmaKodu
            // 
            cmbFirmaKodu.FormattingEnabled = true;
            cmbFirmaKodu.Location = new Point(92, 58);
            cmbFirmaKodu.Name = "cmbFirmaKodu";
            cmbFirmaKodu.Size = new Size(151, 28);
            cmbFirmaKodu.TabIndex = 139;
            // 
            // malzeme_tipi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1367, 709);
            Controls.Add(cmbFirmaKodu);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(malzeme_aciklama_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(malzeme_tipi_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "malzeme_tipi";
            Text = "malzeme_tipi";
            Load += malzeme_tipi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox checkBox2;
        private TextBox malzeme_aciklama_txt;
        private Label label4;
        private Label label3;
        private TextBox malzeme_tipi_txt;
        private Label label2;
        private Label label1;
        private ComboBox cmbFirmaKodu;
    }
}