namespace FactoryMethod.Concept
{
    internal class MatchaViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context) 
        {
            return "View Rendered By Matcha";
        }
    }
}
