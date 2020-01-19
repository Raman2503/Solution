using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solitaire.Domain.Test
{
	[TestClass]
	public class CreateCardDeckTest
	{
		[TestMethod]
		// This tests checks, if card deck is created properly. All 52 cards are written on the console.
		public void NumberOfCardsInDeckTest()
		{
			CardDeckGenerator deckGenerator = new CardDeckGenerator();

			List<Card> Cards = deckGenerator.GenerateDeck();

			Assert.AreEqual(Cards.Count, 52);

			foreach (Card card in Cards)
			Console.WriteLine(card);
		}
	}
}
