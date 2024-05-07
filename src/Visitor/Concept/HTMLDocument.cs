namespace Visitor.Concept
{
    internal class HTMLDocument
    {
        private List<IHTMLNode> HTMLNodes = new List<IHTMLNode>();

        public void AddNode(IHTMLNode node)
        {
            HTMLNodes.Add(node);
        }
        public void Execute(IOperation operation)
        {
            foreach (var node in HTMLNodes)
                node.Exceute(operation);
        }
    }
}
