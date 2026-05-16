using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneOtomasyonSistemi
{
    public partial class SekreterTakip : Form
    {
        public SekreterTakip()
        {
            InitializeComponent();
        }

        public string TCnumara;
        SqlBaglantisi bgl = new SqlBaglantisi();

        void BosIDGetir()
        {
            SqlCommand komut = new SqlCommand("Select MAX(Randevuid) From Tbl_Randevular", bgl.baglanti());

            // ExecuteScalar: Tek bir değer (Hücre) döneceği zaman kullanılır
            object sonuc = komut.ExecuteScalar();

            // Eğer veritabanı boşsa ID 1 olsun
            if (sonuc != DBNull.Value && sonuc != null)
            {
                int enBuyukID = Convert.ToInt32(sonuc);
                textBox1.Text = (enBuyukID + 1).ToString();
            }
            else
            {
                textBox1.Text = "1";
            }

            bgl.baglanti().Close();
        }

        public void BranslariYenile()
        {
            // BRANŞLARI COMBOBOX'A AKTARMA 
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }

            // TABLOYA BRANŞLARI GETİR
            DataTable dt1 = new DataTable();
            
            SqlDataAdapter da1 = new SqlDataAdapter("Select BransAd as 'Branşlar' From Tbl_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        public void DoktorlariYenile()
        {
            // DOKTORLARI GETİR 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans as 'Branş', DoktorTC as 'TC' From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
        }


        private void SekreterTakip_Load(object sender, EventArgs e)
        {
            labeltc.Text = TCnumara;

            BosIDGetir();

            BranslariYenile();

            DoktorlariYenile();

            // AD SOYADI VERİTABANINDAN ÇEK
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", labeltc.Text);

            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                labelad.Text = dr1[0].ToString(); // Ad Soyadı yazdır
            }

            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SekreterDoktorEkleme fr = new SekreterDoktorEkleme();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Duyuru Sisteme Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ÇAKIŞMA KONTROLÜ:"Bu doktora, bu tarihte ve bu saatte zaten randevu verilmiş mi?"
            SqlCommand komutkontrol = new SqlCommand("Select * From Tbl_Randevular where RandevuDoktor=@p1 and RandevuTarih=@p2 and RandevuSaat=@p3", bgl.baglanti());
            komutkontrol.Parameters.AddWithValue("@p1", comboBox2.Text);
            komutkontrol.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komutkontrol.Parameters.AddWithValue("@p3", maskedTextBox2.Text);

            SqlDataReader dr = komutkontrol.ExecuteReader();

            if (dr.Read()) // Eğer kayıt varsa (dr.Read true dönerse)
            {
                MessageBox.Show("Bu doktora belirtilen tarih ve saatte zaten bir randevu açılmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bgl.baglanti().Close();
            }
            else
            {
                // Kayıt yok o zaman yeni randevu
                bgl.baglanti().Close(); 

                // RANDEVUYU KAYDETME
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor, HastaTC, RandevuDurum, HastaSikayet) values (@r1,@r2,@r3,@r4,@r5,@r6,@r7)", bgl.baglanti());

                komutkaydet.Parameters.AddWithValue("@r1", maskedTextBox1.Text);
                komutkaydet.Parameters.AddWithValue("@r2", maskedTextBox2.Text);
                komutkaydet.Parameters.AddWithValue("@r3", comboBox1.Text);
                komutkaydet.Parameters.AddWithValue("@r4", comboBox2.Text);
                komutkaydet.Parameters.AddWithValue("@r7", richTextBox2.Text);

                // Eğer sekreter bir TC yazdıysa randevuyu o hastaya ata.
                if (maskedTextBox3.Text.Length > 10)
                {
                    komutkaydet.Parameters.AddWithValue("@r5", maskedTextBox3.Text); 
                    komutkaydet.Parameters.AddWithValue("@r6", true);
                }
                else
                {
                    komutkaydet.Parameters.AddWithValue("@r5", DBNull.Value);
                    komutkaydet.Parameters.AddWithValue("@r6", false);
                }

                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Randevu Başarıyla Oluşturuldu");

                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                richTextBox2.Text = "";

                // ID sayacını güncelle 
                BosIDGetir();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisPanel fr = new GirisPanel();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string bransAd = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar where DoktorBrans = @p1", bgl.baglanti());

            da.SelectCommand.Parameters.AddWithValue("@p1", bransAd);
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            dataGridView2.Columns["DoktorSifre"].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SekreterBransDuzenleme fr = new SekreterBransDuzenleme();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SekreterRandevuListesi fr = new SekreterRandevuListesi();
            fr.Show();
        }
    }
}
