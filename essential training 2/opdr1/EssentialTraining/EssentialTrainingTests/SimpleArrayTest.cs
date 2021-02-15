using NUnit.Framework;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestFixture]
    public class SimpleArrayTest
    {
        [Test]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.Grocerylist.Length, 4);
            Assert.AreEqual(testInstance.Grocerylist[1], "Milk");
        }

        [Test]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }
    }
}