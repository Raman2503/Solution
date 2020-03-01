using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class FoundationTests
	{
		/// <summary>
		/// This test checks, that all four foundation piles are empty at the very beginning.
		/// <summary>
		[Test]
		public void FoundationInitialStateTest()
		{
			Foundation foundation = new Foundation();

			Assert.IsTrue(foundation.IsEmpty);
		}


		public IEnumerable<TestCaseData> FoundationInitializeTestCases
		{
			get
			{
				yield return new TestCaseData(
					new List<Card>(),
					true,
					//clubs
					new List<Card>(),
					//hearts
					new List<Card>(),
					//diamonds
					new List<Card>(),
					//spades
					new List<Card>()
				).SetName("Empty case");

				yield return new TestCaseData(
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Clubs)
					},
					false,
					//clubs
					new List<Card>()
						{new Card(Rank.Ace, Suit.Clubs)},
					//hearts
					new List<Card>(),
					//diamonds
					new List<Card>(),
					//spades
					new List<Card>()
					).SetName("A single card case");

				yield return new TestCaseData(
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Clubs),
						new Card(Rank.King, Suit.Clubs)
					},
					false,
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Clubs),
						new Card(Rank.King, Suit.Clubs)
					},
					new List<Card>(),
					new List<Card>(),
					new List<Card>()
				).SetName("A 2 cards, same pile case");


				yield return new TestCaseData(
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Clubs),
						new Card(Rank.Ace, Suit.Diamonds),
						new Card(Rank.Ace, Suit.Hearts),
						new Card(Rank.Ace, Suit.Spades),
					},
					false,
					new List<Card>{new Card(Rank.Ace, Suit.Clubs)},
					new List<Card>{new Card(Rank.Ace, Suit.Hearts)},
					new List<Card>{new Card(Rank.Ace, Suit.Diamonds)},
					new List<Card>{new Card(Rank.Ace, Suit.Spades)}
				).SetName("A 4 card case");
			}
		}


		/// <summary>
		/// This test checks, that the first card to be placed on each pile has the rank Ace.
		/// Also the test, ensures that the foundation is not empty anymore.
		/// <summary>
			[Test]
		[TestCaseSource(nameof(FoundationInitializeTestCases))]
		public void FoundationInitializeTest(
			List<Card> initialFoundationCards, 
			bool expectedIsEmpty,
			List<Card> expectedClubs,
			List<Card> expectedHearts,
			List<Card> expectedDiamonds,
			List<Card> expectedSpades
			)
		{
			//Arrange
			Foundation foundation = new Foundation();
			
			//Act
			foundation.Initialize(initialFoundationCards);
			

			//Assert
			Assert.AreEqual(expectedIsEmpty, foundation.IsEmpty);


			CollectionAssert.AreEqual(expectedClubs, foundation.FoundationPileClubs);
			CollectionAssert.AreEqual(expectedHearts, foundation.FoundationPileHearts);
			CollectionAssert.AreEqual(expectedDiamonds, foundation.FoundationPileDiamonds);
			CollectionAssert.AreEqual(expectedSpades, foundation.FoundationPileSpades);

		}


		public IEnumerable<TestCaseData> MoveCardToFoundationTestCases
		{
			get
			{
				yield return new TestCaseData(
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Hearts),
						new Card(Rank.Ten, Suit.Spades),
						new Card(Rank.Queen, Suit.Diamonds),
						new Card(Rank.Two, Suit.Clubs)
					},
					false,
					new Card(Rank.Two, Suit.Hearts),
					new List<Card> { new Card(Rank.Two, Suit.Clubs) },
					new List<Card>
					{ new Card(Rank.Ace, Suit.Hearts),
					  new Card(Rank.Two, Suit.Hearts),
					},
					new List<Card> { new Card(Rank.Queen, Suit.Diamonds) },
					new List<Card> { new Card(Rank.Ten, Suit.Spades) }
					).SetName("Ranks match. Card Is Added");



				yield return new TestCaseData(
								new List<Card>()
					{
					new Card(Rank.Ace, Suit.Hearts),
					new Card(Rank.Ten, Suit.Spades),
					new Card(Rank.Queen, Suit.Diamonds),
					new Card(Rank.Two, Suit.Clubs)
					},
					false,
					new Card(Rank.Six, Suit.Spades),
					new List<Card> { new Card(Rank.Two, Suit.Clubs) },
					new List<Card> { new Card(Rank.Ace, Suit.Hearts) },
					new List<Card> { new Card(Rank.Queen, Suit.Diamonds) },
					new List<Card> { new Card(Rank.Ten, Suit.Spades)}
					).SetName("Ranks do not match. No Card Added.");
			}
		}
		/// <summary>
		/// This test checks that cards that shall be moved to one of the foundation piles, have the correct
		///	Rank and Suit.
		/// <summary>
		[TestCaseSource(nameof(MoveCardToFoundationTestCases))]
		public void MoveCardToFoundationTest(
			List<Card> initialFoundationCards,
			bool expectedIsEmpty,
			Card newCard,
			List<Card> expectedClubs,
			List<Card> expectedHearts,
			List<Card> expectedDiamonds,
			List<Card> expectedSpades)
		{
			//Arrange
			Foundation foundation = new Foundation();
			foundation.Initialize(initialFoundationCards);


			//Act
			foundation.CheckRank(newCard);

			//Assert
			CollectionAssert.AreEqual(expectedClubs, foundation.FoundationPileClubs);
			CollectionAssert.AreEqual(expectedHearts, foundation.FoundationPileHearts);
			CollectionAssert.AreEqual(expectedDiamonds, foundation.FoundationPileDiamonds);
			CollectionAssert.AreEqual(expectedSpades, foundation.FoundationPileSpades);
		}
	}
}
