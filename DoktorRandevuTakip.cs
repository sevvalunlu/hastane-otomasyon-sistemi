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
    public partial class DoktorRandevuTakip : Form
    {
        public DoktorRandevuTakip()
        {
            InitializeComponent();
        }

        public string TC;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisPanel fr = new GirisPanel();
            fr.Show();
            this.Hide();
        }

        private void DoktorRandevuTakip_Load(object sender, EventArgs e)
        {
            labeltc.Text = TC;

            // Randevuları listelemek için doktorun ad ve soyadını çek
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labeltc.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // DOKTORA AİT RANDEVULARI LİSTELE
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + labelad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns["HastaSikayet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenleme fr = new DoktorBilgiDuzenleme();
            fr.TCNO = labeltc.Text; // TC'yi diğer forma taşı
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }
    }
}
