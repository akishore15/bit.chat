using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Server {
    public static void Main() {
        TcpListener server = new TcpListener(IPAddress.Any, 443);
        server.Start();
        Console.WriteLine("Server started on port 443...");

        while (true) {
            TcpClient client = server.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received: " + message);
            stream.Close();
            client.Close();
        }
    }
}
