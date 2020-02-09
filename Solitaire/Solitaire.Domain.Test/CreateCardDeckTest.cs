using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class CreateCardDeckTest
	{
		[Test]
		// This tests checks, if card deck is created properly. All 52 cards are written on the console.
		public void NumberOfCardsInDeckTest()
		{
			CardDeck deck = CardDeckFactory.GenerateDeck();

            Console.WriteLine(deck.Count);
            Assert.AreEqual(deck.Count, 52);

            foreach (Card card in deck.Cards)
			{
				Console.WriteLine(card);
			}
		}
    }
}
