namespace WinFormsApp1
{
    partial class urun_agaci
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
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            checkBox2 = new CheckBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(769, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 59);
            label4.Name = "label4";
            label4.Size = new Size(184, 20);
            label4.TabIndex = 69;
            label4.Text = "ÜRÜN AĞACI AÇIKLAMASI";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(546, 9);
            label3.Name = "label3";
            label3.Size = new Size(574, 39);
            label3.TabIndex = 68;
            label3.Text = "ÜRÜN AĞACI ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(401, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 59);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 66;
            label2.Text = "ÜRÜN AĞACI TİPİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 64;
            label1.Text = "FİRMA ";
            // 
            // checkBox2
            // 
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(931, 54);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 30);
            checkBox2.TabIndex = 76;
            checkBox2.Text = "PASİF Mİ?";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1382, 435);
            dataGridView1.TabIndex = 82;
            // 
            // button4
            // 
            button4.Location = new Point(503, 120);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 80;
            button4.Text = "SİL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSil_Click;
            // 
            // button3
            // 
            button3.Location = new Point(375, 120);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 79;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(257, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 78;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 120);
            button1.Name = "button1";
            button1.Size = new Size(214, 29);
            button1.TabIndex = 77;
            button1.Text = "TÜMÜNÜ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // urun_agaci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1373, 723);
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
            Name = "urun_agaci";
            Text = "urun_agaci";
            Load += urun_agaci_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox2;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}