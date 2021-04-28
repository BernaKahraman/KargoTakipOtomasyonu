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

namespace kargo_takip_otomasyonu
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from PersonelBilgileri", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Güncelleme 
            SqlCommand komut = new SqlCommand("update PersonelBilgileri set PersonelAd=@p1 , PersonelSoyad=@p2, PersonelTelefon=@p3,  PersonelEposta=@p4, PersonelSehir=@p5, PersonelSifre=@p7 where PersonelKullaniciAdi=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", TxtEposta.Text);
            komut.Parameters.AddWithValue("@p5", TxtSehir.Text);
            komut.Parameters.AddWithValue("@p6", TxtKullaniniAdi.Text);
            komut.Parameters.AddWithValue("@p7", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi.");
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagride çift tıklayınca bilgiler textboxlara gelir 
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtEposta.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSehir.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtKullaniniAdi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from PersonelBilgileri where PersonelKullaniciAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniniAdi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı Silindi.");
        }
    }
}
