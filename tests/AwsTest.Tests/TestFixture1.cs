using NUnit.Framework;

namespace AwsTest.Tests
{
    public class TestFixture1
    {
        [Test]
        public void OneEqualsOne()
        {
            Assert.That(1, Is.EqualTo(2));
        }
    }
}