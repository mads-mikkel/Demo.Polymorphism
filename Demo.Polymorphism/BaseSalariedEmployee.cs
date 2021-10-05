namespace Demo.Polymorphism
{
    public class BaseSalariedEmployee: Employee
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override decimal Earnings()
        {
            return salary;
        }
    }
}
