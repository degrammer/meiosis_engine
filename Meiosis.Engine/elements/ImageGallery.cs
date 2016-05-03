using System;
using System.Collections.Generic;

namespace Meiosis.Engine
{
    public class ImageGallery:DataElement
    {
        private List<ImageItem> _items;

        public List<ImageItem> Items
        {
            get
            {
                _items = _items ?? new List<ImageItem>();
                return _items;
            }

          
        }

    }
}