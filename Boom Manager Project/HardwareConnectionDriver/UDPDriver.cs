using System;
using System.Net;
using System.Net.Sockets;

namespace LINQ_test.Driver
{

    public delegate void OnPacketReceive(IPEndPoint source, byte[] data);

    public sealed class UDPDriver
    {
        private const int ListenPort = 11200;
        private const int SendPort = 11199;
        private static volatile UDPDriver _instance;
        private static readonly object SyncRoot = new Object();

        public static UDPDriver Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new UDPDriver();
                    }
                }

                return _instance;
            }
        }


        public void Init()
        {
              client = new UdpClient(SendPort);
              client.EnableBroadcast = true;
              dev = new IPEndPoint(IPAddress.Any, ListenPort);
              server = new UdpClient(dev);
              server.EnableBroadcast = true;
              server.Client.ReceiveTimeout = 100;
              packetReceived = Device.packet_received;

        }
        IPEndPoint dev;
        UdpClient server;
        UdpClient client;
      
        public OnPacketReceive packetReceived;
        
        public void Close()
        {

            client.Close();
            server.Close();
        }

        public Device DiscoverDevice(int timeout)
        {
            server.Client.ReceiveTimeout = timeout;
            byte[] response;
            try
            {
                response = server.Receive(ref dev);
            }
            catch (SocketException ex)
            {
                return null;
            }
            return new Device(dev.Address);
        }

        public bool Send(IPAddress address, byte[] data)
        {
            client.Connect(address, ListenPort);
                client.Send(data, data.Length);
                byte[] response;
                try
                {
                    response = server.Receive(ref dev);
                }
                catch (SocketException ex)
                {
                    return false;
                }
                packetReceived(dev, response);
                return true;
        }

        public void send_thread()
        {

        }


    }
}
