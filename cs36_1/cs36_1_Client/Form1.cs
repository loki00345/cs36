using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace cs36_1_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string serverIP = "127.0.0.1"; // Локальний сервер
            int port = 12345;

            try
            {
                // Підключення до сервера
                TcpClient client = new TcpClient(serverIP, port);
                NetworkStream stream = client.GetStream();

                // Надсилання повідомлення серверу
                string message = "Привіт, сервере!";
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Отримання відповіді від сервера
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string responseMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Відображення відповіді у вікні
                string serverIPReceived = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                lblResponse.Text = $"О {DateTime.Now:HH:mm} від [{serverIPReceived}] отримано рядок: {responseMessage}";

                // Закриття підключення
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}