﻿
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mime;
using System.Windows.Forms;

namespace Boom_Manager_Project
{
    class Options
    {
        public const string FileTypeLogin = "shifts_login";
        public const string FileTypeActionsLogs = "user_actions";
        public const string FileTypeErrorsLogs = "errors";
        public const string StaffTypeAdmnistrator = "Администратор";
        public const string StaffTypeOperator = "Оператор";
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
           bitmap.Save("C:\\Users\\user\\Desktop\\" + DateTime.Now.ToString("MMM-dd-HH-mm") + "_screenshot.jpeg", ImageFormat.Jpeg);
        }
    }
}
