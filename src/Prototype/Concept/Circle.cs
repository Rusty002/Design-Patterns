namespace Prototype.Concept
{
    internal class Circle : IComponent
    {
        private int Radius;
        public void Render()
        {
            Console.WriteLine("Rendering a circle");
        }

        public int GetRadius()
        {
            return Radius;
        }
        public void SetRadius(int radius)
        {
            Radius = radius;
        }

        public IComponent Duplicate()
        {
            Circle newCircle = new Circle();
            newCircle.SetRadius(Radius);
            return newCircle;
        }
    }
}
