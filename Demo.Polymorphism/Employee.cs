namespace Demo.Polymorphism
{
    public abstract class Employee: IPayable
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal GetPaymentAmount()
        {
            return Earnings() * 0.85m; // Pension
        }

        public abstract decimal Earnings();
    }
}
