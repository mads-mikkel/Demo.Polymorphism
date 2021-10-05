namespace Demo.Polymorphism
{
    public class SalesRepresentative: BaseSalariedEmployee
    {
        private decimal weeklySales;
        private double commisionRate;

        public double CommisionRate
        {
            get { return commisionRate; }
            set { commisionRate = value; }
        }

        public decimal WeeklySales
        {
            get { return weeklySales; }
            set { weeklySales = value; }
        }

        public override decimal Earnings()
        {
            return base.Earnings() + (weeklySales * (decimal)commisionRate);
        }
    }
}
