namespace Observer.Exercise
{
    internal class StockList : IStockChange
    {
        private readonly Stock _stock;
        public StockList(Stock stock)
        {
            _stock = stock;
        }
        public void Update()
        {
            Console.WriteLine("Stock List Updated " + _stock.GetPrice());
        }
    }
}
