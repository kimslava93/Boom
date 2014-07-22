using System;
using System.IO;

namespace Boom_Manager_Project
{
    class TextFileWriter
    {
        private static TextFileWriter _textFileWriter;

        public static TextFileWriter TextFileWriterInstance()
        {
            return _textFileWriter ?? (_textFileWriter = new TextFileWriter());
        }

        public void RecordLoginTime(string userName,string prevUserName, string typeOfStaff)
        {
            AddSomeDataToLogReport(
                typeOfStaff +
                " " + userName + " был залогинен.(принял смену у " + prevUserName + ")", Options.FileTypeLogin);
        }

        public void AddSomeDataToLogReport(string dataToAdd,string reportType)
        {
            var fileName = "Logs\\" + reportType + "_" + DateTime.Now.ToShortDateString() + "_.log";
            if (reportType == Options.FileTypeActionsLogs)
            {
                fileName = "Logs\\" + reportType + "_" + DateTime.Now.ToShortDateString() + "_.log";
            }
            else if (reportType == Options.FileTypeLogin)
            {
                fileName = "Logs\\" + reportType + "_.log";
            }
            else if (reportType == Options.FileTypeErrorsLogs)
            {
                fileName = "Logs\\" + reportType + "_" + DateTime.Now.ToShortDateString() + "_.log";
            }

            try
            {
                if (File.Exists(fileName))
                {
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine(DateTime.Now.ToShortDateString() + " " +DateTime.Now.ToShortTimeString() + ":      " + dataToAdd);
                    }
                }
                else
                {
                    // Create a new file 
                    using (var sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine("New file created: {0}", DateTime.Now);
                        sw.WriteLine("Author: Kim Viacheslav");
                        sw.WriteLine();
                        sw.WriteLine(dataToAdd);
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
