namespace hastaneOtomasyonSistemi
{
    partial class DoktorRandevuTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorRandevuTakip));
            label8 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            labelad = new Label();
            label1 = new Label();
            labeltc = new Label();
            label2 = new Label();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label5 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(319, 9);
            label8.Name = "label8";
            label8.Size = new Size(118, 16);
            label8.TabIndex = 5;
            label8.Text = "Randevu Listesi";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(297, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(1022, 458);
            panel3.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(3, 410);
            button2.Name = "button2";
            button2.Size = new Size(49, 43);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1022, 454);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 251);
            panel2.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 18);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(261, 226);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(-2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 0;
            label3.Text = "Randevu Detayı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(labelad);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labeltc);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 88);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 0;
            label4.Text = "Doktor Bilgileri";
            // 
            // labelad
            // 
            labelad.AutoSize = true;
            labelad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelad.Location = new Point(94, 31);
            labelad.Name = "labelad";
            labelad.Size = new Size(29, 13);
            labelad.TabIndex = 4;
            labelad.Text = "Null";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(41, 54);
            label1.Name = "label1";
            label1.Size = new Size(47, 13);
            label1.TabIndex = 1;
            label1.Text = "TC No:";
            // 
            // labeltc
            // 
            labeltc.AutoSize = true;
            labeltc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labeltc.Location = new Point(94, 54);
            labeltc.Name = "labeltc";
            labeltc.Size = new Size(84, 13);
            labeltc.TabIndex = 3;
            labeltc.Text = "00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(23, 31);
            label2.Name = "label2";
            label2.Size = new Size(65, 13);
            label2.TabIndex = 2;
            label2.Text = "Ad Soyad:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(12, 363);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 109);
            panel4.TabIndex = 10;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(136, 65);
            button4.Name = "button4";
            button4.Size = new Size(128, 33);
            button4.TabIndex = 3;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(3, 65);
            button3.Name = "button3";
            button3.Size = new Size(132, 33);
            button3.TabIndex = 2;
            button3.Text = "Duyurular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(3, 18);
            button1.Name = "button1";
            button1.Size = new Size(261, 41);
            button1.TabIndex = 1;
            button1.Text = "Bilgileri Düzenle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(-2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 0;
            label5.Text = "Seçenekler";
            // 
            // DoktorRandevuTakip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1331, 484);
            Controls.Add(panel4);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoktorRandevuTakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Randevu Takip Paneli";
            Load += DoktorRandevuTakip_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Panel panel3;
        private Button button2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label labelad;
        private Label label1;
        private Label labeltc;
        private Label label2;
        private Panel panel4;
        private Button button1;
        private Label label5;
        private Button button4;
        private Button button3;
    }
}