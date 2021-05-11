namespace HouseholdEconomyG4.Interfaces
{
    /// <summary>
    /// Props > Type(string), Cost(float)
    /// </summary>
    public interface IExpenditures
    {
        public string Type { get; set; }
        public float Cost { get; set; }
    }
}
