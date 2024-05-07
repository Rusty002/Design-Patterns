using Adapter.Concept.AvaFilters;

namespace Adapter.Concept
{
    internal class CaramelAdapter : IFilter
    {
        private Caramel Caramel;

        public CaramelAdapter(Caramel caramel)
        {
            Caramel = caramel;
        }

        public void Apply(Image image)
        {
            Caramel.Init();
            Caramel.Render(image);
        }
    }
}
