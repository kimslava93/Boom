using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class ChangeShiftController
    {
        public ChangeShiftController()
        {
            var changeShiftModel = new ChangeShiftModel();
        }

        public string WarningMessage(string type)
        {
            if (type == "WarningLabel")
            {
                return "Please input login and password to accept shift.\n" +
                       "By loging in you accept shift as it is, \nand take all responsibility for equipment itself";
            }
            if (type == "FirstShift")
            {
                return "Your shift is the first and there is no opened one.\nYou should login to continue!";
            }
            if (type == "CloseOldSession")
            {
                return "You should close all old sessions!";
            }
            return "";
        }

        public void ShouldNewShiftBeCreated(string login, string password)
        {
            if (CheckPassword(login, password))
            {
                CreateNewShift(login);
            }
            else
            {
                MessageBox.Show("Login or Password is wrong!");
            }
        }

        private bool CheckPassword(string login, string password)
        {
            var db = new DataBaseClass();
            personal_info_t adminLogin = db.GetUserInfoByLogin(login);
            if (adminLogin != null)
            {
                if (adminLogin.staff_password == password)
                {
                    return true;
                }
            }
            return false;
        }
        private void CreateNewShift(string login)
        {
            var db = DataBaseClass.Instancedb();

            var adminInfo = db.GetUserInfoByLogin(login);

            var lastOpenedSession = db.GetOpenedSession();
            if (lastOpenedSession != null)
            {
                MessageBox.Show(WarningMessage("CloseOldSession"),
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (adminInfo != null)
                {
                    db.AddNewGlobalSession(adminInfo.person_id, "no operator", DateTime.Now);
                }
            }
        }
        public bool ToCloseForm()
        {
            var cs = new ChangeShiftModel();
            return cs.ToCloseForm();
        }
    }
}
