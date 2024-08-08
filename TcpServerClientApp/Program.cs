using System;
using System.Windows.Forms;

namespace TcpServerClientApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServerForm serverForm = new ServerForm();
            ClientForm clientForm = new ClientForm();

            serverForm.Show();
            clientForm.Show();

            Application.Run();
        }
    }
}
