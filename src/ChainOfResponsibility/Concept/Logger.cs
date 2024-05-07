namespace ChainOfResponsibility.Concept
{
    internal class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {

        }

        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Logging ...");
            return false;
        }
    }
}
