using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boom_Manager_Project.HardwareConnectionDriver;

namespace Boom_Manager_Project
{
    class DevicesWithEndPoints
    {
        private Device _device;
        private List<Endpoint> _endpointsList; 
        public DevicesWithEndPoints(Device device, List<Endpoint> endpointsOfDevice)
        {
            _device = device;
            _endpointsList = endpointsOfDevice;
        }

    }
}
