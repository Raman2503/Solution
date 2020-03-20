using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Solitaire.Domain.Test
{
	[TestFixture]
	public class BoardTests
	{
		public IEnumerable<TestCaseData> MoveCardsFromTableauToTableauTestCases
		{
			get
			{
				yield return new TestCaseData(
					new List<List<Card>>() { },
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					null
					).SetName("Both Tableau Piles Empty");

				yield return new TestCaseData(
					null,
					false,
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					null
				).SetName("Tableau Null Case").Throws(typeof(ArgumentNullException));

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
						new List<Card> { },
						new Card(Rank.Five, Suit.Clubs)
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
					new List<Card> { },
					new Card(Rank.Jack, Suit.Spades)
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
					new List<Card> { },
					new Card(Rank.Five, Suit.Diamonds)
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
					new List<Card> { },
					null
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
					new List<Card> { },
					new Card(Rank.Five, Suit.Diamonds)
				).SetName("Target Pile is empty");

				yield return new TestCaseData(
					new List<List<Card>>()
					{
						new List<Card>() { },
						new List<Card>() { },
						new List<Card>()
						{
							new Card(Rank.Ace, Suit.Spades),
							new Card(Rank.Five, Suit.Clubs),
							new Card(Rank.King, Suit.Diamonds),
						},
						new List<Card>() { },
						new List<Card>()
						{

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
						new Card(Rank.King, Suit.Diamonds)
					},
					new List<Card> { },
					new List<Card> { },
					new Card(Rank.Five, Suit.Clubs)
				).SetName("Move King To Empty Target Pile");
			}
		}

		[Test]
		[TestCaseSource(nameof(MoveCardsFromTableauToTableauTestCases))]
		public void MoveCardsFromTableauToTableauTest(List<List<Card>> initialTableauPiles,
			bool pCardCanBeMoved,
			List<Card> expectedPile1,
			List<Card> expectedPile2,
			List<Card> expectedPile3,
			List<Card> expectedPile4,
			List<Card> expectedPile5,
			List<Card> expectedPile6,
			List<Card> expectedPile7,
			Card expectedOpenCard)
		{
			//Arrange
			Tableau tableau = new Tableau();
			Foundation foundation = new Foundation();
			Stock stock = new Stock(tableau);

			Board board = new Board(tableau, foundation, stock);

			//Act
			board.InitializeTableau(initialTableauPiles);
			tableau.CheckRankAndSuitInTableau(initialTableauPiles);

			//Assert
			Assert.AreEqual(tableau.CardCanBeMoved, pCardCanBeMoved);
			CollectionAssert.AreEqual(expectedPile3, tableau.TableauPile3);
			CollectionAssert.AreEqual(expectedPile5, tableau.TableauPile5);
			Assert.AreEqual(tableau.OpenCard, expectedOpenCard);
		}


		public IEnumerable<TestCaseData> MoveCardsFromStockToTableauTestCases
		{
			get
			{
				yield return new TestCaseData(
					new List<Card> { },
					null,
					new List<Card> { },
					new List<Card> { },
					new List<Card> { },
					new List<Card> { }
			).SetName("Empty Stock and Tableau");

				yield return new TestCaseData(
					null,
					null,
					null,
					new List<Card> { },
					new List<Card> { },
					new List<Card> { }
			).SetName("Stock and Tableau Null Case").Throws(typeof(ArgumentNullException));

				yield return new TestCaseData(
					new List<Card>()
				{
				new Card(Rank.Ace, Suit.Clubs),
				new Card(Rank.Four, Suit.Diamonds),
				new Card(Rank.Eight, Suit.Hearts),
				new Card(Rank.Six, Suit.Spades),
				new Card(Rank.Queen, Suit.Clubs),
				},
				new Card(Rank.Queen, Suit.Clubs),
				new List<Card>()
				{
				new Card(Rank.Ace, Suit.Spades),
				new Card(Rank.Five, Suit.Clubs),
				new Card(Rank.King, Suit.Hearts),
				},
				new List<Card>()
				{
				new Card(Rank.Ace, Suit.Clubs),
				new Card(Rank.Four, Suit.Diamonds),
				new Card(Rank.Eight, Suit.Hearts),
				new Card(Rank.Six, Suit.Spades),
				},
				new List<Card>()
				{
				new Card(Rank.Ace, Suit.Spades),
				new Card(Rank.Five, Suit.Clubs),
				new Card(Rank.King, Suit.Hearts),
				new Card(Rank.Queen, Suit.Clubs) },
				new List<Card> { }
			).SetName("Card Can Be Moved From Stock To Tableau");

				yield return new TestCaseData(
					new List<Card>()
				{
				new Card(Rank.Ace, Suit.Clubs),
				new Card(Rank.Four, Suit.Diamonds),
				new Card(Rank.Eight, Suit.Hearts),
				new Card(Rank.Six, Suit.Spades),
				new Card(Rank.Queen, Suit.Hearts),
				},
				new Card(Rank.Queen, Suit.Hearts),
				new List<Card>()
				{
				new Card(Rank.Ace, Suit.Spades),
				new Card(Rank.Five, Suit.Clubs),
				new Card(Rank.King, Suit.Hearts),
				},
				new List<Card>()
				{
				new Card(Rank.Ace, Suit.Clubs),
				new Card(Rank.Four, Suit.Diamonds),
				new Card(Rank.Eight, Suit.Hearts),
				new Card(Rank.Six, Suit.Spades),
				new Card(Rank.Queen, Suit.Hearts),
				},
				new List<Card>()
				{
				new Card(Rank.Ace, Suit.Spades),
				new Card(Rank.Five, Suit.Clubs),
				new Card(Rank.King, Suit.Hearts),
				},
				new List<Card> {new Card(Rank.Queen, Suit.Hearts)}
			).SetName("Card Could Not Be Moved From Stock To Tableau");
		}

		}
		[Test]
		[TestCaseSource(nameof(MoveCardsFromStockToTableauTestCases))]
		public void MoveCardsFromStockToTableauTest(List<Card> initialStockCards,
				Card cardToBeMoved,
				List<Card> tableauPile,
				List<Card> expectedStockCards,
				List<Card> expectedTableauPile,
				List<Card> expectedOpenCards)
		{
			//Arrange
			Tableau tableau = new Tableau();
			Stock stock = new Stock(tableau);
			Foundation foundation = new Foundation();

			Board board = new Board(tableau, foundation, stock);

			//Act
			board.InitializeStock(initialStockCards);
			stock.CheckRankAndSuitInStockAndTableau(cardToBeMoved, tableauPile);

			//Assert
			CollectionAssert.AreEqual(expectedTableauPile, tableau.TableauPile3);
			CollectionAssert.AreEqual(expectedStockCards, stock.StockCards);
			Assert.AreEqual(expectedOpenCards, stock.OpenCards);
		}
	}
}

