namespace ChainOfResponsibility.Concept
{
    internal class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {

        }

        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Compressing Data ...");
            return false;
        }
    }
}
