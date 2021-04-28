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
    public partial class FrmKargoListele : Form
    {
        public FrmKargoListele()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmKargoListele_Load(object sender, EventArgs e)
        {
            // DataGride veri çekme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KargoEkle", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
