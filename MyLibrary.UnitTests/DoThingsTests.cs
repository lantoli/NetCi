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
    }
}
