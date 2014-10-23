using System;
using System.Collections.Generic;
using System.Linq;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    class CheckDiscountAvailibily
    {
        private static CheckDiscountAvailibily _checkDiscountAvailibily;

        public static CheckDiscountAvailibily InstanceCheckDiscountAvailibily()
        {
            return _checkDiscountAvailibily ?? (_checkDiscountAvailibily = new CheckDiscountAvailibily());
        }

        public List<int> FilterAvailablePromos(string discountCardOwnerName, string playstationsId, bool nightTime,
            TimeSpan paidTime, double paidSum, double discount)
        {
            var allFilteredBonuses = new List<int>();
            var allPromos = DataBaseClass.Instancedb().GetAllDiscounts();
            var allActivePromos = (from p in allPromos
                where p.promo_state == "Opened"
                where p.promo_end > DateTime.Now
                select p).ToList();
            foreach (var p in allActivePromos)
            {
                if (p.promo_requirements_id != null)
                {
                    var promoRequirements = DataBaseClass.Instancedb().GetRequirementById((int)p.promo_requirements_id);
                    if (p.promo_auditory.Equals("Все") || CheckAuditory(discountCardOwnerName,p.promo_auditory))
                    {
                        if (CheckPlaystations(playstationsId,p.promo_playstations) && CheckTimezones(p.promo_timezones))
                        {
                            if (promoRequirements.promo_requirements_hours != null &&
                                promoRequirements.promo_requirements_hours != new TimeSpan())
                            {
                                if (paidTime >= promoRequirements.promo_requirements_hours)
                                {
                                    if (p.discount_bonus_id != null) allFilteredBonuses.Add((int) p.discount_bonus_id);
                                    continue;
                                }
                            }
                            if (promoRequirements.promo_requirements_money_sum != null &&
                                promoRequirements.promo_requirements_money_sum > 0)
                            {
                                if (paidSum >= promoRequirements.promo_requirements_money_sum)
                                {
                                    if (p.discount_bonus_id != null) allFilteredBonuses.Add((int) p.discount_bonus_id);
                                }
                            }
                        }
                    }
                }
            }
            return allFilteredBonuses;
        }

        private bool CheckAuditory(string discountCardOwnerName, string requiredAuditory)
        {
            if (discountCardOwnerName.Equals("0") && requiredAuditory.Equals("Только без карточек") ||
                discountCardOwnerName.Equals("Usual Client") && requiredAuditory.Equals("Только без карточек") ||
                !discountCardOwnerName.Equals("0") && !discountCardOwnerName.Equals("Usual Client")
                && requiredAuditory.Equals("Только с карточками"))
            {
                return true;
            }
            return false;
        }

        private bool CheckPlaystations(string plst, string listOfPlst)
        {
            return (Options.OptionsInstance().FindSubString(listOfPlst, plst));
        }
        private bool CheckTimezones(string listOfTmz)
        {
            return Options.OptionsInstance()
                .FindSubString(listOfTmz, AddNewSessionModel.InstanceAddNewSessionModel().WhichTimeZoneIs(DateTime.Now));
        }

        public BonusesMyClass CheckOnRequiredSum(double sum)
        {
            var activePromos = GetAllActivePromos();
            int? reqId = null;
            foreach (var activePromo in activePromos)
            {
                if (activePromo.promo_requirements_id != null)
                {
                    var req = DataBaseClass.Instancedb().GetRequirementById((int)activePromo.promo_requirements_id);
                    if (sum >= req.promo_requirements_money_sum)
                    {
                        reqId = req.promo_requirement_id;
                    }
                }
                if (reqId == null)
                {
                    return new BonusesMyClass();
                }
            }
            if (reqId != null) return DataBaseClass.Instancedb().GetBonusById((int) reqId);
            return DataBaseClass.Instancedb().GetBonusById(-1);
        }

        private List<promos_t> GetAllActivePromos()
        {
            var allPromos = DataBaseClass.Instancedb().GetAllDiscounts();
            return (from p in allPromos
                    where p.promo_state == "Opened"
                    where p.promo_end > DateTime.Now
                select p).ToList();
        }
    }
}
