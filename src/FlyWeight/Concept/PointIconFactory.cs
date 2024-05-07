namespace FlyWeight.Concept
{
    internal class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> Icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!Icons.ContainsKey(pointType))
            {
                var icon = new PointIcon(pointType, []);
                Icons.Add(pointType, icon);  
            }
            return Icons[pointType];

        }
    }
}
