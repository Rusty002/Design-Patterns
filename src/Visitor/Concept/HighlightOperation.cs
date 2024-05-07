namespace Visitor.Concept
{
    internal class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("Highlighting Heading Node");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("Highlighting Anchor Node");
        }
    }
}
