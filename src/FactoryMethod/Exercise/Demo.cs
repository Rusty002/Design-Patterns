namespace FactoryMethod.Exercise
{
    internal class Demo
    {
        public static void Show()
        {
            var scheduler = new Schedular();
            scheduler.Schedule(new Event());
        }
    }
}
