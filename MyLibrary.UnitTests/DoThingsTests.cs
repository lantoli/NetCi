using NUnit.Framework;

namespace MyLibrary.UnitTests
{

    [TestFixture]
    public class DoThingsTests
    {
        [Test]
        public void TestSomeWork()
        {
            Assert.IsTrue(new DoThings().DoManyThings());
        }

        [Test]
        public void FailedTest()
        {
        //    Assert.Fail("problem");
        }
    }
}
