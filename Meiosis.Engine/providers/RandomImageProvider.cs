namespace Meiosis.Engine
{
    public class RandomImageProvider
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public string BaseURL { get; set; }

        public virtual ImageItem GetImage()
        {
            return null;
        }
    }
}