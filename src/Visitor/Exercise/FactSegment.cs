namespace Visitor.Exercise
{
    internal class FactSegment : IVisitor
    {
        public void Execute(INoiseOperation operation)
        {
            operation.Apply(this);
        }
    }
}
