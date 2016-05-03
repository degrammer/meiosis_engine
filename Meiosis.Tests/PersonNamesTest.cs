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
    public class PersonNamesTest
    {

        [Test]
        public void ShouldGetBillGatesName()
        {
            //Arrange
            string expectedName = "bill gates";
            int expectedWords = 1;
            Mock<ILoremIpsumTextDictionary> providerMock = new Mock<ILoremIpsumTextDictionary>();
            providerMock.Setup(x => x.GetText(expectedWords)).Returns(new List<string>() { expectedName });
            //Act
            LoremIpsumEngine engine = new LoremIpsumEngine(providerMock.Object);
            LoremIpsumText name = engine.Create(expectedWords);
            //Assert
            Assert.AreEqual(expectedName, name.AsParagraph());

        }
    }
}
