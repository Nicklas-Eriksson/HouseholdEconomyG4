using HouseholdEconomyG4.EconomyPlanner;
using HouseholdEconomyG4.EconomyPlanner.Models;
using HouseholdEconomyG4.Interfaces;
using System;
using System.Collections.Generic;

namespace HouseholdEconomyG4.Data
{
    public static class MockData
    {
        public static bool MockIncome()
        {
            try
            {
                BudgetCalculation.Income.Add(new Salaries(14500F));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static bool MockExpenditures()
        {
            List<IExpenditures> expenditure = new()
            {
                new Expenditure("Rent", 8900),
                new Expenditure("Netflix", 89),
                new Expenditure("Mobile", 99),
                new Expenditure("Broadband", 199),
                new Expenditure("Food", 1200),
                new Expenditure("Consumables", 600),
                new Expenditure("Bank cost", 45),
                new Expenditure("Pensions", 1000),
                new Expenditure("Gym", 350),
                new Expenditure("Home insurance", 75)
            };

            try
            {
                BudgetCalculation.Expenditures.AddRange(expenditure);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

    }
}
