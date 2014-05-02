using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class ChangeShiftModel
    {
        public bool ToCloseForm()
        {
            var db = DataBaseClass.Instancedb();

            if (db.GetOpenedGlobalSession() != null)
            {
                return true;
            }
            return false;
        }
    }
}
