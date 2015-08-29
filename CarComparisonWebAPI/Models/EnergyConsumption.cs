namespace CarComparisonWebAPI.Models
{
    public class EnergyConsumption
    {
        public EnergyType Type { get; set; }
        public double ConsumptionRate { get; set; }
        public ConsumptionCalcType RateCalculationType { get; set; }
    }
}