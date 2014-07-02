#region

using System;

#endregion

namespace Boom_Manager_Project.MyClasses
{
    public class DaySessionClass
    {
        public int Сессия { get; set; }
        public string Приставка { get; set; }
        public DateTime Начало { get; set; }
        public DateTime Конец { get; set; }
        public TimeSpan Оставшееся_время { get; set;}
        public string Клиент { get; set; }
        public double Счетчик { get; set; }
        public double Скидка_сессии { get; set; }
        public double Оплачено { get; set; }
    }
}