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
    public class LoremIpsumTest
    {

        Mock<LoremIpsumTextDictionaryProvider> _dictonaryMock;

        [SetUp]
        public void Setup() {

            _dictonaryMock = new Mock<LoremIpsumTextDictionaryProvider>();
        }

        [Test]
        public void ShouldCreateALoremIpsumText()
        {

            //Arrange
            int expectedWords = 1000;
            LoremIpsumProvider loremIpsum = new LoremIpsumProvider(_dictonaryMock.Object);
            //Action
            LoremIpsumText text = loremIpsum.Create(expectedWords);
            //Assert
            Assert.AreEqual(expectedWords, text.Words.Count);
        }

        [Test]
        public void ShouldUseALoremIpsumTextDictionary()
        {

            //Arrange
            int expectedWords = 1000;
            _dictonaryMock.Setup(x => x.GetWords(expectedWords)).Returns(new List<string>());
            LoremIpsumProvider loremIpsum = new LoremIpsumProvider(_dictonaryMock.Object);
            //Action
            loremIpsum.Create(expectedWords);
            //Assert
            _dictonaryMock.Verify(i => i.GetWords(expectedWords));

           
        }
    }
}
