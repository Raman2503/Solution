using NUnit.Framework;
using Sqrt;
using Sqrt.Test;

namespace Sqrt.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Solution mySolution = new Solution();

            int res = mySolution.MySqrt(16);

            Assert.AreEqual(res,4);
        }
    }
}
