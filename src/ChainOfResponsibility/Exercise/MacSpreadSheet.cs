namespace ChainOfResponsibility.Exercise
{
    internal class MacSpreadSheet : DataReaderHandler
    {
        public MacSpreadSheet(DataReaderHandler next) : base(next)
        {

        }

        public override bool DoHandle(DataReader next)
        {
            Console.WriteLine("Reading From a Mac SpreadSheet");
            return false;
        }
    }
}
