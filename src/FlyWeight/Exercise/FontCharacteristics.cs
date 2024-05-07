namespace FlyWeight.Exercise
{
    internal class FontCharacteristics
    {
        private readonly int Size;
        private readonly bool IsBold;
        private readonly FontFamily Family;
        public FontCharacteristics(int fontSize, bool isBold, FontFamily fontFamily)
        {
            Size = fontSize;
            IsBold = isBold;
            Family = fontFamily;
        }

        public int GetFontSize()
        {
            return Size;
        }

        public bool GetIsBold()
        {
            return IsBold;
        }

        public FontFamily GetFontFamily()
        {
            return Family;
        }

    }
}
