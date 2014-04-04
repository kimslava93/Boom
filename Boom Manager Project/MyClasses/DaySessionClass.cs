#region

using System;

#endregion

namespace Boom_Manager_Project.MyClasses
{
    public class DaySessionClass
    {
        public int SessionId { get; set; }
        public string PlaystationId { get; set; }
        public DateTime StartGame { get; set; }
        public DateTime EndGame { get; set; }
        public TimeSpan TimeLeft { get; set;}
        public string ClientId { get; set; }
        public double MoneyLeft { get; set; }
        public double SessionDiscount { get; set; }
        public double PayedSum { get; set; }
    }
}