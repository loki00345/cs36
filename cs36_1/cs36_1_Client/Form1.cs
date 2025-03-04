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
            string serverIP = "127.0.0.1"; // ��������� ������
            int port = 12345;

            try
            {
                // ϳ��������� �� �������
                TcpClient client = new TcpClient(serverIP, port);
                NetworkStream stream = client.GetStream();

                // ���������� ����������� �������
                string message = "�����, �������!";
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // ��������� ������ �� �������
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string responseMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // ³���������� ������ � ���
                string serverIPReceived = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                lblResponse.Text = $"� {DateTime.Now:HH:mm} �� [{serverIPReceived}] �������� �����: {responseMessage}";

                // �������� ����������
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�������: {ex.Message}");
            }
        }
    }
}