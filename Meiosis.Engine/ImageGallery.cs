using System;
using System.Collections.Generic;

namespace Meiosis.Engine
{
    public class ImageGallery:DataElement
    {
        private List<RandomImage> _items;

        public List<RandomImage> Items
        {
            get
            {
                _items = _items ?? new List<RandomImage>();
                return _items;
            }

          
        }

    }
}