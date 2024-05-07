namespace FlyWeight.Exercise
{
    internal class SpreadSheet
    {
        private readonly int MAX_ROWS = 3;
        private readonly int MAX_COLS = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private readonly FontFamily fontFamily = FontFamily.TimesNewRoman;
        private readonly int fontSize = 12;
        private readonly bool isBold = false;

        private Cell[,] cells;

        public SpreadSheet()
        {
            cells=  new Cell[MAX_ROWS, MAX_COLS];
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            cells[row, col].SetContent(content);
        }

        public void SetFontFamily(int row, int col, FontFamily fontFamily)
        {
            EnsureCellExists(row, col);

            cells[row, col] = new Cell(row, col, GenerateFontCharacetristics(fontFamily));
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new IndexOutOfRangeException();

            if (col < 0 || col >= MAX_COLS)
                throw new IndexOutOfRangeException();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col, GenerateFontCharacetristics(fontFamily));
                    cells[row, col] = cell;
                }
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row, col].Render();
        }

        private FontCharacteristics GenerateFontCharacetristics(FontFamily fontFamily)
        {
            return new FontCharacteristics(fontSize, isBold, fontFamily);
        }
    }
}
