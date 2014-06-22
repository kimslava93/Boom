using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
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
            if (gs.start_session == gs.end_session)
            {
                doc.InsertParagraph("Сессия еще не закончена!");
            }
            else
            {
                doc.InsertParagraph("Конец: " + gs.end_session);
            }
            doc.InsertParagraph("Администратор: " +
                                DataBaseClass.Instancedb().GetUserInfoByPersonID(gs.administrator_id).name);


            doc.InsertParagraph();
            doc.InsertTable(allSessions.Count + 1, 8);
            doc.PageLayout.Orientation = Orientation.Landscape;
            Table t = doc.Tables[0];
            t.AutoFit = AutoFit.Contents;
            t.Design = TableDesign.TableGrid;
            t.Rows[0].Cells[0].Paragraphs[0].InsertText("№");
            t.Rows[0].Cells[0].Width = 80;
            t.Rows[0].Cells[1].Paragraphs[0].InsertText("ID приставки");
//            t.Rows[0].Cells[1].Width = "Console ID".Length;
            t.Rows[0].Cells[2].Paragraphs[0].InsertText("Начало");
//            t.Rows[0].Cells[2].Width = "Start".Length;
            t.Rows[0].Cells[3].Paragraphs[0].InsertText("Конец");
//            t.Rows[0].Cells[3].Width = "End".Length;
            t.Rows[0].Cells[4].Paragraphs[0].InsertText("ID клиента");
            t.Rows[0].Cells[4].Width = 300;
            t.Rows[0].Cells[5].Paragraphs[0].InsertText("Наиграно");
//            t.Rows[0].Cells[5].Width = "Money Left".Length;
            t.Rows[0].Cells[6].Paragraphs[0].InsertText("Скидка");
//            t.Rows[0].Cells[6].Width = "Discount".Length;
            t.Rows[0].Cells[7].Paragraphs[0].InsertText("Оплачено");
//            t.Rows[0].Cells[7].Width = "Paid sum".Length;
            
            double playedSum = 0;
            double allRegisteredCash = 0;
            double allDiscounts = 0;
            for (int row = 1; row <= allSessions.Count; row++)
            {
                t.Rows[row].Cells[0].Paragraphs[0].InsertText(
                    allSessions[row - 1].Сессия.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[1].Paragraphs[0].InsertText(allSessions[row - 1].Приставка);
                t.Rows[row].Cells[2].Paragraphs[0].InsertText(allSessions[row - 1].Начало.ToString("HH:mm"));
                t.Rows[row].Cells[3].Paragraphs[0].InsertText(allSessions[row - 1].Конец.ToString("HH:mm"));
                t.Rows[row].Cells[4].Paragraphs[0].InsertText(allSessions[row - 1].Клиент);
                t.Rows[row].Cells[5].Paragraphs[0].InsertText(
                    allSessions[row - 1].Счетчик.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[6].Paragraphs[0].InsertText(
                    allSessions[row - 1].Скидка_сессии.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[7].Paragraphs[0].InsertText(
                    allSessions[row - 1].Оплачено.ToString(CultureInfo.InvariantCulture));
                playedSum += allSessions[row - 1].Оплачено;
                allRegisteredCash += allSessions[row - 1].Счетчик;
                allDiscounts += allSessions[row - 1].Скидка_сессии;
            }
            List<double?> withdrMoney = DataBaseClass.Instancedb().GetAllWithdrawnMoneyOnDailyId(dailyId);
            
            double withdrawnMoney = withdrMoney.Where(t1 => t1 != null).Sum(t1 => t1 != null ? t1.Value : 0);

          
            List<expenses_t> expenses = DataBaseClass.Instancedb().GetAllExpensesOnDailyId(dailyId);
            
            double expensesSum = expenses.Sum(exp => exp.cash_amount);

            double? moneyFromPrevShift = DataBaseClass.Instancedb().GetCashFromDailyId(dailyId - 1);
            var cashFromDailyId = DataBaseClass.Instancedb().GetCashFromDailyId(dailyId);
            if (cashFromDailyId != null)
            {
                var currentCash = (double)cashFromDailyId;
                moneyFromPrevShift = moneyFromPrevShift == null ? 0 : Math.Round((double) moneyFromPrevShift, 0);

                doc.InsertParagraph("Общая касса (со скидками и с не наигранными деньгами) = " + allRegisteredCash + " сом");
                doc.InsertParagraph("Наигранные деньги = " + playedSum + " сом");
                doc.InsertParagraph("Скидки = " + allDiscounts + " сом");
                doc.InsertParagraph("Снято = " + withdrawnMoney + " сом");
                doc.InsertParagraph("Остаток с прошлой смены " + moneyFromPrevShift + " сом");
                doc.InsertParagraph("Сумма затрат = " + expensesSum + " сом");
                doc.InsertParagraph("Сумма денег в кассе на данный момент = " + currentCash + " сом");
            }

            PrintExpenses(expenses, doc);
            try
            {
                doc.Save();
                try
                {
                    DialogResult dresult =
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(9),
                            ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetCaption(2), MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                    if (dresult == DialogResult.Yes)
                    {
                        Process.Start("WINWORD.EXE", fileName);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(13));
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(30));
            }
            
        }

//        private double GetMoneyLeftFromPreviousShift(int dailyId)
//        {
//            List<double?> allMoneyWithdrownFromPreviousShift =
//              DataBaseClass.Instancedb().GetAllWithdrawnMoneyOnDailyId(dailyId - 1);
//            double moneyWithdrownFromPreviousShift =
//                allMoneyWithdrownFromPreviousShift.Where(t1 => t1 != null).Sum(t1 => t1 != null ? t1.Value : 0);
//            if (moneyWithdrownFromPreviousShift < 0)
//            {
//                moneyWithdrownFromPreviousShift = 0;
//            }
//
//        }

        private void PrintExpenses(IEnumerable<expenses_t> allExpenses, DocX doc)
        {
            for (int i = 0; i < 5; i++)
            {
                doc.InsertParagraph();
            }
            foreach (expenses_t exp in allExpenses)
            {
                doc.InsertParagraph(exp.expenses_time.ToString("HH:mm") + ":     " + exp.comments + "       -      " + exp.cash_amount + " сом");
            }
        }
    }
}
