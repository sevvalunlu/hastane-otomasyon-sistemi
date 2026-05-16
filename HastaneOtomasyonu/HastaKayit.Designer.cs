namespace hastaneOtomasyonSistemi
{
    partial class HastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayit));
            ad_label = new Label();
            soyad_label = new Label();
            ad_textBox = new TextBox();
            soyad_textBox = new TextBox();
            tc_label = new Label();
            sifre_label = new Label();
            sifre_textBox = new TextBox();
            tel_no_label = new Label();
            adres_label = new Label();
            adres_textBox = new TextBox();
            hesap_olustur_button = new Button();
            ana_sayfa_link_label = new LinkLabel();
            kayit_ol_label = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            SuspendLayout();
            // 
            // ad_label
            // 
            ad_label.AutoSize = true;
            ad_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ad_label.Location = new Point(83, 56);
            ad_label.Name = "ad_label";
            ad_label.Size = new Size(28, 20);
            ad_label.TabIndex = 0;
            ad_label.Text = "Ad";
            // 
            // soyad_label
            // 
            soyad_label.AutoSize = true;
            soyad_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            soyad_label.Location = new Point(332, 56);
            soyad_label.Name = "soyad_label";
            soyad_label.Size = new Size(50, 20);
            soyad_label.TabIndex = 1;
            soyad_label.Text = "Soyad";
            // 
            // ad_textBox
            // 
            ad_textBox.Location = new Point(83, 79);
            ad_textBox.Name = "ad_textBox";
            ad_textBox.Size = new Size(165, 23);
            ad_textBox.TabIndex = 2;
            // 
            // soyad_textBox
            // 
            soyad_textBox.Location = new Point(332, 79);
            soyad_textBox.Name = "soyad_textBox";
            soyad_textBox.Size = new Size(165, 23);
            soyad_textBox.TabIndex = 3;
            // 
            // tc_label
            // 
            tc_label.AutoSize = true;
            tc_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tc_label.Location = new Point(83, 118);
            tc_label.Name = "tc_label";
            tc_label.Size = new Size(94, 20);
            tc_label.TabIndex = 4;
            tc_label.Text = "TC Kimlik No";
            tc_label.Click += label3_Click;
            // 
            // sifre_label
            // 
            sifre_label.AutoSize = true;
            sifre_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sifre_label.Location = new Point(332, 118);
            sifre_label.Name = "sifre_label";
            sifre_label.Size = new Size(39, 20);
            sifre_label.TabIndex = 6;
            sifre_label.Text = "Şifre";
            // 
            // sifre_textBox
            // 
            sifre_textBox.Location = new Point(333, 141);
            sifre_textBox.Name = "sifre_textBox";
            sifre_textBox.Size = new Size(165, 23);
            sifre_textBox.TabIndex = 7;
            // 
            // tel_no_label
            // 
            tel_no_label.AutoSize = true;
            tel_no_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tel_no_label.Location = new Point(83, 185);
            tel_no_label.Name = "tel_no_label";
            tel_no_label.Size = new Size(125, 20);
            tel_no_label.TabIndex = 8;
            tel_no_label.Text = "Telefon Numarası";
            // 
            // adres_label
            // 
            adres_label.AutoSize = true;
            adres_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            adres_label.Location = new Point(332, 185);
            adres_label.Name = "adres_label";
            adres_label.Size = new Size(47, 20);
            adres_label.TabIndex = 9;
            adres_label.Text = "Adres";
            // 
            // adres_textBox
            // 
            adres_textBox.Location = new Point(332, 208);
            adres_textBox.Name = "adres_textBox";
            adres_textBox.Size = new Size(165, 23);
            adres_textBox.TabIndex = 11;
            // 
            // hesap_olustur_button
            // 
            hesap_olustur_button.BackColor = Color.LimeGreen;
            hesap_olustur_button.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hesap_olustur_button.Location = new Point(217, 267);
            hesap_olustur_button.Name = "hesap_olustur_button";
            hesap_olustur_button.Size = new Size(145, 41);
            hesap_olustur_button.TabIndex = 12;
            hesap_olustur_button.Text = "Hesap Oluştur";
            hesap_olustur_button.UseVisualStyleBackColor = false;
            hesap_olustur_button.Click += hesap_olustur_button_Click;
            // 
            // ana_sayfa_link_label
            // 
            ana_sayfa_link_label.AutoSize = true;
            ana_sayfa_link_label.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ana_sayfa_link_label.LinkColor = Color.Black;
            ana_sayfa_link_label.Location = new Point(222, 343);
            ana_sayfa_link_label.Name = "ana_sayfa_link_label";
            ana_sayfa_link_label.Size = new Size(140, 16);
            ana_sayfa_link_label.TabIndex = 13;
            ana_sayfa_link_label.TabStop = true;
            ana_sayfa_link_label.Text = "Ana Sayfaya Geri Dön";
            ana_sayfa_link_label.LinkClicked += ana_sayfa_link_label_LinkClicked;
            // 
            // kayit_ol_label
            // 
            kayit_ol_label.AutoSize = true;
            kayit_ol_label.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kayit_ol_label.Location = new Point(245, 18);
            kayit_ol_label.Name = "kayit_ol_label";
            kayit_ol_label.Size = new Size(87, 25);
            kayit_ol_label.TabIndex = 14;
            kayit_ol_label.Text = "Kayıt Ol";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(83, 208);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(165, 23);
            maskedTextBox1.TabIndex = 15;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(83, 141);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(165, 23);
            maskedTextBox2.TabIndex = 16;
            // 
            // HastaKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(585, 368);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(kayit_ol_label);
            Controls.Add(ana_sayfa_link_label);
            Controls.Add(hesap_olustur_button);
            Controls.Add(adres_textBox);
            Controls.Add(adres_label);
            Controls.Add(tel_no_label);
            Controls.Add(sifre_textBox);
            Controls.Add(sifre_label);
            Controls.Add(tc_label);
            Controls.Add(soyad_textBox);
            Controls.Add(ad_textBox);
            Controls.Add(soyad_label);
            Controls.Add(ad_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HastaKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Kayıt Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ad_label;
        private Label soyad_label;
        private TextBox ad_textBox;
        private TextBox soyad_textBox;
        private Label tc_label;
        private Label sifre_label;
        private TextBox sifre_textBox;
        private Label tel_no_label;
        private Label adres_label;
        private TextBox adres_textBox;
        private Button hesap_olustur_button;
        private LinkLabel ana_sayfa_link_label;
        private Label kayit_ol_label;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
    }
}