namespace Composite.Exercise
{
    internal class Team : IOperation
    {
        private List<IOperation> Operations = new List<IOperation>();

        public void AddTeam(IOperation operation)
        {
            Operations.Add(operation);
        }

        public void Deploy()
        {
            foreach (var operation in Operations)
                operation.Deploy();
        }

        public void Move()
        {
            foreach (var operation in Operations)
                operation.Move();
        }
    }
}
