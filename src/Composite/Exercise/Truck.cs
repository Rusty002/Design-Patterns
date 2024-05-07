namespace Composite.Exercise
{
    internal class Truck : IOperation
    {
        public void Deploy()
        {
            Console.WriteLine("Deploy Trucks on Site");
        }

        public void Move()
        {
            Console.WriteLine("Move Trucks");
        }
    }
}
