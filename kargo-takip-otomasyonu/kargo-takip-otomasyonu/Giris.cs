using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargo_takip_otomasyonu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKargoEkle fr = new FrmKargoEkle();
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKargoListele fr = new FrmKargoListele();
            fr.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKargoSorgula fr = new FrmKargoSorgula();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPersonelListesi fr = new FrmPersonelListesi();
            fr.Show();
        }
    }
}
