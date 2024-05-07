namespace FlyWeight.Exercise
{
    internal class Cell
    {
        private readonly int Row;
        private readonly int Column;
        private string Content;
        private readonly FontCharacteristics FontProperties;

        public Cell(int row, int column, FontCharacteristics fontProperties)
        {
            Row = row;
            Column = column;
            FontProperties = fontProperties;
        }

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string content)
        {
            Content = content;
        }

        public void Render()
        {
            Console.WriteLine("({0}, {1}): {2} [{3}]", Row, Column, Content, FontProperties.GetFontFamily());
        }
    }
}
