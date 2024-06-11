using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PTZManager.Workers;

public class UDPSender
{
    private const int PORT = 1289;
    private string Ip { get; set; }
    
    
    public UDPSender(string pip)
    {
        this.Ip = pip;
    }

    public bool send(string pmessage)
    {
        using (UdpClient udpClient = new UdpClient())
        {
            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(this.Ip), PORT);
                byte[] messageBytes = Encoding.UTF8.GetBytes(pmessage);
                udpClient.Send(messageBytes, messageBytes.Length, remoteEndPoint);
                Console.WriteLine($"Message sent to {this.Ip}:{PORT}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
        
    }
    
    
    
}