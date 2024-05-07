namespace FlyWeight.Exercise
{
    internal class Demo
    {
        public static void Show()
        {
            var sheet = new SpreadSheet();
            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetFontFamily(0, 0, FontFamily.Arial);
            sheet.Render();
        }
    }
}
