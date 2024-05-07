namespace Prototype.Concept
{
    internal interface IComponent
    {
        void Render();
        IComponent Duplicate();
    }
}
