namespace Composite.Concept
{
    internal class Group : IComponent
    {
        private List<IComponent> Components = new List<IComponent>();

        public void AddShape(IComponent shape)
        {
            Components.Add(shape);
        }

        public void Move()
        {
            foreach (var component in Components)
                component.Move();
        }

        public void Render()
        {
            foreach (var component in Components)
                component.Render();
        }
    }
}
