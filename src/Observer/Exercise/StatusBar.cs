namespace Observer.Exercise
{
    internal class StatusBar : IStockChange
    {
        private readonly Stock _stock;
        public StatusBar(Stock stock)
        {
            _stock = stock;
        }
        public void Update()
        {
            Console.WriteLine("Status bar updated " + _stock.GetPrice());
        }
    }
}
