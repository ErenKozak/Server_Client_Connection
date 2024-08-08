using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TcpServerClientApp
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnConnectClient_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 8080;

                client = new TcpClient();
                client.Connect(ipAddress, port);
                stream = client.GetStream();

                lblClientStatus.Text = "Server'a bağlanıldı.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSendClientMessage_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                try
                {
                    string message = "Mesaj alındı";
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    lblClientStatus.Text = "Mesaj gönderildi: " + message;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sunucuya bağlı değil.");
            }
        }

        private void btnDisconnectClient_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                try
                {
                    stream.Close();
                    client.Close();

                    lblClientStatus.Text = "Bağlantı kesildi.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sunucuya bağlı değil.");
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
