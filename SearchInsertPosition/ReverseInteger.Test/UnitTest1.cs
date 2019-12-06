using NUnit.Framework;
using ReverseInteger;
using ReverseInteger.Test;

namespace ReverseInteger.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Solution mySolution = new Solution();
            int res = mySolution.Reverse(145);

            Assert.AreEqual(res, 541);
            
        }
    }
}
