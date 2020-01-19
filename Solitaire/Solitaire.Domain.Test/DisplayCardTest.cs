using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solitaire.Domain.Test
{
    [TestClass]
    public class DisplayCardTest
    {
        [TestMethod]
        public void CreateCardWithRankAndSuite()
        {
            Card card1 = new Card();

            card1.Rank = Rank.Jack;
            card1.Suit = Suit.Clubs;

            Card card2 = new Card();
            card2.Rank = Rank.King;
            card2.Suit = Suit.Hearts;


            Console.WriteLine(card1.ToString());
            Console.WriteLine(card2.ToString());
        }

        [TestMethod]
        public void CreateCardWithInvalidValues()
        {
            Card card1 = new Card();

            card1.Rank = Rank.King;
            card1.Suit = Suit.Diamonds;

            Console.WriteLine(card1.ToString());
        }

        [TestMethod]
        public void OnlyAPartOfValuesProvidedTest()
        {
            Card card1 = new Card();

            Console.WriteLine(card1.ToString());

            Card card2 = new Card();
            card2.Suit = Suit.Clubs;

            Console.WriteLine(card2.ToString());

            DateTime dt = DateTime.Now;
        }
	}
}
