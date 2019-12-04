using NUnit.Framework;
using SearchInsertPositionTest;
using SearchInsertPosition;

namespace SearchInsertPositionTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            int[] array = new int[4] { 1, 5, 6, 7 };

            Solution mySolution = new Solution();

            int res = mySolution.SearchInsert(array, 1);

            Assert.AreEqual(res, 0);

        }
        [Test]
        public void TestMethod2()
        {
            int[] array = new int[4] { 4, 5, 6, 7 };

            Solution mySolution = new Solution();

            int res = mySolution.SearchInsert(array, 1);

            Assert.AreEqual(res, 0);


        }

    }


}