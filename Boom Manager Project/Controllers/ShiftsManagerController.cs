﻿using System;
using System.Collections.Generic;
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
            List<DaySessionForShiftReport> allSessions = DataBaseClass.Instancedb().GetAllDaySessionsInShift(dailyId);
            global_session_t gs = DataBaseClass.Instancedb().GetGlobalSessionByDailyId(dailyId);
            string fileName = @"E:\BOOMgamebar\Reports\" + gs.start_session.ToString("MMM-dd-HH-mm") + @".docx";

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
                                DataBaseClass.Instancedb().GetUserInfoByPersonId(gs.administrator_id).name);


            doc.InsertParagraph();
            doc.InsertTable(allSessions.Count + 1, 9);
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
            t.Rows[0].Cells[4].Width = 150;
            t.Rows[0].Cells[5].Paragraphs[0].InsertText("Комментарии");
            t.Rows[0].Cells[5].Width = 300;
            t.Rows[0].Cells[6].Paragraphs[0].InsertText("Наиграно");
//            t.Rows[0].Cells[5].Width = "Money Left".Length;
            t.Rows[0].Cells[7].Paragraphs[0].InsertText("Скидка");
//            t.Rows[0].Cells[6].Width = "Discount".Length;
            t.Rows[0].Cells[8].Paragraphs[0].InsertText("Оплачено");
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
                t.Rows[row].Cells[5].Paragraphs[0].InsertText(allSessions[row - 1].Комментарии);
                t.Rows[row].Cells[6].Paragraphs[0].InsertText(
                    allSessions[row - 1].Счетчик.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[7].Paragraphs[0].InsertText(
                    allSessions[row - 1].Скидка_сессии.ToString(CultureInfo.InvariantCulture));
                t.Rows[row].Cells[8].Paragraphs[0].InsertText(
                    allSessions[row - 1].Оплачено.ToString(CultureInfo.InvariantCulture));
                playedSum += allSessions[row - 1].Оплачено;
                allRegisteredCash += allSessions[row - 1].Счетчик;
                allDiscounts += allSessions[row - 1].Скидка_сессии;
            }
            List<double?> withdrMoney = DataBaseClass.Instancedb().GetAllWithdrawnMoneyOnDailyId(dailyId);
            
            double withdrawnMoney = withdrMoney.Where(t1 => t1 != null).Sum(t1 => t1 != null ? t1.Value : 0);
            var allWithdrownMoney = DataBaseClass.Instancedb().GetAllWithdrawnDataOnDailyId(dailyId);
          
            List<expenses_t> expenses = DataBaseClass.Instancedb().GetAllExpensesOnDailyId(dailyId);
            
            double expensesSum = expenses.Sum(exp => exp.cash_amount);

            double? moneyFromPrevShift = DataBaseClass.Instancedb().GetCashFromDailyId(dailyId - 1);
            var cashFromDailyId = DataBaseClass.Instancedb().GetCashFromDailyId(dailyId);
            if (cashFromDailyId != null)
            {
                var currentCash = (double)cashFromDailyId;
                moneyFromPrevShift = moneyFromPrevShift == null ? 0 : Math.Round((double) moneyFromPrevShift, 0);

                doc.InsertParagraph("Общая касса (со скидками и с не наигранными деньгами) = " + Math.Round(playedSum,0) + " сом");
                doc.InsertParagraph("Сгоревшие деньги = " + Math.Round(playedSum - allRegisteredCash,0) + " сом");
                doc.InsertParagraph("Скидки = " + allDiscounts + " сом");
                doc.InsertParagraph("Снято = " + withdrawnMoney + " сом");
                doc.InsertParagraph("Остаток с прошлой смены " + moneyFromPrevShift + " сом");
                doc.InsertParagraph("Сумма затрат = " + expensesSum + " сом");
                doc.InsertParagraph("Сумма денег в кассе на момент Просмотра отчета= " + Math.Round(currentCash, 0) + " сом");


                doc.InsertParagraph();
                doc.InsertTable(2, 9);
                doc.PageLayout.Orientation = Orientation.Landscape;
                Table accountingTable = doc.Tables[1];
                accountingTable.AutoFit = AutoFit.Contents;
                accountingTable.Design = TableDesign.TableGrid;

                accountingTable.Rows[0].Cells[0].Paragraphs[0].InsertText("Число");
                accountingTable.Rows[0].Cells[1].Paragraphs[0].InsertText("Смена");
                accountingTable.Rows[0].Cells[2].Paragraphs[0].InsertText("Касса");
                accountingTable.Rows[0].Cells[3].Paragraphs[0].InsertText("Снято");
                accountingTable.Rows[0].Cells[4].Paragraphs[0].InsertText("Расход");
                accountingTable.Rows[0].Cells[5].Paragraphs[0].InsertText("Остаток");
                accountingTable.Rows[0].Cells[6].Paragraphs[0].InsertText("-%");
                accountingTable.Rows[0].Cells[7].Paragraphs[0].InsertText("+%");
                accountingTable.Rows[0].Cells[8].Paragraphs[0].InsertText("Комментарии");

                accountingTable.Rows[1].Cells[0].Paragraphs[0].InsertText(gs.start_session.Day + " " + gs.start_session.ToString("MMM"));
                accountingTable.Rows[1].Cells[1].Paragraphs[0].InsertText(gs.administrator_id + " и " + gs.operator_id);
                accountingTable.Rows[1].Cells[2].Paragraphs[0].InsertText(Math.Round(playedSum, 0) + "");
                accountingTable.Rows[1].Cells[3].Paragraphs[0].InsertText(withdrawnMoney + "");
                accountingTable.Rows[1].Cells[4].Paragraphs[0].InsertText("Расход");
                accountingTable.Rows[1].Cells[5].Paragraphs[0].InsertText("Остаток");
                accountingTable.Rows[1].Cells[6].Paragraphs[0].InsertText("-%");
                accountingTable.Rows[1].Cells[7].Paragraphs[0].InsertText("+%");
                accountingTable.Rows[1].Cells[8].Paragraphs[0].InsertText("Комментарии");

            }

            PrintExpenses(expenses, doc);
            PrintWithdrownMoney(allWithdrownMoney, doc);
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
        private void PrintWithdrownMoney(IEnumerable<withdrow_money_t> allWithdrownMoney, DocX doc)
        {

            for (int i = 0; i < 5; i++)
            {
                doc.InsertParagraph();
            }
            doc.InsertParagraph("Таблица снятых менеджером денег:");
            foreach (var w in allWithdrownMoney)
            {
                doc.InsertParagraph(w.transaction_time.ToString("HH:mm") + ":     " + w.manager + "       -      " + w.cash_amount + " сом");
            }
        }

        private void PrintExpenses(IEnumerable<expenses_t> allExpenses, DocX doc)
        {
            for (int i = 0; i < 5; i++)
            {
                doc.InsertParagraph();
            }
            doc.InsertParagraph("Таблица расходов: ");
            foreach (expenses_t exp in allExpenses)
            {
                doc.InsertParagraph(exp.expenses_time.ToString("HH:mm") + ":     " + exp.comments + "       -      " + exp.cash_amount + " сом");
            }
        }
    }
}
