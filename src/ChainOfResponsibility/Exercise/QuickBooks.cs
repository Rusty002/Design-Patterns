namespace ChainOfResponsibility.Exercise
{
    internal class QuickBooks : DataReaderHandler
    {
        public QuickBooks(DataReaderHandler next) : base(next)
        {

        }

        public override bool DoHandle(DataReader next)
        {
            Console.WriteLine("Reading a quick book");
            return false;
        }
    }
}
