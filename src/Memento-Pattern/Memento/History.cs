namespace Memento_Pattern.Memento
{
    public class History
    {
        private List<EditorState> States = new List<EditorState>();

        public void PushState(EditorState state)
        {
            States.Add(state);
        }
        public EditorState PopState()
        {
            EditorState lastState = States[States.Count - 1];
            States.Remove(lastState);
            return lastState;
        }
    }
}
