
namespace FactoryMethod.Concept
{
    internal class SharpViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "Render using SharpView Engine";
        }
    }
}
