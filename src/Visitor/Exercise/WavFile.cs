namespace Visitor.Exercise
{
    internal class WavFile
    {
        private List<IVisitor> Visitors = new List<IVisitor>();
        public void AddOperation(IVisitor operation)
        {
            Visitors.Add(operation);
        }
        public void Execute(INoiseOperation noiseOperation)
        {
            foreach (var operation in Visitors)
                operation.Execute(noiseOperation);
        }
    }
}
