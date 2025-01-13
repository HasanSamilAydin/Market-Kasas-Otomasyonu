using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Market
{
    public partial class ardinuoIade : Form
    {
        public ardinuoIade()
        {
            InitializeComponent();
        }

        private void ardinuoIade_Load(object sender, EventArgs e)
        {
            foreach (var port in ports)
            {
                cbPorts.Items.Add(port);
            }
            cbBantHizi.Items.Add("2400");
            cbBantHizi.Items.Add("4800");
            cbBantHizi.Items.Add("9600");
            cbBantHizi.Items.Add("19200");
            cbBantHizi.Items.Add("115200");
            cbPorts.SelectedIndex = 0;
            cbBantHizi.SelectedIndex = 2;
        }
        public static string portIsmi, bantHizi;
        string[] ports = SerialPort.GetPortNames();
        string kartID;

        private void tmOkuyucu_Tick(object sender, EventArgs e)
        {
            try
            {
                kartID = spArdunio.ReadExisting();

                if (kartID != "1")
                {
                    tmOkuyucu.Stop();
                    spArdunio.Close();
                    Iade ıade = new Iade();
                    ıade.Show();
                    this.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
            
        }
        private void ardinuoIade_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (spArdunio.IsOpen)
            {
                spArdunio.Close();
            }
        }
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                portIsmi = cbPorts.Text;
                bantHizi = cbBantHizi.Text;
                spArdunio.PortName = portIsmi;
                spArdunio.BaudRate = int.Parse(bantHizi);
                spArdunio.Open();
                MessageBox.Show("Bağlantı Sağlandı","BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tmOkuyucu.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Sağlanamadı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
