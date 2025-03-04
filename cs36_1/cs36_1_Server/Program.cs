using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main()
    {
        int port = 12345;
        TcpListener server = new TcpListener(IPAddress.Any, port);
        server.Start();
        Console.WriteLine($"Сервер запущено на порті {port}...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
            Console.WriteLine($"О {DateTime.Now:HH:mm} від [{clientIP}] отримано рядок: {receivedMessage}");

            string responseMessage = "Привіт, клієнте!";
            byte[] responseBytes = Encoding.UTF8.GetBytes(responseMessage);
            stream.Write(responseBytes, 0, responseBytes.Length);

            client.Close();
        }
    }
}   
