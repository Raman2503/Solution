using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class FoundationTests
	{
		[Test]
		/// <summary>
		/// This test checks, that all four foundation piles are empty at the very beginning.
		/// <summary>
		public void FoundationInitialStateTest()
		{
			Foundation foundation = new Foundation();

			Assert.IsTrue(foundation.IsEmpty);
		}

		[Test]
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

			//Assert
			Assert.IsFalse(foundation.IsEmpty);

			Assert.AreEqual(foundation.FoundationPileClubs[0], initialFoundationCards[0]);
			Assert.AreEqual(foundation.FoundationPileDiamonds[0], initialFoundationCards[1]);
			Assert.AreEqual(foundation.FoundationPileHearts[0], initialFoundationCards[2]);
			Assert.AreEqual(foundation.FoundationPileSpades[0], initialFoundationCards[3]);
		}


		/// <summary>
		/// This test checks that cards that shall be moved to one of the foundation piles, have the correct
		///	Rank and Suit.
		/// <summary>
		[TestCaseSource(nameof(MoveCardToFoundationTestCases))]
		public void MoveCardToFoundationTest(Card newCard)
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

			foundation.MoveCardToFoundation(newCard);

			//Assert

			Assert.AreEqual(2, foundation.FoundationPileHearts.Count);

			Assert.AreEqual(newCard, foundation.FoundationPileHearts[1]);
		}


		static object[] MoveCardToFoundationTestCases =
		{

		   new object[]
		   {
					new Card(Rank.Two, Suit.Hearts)
		   }
		};

	}
}
