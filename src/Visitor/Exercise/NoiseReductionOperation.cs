namespace Visitor.Exercise
{
    internal class NoiseReductionOperation : INoiseOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Reducing Noise For Format Segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Reducing Noise For Fact Segment");
        }
    }
}
