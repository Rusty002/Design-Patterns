namespace State_Pattern.Exercise
{
    public class Driving : IDirectionService
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public int GetETA()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}
