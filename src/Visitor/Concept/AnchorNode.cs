namespace Visitor.Concept
{
    internal class AnchorNode : IHTMLNode
    {
        public void Exceute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
