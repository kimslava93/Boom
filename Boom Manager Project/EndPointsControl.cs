using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.HardwareConnectionDriver;

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
                        var ep = new Endpoint(device, (byte)console.endpoint_index);

                        while (true)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (!ep.On())
                                {
                                    Thread.Sleep(100);
                                }
                                else
                                {
                                    return true;
                                }
                            }
                            if (!ep.On())
                            {
                                DialogResult dr = MessageBox.Show(
                                    "Нет соединения! Нажмите Повторить чтобы попытатся снова.", "Ошибка", MessageBoxButtons.RetryCancel);
                                if (dr == DialogResult.Cancel)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return true;
                            }

                        }
                    }
                }
            }
            return false;
            //return true;
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
                        while (true)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (!ep.Off())
                                {
                                    Thread.Sleep(100);
                                }
                                else
                                {
                                    return true;
                                }
                            }
                            if (!ep.Off())
                            {
                                DialogResult dr = MessageBox.Show(
                                    "Нет соединения! Нажмите Повторить чтобы попытатся снова.", "Ошибка", MessageBoxButtons.RetryCancel);
                                if (dr == DialogResult.Cancel)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return true;
                            }

                        }
                       /* if (!ep.Off())
                        {
                            MessageBox.Show(
                                "No connection with device! Please try to reboot device or check the lan connection.");
                            return false;
                        }
                        return true;*/
                    }
                }
            }
            return false;
            //return true;
        }
    }
}
