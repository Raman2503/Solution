using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solitaire.Domain.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Card card1 = new Card();

            card1.Rank = Rank.Jack;
            card1.Suite = Suite.Clubs;

            Card card2 = new Card();
            card2.Rank = Rank.King;
            card2.Suite = Suite.Hearts;


            Console.WriteLine(card1.ToString());
            Console.WriteLine(card2.ToString());
        }

        [TestMethod]
        public void CreateCardWithInvalidValues()
        {
            Card card1 = new Card();

            card1.Rank = Rank.King;
            card1.Suite = Suite.Diamonds;


            Console.WriteLine(card1.ToString());
        }



        [TestMethod]
        public void OnlyAPartOfValuesProvidedTest()
        {
            Card card1 = new Card();

            Console.WriteLine(card1.ToString());
            
            //

            Card card2 = new Card();
            card2.Suite = Suite.Clubs;

            Console.WriteLine(card2.ToString());


            DateTime dt = DateTime.Now;
        }
    }
}
