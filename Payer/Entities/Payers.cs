namespace Payer.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Payers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }



        public abstract double Taxes();
    }
}
