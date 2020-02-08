using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Sim900Gorsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        void bağlanToolStripMenuItem_Click(object sender, EventArgs e)
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
        void portListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxEx1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            string[] array = ports;
            for (int i = 0; i < array.Length; i++)
            {
                comboBoxEx1.Items.Add(array[i].ToString());
            }
        }
        void bağlantıyıKesToolStripMenuItem_Click(object sender, EventArgs e)
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
        void komutYollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kmtmrkz.th = new Thread(simi); kmtmrkz.th.Start();
        }
        void simi()
        {
            richTextBox1.AppendText(kmtmrkz.bekracommand(textBoxX1.Text));
        }
        void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBoxEx1.SelectedItem.ToString();
        }
    }

  
}
