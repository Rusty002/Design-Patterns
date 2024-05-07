namespace FactoryMethod.Concept
{
    internal class Controller
    {
        public void Render(string viewName, Dictionary<string, object> context)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, context);
            Console.WriteLine(html);
        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
