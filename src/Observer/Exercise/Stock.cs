namespace Observer.Exercise
{
    internal class Stock : StockSubject
    {
        private int Price;
        public int GetPrice() 
        { 
            return Price; 
        }
        public void SetPrice(int price)
        {
            Price = price;
            NotifyObserver();
        }
    }
}
