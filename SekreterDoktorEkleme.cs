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
    public partial class SekreterDoktorEkleme : Form
    {
        public SekreterDoktorEkleme()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void SekreterDoktorEkleme_Load(object sender, EventArgs e)
        {
            // Doktorları datagrid e aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns["DoktorSifre"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", textBox1.Text);
            komut.Parameters.AddWithValue("@d2", textBox2.Text);
            komut.Parameters.AddWithValue("@d3", comboBox1.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@d5", textBox3.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // liste güncelleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // sekretertakip formundaki doktorlar listesini güncelleme
            SekreterTakip anaForm = (SekreterTakip)Application.OpenForms["SekreterTakip"];
            if (anaForm != null)
            {
                anaForm.DoktorlariYenile();
            }

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();      
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();   
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();   
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();      
            //textBox3.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();  // Şifre boş kalsın sekreter görüntüleyemesin.
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox3.Text = "";

            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisPanel fr = new GirisPanel();
            fr.Show();
            this.Hide();
        }

        //Kayıt Silme
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //Silme işleminden sonra listeyi güncelleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // sekretertakip formundaki doktorlar listesini güncelleme
            SekreterTakip anaForm = (SekreterTakip)Application.OpenForms["SekreterTakip"];
            if (anaForm != null)
            {
                anaForm.DoktorlariYenile(); // Yeni oluşturduğumuz metodu çağırıyoruz
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3 where DoktorTC=@d4", bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", textBox1.Text);
            komut.Parameters.AddWithValue("@d2", textBox2.Text);
            komut.Parameters.AddWithValue("@d3", comboBox1.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBox1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Doktor Bilgisi Güncellendi (Şifre Değişmedi)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Listeyi Yenileme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // sekretertakip formundaki doktorlar listesini güncelleme
            SekreterTakip anaForm = (SekreterTakip)Application.OpenForms["SekreterTakip"];
            if (anaForm != null)
            {
                anaForm.DoktorlariYenile();
            }
        }
    }
}
