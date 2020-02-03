using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solitaire.Domain.Test
{
	[TestClass]
	public class FoundationTests
	{
		[TestMethod]
		/// <summary>
		/// This test checks, that all four foundation piles are empty at the very beginning.
		/// <summary>
		public void FoundationInitialStateTest()
		{
			Foundation foundation = new Foundation();

			Assert.IsTrue(foundation.IsEmpty);
		}
		
		[TestMethod]
		/// <summary>
		/// This test checks, that the first card to be placed on each pile has the rank Ace.
		/// Also the test, ensures that the foundation is not empty anymore.
		/// <summary>
		public void FoundationInitializeTest()
		{
			//Arrange
			Foundation foundation = new Foundation();

			List<Card> initialFoundationCards = new List<Card>()
			{
				new Card(Rank.Ace, Suit.Clubs),
				new Card(Rank.Ace, Suit.Diamonds),
				new Card(Rank.Ace, Suit.Hearts),
				new Card(Rank.Ace, Suit.Spades),
			};

			//Act
			foundation.Initialize(initialFoundationCards);

			List<Card> openCards = foundation.GetOpenCards();

			//Assert
			Assert.IsFalse(foundation.IsEmpty);

			Assert.AreEqual(foundation.FoundationPileClubs[0], initialFoundationCards[0]);
			Assert.AreEqual(foundation.FoundationPileDiamonds[0], initialFoundationCards[1]);
			Assert.AreEqual(foundation.FoundationPileHearts[0], initialFoundationCards[2]);
			Assert.AreEqual(foundation.FoundationPileSpades[0], initialFoundationCards[3]);

			Assert.AreEqual(4,openCards.Count);
			foreach (Card card in openCards)
			{
				Console.WriteLine(card.ToString());
			}
			Assert.AreEqual(initialFoundationCards[0], openCards[0]);
			Assert.AreEqual(initialFoundationCards[1], openCards[1]);
			Assert.AreEqual(initialFoundationCards[2], openCards[2]);
			Assert.AreEqual(initialFoundationCards[3], openCards[3]);


			Assert.AreEqual(0, foundation.ClosedCards.Count);
		}

		[TestMethod]
		/// <summary>
		/// This test checks that cards that shall be moved to one of the foundation piles, have the correct
		///	Rank and Suit.
		/// <summary>
		public void MoveCardToFoundationTest()
		{
			//Arrange
			Foundation foundation = new Foundation();

			List<Card> initialFoundationCards = new List<Card>()
			{
				new Card(Rank.Ace, Suit.Clubs),
				new Card(Rank.Ace, Suit.Diamonds),
				new Card(Rank.Ace, Suit.Hearts),
				new Card(Rank.Ace, Suit.Spades),
			};

			Card nextCard = new Card(Rank.Two, Suit.Hearts);

			//Act
			foundation.Initialize(initialFoundationCards);

			foundation.MoveCardToFoundation(nextCard);

			//Assert
			Assert.AreEqual(2, foundation.FoundationPileHearts.Count);
			Assert.AreEqual(nextCard, foundation.FoundationPileHearts[1]);

			foreach (Card card in foundation.FoundationPileHearts)
			{
				Console.WriteLine(card.ToString());
			}
		}
	}
}
