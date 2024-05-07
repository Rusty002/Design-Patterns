namespace FactoryMethod.Exercise
{
    internal class Calendar
    {
        public void AddEvent(Event myevent, DateTime date) 
        {
            var calendar = CreateCalendar();
            calendar.AddEvent(myevent, date);
        }

        protected virtual IEvent CreateCalendar()
        {
            return new ArabicCalendar();
        }
    }
}
