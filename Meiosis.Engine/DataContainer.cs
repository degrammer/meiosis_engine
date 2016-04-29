
using System.Collections.Generic;

namespace Meiosis.Engine
{
    public class DataContainer
    {
        private List<DataElement> _dataElements;

        private List<DataElement> DataElements
        {
            get
            {
                _dataElements = _dataElements ?? new List<DataElement>();
                return _dataElements;
            }

        }

        public void append(DataElement itemTemplate)
        {
            DataElements.Add(itemTemplate);
        }

        public List<DataElement> getDataElements()
        {
            return DataElements;
        }
    }
}