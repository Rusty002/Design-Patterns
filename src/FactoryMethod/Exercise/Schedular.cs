namespace FactoryMethod.Exercise
{
    internal class Schedular : Calendar
    {
        public void Schedule(Event myEvent) 
        {
            var today = new DateTime();
            AddEvent(myEvent, today);
        }
    }
}
