using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Sim900Gorsel
{
    public partial class veriokuma : Form
    {
        public veriokuma()
        {
            InitializeComponent();
        }
        private void veriOkumayaBaşlaToolStripMenuItem_Click(object sender, EventArgs e)
        {

           kmtmrkz.sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
        }
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //ReadExisting() fonksiyonu ile String olarak okuyoruz;
            string veri1 = kmtmrkz.sp.ReadExisting();
            richTextBox1.AppendText(veri1+"\r");

            //ReadLine() fonksiyonu ile yine Strig türünde satır satır okuyoruz;
            string veri2 = kmtmrkz.sp.ReadLine();
            richTextBox1.AppendText(veri2 + "\r");

            //Read() fonksiyonu ile Byte dizisi olarak okuyoruz.
            byte[] veri3 = new byte[kmtmrkz.sp.ReadBufferSize];
            kmtmrkz.sp.Read(veri3, 0, kmtmrkz.sp.ReadBufferSize);
        }
        private void portListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxEx1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            string[] array = ports;
            for (int i = 0; i < array.Length; i++)
            {
                comboBoxEx1.Items.Add(array[i].ToString());
            }
        }

        private void bağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kmtmrkz.th = new Thread(baglanaloo); kmtmrkz.th.Start();
        }
        void baglanaloo()
        {
            if (kmtmrkz.sp.IsOpen)
            {
                MessageBox.Show("Port Zaten Açık!");
            }
            else
            {
                try
                {
                    kmtmrkz.sp.BaudRate = int.Parse("33600"); //9600
                    kmtmrkz.sp.DataBits = int.Parse("8");
                    kmtmrkz.sp.StopBits = StopBits.One;
                    kmtmrkz.sp.Parity = Parity.None;
                    kmtmrkz.sp.PortName = textBox1.Text;
                    kmtmrkz.sp.Open();
                    label3.Text = "Bağlantı Başlatıldı.";
                    Form.ActiveForm.Show();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
            }
        }

        private void bağlantıyıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                kmtmrkz.sp.Close();
                label3.Text = "Bağlantı Kapatıldı.";
            }
            catch (Exception exim)
            {
                MessageBox.Show(exim.ToString());
            }
        }
    }
}
