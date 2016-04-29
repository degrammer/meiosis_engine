
using System;


namespace Meiosis.Engine
{
    public class ImageGalleryEngine:IMeiosisEngine<RandomImage, ImageGallery>
    {

        private RandomImageProvider _randomImageProvider;
        public ImageGalleryEngine(RandomImageProvider randomImageProvider)
        {
            _randomImageProvider = randomImageProvider;
        }

        public ImageGallery Create(int times, RandomImage defaultTemplate)
        {

            ImageGallery gallery = new ImageGallery();

            for (int i = 0; i < times; i++)
            {
                RandomImage item = new RandomImage();

                if (_randomImageProvider != null)
                {
                    item = _randomImageProvider.GetImage(); 
                }

                gallery.Items.Add(item);

            }

            return gallery;
        }

    }
}