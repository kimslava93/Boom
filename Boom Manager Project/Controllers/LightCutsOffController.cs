using System.Collections.Generic;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class LightCutsOffController
    {
        private static LightCutsOffController _lightCutsOffController;

        public static LightCutsOffController LihtLightCutsOffController()
        {
            return _lightCutsOffController ?? (_lightCutsOffController = new LightCutsOffController());
        }

        public List<MyString> GetAllOpenedConsoles()
        {
            return DataBaseClass.Instancedb().GetOpenedConsolesWithSessionIds();
        }
    }
}
