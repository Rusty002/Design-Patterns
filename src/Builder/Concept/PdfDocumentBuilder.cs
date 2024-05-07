namespace Builder.Concept
{
    internal class PdfDocumentBuilder : IPresentationBuilder
    {
        private PdfDocument PdfDocument = new PdfDocument();
        public void AddSlide(Slide slide)
        {
            PdfDocument.AddPage(slide.GetText());
        }

        public PdfDocument GetPdfDocument()
        {
            return PdfDocument;
        }
    }
}
