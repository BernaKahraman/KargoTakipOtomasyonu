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
    public partial class FrmKargoEkle : Form
    {
        public FrmKargoEkle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into KargoEkle (GTCNo, GAdi, GSoyadi, GTelefon, GSehir, GTarih, GAdres, ATCNo, AAdi, ASoyadi, ATelefon, ASehir, AAdres, ANot, KargoNo, Urun, Adet, Agirlik, TeslimTuru) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18, @p19)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskGTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtGAdı.Text);
            komut.Parameters.AddWithValue("@p3", TxtGSoyadı.Text);
            komut.Parameters.AddWithValue("@p4", MskGTelefon.Text);
            komut.Parameters.AddWithValue("@p5", CmbGSehir.Text);
            komut.Parameters.AddWithValue("@p6", MskGTarih.Text);
            komut.Parameters.AddWithValue("@p7", RchGAdres.Text);
            komut.Parameters.AddWithValue("@p8", MskATC.Text);
            komut.Parameters.AddWithValue("@p9", TxtAAdi.Text);
            komut.Parameters.AddWithValue("@p10", TxtASoyadi.Text);
            komut.Parameters.AddWithValue("@p11", MskATelefon.Text);
            komut.Parameters.AddWithValue("@p12", CmbASehir.Text);
            komut.Parameters.AddWithValue("@p13", RchAAdres.Text);
            komut.Parameters.AddWithValue("@p14", RchANot.Text);
            komut.Parameters.AddWithValue("@p15", MskKargoNo.Text);
            komut.Parameters.AddWithValue("@p16", CmbUrun.Text);
            komut.Parameters.AddWithValue("@p17", TxtAdet.Text);
            komut.Parameters.AddWithValue("@p18", TxtAgirlik.Text);
            komut.Parameters.AddWithValue("@p19", CmbTeslimTuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kargo kaydı gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update KargoEkle set GTCNo=@p1, GAdi=@p2, GSoyadi=@p3, GTelefon=@p4, GSehir=@p5, GTarih=@p6, GAdres=@p7, ATCNo=@p8, AAdi=@p9, ASoyadi=@p10, ATelefon=@p11, ASehir=@p12, AAdres=@p13, ANot=@p14, KargoNo=@p15, Urun=@p16, Adet=@p17, Agirlik=@p18, TeslimTuru@p19", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskGTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtGAdı.Text);
            komut.Parameters.AddWithValue("@p3", TxtGSoyadı.Text);
            komut.Parameters.AddWithValue("@p4", MskGTelefon.Text);
            komut.Parameters.AddWithValue("@p5", CmbGSehir.Text);
            komut.Parameters.AddWithValue("@p6", MskGTarih.Text);
            komut.Parameters.AddWithValue("@p7", RchGAdres.Text);
            komut.Parameters.AddWithValue("@p8", MskATC.Text);
            komut.Parameters.AddWithValue("@p9", TxtAAdi.Text);
            komut.Parameters.AddWithValue("@p10", TxtASoyadi.Text);
            komut.Parameters.AddWithValue("@p11", MskATelefon.Text);
            komut.Parameters.AddWithValue("@p12", CmbASehir.Text);
            komut.Parameters.AddWithValue("@p13", RchAAdres.Text);
            komut.Parameters.AddWithValue("@p14", RchANot.Text);
            komut.Parameters.AddWithValue("@p15", MskKargoNo.Text);
            komut.Parameters.AddWithValue("@p16", CmbUrun.Text);
            komut.Parameters.AddWithValue("@p17", TxtAdet.Text);
            komut.Parameters.AddWithValue("@p18", TxtAgirlik.Text);
            komut.Parameters.AddWithValue("@p19", CmbTeslimTuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
