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

        Mock<ILoremIpsumTextDictionary> _dictonaryMock;

        [SetUp]
        public void Setup() {

            _dictonaryMock = new Mock<ILoremIpsumTextDictionary>();
        }

        [Test]
        public void ShouldCreateALoremIpsumText()
        {

            //Arrange
            int expectedWords = 1;
            _dictonaryMock.Setup(x => x.GetText(expectedWords)).Returns(new List<string> { "hello"});
            LoremIpsumEngine loremIpsum = new LoremIpsumEngine(_dictonaryMock.Object);
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
            _dictonaryMock.Setup(x => x.GetText(expectedWords)).Returns(new List<string>());
            LoremIpsumEngine loremIpsum = new LoremIpsumEngine(_dictonaryMock.Object);
            //Action
            loremIpsum.Create(expectedWords);
            //Assert
            _dictonaryMock.Verify(i => i.GetText(expectedWords));

           
        }


        [Test]
        public void ShouldReturnADefaultDictionaryText()
        {
            int expectedWords = 1000;
          
            LoremIpsumEngine loremIpsum = new LoremIpsumEngine(new LoremIpsumTextProvider());
            //Action
            LoremIpsumText text = loremIpsum.Create(expectedWords);
            //Assert
            Assert.AreEqual(text.Words.Count, expectedWords);
            
        }
    }
}
