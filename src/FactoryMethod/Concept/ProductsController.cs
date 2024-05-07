namespace FactoryMethod.Concept
{
    internal class ProductsController : SharpController
    {
        public void GetProductsList()
        {
            // Get List from Database
            Dictionary<string, object> context = new Dictionary<string, object>();
            // context.put(Products)
            Render("products", context);
        }
    }
}
