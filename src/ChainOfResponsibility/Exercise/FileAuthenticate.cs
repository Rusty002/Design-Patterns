namespace ChainOfResponsibility.Exercise
{
    internal class FileAuthenticate : DataReaderHandler
    {
        public FileAuthenticate(DataReaderHandler next) : base(next)
        {
        }

        public override bool DoHandle(DataReader next)
        {
            Console.WriteLine("Authenticating File Name");
            if(next.GetFileName().Contains(".xlsx"))
                return false;
            else if(next.GetFileName().Contains(".numbers"))
                return false;
            else if(next.GetFileName().Contains(".qbw"))
                return false;
            else
                return true;
        }
    }
}
