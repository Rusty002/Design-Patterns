namespace State_Pattern.Exercise
{
    public class Bicycling : IDirectionService
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }

        public int GetETA()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}
