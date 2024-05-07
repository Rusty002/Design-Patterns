
namespace FactoryMethod.Exercise
{
    internal class GregorianCalendar : IEvent
    {
        public void AddEvent(Event myevent, DateTime date)
        {
            Console.WriteLine("Adding an event on the given date For Gregorian Calendar.");
        }
    }
}
