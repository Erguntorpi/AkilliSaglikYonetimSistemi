namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void btnHastaGirisi_Click(object sender, EventArgs e)
        {
            FrmHastaGiriþ frm = new FrmHastaGiriþ();
            frm.Show();
            this.Hide();
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGýrýs frm = new FrmDoktorGýrýs();
            frm.Show();
            this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm = new FrmSekreterGiris();
            frm.Show();
            this.Hide();
        }

        private void btnCýkýs_Click(object sender, EventArgs e)
        {
            FrmHastanePanel frm = new FrmHastanePanel();
            frm.Show();
            this.Hide();
        }
    }
}
