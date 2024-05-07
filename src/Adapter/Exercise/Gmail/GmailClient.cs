namespace Adapter.Exercise.Gmail
{
    internal class GmailClient
    {
        public void Connect() 
        {
            Console.WriteLine("Connecting To Gmail ...");
        }
        public void GetEmails()
        {
            Console.WriteLine("Downloading emails from Gmail");
        }
        public void Disconnect()
        {
            Console.WriteLine("Disconnecting From Gmail");
        }
    }
}
