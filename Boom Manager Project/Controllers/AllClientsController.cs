using System.Collections.Generic;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class AllClientsController
    {
        private static AllClientsController _allClientsController;

        public static AllClientsController AllClientsControllerInstance()
        {
            return _allClientsController ?? (_allClientsController = new AllClientsController());
        }

        public List<ClientMyClass> GetAllClients()
        {
            return DataBaseClass.Instancedb().GetAllClientsForEditing();
        }

        public void DeleteClient(string clientId)
        {
            if (!string.IsNullOrEmpty(clientId))
            {
                DataBaseClass.Instancedb().DeleteClient(clientId);
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            }
        }
    }
}
