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
    public partial class FrmKullaniciGirisi : Form
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From PersonelBilgileri where PersonelKullaniciAdi=@p1 and PersonelSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", PersonelSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Giris fr = new Giris(); // fr adında değişken türettim aç gizle yaptırdım 
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            bgl.baglanti().Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPersonelKayit fr = new FrmPersonelKayit();
            fr.Show();
        }
    }
}
