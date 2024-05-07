namespace Observer.Exercise
{
    internal class StockSubject
    {
        private readonly List<IStockChange> _stockObserver = new List<IStockChange>();
        public void AddObserver(IStockChange stockChange)
        {
            _stockObserver.Add(stockChange);
        }
        public void RenoveObserver(IStockChange stockChange)
        {
            _stockObserver.Remove(stockChange);
        }
        public void NotifyObserver()
        {
            foreach (var stock in _stockObserver)
                stock.Update();
        }
    }
}
