using System;

namespace Meiosis.Engine
{
    public class RandomImage:DataElement
    {
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public int Height { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri URI { get; set; }
        public int Width { get; set; }
    }
}