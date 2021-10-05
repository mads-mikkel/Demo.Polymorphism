namespace Demo.Polymorphism
{
    public abstract class Entity: IPersistable
    {
        protected int id;

        public int Id => id;
    }
}