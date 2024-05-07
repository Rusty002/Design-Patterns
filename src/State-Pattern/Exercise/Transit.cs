namespace State_Pattern.Exercise
{
    public class Transit : IDirectionService
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }

        public int GetETA()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }

    }
}
