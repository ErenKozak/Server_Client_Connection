using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TcpServerClientApp
{
    public partial class ServerForm : Form
    {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 8080;

                listener = new TcpListener(ipAddress, port);
                listener.Start();

                lblServerStatus.Text = "Server başlatıldı. Bekleniyor...";

                listener.BeginAcceptTcpClient(new AsyncCallback(OnClientConnect), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void OnClientConnect(IAsyncResult ar)
        {
            try
            {
                client = listener.EndAcceptTcpClient(ar);
                stream = client.GetStream();

                this.Invoke((MethodInvoker)delegate
                {
                    lblServerStatus.Text = "Client bağlandı.";
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                try
                {
                    string message = "Server başladı";
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    lblServerStatus.Text = "Mesaj gönderildi: " + message;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("İstemci bağlanmadı.");
            }
        }

        private void btnDisconnectServer_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                stream.Close();
                client.Close();
                listener.Stop();

                lblServerStatus.Text = "Bağlantı kesildi.";
            }
            else
            {
                MessageBox.Show("Bağlantı yok.");
            }
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
