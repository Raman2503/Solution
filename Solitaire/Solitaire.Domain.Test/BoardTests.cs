using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class BoardTests
	{
		public IEnumerable<TestCaseData> MoveCardsTestCases
		{
			get
			{
				yield return new TestCaseData(
					new List<List<Card>>() {},
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { }
					).SetName("Empty case");

				yield return new TestCaseData(
					null,
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { }
				).SetName("Null Case").Throws(typeof(ArgumentNullException));

				// Move Card from normal pile to another pile
				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() { },
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.Ace, Suit.Spades),
							new Card(Rank.Five, Suit.Clubs),
							new Card(Rank.Five, Suit.Spades),
						},
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.King, Suit.Diamonds),
							new Card(Rank.Nine, Suit.Spades),
							new Card(Rank.Two, Suit.Diamonds),
							new Card(Rank.Six, Suit.Diamonds),
							new Card(Rank.Six, Suit.Hearts)
						},
						new List<Card>() { },
						new List<Card>() { }
					},
						true,
						new List<Card> { },
						new List<Card> { },
						new List<Card>()
						{
							new Card(Rank.Ace, Suit.Spades),
							new Card(Rank.Five, Suit.Clubs),
						},
						new List<Card> { },
						new List<Card>
						{                          
							new Card(Rank.King, Suit.Diamonds), 
							new Card(Rank.Nine, Suit.Spades),
							new Card(Rank.Two, Suit.Diamonds),
							new Card(Rank.Six, Suit.Diamonds),
							new Card(Rank.Six, Suit.Hearts),
							new Card(Rank.Five, Suit.Spades),
						},
						new List<Card> { },
						new List<Card> { }
				).SetName("Card Can Be Moved");

				// Card cannot be moved because rank is wrong
				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() { },
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.Ace, Suit.Spades),
							new Card(Rank.Five, Suit.Clubs),
							new Card(Rank.Jack, Suit.Spades),
						},
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.King, Suit.Diamonds),
							new Card(Rank.Nine, Suit.Spades),
							new Card(Rank.Two, Suit.Diamonds),
							new Card(Rank.Six, Suit.Diamonds),
							new Card(Rank.Six, Suit.Hearts)
						},
						new List<Card>() { },
						new List<Card>() { }
					},
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Spades),
						new Card(Rank.Five, Suit.Clubs),
						new Card(Rank.Jack, Suit.Spades),
					},
					new List<Card> { },
					new List<Card>
					{
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Spades),
						new Card(Rank.Two, Suit.Diamonds),
						new Card(Rank.Six, Suit.Diamonds),
						new Card(Rank.Six, Suit.Hearts)
					},
					new List<Card> { },
					new List<Card> { }
				).SetName("Card Cannot Be Moved: Wrong Rank");

				// Card cannot be moved because rank is wrong
				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() { },
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.Ace, Suit.Spades),
							new Card(Rank.Five, Suit.Clubs),
							new Card(Rank.Five, Suit.Diamonds),
						},
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.King, Suit.Diamonds),
							new Card(Rank.Nine, Suit.Spades),
							new Card(Rank.Two, Suit.Diamonds),
							new Card(Rank.Six, Suit.Diamonds),
							new Card(Rank.Six, Suit.Hearts)
						},
						new List<Card>() { },
						new List<Card>() { }
					},
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Spades),
						new Card(Rank.Five, Suit.Clubs),
						new Card(Rank.Five, Suit.Diamonds),
					},
					new List<Card> { },
					new List<Card>
					{
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Spades),
						new Card(Rank.Two, Suit.Diamonds),
						new Card(Rank.Six, Suit.Diamonds),
						new Card(Rank.Six, Suit.Hearts)
					},
					new List<Card> { },
					new List<Card> { }
				).SetName("Card Cannot Be Moved: Wrong Suit");

				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() { },
						new List<Card>() { },
						new List<Card>()
						{

						},
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.King, Suit.Diamonds),
							new Card(Rank.Nine, Suit.Spades),
							new Card(Rank.Two, Suit.Diamonds),
							new Card(Rank.Six, Suit.Diamonds),
							new Card(Rank.Six, Suit.Hearts)
						},
						new List<Card>() { },
						new List<Card>() { }
					},
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card>()
					{

					},
					new List<Card> { },
					new List<Card>
					{
						new Card(Rank.King, Suit.Diamonds),
						new Card(Rank.Nine, Suit.Spades),
						new Card(Rank.Two, Suit.Diamonds),
						new Card(Rank.Six, Suit.Diamonds),
						new Card(Rank.Six, Suit.Hearts)
					},
					new List<Card> { },
					new List<Card> { }
				).SetName("Original Pile is empty");

				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() { },
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.Ace, Suit.Spades),
							new Card(Rank.Five, Suit.Clubs),
							new Card(Rank.Five, Suit.Diamonds),
						},
						new List<Card>() { },
						new List<Card>()
						{

						},
						new List<Card>() { },
						new List<Card>() { }
					},
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card>()
					{
						new Card(Rank.Ace, Suit.Spades),
						new Card(Rank.Five, Suit.Clubs),
						new Card(Rank.Five, Suit.Diamonds),
					},
					new List<Card> { },
					new List<Card>
					{

					},
					new List<Card> { },
					new List<Card> { }
				).SetName("Target Pile is empty");

			}
		}

		[Test]
		[TestCaseSource(nameof(MoveCardsTestCases))]
		public void MoveCardsTest(List<List<Card>> initialTableauPiles, 
			bool pCardCanBeMoved,
			List<Card> expectedPile1,
			List<Card> expectedPile2,
			List<Card> expectedPile3,
			List<Card> expectedPile4,
			List<Card> expectedPile5,
			List<Card> expectedPile6,
			List<Card> expectedPile7)
		{
			//Arrange
			Tableau tableau = new Tableau();

			Board board = new Board(tableau);

			//Act
			board.InitializeBoard(initialTableauPiles);
			tableau.CheckRankAndSuitInTableau(initialTableauPiles);
			
			//Assert
			Assert.AreEqual(tableau.CardCanBeMoved, pCardCanBeMoved);
			CollectionAssert.AreEqual(expectedPile3, tableau.TableauPile3);
			CollectionAssert.AreEqual(expectedPile5, tableau.TableauPile5);
		}
	}
}
