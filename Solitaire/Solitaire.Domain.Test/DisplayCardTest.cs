using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Solitaire.Domain.Test
{
    [TestFixture]
    public class DisplayCardTest
    {
        [Test]
        public void CreateCardWithRankAndSuite()
        {
            Card card1 = new Card(Rank.Jack,Suit.Clubs);

            Card card2 = new Card(Rank.King, Suit.Hearts);
          
            Console.WriteLine(card1.ToString());
            Console.WriteLine(card2.ToString());
        }

        [Test]
        public void CreateCardWithInvalidValues()
        {
            Card card1 = new Card(Rank.King,Suit.Diamonds);

            Console.WriteLine(card1.ToString());
        }
    }
}
