namespace Adapter.Concept
{
    internal class ImageView
    {
        private Image Image;

        public ImageView(Image image)
        {
            Image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(Image);
        }
    }
}
