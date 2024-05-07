namespace Facade.Concept
{
    internal class Connection
    {
        public void Connect() 
        {
            Console.WriteLine("Connected To Server");
        }

        public void Disconnect() 
        {
            Console.WriteLine("Disconnected From Server");
        }
    }
}
