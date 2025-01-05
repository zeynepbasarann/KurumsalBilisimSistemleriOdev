namespace WinFormsApp1
{
    partial class maliyet_merkezi
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
            maliyet_merkezi_aciklamasi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            maliyet_merkezi_kodu_txt = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 124;
            // 
            // button4
            // 
            button4.Location = new Point(490, 120);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 122;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(362, 120);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 121;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(229, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 120;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(25, 120);
            button1.Name = "button1";
            button1.Size = new Size(172, 29);
            button1.TabIndex = 119;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(1004, 59);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 30);
            checkBox2.TabIndex = 118;
            checkBox2.Text = "PASİF Mİ?";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // maliyet_merkezi_aciklamasi_txt
            // 
            maliyet_merkezi_aciklamasi_txt.Location = new Point(873, 60);
            maliyet_merkezi_aciklamasi_txt.Name = "maliyet_merkezi_aciklamasi_txt";
            maliyet_merkezi_aciklamasi_txt.Size = new Size(125, 27);
            maliyet_merkezi_aciklamasi_txt.TabIndex = 117;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(648, 63);
            label4.Name = "label4";
            label4.Size = new Size(219, 20);
            label4.TabIndex = 116;
            label4.Text = "MALİYET MERKEZİ AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(613, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 115;
            label3.Text = "MALİYET MERKEZİ ";
            // 
            // maliyet_merkezi_kodu_txt
            // 
            maliyet_merkezi_kodu_txt.Location = new Point(490, 56);
            maliyet_merkezi_kodu_txt.Name = "maliyet_merkezi_kodu_txt";
            maliyet_merkezi_kodu_txt.Size = new Size(125, 27);
            maliyet_merkezi_kodu_txt.TabIndex = 114;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 59);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 113;
            label2.Text = "MALİYET MERKEZİ  TİPİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 112;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 111;
            label1.Text = "FİRMA ";
            // 
            // maliyet_merkezi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1335, 710);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(maliyet_merkezi_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maliyet_merkezi_kodu_txt);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "maliyet_merkezi";
            Text = "maaliyet_merkezi";
            Load += maliyet_merkezi_Load;
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
        private TextBox maliyet_merkezi_aciklamasi_txt;
        private Label label4;
        private Label label3;
        private TextBox maliyet_merkezi_kodu_txt;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}