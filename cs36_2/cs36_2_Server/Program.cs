﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main()
    {
        int port = 12345;
        TcpListener listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        Console.WriteLine($"Сервер запущено на порту {port}");

        while (true)
        {
            using (TcpClient client = listener.AcceptTcpClient())
            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                string response = request.ToLower() == "time"
                    ? DateTime.Now.ToLongTimeString()
                    : request == "date"
                        ? DateTime.Now.ToLongDateString()
                        : "Невідомий запит";


                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);

                Console.WriteLine($"Відповідь надіслано: {response}");
            }
        }
    }
}
