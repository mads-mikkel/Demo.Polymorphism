namespace Demo.Polymorphism
{
    public class Product
    {
        protected string name;
        protected int qty;
        protected decimal price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price { get => price*qty; set => price = value; }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
    }
}