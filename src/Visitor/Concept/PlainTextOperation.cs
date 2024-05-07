namespace Visitor.Concept
{
    internal class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("Extracting Text For Highlight Node");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("Extracting Text For Anchor Node");
        }
    }
}
