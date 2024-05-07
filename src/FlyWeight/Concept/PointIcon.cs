namespace FlyWeight.Concept
{
    internal class PointIcon
    {
        private readonly PointType Type;
        private readonly byte[] Icon;

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            Icon = icon;
        }

        public PointType GetPointType()
        {
            return Type;
        }

        public byte[] GetIcon()
        {
            return Icon;
        }

    }
}
