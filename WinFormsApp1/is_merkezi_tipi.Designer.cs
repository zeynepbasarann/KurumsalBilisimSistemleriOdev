namespace WinFormsApp1
{
    partial class is_merkezi_tipi
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            chbPasif = new CheckBox();
            is_merkezi_aciklamasi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            is_merkezi_tipi_txt = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 110;
            // 
            // button5
            // 
            button5.Location = new Point(534, 120);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 109;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(408, 120);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 108;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(287, 120);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 107;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 106;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 120);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 105;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chbPasif
            // 
            chbPasif.CheckAlign = ContentAlignment.MiddleRight;
            chbPasif.Location = new Point(1012, 54);
            chbPasif.Name = "chbPasif";
            chbPasif.Size = new Size(126, 30);
            chbPasif.TabIndex = 104;
            chbPasif.Text = "PASİF Mİ?";
            chbPasif.TextAlign = ContentAlignment.MiddleCenter;
            chbPasif.TextImageRelation = TextImageRelation.TextAboveImage;
            chbPasif.UseVisualStyleBackColor = true;
            // 
            // is_merkezi_aciklamasi
            // 
            is_merkezi_aciklamasi.Location = new Point(823, 56);
            is_merkezi_aciklamasi.Name = "is_merkezi_aciklamasi";
            is_merkezi_aciklamasi.Size = new Size(125, 27);
            is_merkezi_aciklamasi.TabIndex = 103;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 56);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 102;
            label4.Text = "İŞ MERKEZİ AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 101;
            label3.Text = "İŞ MERKEZİ TİPİ";
            // 
            // is_merkezi_tipi_txt
            // 
            is_merkezi_tipi_txt.Location = new Point(475, 56);
            is_merkezi_tipi_txt.Name = "is_merkezi_tipi_txt";
            is_merkezi_tipi_txt.Size = new Size(125, 27);
            is_merkezi_tipi_txt.TabIndex = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 59);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 99;
            label2.Text = "İŞ MERKEZİ TİPİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 98;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 97;
            label1.Text = "FİRMA ";
            // 
            // is_merkezi_tipi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 735);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chbPasif);
            Controls.Add(is_merkezi_aciklamasi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(is_merkezi_tipi_txt);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "is_merkezi_tipi";
            Text = "is_merkezi_tipi";
            Load += is_merkezi_tipi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox chbPasif;
        private TextBox is_merkezi_aciklamasi;
        private Label label4;
        private Label label3;
        private TextBox is_merkezi_tipi_txt;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}