using System;
using System.Windows.Forms.VisualStyles;

namespace Boom_Manager_Project.MyClasses
{
    public class BonusPromoTimeTemplateMyClass
    {

        public string TimeName;
        public TimeSpan BonusTime;

        public BonusPromoTimeTemplateMyClass(string name, TimeSpan bonusTime)
        {
            TimeName = name;
            BonusTime = bonusTime;
        }
    }
}