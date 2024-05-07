namespace Proxy.Exercise
{
    internal class DbContext
    {
        private Dictionary<int, Product> UpdatedObjects = new Dictionary<int, Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine("SELECT * FROM products WHERE product_id = {0}", id);

            // Simulate reading a product object from a database.
            var product = new ProductProxy(id, this);
            product.SetName("Product 1");

            return product;
        }

        public void SaveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in UpdatedObjects)
                Console.WriteLine("UPDATE products SET name = '{0}' " +
                                        "WHERE product_id = {1}", 
                                        updatedObject.Value.GetName(), 
                                        updatedObject.Value.GetId());

            UpdatedObjects.Clear();
        }

        public void MarkAsChanged(Product product)
        {
            UpdatedObjects.Add(product.GetId(), product);
        }
    }
}
