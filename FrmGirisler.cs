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
            FrmHastaGiri� frm = new FrmHastaGiri�();
            frm.Show();
            this.Hide();
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorG�r�s frm = new FrmDoktorG�r�s();
            frm.Show();
            this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm = new FrmSekreterGiris();
            frm.Show();
            this.Hide();
        }

        private void btnC�k�s_Click(object sender, EventArgs e)
        {
            FrmHastanePanel frm = new FrmHastanePanel();
            frm.Show();
            this.Hide();
        }
    }
}
