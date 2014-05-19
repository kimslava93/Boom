using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;
using Novacode;
using Orientation = Novacode.Orientation;

namespace Boom_Manager_Project.Controllers
{
    internal class ShiftsManagerController
    {
        private static ShiftsManagerController _shiftsManagerController;

        public static ShiftsManagerController ShiftsControllerInstance()
        {
            return _shiftsManagerController ?? (_shiftsManagerController = new ShiftsManagerController());
        }

        public List<ShiftsMyClass> GetAllShifts()
        {
            return DataBaseClass.Instancedb().GetAllGlobalSessions(10);
        }

        public void GenerateWordReport(int dailyId)
        {
            List<DaySessionClass> allSessions = DataBaseClass.Instancedb().GetAllDaySessionsInShift(dailyId);
            global_session_t gs = DataBaseClass.Instancedb().GetGlobalSessionByDailyId(dailyId);
            string fileName = @"D:\" + gs.start_session.ToString("MMM-dd-HH-mm") + @".docx";

            var doc = DocX.Create(fileName);

            doc.InsertParagraph("Daily ID: " + dailyId);
            doc.InsertParagraph("Start date: " + gs.start_session);
            doc.InsertParagraph("End date: " + gs.end_session);
            doc.InsertParagraph("Administrator: " +
                                DataBaseClass.Instancedb().GetUserInfoByPersonID(gs.administrator_id).name);


            doc.InsertParagraph();
            doc.InsertTable(allSessions.Count + 1, 8);
            doc.PageLayout.Orientation = Orientation.Landscape;
            Table t = doc.Tables[0];
            t.AutoFit = AutoFit.Contents;
            t.Design = TableDesign.TableGrid;
            t.Rows[0].Cells[0].Paragraphs[0].InsertText("#");
            t.Rows[0].Cells[0].Width = 80;//"#".Length;
            t.Rows[0].Cells[1].Paragraphs[0].InsertText("Console ID");
//            t.Rows[0].Cells[1].Width = "Console ID".Length;
            t.Rows[0].Cells[2].Paragraphs[0].InsertText("Start time");
//            t.Rows[0].Cells[2].Width = "Start".Length;
            t.Rows[0].Cells[3].Paragraphs[0].InsertText("End time");
//            t.Rows[0].Cells[3].Width = "End".Length;
            t.Rows[0].Cells[4].Paragraphs[0].InsertText("Client ID");
            t.Rows[0].Cells[4].Width = 300;
            t.Rows[0].Cells[5].Paragraphs[0].InsertText("Money Left");
//            t.Rows[0].Cells[5].Width = "Money Left".Length;
            t.Rows[0].Cells[6].Paragraphs[0].InsertText("Discount sum");
//            t.Rows[0].Cells[6].Width = "Discount".Length;
            t.Rows[0].Cells[7].Paragraphs[0].InsertText("Paid sum");
//            t.Rows[0].Cells[7].Width = "Paid sum".Length;
            
            double playedSum = 0;
            double moneyLeftSum = 0;
            for (int row = 1; row < allSessions.Count; row++)
            {
                t.Rows[row].Cells[0].Paragraphs[0].InsertText(
                    allSessions[row - 1].SessionId.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[1].Paragraphs[0].InsertText(allSessions[row - 1].PlaystationId);
                t.Rows[row].Cells[2].Paragraphs[0].InsertText(allSessions[row - 1].StartGame.ToString("dd/MMM HH:mm:ss"));
                t.Rows[row].Cells[3].Paragraphs[0].InsertText(allSessions[row - 1].EndGame.ToString("dd/MMM HH:mm:ss"));
                t.Rows[row].Cells[4].Paragraphs[0].InsertText(allSessions[row - 1].ClientId);
                t.Rows[row].Cells[5].Paragraphs[0].InsertText(
                    allSessions[row - 1].MoneyLeft.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[6].Paragraphs[0].InsertText(
                    allSessions[row - 1].SessionDiscount.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[7].Paragraphs[0].InsertText(
                    allSessions[row - 1].PayedSum.ToString(CultureInfo.InvariantCulture));
                playedSum += allSessions[row - 1].PayedSum;
                moneyLeftSum += allSessions[row - 1].MoneyLeft;
            }
            
            doc.InsertParagraph("Money left(Tips and odd money) = " + moneyLeftSum + " soms");
            doc.InsertParagraph("Played money = " + playedSum + " soms");

            doc.Save();

            DialogResult dresult =
                MessageBox.Show("Report was successfully generated.\nWould younlike to open generated report?",
                    "Question", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {
                Process.Start("WINWORD.EXE", fileName);
            }
        }
    }
}
