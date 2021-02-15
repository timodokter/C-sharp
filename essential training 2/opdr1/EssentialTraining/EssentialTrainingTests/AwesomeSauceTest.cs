using EssentialTraining;
using NUnit.Framework;

namespace EssentialTrainingTests
{
    public class AwesomeSauceTest
    {
        [Test]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");
            
            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));
            
            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}