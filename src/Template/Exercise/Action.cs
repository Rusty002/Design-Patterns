namespace Template.Exercise
{
    public abstract class Action
    {
        private CloseWindowActions _closeWindowActions;
        public Action()
        {
            _closeWindowActions = new CloseWindowActions();
        }
        public Action(CloseWindowActions closeWindowActions)
        {
            _closeWindowActions = closeWindowActions;
        }

        public void Close()
        {
            _closeWindowActions.BeforeClose();
            OnClose();
            _closeWindowActions.AfterClose();
        }

        protected abstract void OnClose();
    }
}
