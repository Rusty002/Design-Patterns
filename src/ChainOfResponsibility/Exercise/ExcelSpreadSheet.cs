namespace ChainOfResponsibility.Exercise
{
    internal class ExcelSpreadSheet : DataReaderHandler
    {
        public ExcelSpreadSheet(DataReaderHandler next) : base(next)
        {

        }

        public override bool DoHandle(DataReader next)
        {
            Console.WriteLine("Reading Data From a Excel Spread Sheet");
            return false;
        }
    }
}
