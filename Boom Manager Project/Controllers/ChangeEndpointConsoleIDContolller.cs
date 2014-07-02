using System.Collections.Generic;
using System.Linq;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class ChangeEndpointConsoleIdContolller
    {
        private static ChangeEndpointConsoleIdContolller _changeEndpointConsoleIdContolller;

        public static ChangeEndpointConsoleIdContolller EndPointsManagerContolllerInstance()
        {
            return _changeEndpointConsoleIdContolller ?? (_changeEndpointConsoleIdContolller = new ChangeEndpointConsoleIdContolller());
        }

        public List<DevicesEndPointsMyClass> GetAllEndPoints(int deviceId)
        {
            return DataBaseClass.Instancedb().GetAllEndPointsIndexes(deviceId);
        }
        public List<tables_t> GetConsolesList()
        {
            return DataBaseClass.Instancedb().GetAllTables();
        }
        public List<int> GetAllDevicesIndexes()
        {
            List<devices_t> devices = DataBaseClass.Instancedb().GetAllDevices();
            return (from d in devices
                select new
                {
                    d.device_id
                }).Select(a => a.device_id).ToList();
        }

        public void ChangePlaystationForEndPoint(int endpointId, string newPlaystation, int deviceId)
        {
            DataBaseClass.Instancedb().ChangeEndPointConsoleId(endpointId, newPlaystation, deviceId);
        }
    }
}
