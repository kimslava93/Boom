using System;
using System.Threading;
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
//            if (EndPointsControl.EndPointsControlInstance().SwitchOn(newPlaystation) &&
//                EndPointsControl.EndPointsControlInstance().SwitchOff(sessionToReplace.Приставка))
            if (ChangePlst(newPlaystation, sessionToReplace.Приставка))
            {
                DataBaseClass.Instancedb().ChangePlaystation(sessionToReplace, newPlaystation, comments);
            }
        }

        private bool ChangePlst(string newPlst, string oldPlst)
        {
            int tries = 10;
            while (true)
            {
                try
                {
                    EndPointsControl.EndPointsControlInstance().SwitchOn(newPlst);
                    EndPointsControl.EndPointsControlInstance().SwitchOff(oldPlst);
                    return true;
                }
                catch (Exception)
                {
                    tries--;
                    if (tries <= 0)
                    {
                        return false;
                    }
                    Thread.Sleep(500);
                }
            }
        }

    }
}
