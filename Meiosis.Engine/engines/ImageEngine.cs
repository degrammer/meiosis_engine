
using System;


namespace Meiosis.Engine
{
    public class ImageEngine:IMeiosisEngine<ImageItem, ImageGallery>
    {

        private RandomImageProvider _randomImageProvider;
        public ImageEngine(RandomImageProvider randomImageProvider)
        {
            _randomImageProvider = randomImageProvider;
        }

        public ImageGallery Create(int times, ImageItem defaultTemplate)
        {

            ImageGallery gallery = new ImageGallery();

            for (int i = 0; i < times; i++)
            {
                ImageItem item = new ImageItem();

                if (_randomImageProvider != null)
                {
                    item = _randomImageProvider.GetImage(); 
                }

                gallery.Items.Add(item);

            }

            return gallery;
        }

        public ImageItem Create()
        {
            ImageItem item = new ImageItem();

            if (_randomImageProvider != null)
            {
                item = _randomImageProvider.GetImage();
            }

            return item;
        }
    }
}