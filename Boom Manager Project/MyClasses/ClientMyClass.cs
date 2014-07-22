using System;

namespace Boom_Manager_Project.MyClasses
{
    public class ClientMyClass
    {
        public string ID_Клиента { get; set; }
        public string Имя { get; set; }
        public DateTime День_рождение { get; set; }
        public string Email { get; set; }
        public string Телефон { get; set; }
        public DateTime Дата_активации { get; set; }
        public double  Персональная_скидка { get; set; }
        public double  Наигранная_сумма { get; set; }
    }
}
