using NUnit.Framework;
using EssentialTraining;

namespace EssentialTrainingTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "i expect 9 + 5 to be 14");
        }
    }
}