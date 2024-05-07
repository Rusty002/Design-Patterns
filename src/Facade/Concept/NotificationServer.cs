namespace Facade.Concept
{
    internal class NotificationServer
    {
        // connection() -> connection
        // authentication(ID, Key) -> AuthToken
        // send(message, authtoken, Target)
        // disconnect()

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(Message message, AuthToken token, string target) 
        {
            Console.WriteLine("Sending a message");
        }
    }
}
