using System.Net;
using Boom_Manager_Project.HardwareConnectionDriver;

namespace Boom_Manager_Project
{
    internal class CheckConnectionWithDevices
    {
        public void Check()
        {
            //var d = new Device(IPAddress.Parse("192.168.1.230"));
            var devices = DataBaseClasses.DataBaseClass.Instancedb().GetAllDevices();
            foreach (var device in devices)
            {
                var d = new Device(IPAddress.Parse(device.ip_address));
                byte[] dat = {0, 0};
                d.send_packet(dat);
            }
            
        }
    }
}
