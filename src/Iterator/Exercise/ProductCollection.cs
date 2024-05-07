namespace Iterator.Exercise
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public List<Product> GetProducts() { 
            return products; 
        }

        public void AddProduct(Product product){
            products.Add(product);
        }

        public ITERATOR CreateIterator(){
            return new ProductIterator(this);
        }
        public class ProductIterator : ITERATOR
        {
            private ProductCollection _product;
            private int index = 0;
            public ProductIterator(ProductCollection product)
            {
                _product = product;
            }
            public Product Current()
            {
                return _product.GetProducts()[index];
            }

            public bool HasNext()
            {
                return index < _product.GetProducts().Count;
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
