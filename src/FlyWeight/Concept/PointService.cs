namespace FlyWeight.Concept
{
    internal class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point1 = new Point(12, 24, _iconFactory.GetPointIcon(PointType.Cafe));
            points.Add(point1);
            return points;
        }
    }
}
