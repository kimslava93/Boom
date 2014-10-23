using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Boom_Manager_Project.MyClasses;
using Novacode;

namespace Boom_Manager_Project
{
    class Options
    {
        public const string FileTypeLogin = "shifts_login";
        public const string FileTypeActionsLogs = "user_actions";
        public const string FileTypeErrorsLogs = "errors";
        public const string StaffTypeAdmnistrator = "Администратор";
        public const string StaffTypeOperator = "Оператор";
        public List<BonusPromoTimeTemplateMyClass> BonusTime = new List<BonusPromoTimeTemplateMyClass>(); 
        private static Options _opt;
        public static Options OptionsInstance()
        {
            return _opt ?? (_opt = new Options());
        }

        public string UsualClient = "0";

        public void TakeScreenShot()
        {
           var bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
           var graphics = Graphics.FromImage(bitmap);
           graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
//           bitmap.Save("C:\\Users\\user\\Desktop\\" + DateTime.Now.ToString("MMM-dd-HH-mm") + "_screenshot.jpeg", ImageFormat.Jpeg);
           bitmap.Save("ScreenShotLogs\\" + DateTime.Now.ToString("MMM-dd-HH-mm-ss") + "_screenshot.jpeg", ImageFormat.Jpeg);
        }

        public TimeSpan RoundTimeSpan(TimeSpan input)
        {
            if (input != new TimeSpan())
            {
                input = new RoundedTimeSpan(input.Ticks, 0).TimeSpan;
            }
            return input;
        }

        public bool FindSubString(string stringList, string stringToFind)
        {
            List<string> subStrings = stringList.Split(';').ToList();
            if (subStrings.Any(s => s.Equals(stringToFind)))
            {
                return true;
            }
            return false;
        }
        public List<string> SplitAllAtems(string stringList)
        {
            List<string> subStrings = stringList.Split(';').ToList();
            return subStrings;
        }
        public List<string> SplitStringToList(string stringList, string divider)
        {
            List<string> subStrings = Regex.Split(stringList,divider).ToList();
            return subStrings;
        }
//        public void TakeScreenShotLog(string nameOfFile)
//        {
//            var bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
//            var graphics = Graphics.FromImage(bitmap);
//            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
//            //           bitmap.Save("C:\\Users\\user\\Desktop\\" + DateTime.Now.ToString("MMM-dd-HH-mm") + "_screenshot.jpeg", ImageFormat.Jpeg);
//            bitmap.Save("ScreenShotLogs\\" + DateTime.Now.ToString("MMM-dd-HH-mm-ss") + "_" + nameOfFile + ".jpeg",
//                ImageFormat.Jpeg);
//        }
    }
}
