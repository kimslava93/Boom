using System.Collections.Generic;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class DeviceManagerContoller
    {
        private static DeviceManagerContoller _deviceManagerContoller;

        public static DeviceManagerContoller DeviceManagerContollerInstance()
        {
            return _deviceManagerContoller ?? (_deviceManagerContoller = new DeviceManagerContoller());
        }

        public List<devices_t> GetAllDevices()
        {
            return DataBaseClass.Instancedb().GetAllDevices();
        }
        public List<DevicesEndPointsMyClass> GetAllEndpoints(int deviceId)
        {
            return DataBaseClass.Instancedb().GetAllEndPointsIndexes(deviceId);
        }

        public void DeleteDevice(int deviceID)
        {
            DataBaseClass.Instancedb().DeleteDevice(deviceID);
        }
    }
}
