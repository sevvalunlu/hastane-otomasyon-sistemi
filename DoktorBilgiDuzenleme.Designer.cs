namespace hastaneOtomasyonSistemi
{
    partial class DoktorBilgiDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBilgiDuzenleme));
            button2 = new Button();
            hesap_olustur_button = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(20, 259);
            button2.Name = "button2";
            button2.Size = new Size(36, 36);
            button2.TabIndex = 31;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hesap_olustur_button
            // 
            hesap_olustur_button.BackColor = Color.LightGreen;
            hesap_olustur_button.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hesap_olustur_button.Location = new Point(127, 213);
            hesap_olustur_button.Name = "hesap_olustur_button";
            hesap_olustur_button.Size = new Size(169, 41);
            hesap_olustur_button.TabIndex = 30;
            hesap_olustur_button.Text = "Bilgileri Güncelle";
            hesap_olustur_button.UseVisualStyleBackColor = false;
            hesap_olustur_button.Click += hesap_olustur_button_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 23);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 27;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(163, 106);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(133, 23);
            maskedTextBox1.TabIndex = 25;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(114, 172);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 24;
            label5.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(101, 142);
            label4.Name = "label4";
            label4.Size = new Size(51, 16);
            label4.TabIndex = 23;
            label4.Text = "Branş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(57, 108);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 22;
            label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(101, 78);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 21;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(127, 45);
            label1.Name = "label1";
            label1.Size = new Size(30, 16);
            label1.TabIndex = 20;
            label1.Text = "Ad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(163, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 32;
            // 
            // DoktorBilgiDuzenleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(355, 306);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(hesap_olustur_button);
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
            Name = "DoktorBilgiDuzenleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Bilgi Düzenleme";
            Load += DoktorBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button hesap_olustur_button;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
    }
}