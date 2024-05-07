namespace AbstractFactory.Concept.App
{
    internal class ContactForm
    {
        public void Render(IWidgetFactory widgetFactory)
        {
            widgetFactory.CreateTextBox().Render();
            widgetFactory.CreateButton().Render(); 
        }
    }
}
