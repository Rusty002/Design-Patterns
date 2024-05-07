namespace Mediator.Concept
{
    internal class ListBox : UIControl
    {
        private string Selection;

        public ListBox(DialogBox owner) : base(owner)
        {

        }
        public string GetSelection() 
        { 
            return Selection; 
        }
        public void SetSelection(string selection) 
        {  
            Selection = selection;
            _owner.Changed(this);
        }
    }
}
