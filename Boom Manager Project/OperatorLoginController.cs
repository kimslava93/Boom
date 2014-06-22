using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class OperatorLoginController
    {
        private static OperatorLoginController _operatorLoginController;

        public static OperatorLoginController OperatorLoginControllerInstance()
        {
            return _operatorLoginController ?? (_operatorLoginController = new OperatorLoginController());
        }
        public bool CheckPassword(string login, string password)
        {
            personal_info_t operatorLogin = DataBaseClass.Instancedb().GetUserInfoByLogin(login);
            if (operatorLogin != null)
            {
                if (operatorLogin.staff_password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public void LoginOperator(string login)
        {
            DataBaseClass.Instancedb().LoginOperatorToLastOpenedSession(login);
        }
    }
}
