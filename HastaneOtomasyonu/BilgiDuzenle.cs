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
    public partial class BilgiDuzenle : Form
    {
        public BilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = TCno;
            maskedTextBox1.Enabled = false;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                textBox3.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void hesap_olustur_button_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4 where HastaTC=@p5", bgl.baglanti());

            komut2.Parameters.AddWithValue("@p1", textBox1.Text);
            komut2.Parameters.AddWithValue("@p2", textBox2.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBox2.Text);
            komut2.Parameters.AddWithValue("@p4", textBox3.Text);
            komut2.Parameters.AddWithValue("@p5", maskedTextBox1.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisPanel fr = new GirisPanel();
            fr.Show();
            this.Hide();
        }
    }
}
