namespace Facade.Concept
{
    internal interface INotificationService
    {
        void Send(string message, string target);
    }
}
