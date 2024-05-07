namespace Visitor.Exercise
{
    internal class ReverbOperation : INoiseOperation
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Apply reverb on Format Segment");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Apply reverb on fact segment");
        }
    }
}
