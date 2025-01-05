namespace WinFormsApp1
{
    partial class rota_tipi
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
            rota_aciklamasi_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            rota_tipi_txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            firma_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 96;
            // 
            // button4
            // 
            button4.Location = new Point(504, 120);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 94;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(376, 120);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 93;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 92;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 120);
            button1.Name = "button1";
            button1.Size = new Size(211, 29);
            button1.TabIndex = 91;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(1030, 54);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 30);
            checkBox2.TabIndex = 90;
            checkBox2.Text = "PASİF Mİ?";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // rota_aciklamasi_txt
            // 
            rota_aciklamasi_txt.Location = new Point(841, 56);
            rota_aciklamasi_txt.Name = "rota_aciklamasi_txt";
            rota_aciklamasi_txt.Size = new Size(125, 27);
            rota_aciklamasi_txt.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(651, 56);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 88;
            label4.Text = "ROTA AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(598, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 87;
            label3.Text = "ROTA TİPİ";
            // 
            // rota_tipi_txt
            // 
            rota_tipi_txt.Location = new Point(493, 56);
            rota_tipi_txt.Name = "rota_tipi_txt";
            rota_tipi_txt.Size = new Size(125, 27);
            rota_tipi_txt.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 59);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 85;
            label2.Text = "ROTA TİPİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 83;
            label1.Text = "FİRMA ";
            // 
            // firma_txt
            // 
            firma_txt.Location = new Point(142, 54);
            firma_txt.Name = "firma_txt";
            firma_txt.Size = new Size(125, 27);
            firma_txt.TabIndex = 84;
            // 
            // rota_tipi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1414, 693);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(rota_aciklamasi_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rota_tipi_txt);
            Controls.Add(label2);
            Controls.Add(firma_txt);
            Controls.Add(label1);
            Name = "rota_tipi";
            Text = "rota_tipi";
            Load += rota_tipi_Load_1;
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
        private TextBox rota_aciklamasi_txt;
        private Label label4;
        private Label label3;
        private TextBox rota_tipi_txt;
        private Label label2;
        private Label label1;
        private TextBox firma_txt;
    }
}