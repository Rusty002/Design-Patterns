namespace Visitor.Concept
{
    internal class HeadingNode : IHTMLNode
    {
        public void Exceute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
