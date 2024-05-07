namespace AbstractFactory.Concept
{
    internal interface IWidgetFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
