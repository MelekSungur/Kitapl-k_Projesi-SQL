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

namespace Kitaplık_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string durum = " ";
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-D0LP1EG;Initial Catalog=Kitaplık;Integrated Security=True");
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaydet = new SqlCommand("insert into Tbl_Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            kaydet.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            kaydet.Parameters.AddWithValue("@p2",TxtYazar.Text);
            kaydet.Parameters.AddWithValue("@p3", CmbTur.Text);
            kaydet.Parameters.AddWithValue("@p4", TxtSayfa.Text);
            kaydet.Parameters.AddWithValue("@p5", durum);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Oluşturuldu", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Radiobtnsifir_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void Radiobttnikinciel_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
           
            TxtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbTur.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                Radiobtnsifir.Checked = true;
            }
            else
            {
                Radiobttnikinciel.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil =new SqlCommand("Delete From Tbl_Kitaplar where Kitapid=@k1", baglanti);
            sil.Parameters.AddWithValue("@k1", TxtKitapid.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Guncelle = new SqlCommand("Update Tbl_Kitaplar set Kitapad=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 where Kitapid=@p6", baglanti);
            Guncelle.Parameters.AddWithValue("p1", TxtKitapAd.Text);
            Guncelle.Parameters.AddWithValue("@p2", TxtSayfa.Text);
            Guncelle.Parameters.AddWithValue("@p3", CmbTur.Text);
            Guncelle.Parameters.AddWithValue("@p4", TxtSayfa.Text);
            if (Radiobtnsifir.Checked==true)
            {
                Guncelle.Parameters.AddWithValue("@p5", durum);
            }
            Guncelle.Parameters.AddWithValue("@p6", TxtKitapid.Text);
            Guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand bul = new SqlCommand("Select * From Tbl_Kitaplar where KitapAd=@p1", baglanti);
            bul.Parameters.AddWithValue("@p1", TxtKitapbul.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listele();
        }

        private void BtnHarfAra_Click(object sender, EventArgs e)
        {
            SqlCommand bul = new SqlCommand("Select * From Tbl_Kitaplar where KitapAd like '%"+TxtKitapHarfAra.Text+"%'", baglanti);
            bul.Parameters.AddWithValue("@p1", TxtKitapbul.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
