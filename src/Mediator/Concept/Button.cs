namespace Mediator.Concept
{
    internal class Button : UIControl
    {
        private bool IsEnabled;

        public Button(DialogBox owner) : base(owner)
        {

        }
        public bool GetIsEnabled()
        {
            return IsEnabled;
        }
        public void SetIsEnabled(bool isEnabled)
        {
            IsEnabled = isEnabled;
            _owner.Changed(this);
        }
    }
}
