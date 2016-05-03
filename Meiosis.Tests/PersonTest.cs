using Meiosis.Engine;
using Meiosis.Engine.models;
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
    public class PersonTest
    {

        [Test]
        public void ShouldGetAPersonList()
        {

            //Arrange
            //Todo: How to fix person dependency in order to get random profile images and lorem ipsum text of names ?
            PersonEngine personEngine = new PersonEngine();
            ImageEngine imageEngine = new ImageEngine(new LoremPixelProvider());
            LoremIpsumEngine textEngine = new LoremIpsumEngine(new PersonNamesProvider());
            string[] text = textEngine.Create(1).AsParagraph().Split(' ');


            //Act
            List<Person> personList = personEngine.Create(1);

            //Assert

            List<Person> testList = new List<Person> {

                 new Person { FirstName =  text[0], LastName = text[1], Image = imageEngine.Create()}
            };


            Assert.AreEqual(testList, personList);


        }
    }
}
