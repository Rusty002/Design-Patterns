namespace Observer.Concept
{
    internal class Chart : IObserver
    {
        private readonly DataSource _dataSource;
        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Chart Class Updated" + _dataSource.GetValue());
        }
    }
}
