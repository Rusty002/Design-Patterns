namespace Memento_Pattern.Exercise
{
    public class DocumentState
    {
        private readonly Document _state;

        public Document GetDocumentState()
        {
            return _state;
        }

        public DocumentState(string content, string fontName, int fontSize) 
        {
            _state = new Document(content, fontName, fontSize);
        }

    }
}
