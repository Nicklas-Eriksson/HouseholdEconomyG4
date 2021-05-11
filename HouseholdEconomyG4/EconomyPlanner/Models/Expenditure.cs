using HouseholdEconomyG4.Interfaces;

namespace HouseholdEconomyG4.EconomyPlanner.Models
{
    public class Expenditure : IExpenditures
    {
        public string Type { get; set; }
        public float Cost { get; set; }

        public Expenditure(string type, float cost)
        {
            this.Type = type;
            this.Cost = cost;
        }

        
    }
}
