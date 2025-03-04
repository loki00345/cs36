using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace c36_2_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            SendRequest("time");
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            SendRequest("date");
        }

        private void SendRequest(string request)
        {
            string serverIp = "127.0.0.1";
            int port = 12345;

            try
            {
                using (TcpClient client = new TcpClient(serverIp, port))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] requestBytes = Encoding.UTF8.GetBytes(request);
                    stream.Write(requestBytes, 0, requestBytes.Length);

                    byte[] buffer = new byte[256];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    lblResponse.Text = $"Відповідь від сервера: {response}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
