using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class ManagerCardReaderController
    {
        private static ManagerCardReaderController _managerCardReaderController;

        public static ManagerCardReaderController ManagerCardReaderControllerInstance()
        {
            return _managerCardReaderController ?? (_managerCardReaderController = new ManagerCardReaderController());
        }

        public personal_info_t GetManagerById(string id)
        {
            return DataBaseClass.Instancedb().GetUserInfoByPersonID(id);
        }
    }
}
