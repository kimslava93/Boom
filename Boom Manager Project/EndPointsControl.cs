using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using LINQ_test.Driver;

namespace Boom_Manager_Project
{
    class EndPointsControl
    {
        private static EndPointsControl _endPointsControl;

        public static EndPointsControl EndPointsControlInstance()
        {
            return _endPointsControl ?? (_endPointsControl = new EndPointsControl());
        }

        public bool SwitchOn(string consoleId)
        {
            if (!String.IsNullOrWhiteSpace(consoleId))
            {
                List<device_endpoints_t> allEndPoints = DataBaseClass.Instancedb().GetAllEndPoints();
                var console = (from c in allEndPoints
                    where c.playstation_id == consoleId
                    select c).SingleOrDefault();
                List<devices_t> allDevices = DataBaseClass.Instancedb().GetAllDevices();
                string iPaddress = (from i in allDevices
                    where console != null && i.device_id == console.device_id
                    select i.ip_address).SingleOrDefault();
                if (iPaddress != null)
                {
                    var device = new Device(IPAddress.Parse(iPaddress));
                    if (console != null)
                    {
                        var ep = new Endpoint(device, (byte) console.endpoint_index);
                        if (!ep.On())
                        {
                            MessageBox.Show(
                                "No connection with device! Please try to reboot device or check the lan connection.");
                            return false;
                        }
                        return true;
                    }
                }
            }
            return false;
        }
        public bool SwitchOff(string consoleId)
        {
            if (!String.IsNullOrWhiteSpace(consoleId))
            {
                List<device_endpoints_t> allEndPoints = DataBaseClass.Instancedb().GetAllEndPoints();
                var console = (from c in allEndPoints
                               where c.playstation_id == consoleId
                               select c).SingleOrDefault();
                List<devices_t> allDevices = DataBaseClass.Instancedb().GetAllDevices();
                string iPaddress = (from i in allDevices
                                    where console != null && i.device_id == console.device_id
                                    select i.ip_address).SingleOrDefault();
                if (iPaddress != null)
                {
                    var device = new Device(IPAddress.Parse(iPaddress));
                    if (console != null)
                    {
                        var ep = new Endpoint(device, (byte)console.endpoint_index);
                        if (!ep.Off())
                        {
                            MessageBox.Show(
                                "No connection with device! Please try to reboot device or check the lan connection.");
                            return false;
                        }
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
