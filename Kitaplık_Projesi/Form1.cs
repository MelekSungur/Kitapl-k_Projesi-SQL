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
    }
}
