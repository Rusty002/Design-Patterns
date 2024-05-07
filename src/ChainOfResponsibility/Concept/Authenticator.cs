namespace ChainOfResponsibility.Concept
{
    internal class Authenticator : Handler
    {
        public Authenticator(Handler handler) : base(handler) 
        {

        }

        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Authenticating ...");
            return !(request.GetUserName() == "admin" && request.GetPassword() == "1234");
        }
    }
}
