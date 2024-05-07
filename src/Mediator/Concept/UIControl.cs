namespace Mediator.Concept
{
    internal class UIControl
    {
        protected readonly DialogBox _owner;
        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}
