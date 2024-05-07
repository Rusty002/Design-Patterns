namespace Proxy.Exercise
{
    internal class Product
    {
        private readonly int Id;
        private string Name;

        public Product(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
