namespace Memento_Pattern.Exercise
{
    public class DocumentHistory
    {
        private List<DocumentState> DocumentStates = new List<DocumentState>();

        public void PushState(DocumentState state)
        {
            DocumentStates.Add(state);
        }
        public DocumentState PopState()
        {
            DocumentState lastState = DocumentStates[DocumentStates.Count - 1];
            DocumentStates.Remove(lastState);
            return lastState;
        }
    }
}
