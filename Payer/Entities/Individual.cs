using Payer.Entities;

namespace Payer.Entities
{
    class Individual : Payers
    {
        public double HealthExpen { get; set; }

        public Individual(string name, double anualIncome, double healthExpen) : base(name, anualIncome)
        {
            HealthExpen = healthExpen;
        }

        public override double Taxes()
        {
            double taxe = 0;
            if (AnualIncome < 20000)
            {
                taxe = (AnualIncome * 0.15) - (HealthExpen / 2);
            }
            else
            {
                taxe = (AnualIncome * 0.25) - (HealthExpen / 2);
            }

            return taxe;
        }
    }
}
