namespace WinFormsApp1
{
    partial class operasyon_tipi
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
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
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
            dataGridView1.Location = new Point(-5, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 96;
            // 
            // button4
            // 
            button4.Location = new Point(506, 129);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 94;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(378, 129);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 93;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(260, 129);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 92;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 129);
            button1.Name = "button1";
            button1.Size = new Size(239, 29);
            button1.TabIndex = 91;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(1012, 63);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 30);
            checkBox2.TabIndex = 90;
            checkBox2.Text = "PASİF Mİ?";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(823, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 65);
            label4.Name = "label4";
            label4.Size = new Size(184, 20);
            label4.TabIndex = 88;
            label4.Text = "OPERASYON  AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(573, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 87;
            label3.Text = "OPERASYON TİPİ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(475, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 68);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 85;
            label2.Text = "OPERASYON TİPİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 84;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 68);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 83;
            label1.Text = "FİRMA ";
            // 
            // operasyon_tipi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1342, 706);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "operasyon_tipi";
            Text = "operasyon_tipi";
            Load += operasyon_tipi_Load;
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
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}