using System;
using System.Net.Sockets;
using System.Text;

public class Client {
    public static void Main() {
        TcpClient client = new TcpClient("127.0.0.1", 443);
        NetworkStream stream = client.GetStream();
        string message = "Hello from client!";
        byte[] data = Encoding.ASCII.GetBytes(message);
        stream.Write(data, 0, data.Length);
        Console.WriteLine("Sent: " + message);
        stream.Close();
        client.Close();
    }
}
