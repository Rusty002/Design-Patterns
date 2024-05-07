namespace ChainOfResponsibility.Concept
{
    internal class Encryptor : Handler
    {
        public Encryptor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Encrypting ... ");
            return false;
        }
    }
}
