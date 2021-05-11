using System;
using HouseholdEconomyG4.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HouseholdEconomyG4.EconomyPlanner
{
    public static class BudgetCalculation
    {
        public static List<IIncome> Income { get; set; }
        public static List<IExpenditures> Expenditures { get; set; }
        public static float AmountOfMoneyLeft { get; set; }
        //public static List<??> ?? { get; set; }

        public static float TotalIncome()
        {
            try
            {
                return Income.Sum(s => s.Salary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default;
            }
        }

        public static float TotalExpenditure()
        {
            try
            {
                return Expenditures.Sum(e => e.Cost);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default;
            }
        }

        public static float MoneyLeft()
        {
            try
            {
                return TotalIncome() - TotalExpenditure();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default;
            }
        }
    }
}
