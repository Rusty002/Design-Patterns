namespace Strategy.Concept
{
    public class BlackFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine(fileName + " filtered using Black Filter");
        }
    }
}
