using System;


namespace Meiosis.Engine
{
    public class LoremPixelProvider : RandomImageProvider
    {
        
        public LoremPixelProvider()
        {
            BaseURL = "http://lorempixel.com/";
        }

        public override RandomImage GetImage()
        {
            return new RandomImage
            {
                URI = new Uri(string.Format("{0}/{1}/{2}", BaseURL, this.Width, this.Height))
            };
        }

    }
}