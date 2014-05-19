using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace LINQ_test.Driver
{
    public class Device
    {

        public int serial;
        public IPAddress ip;

        private readonly byte[] _key =
        {
            0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD,
            0xEF
        };

        private readonly byte[] _checksumkey =
        {
            0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB,
            0xCD, 0xEF
        };


        public Device(IPAddress ip_addr)
        {
            serial = 0;
            ip = ip_addr;
            if (devices == null) devices = new List<Device>();
            devices.Add(this);
        }

        static List<Device> devices;


        public static void packet_received(IPEndPoint source, byte[] data)
        {
            if (devices == null | devices.Count == 0)
            {
                throw (new Exception("No devices initialized!"));
            }
            foreach (Device d in devices)
            {
                if (d.ip.Equals(source.Address))
                {
                    d.received(source, data);
                }
            }
        }

        void received(IPEndPoint source, byte[] enc_data)
        {
            byte[] old = new byte[16];            
            byte[] data = new byte[16];
            Array.Copy(enc_data,16,old,0,16);
            Array.Copy(enc_data,0,data,0,16);
            byte[] checksum = Crypto.Decrypt(old, _checksumkey);
            if (!Enumerable.SequenceEqual(checksum, data))
            {
                throw new Exception("Wrong Checksum!");
            }
            process_packet(Crypto.Decrypt(data, _key));
            
        }

        public void process_packet(byte[] data)
        {

        }

        public bool send_packet(byte[] data)
        {
            byte[] enc_data = new byte[32];
            byte[] tmp_data = Crypto.Encrypt(data, _key);
            Array.Copy(tmp_data, 0, enc_data, 0, 16);
            byte[] checksum = Crypto.Encrypt(tmp_data, _checksumkey);
            Array.Copy(checksum, 0, enc_data, 16, 16);
            return UDPDriver.Instance.Send(ip, enc_data);
        }

        public override string ToString()
        {
            return serial.ToString();
        }
        
    }
}
