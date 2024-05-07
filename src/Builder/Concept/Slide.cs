namespace Builder.Concept
{
    internal class Slide
    {
        private readonly string Text;

        public Slide(string text)
        {
            Text = text;
        }

        public string GetText()
        {
            return Text;
        }
    }
}
