namespace Composite.Exercise
{
    internal class HumanResource : IOperation
    {
        public void Deploy()
        {
            Console.WriteLine("Deploy ManForce");
        }

        public void Move()
        {
            Console.WriteLine("Personal Started To Move");
        }
    }
}
