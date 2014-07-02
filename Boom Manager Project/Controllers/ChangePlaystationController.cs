using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class ChangePlaystationController
    {
        private static ChangePlaystationController _changePlaystationController;

        public static ChangePlaystationController ChangePlaystationControllerInstance()
        {
            return _changePlaystationController ?? (_changePlaystationController = new ChangePlaystationController());
        }

        public void ReplaceClient(DaySessionClass sessionToReplace, string newPlaystation, string comments)
        {
            if (EndPointsControl.EndPointsControlInstance().SwitchOn(newPlaystation) &&
                EndPointsControl.EndPointsControlInstance().SwitchOff(sessionToReplace.Приставка))
            {
                DataBaseClass.Instancedb().ChangePlaystation(sessionToReplace, newPlaystation, comments);
            }
        }
    }
}
