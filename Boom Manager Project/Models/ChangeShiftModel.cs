using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Models
{
    class ChangeShiftModel
    {
        private static ChangeShiftModel _changeShiftModel;

        public static ChangeShiftModel ChangeShiftModelInstance()
        {
            return _changeShiftModel ?? (_changeShiftModel = new ChangeShiftModel());
        }

        public bool ToCloseForm()
        {
            if(DataBaseClass.Instancedb().GetOpenedGlobalSession() != null)
            {
                return true;
            }
            return false;
        }
    }
}
