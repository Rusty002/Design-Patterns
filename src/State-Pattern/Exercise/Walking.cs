namespace State_Pattern.Exercise
{
    public class Walking : IDirectionService
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return 4;
        }

        public int GetETA()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }
    }
}
