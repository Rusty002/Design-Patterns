
namespace FactoryMethod.Exercise
{
    internal class ArabicCalendar : IEvent
    {
        public void AddEvent(Event myevent, DateTime date)
        {
            Console.WriteLine("Adding an event on the given date For Arabic Calendar.");
        }
    }
}
