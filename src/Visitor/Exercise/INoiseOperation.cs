namespace Visitor.Exercise
{
    internal interface INoiseOperation
    {
        void Apply(FormatSegment formatSegment);
        void Apply(FactSegment factSegment);
    }
}
