namespace Strategy.Concept
{
    public class WhiteFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine(fileName + " Filtered using WhiteFilter");
        }
    }
}
