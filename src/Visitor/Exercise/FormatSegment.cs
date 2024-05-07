namespace Visitor.Exercise
{
    internal class FormatSegment : IVisitor
    {
        public void Execute(INoiseOperation operation)
        {
            operation.Apply(this);
        }
    }
}
