using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class AddNewDeviceController
    {
        private static AddNewDeviceController _addNewDeviceController;

        public static AddNewDeviceController AddNewSessionControllerInstance()
        {
            return _addNewDeviceController ?? (_addNewDeviceController = new AddNewDeviceController());
        }

        private string CheckIpAddress(string inputIp)
        {
            if (inputIp.Contains(" "))
                inputIp = inputIp.Replace(" ", "");
            IPAddress ipAddress;
            return IPAddress.TryParse(inputIp, out ipAddress) ? ipAddress.ToString() : null;
        }

        public void AddNewDevice(int deviceId, string ipAddress)
        {
            if (CheckIpAddress(ipAddress) == null)
            {
                MessageBox.Show("Wrong IP address!");
            }
            else
            {
                ipAddress = CheckIpAddress(ipAddress);
                MessageBox.Show(ipAddress);
                var allDevices = DataBaseClass.Instancedb().GetAllDevices();
                if (allDevices != null)
                {
                    var matchedId = (from d in allDevices
                        where d.device_id == deviceId
                        select d).SingleOrDefault();
                    var matchedIpAddress = (from d in allDevices
                        where d.ip_address == ipAddress
                        select d).SingleOrDefault();
                    if (matchedId == null && matchedIpAddress == null)
                    {
                        DataBaseClass.Instancedb().AddNewDevice(deviceId, ipAddress);
                    }
                    else
                    {
                        MessageBox.Show("There is already one device with such name or ip address. Choose another one.");
                    }
                }
                else
                {
                    DataBaseClass.Instancedb().AddNewDevice(deviceId, ipAddress);
                }
               
            }
        }
    }
}
