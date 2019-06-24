using Payer.Entities;

namespace Payer.Entities
{
    class Company : Payers
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            double taxe = 0;
            if (Employees <= 10)
            {
                taxe = AnualIncome * 0.16;
            }
            else
            {
                taxe = AnualIncome * 0.14;
            }
            return taxe;
        }
    }
}
