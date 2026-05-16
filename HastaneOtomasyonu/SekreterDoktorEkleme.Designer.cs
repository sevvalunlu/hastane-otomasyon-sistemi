namespace hastaneOtomasyonSistemi
{
    partial class SekreterDoktorEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterDoktorEkleme));
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 23);
            comboBox1.TabIndex = 42;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 23);
            textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 39;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(133, 130);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(221, 23);
            maskedTextBox1.TabIndex = 38;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(84, 171);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 37;
            label5.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(76, 98);
            label4.Name = "label4";
            label4.Size = new Size(51, 16);
            label4.TabIndex = 36;
            label4.Text = "Branş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(27, 132);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 35;
            label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(71, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 34;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(97, 26);
            label1.Name = "label1";
            label1.Size = new Size(30, 16);
            label1.TabIndex = 33;
            label1.Text = "Ad:";
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(133, 209);
            button1.Name = "button1";
            button1.Size = new Size(101, 38);
            button1.TabIndex = 43;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(253, 209);
            button2.Name = "button2";
            button2.Size = new Size(101, 38);
            button2.TabIndex = 44;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(133, 293);
            button3.Name = "button3";
            button3.Size = new Size(221, 38);
            button3.TabIndex = 45;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Location = new Point(56, 293);
            button7.Name = "button7";
            button7.Size = new Size(51, 38);
            button7.TabIndex = 46;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(377, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(751, 289);
            dataGridView1.TabIndex = 47;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(175, 253);
            button4.Name = "button4";
            button4.Size = new Size(137, 34);
            button4.TabIndex = 48;
            button4.Text = "Temizle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // SekreterDoktorEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1153, 340);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SekreterDoktorEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Paneli";
            Load += SekreterDoktorEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button7;
        private DataGridView dataGridView1;
        private Button button4;
    }
}