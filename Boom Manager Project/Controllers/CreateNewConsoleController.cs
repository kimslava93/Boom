using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class CreateNewConsoleController
    {
        private static CreateNewConsoleController _createNewConsoleController;

        public static CreateNewConsoleController CreateNewConsoleControllerIstance()
        {
            return _createNewConsoleController ?? (_createNewConsoleController = new CreateNewConsoleController());
        }

        public bool CheckNameOfConsoleOnRepeat(string consoleName)
        {
            if (!String.IsNullOrEmpty(consoleName))
            {
                if (DataBaseClass.Instancedb().GetAllTables().Any(console => console.playstation_id.Equals(consoleName)))
                {
                    MessageBox.Show(
                        "This name is unavailable, because it already exists!/nPlease choose another one.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Enter the name of console. For example: PS4.");
                return false;
            }
            return true;
        }

        public void CallChangePrice(string consoleToChangePrice, string timeZoneName)
        {
            var consolesToChange = new List<string> {consoleToChangePrice};
            var cpp = new ChangePlaystationPrice(consolesToChange, timeZoneName);
            cpp.ShowDialog();
        }
    }
}
