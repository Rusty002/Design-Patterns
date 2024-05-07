namespace Visitor.Exercise
{
    internal class NormalizeOperation : INoiseOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalize Format Segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Normalize Fact Segment");
        }
    }
}
