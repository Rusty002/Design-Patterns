namespace Memento_Pattern.Exercise
{
    public class Document
    {
        private string Content;
        private string FontName;
        private int FontSize;
        public string GetContent() { return Content; }
        public string GetFontName() { return FontName; }
        public int GetFontSize() { return FontSize; }
        public void SetContent(string content) { Content = content;}
        public void SetFontName(string fontName) {  FontName = fontName;}
        public void SetFontSize(int fontSize) {  FontSize = fontSize;}

        public Document(string content, string fontName, int fontSize) 
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public DocumentState CreateState() 
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState documentState) 
        {
            Content = documentState.GetDocumentState().Content;
            FontName= documentState.GetDocumentState().FontName;
            FontSize= documentState.GetDocumentState().FontSize;
        }


    }
}
