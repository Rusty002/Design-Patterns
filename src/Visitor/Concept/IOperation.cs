namespace Visitor.Concept
{
    internal interface IOperation
    {
        void Apply(HeadingNode headingNode);
        void Apply(AnchorNode anchorNode);
    }
}
