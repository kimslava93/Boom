using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Models
{
    class ModelPersonalInfo
    {
        public personal_info_t GetUserInfo(string login)
        {
            var db = new DataBaseClass();
            personal_info_t userInfo = db.GetUserInfoByLogin(login);
            if (userInfo != null)
            {
                return db.GetUserInfoByLogin(login);
            }
            return null;
        }

        public void CreateNewUser(personal_info_t newUserInfo)
        {
            var db = new DataBaseClass();
            db.AddNewStaffUser(newUserInfo);
        }
    }
}
