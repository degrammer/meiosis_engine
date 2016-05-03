using Meiosis.Engine;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meiosis.Tests
{

    [TestFixture]
    public class ImageTest
    {
        private ImageEngine _imageGalleryEngine;
        private LoremPixelProvider _loremIpsumImageProvider;

        [SetUp]
        public void Setup()
        {

            _loremIpsumImageProvider = new LoremPixelProvider();
            _imageGalleryEngine = new ImageEngine(_loremIpsumImageProvider);
        }

        [Test]
        public void ShouldCreateAnImageGallery()
        {
            //Arrange
            LoremPixelProvider loremPixel = new LoremPixelProvider();
            int expectedCount = 10;
            //Act
            ImageGallery gallery = _imageGalleryEngine.Create(expectedCount, null);
            //Assert
            Assert.AreEqual(gallery.Items.Count(), expectedCount);

        }

      
    }
}
