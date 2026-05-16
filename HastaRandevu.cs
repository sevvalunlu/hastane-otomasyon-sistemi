using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastaneOtomasyonSistemi
{
    public partial class HastaRandevu : Form
    {
        public HastaRandevu()
        {
            InitializeComponent();
        }

        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            // Randevu için saat ve tarih çakışma kontrolü
            SqlCommand komutKontrol = new SqlCommand("Select * From Tbl_Randevular where RandevuBrans=@p1 and RandevuDoktor=@p2 and RandevuTarih=@p3 and RandevuSaat=@p4 and RandevuDurum=1", bgl.baglanti());

            komutKontrol.Parameters.AddWithValue("@p1", comboBox1.Text);
            komutKontrol.Parameters.AddWithValue("@p2", comboBox2.Text);

            komutKontrol.Parameters.AddWithValue("@p3", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
            komutKontrol.Parameters.AddWithValue("@p4", comboBox3.Text);

            SqlDataReader dr = komutKontrol.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Bu doktorun bu tarih ve saatteki randevusu doludur. Lütfen başka bir saat seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bgl.baglanti().Close();
            }
            else
            {
                // Eğer randevu yoksa burası çalışarak randevu alımını sağlar
                dr.Close();

                SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum,HastaTC,HastaSikayet) values (@r1,@r2,@r3,@r4,@r5,@r6,@r7)", bgl.baglanti());

                komutKaydet.Parameters.AddWithValue("@r1", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                komutKaydet.Parameters.AddWithValue("@r2", comboBox3.Text);
                komutKaydet.Parameters.AddWithValue("@r3", comboBox1.Text);
                komutKaydet.Parameters.AddWithValue("@r4", comboBox2.Text);
                komutKaydet.Parameters.AddWithValue("@r5", true); // Dolu
                komutKaydet.Parameters.AddWithValue("@r6", labeltc.Text);
                komutKaydet.Parameters.AddWithValue("@r7", richTextBox1.Text);

                komutKaydet.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Randevunuz başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Randevu geçmişi listelemesi yapılıyor
                DataTable dt1 = new DataTable();

                SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc + " and CONVERT(date, RandevuTarih, 104) < CAST(GETDATE() AS DATE)", bgl.baglanti());
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;


                // Aktif randevu listelemesi yapılıyor
                DataTable dt2 = new DataTable();

                SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc + " and CONVERT(date, RandevuTarih, 104) >= CAST(GETDATE() AS DATE)", bgl.baglanti());
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView2.AllowUserToAddRows = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisPanel fr = new GirisPanel();
            fr.Show();
            this.Hide();
        }

        private void HastaRandevu_Load(object sender, EventArgs e)
        {
            labeltc.Text = tc;

            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labeltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Branşları çekme 
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            // Randevu geçmişi listelemesi yapılıyor
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc + " and CONVERT(date, RandevuTarih, 104) < CAST(GETDATE() AS DATE) ORDER BY RandevuTarih DESC", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Aktif randevu listelemesi yapılıyor
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc + " and CONVERT(date, RandevuTarih, 104) >= CAST(GETDATE() AS DATE) ORDER BY RandevuTarih ASC", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns["HastaSikayet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.Columns["HastaSikayet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            SqlBaglantisi bgl = new SqlBaglantisi();

            // Seçilen branşın doktorlarını getirir
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", comboBox1.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0] + " " + dr[1]);
            }

            bgl.baglanti().Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiDuzenle fr = new BilgiDuzenle();
            fr.TCno = labeltc.Text;
            fr.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }    
    }
}
