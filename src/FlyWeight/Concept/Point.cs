namespace FlyWeight.Concept
{
    internal class Point
    {
        private int X; 
        private int Y;
        private PointIcon Icon;
        public Point(int x, int y, PointIcon icon)
        {
            X = x;
            Y = y;
            Icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine("{0} at ({1}, {2})", Icon.GetPointType(), X, Y);
        }
    }
}
