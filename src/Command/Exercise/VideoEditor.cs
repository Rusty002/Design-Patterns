namespace Command.Exercise
{
    internal class VideoEditor
    {
        private float Contrast = 0.5f;
        private string Text;

        public void SetText(string text)
        {
            Text = text;
        }
        public string GetText()
        {
            return Text;
        }
        public void SetContrast(float contrast)
        {
            Contrast = contrast;
        }
        public float GetContrast()
        {
            return Contrast;
        }

        public override string ToString() 
        { 
            return @"Video Editor {" +
                        "Contrast=" + Contrast + ", " +
                        "Text =" + Text + 
                   "}"; 
        }

    }
}
