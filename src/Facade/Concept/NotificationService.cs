namespace Facade.Concept
{
    internal class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("imaginary IpAddress");
            var authToken = server.Authenticate("appId", "Key");
            server.Send(new Message(message), authToken, target);
            connection.Disconnect();
        }
    }
}
