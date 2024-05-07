namespace FactoryMethod.Concept
{
    internal class SharpController : Controller
    {
        protected override IViewEngine CreateViewEngine() 
        { 
            return new SharpViewEngine(); 
        }
    }
}
