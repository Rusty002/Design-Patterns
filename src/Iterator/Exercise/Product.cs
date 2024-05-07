namespace Iterator.Exercise
{
    public class Product
    {
        private readonly int id;
        private readonly string name;

        public Product(int _id, string _name) {
            id = _id;
            name = _name;
        }

        public string InString() { 
            return String.Format(
                    @"Product 
                      id = {0},
                      name = {1}
                      ", id, name); 
        }
    }
}
