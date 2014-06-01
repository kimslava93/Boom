﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
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

            doc.InsertParagraph("ID дня: " + dailyId);
            doc.InsertParagraph("Начало: " + gs.start_session);
            doc.InsertParagraph("Конец: " + gs.end_session);
            doc.InsertParagraph("Администратор: " +
                                DataBaseClass.Instancedb().GetUserInfoByPersonID(gs.administrator_id).name);


            doc.InsertParagraph();
            doc.InsertTable(allSessions.Count + 1, 8);
            doc.PageLayout.Orientation = Orientation.Landscape;
            Table t = doc.Tables[0];
            t.AutoFit = AutoFit.Contents;
            t.Design = TableDesign.TableGrid;
            t.Rows[0].Cells[0].Paragraphs[0].InsertText("№");
            t.Rows[0].Cells[0].Width = 80;//"#".Length;
            t.Rows[0].Cells[1].Paragraphs[0].InsertText("ID приставки");
//            t.Rows[0].Cells[1].Width = "Console ID".Length;
            t.Rows[0].Cells[2].Paragraphs[0].InsertText("Начало");
//            t.Rows[0].Cells[2].Width = "Start".Length;
            t.Rows[0].Cells[3].Paragraphs[0].InsertText("Конец");
//            t.Rows[0].Cells[3].Width = "End".Length;
            t.Rows[0].Cells[4].Paragraphs[0].InsertText("ID клиента");
            t.Rows[0].Cells[4].Width = 300;
            t.Rows[0].Cells[5].Paragraphs[0].InsertText("Остаток");
//            t.Rows[0].Cells[5].Width = "Money Left".Length;
            t.Rows[0].Cells[6].Paragraphs[0].InsertText("Скидка");
//            t.Rows[0].Cells[6].Width = "Discount".Length;
            t.Rows[0].Cells[7].Paragraphs[0].InsertText("Оплачено");
//            t.Rows[0].Cells[7].Width = "Paid sum".Length;
            
            double playedSum = 0;
            double moneyLeftSum = 0;
            for (int row = 1; row < allSessions.Count; row++)
            {
                t.Rows[row].Cells[0].Paragraphs[0].InsertText(
                    allSessions[row - 1].Сессия.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[1].Paragraphs[0].InsertText(allSessions[row - 1].Приставка);
                t.Rows[row].Cells[2].Paragraphs[0].InsertText(allSessions[row - 1].Начало.ToString("dd/MMM HH:mm:ss"));
                t.Rows[row].Cells[3].Paragraphs[0].InsertText(allSessions[row - 1].Конец.ToString("dd/MMM HH:mm:ss"));
                t.Rows[row].Cells[4].Paragraphs[0].InsertText(allSessions[row - 1].Клиент);
                t.Rows[row].Cells[5].Paragraphs[0].InsertText(
                    allSessions[row - 1].Остаток_денег.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[6].Paragraphs[0].InsertText(
                    allSessions[row - 1].Скидка_сессии.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[7].Paragraphs[0].InsertText(
                    allSessions[row - 1].Оплаченная_сумма.ToString(CultureInfo.InvariantCulture));
                playedSum += allSessions[row - 1].Оплаченная_сумма;
                moneyLeftSum += allSessions[row - 1].Остаток_денег;
            }
            List<double?> withdrMoney = DataBaseClass.Instancedb().GetAllWithdrawnMoneyOnDailyId(dailyId);
            double withdrawnMoney = withdrMoney.Where(t1 => t1 != null).Sum(t1 => t1 != null ? t1.Value : 0);

            doc.InsertParagraph("Остаток денег(ненаигранные деньги) = " + moneyLeftSum + " сом");
            doc.InsertParagraph("Наигранные деньги = " + playedSum + " сом");
            doc.InsertParagraph("Снято = " + withdrawnMoney + " сом");

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
