using System;
using System.Windows.Forms;

namespace Market
{
    public partial class SatOrIade : Form
    {
        public SatOrIade()
        {
            InitializeComponent();
        }
        AnaMenu menu = new AnaMenu();
        private void btnSat_Click(object sender, EventArgs e)
        {
            menu.Hide();
            Satis satis = new Satis();
            satis.Show();
            this.Close();


        }

        private void btnİade_Click(object sender, EventArgs e)
        {
            menu.Hide();
            if (Hesap.nickname!="admin")
            {
                ardinuoIade ardinuoIade = new ardinuoIade();
                ardinuoIade.Show();
            }
            else
            {
                Iade ıade = new Iade();
                ıade.Show();
            }
            this.Close();
            //menu.Hide();

            //this.Close();
        }

        private void SatOrIade_Load(object sender, EventArgs e)
        {

        }
    }
}
