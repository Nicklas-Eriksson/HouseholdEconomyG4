using HouseholdEconomyG4.Interfaces;

namespace HouseholdEconomyG4.EconomyPlanner.Models
{
    public class Salaries : IIncome
    {
        /// <summary>
        /// float > Salary
        /// </summary>
        public float Salary { get; set; }

        public Salaries(float salary)
        {
            this.Salary = salary;
        }
    }
}
