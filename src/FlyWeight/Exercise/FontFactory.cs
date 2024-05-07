namespace FlyWeight.Exercise
{
    internal class FontFactory
    {
        private Dictionary<FontFamily, FontCharacteristics> FontFormats = new Dictionary<FontFamily, FontCharacteristics>();

        public FontCharacteristics GetFontCharacteristics(FontFamily fontFamily)
        {
            if(!FontFormats.ContainsKey(fontFamily))
                FontFormats.Add(fontFamily, new FontCharacteristics(12, false, fontFamily));
            
            return FontFormats[fontFamily];
        }
    }
}
