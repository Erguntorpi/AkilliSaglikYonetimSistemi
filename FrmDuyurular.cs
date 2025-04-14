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

namespace Proje_Hastane
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_duyurular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            // Eğer Duyurular Formu, Doktor Detay Formu'ndan açıldıysa
            if (this.Owner is FrmDoktorDetay)
            {
                this.Close(); // Duyurular formunu kapatıyoruz
                FrmDoktorDetay frmDoktor = (FrmDoktorDetay)this.Owner;
                frmDoktor.Show(); // Doktor detay formunu açıyoruz
            }
            // Eğer Duyurular Formu, Sekreter Detay Formu'ndan açıldıysa
            else if (this.Owner is FrmSekreterDetay)
            {
                this.Close(); // Duyurular formunu kapatıyoruz
                FrmSekreterDetay frmSekreter = (FrmSekreterDetay)this.Owner;
                frmSekreter.Show(); // Sekreter detay formunu açıyoruz
            }
            else
            {
                this.Close(); // Diğer durumlarda sadece Duyurular formunu kapatıyoruz
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
