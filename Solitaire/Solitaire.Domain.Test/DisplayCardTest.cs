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
            Card card1 = new Card(Rank.Jack,Suit.Clubs);

            Card card2 = new Card(Rank.King, Suit.Hearts);
          
            Console.WriteLine(card1.ToString());
            Console.WriteLine(card2.ToString());
        }

        [TestMethod]
        public void CreateCardWithInvalidValues()
        {
            Card card1 = new Card(Rank.King,Suit.Diamonds);

            Console.WriteLine(card1.ToString());
        }
    }
}
